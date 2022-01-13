using iiko_it_getversion_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace iikoBOS
{
    public partial class Form1 : Form
    {
        private string mUrl = string.Empty;
        public Form1()
        {
            InitializeComponent();
            tb_Path.Text = Properties.Settings.Default.Path;
            tb_Passwd.Text = Properties.Settings.Default.Passwd;
            tb_Login.Text = Properties.Settings.Default.Login;
        }

        private ServerProperties GetServerProperties()
        {
            if (!mUrl.Contains("https://") && mUrl.Contains("iiko.it"))
            {
                mUrl = "https://" + mUrl;
            }

            else if (!mUrl.Contains("http://") && !mUrl.Contains("iiko.it"))
            {
                mUrl = "http://" + mUrl;
            }

            if (!mUrl.Contains("/resto"))
            { mUrl = mUrl + "/resto"; }

            var url = mUrl + "/get_server_info.jsp?encoding=UTF-8";
            UrlService urlService = new UrlService();

            var serverProperties = urlService.GetServerProperties(url);
            return serverProperties;
        }

        #region
        // надо потом запихнуть это в отдельный файл

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        delegate bool EnumWindowProc(IntPtr hWnd, IntPtr parameter);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr i);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        static bool EnumWindow(IntPtr handle, IntPtr pointer)
        {
            GCHandle gch = GCHandle.FromIntPtr(pointer);
            List<IntPtr> list = gch.Target as List<IntPtr>;
            if (list == null)
                throw new InvalidCastException("GCHandle Target could not be cast as List<IntPtr>");

            list.Add(handle);
            return true;
        }

        static List<IntPtr> GetChildWindows(IntPtr parent)
        {
            List<IntPtr> result = new List<IntPtr>();
            GCHandle listHandle = GCHandle.Alloc(result);

            try
            {
                EnumWindowProc childProc = new EnumWindowProc(EnumWindow);
                EnumChildWindows(parent, childProc, GCHandle.ToIntPtr(listHandle));
            }
            finally
            {
                if (listHandle.IsAllocated)
                    listHandle.Free();
            }
            return result;
        }
        #endregion
        private void BackClientConfigEdit()
        {
            var serverProperties = GetServerProperties();
            string roamingpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string backclientconfig = "";
            if (serverProperties.Edition == "chain")
            {
                backclientconfig = roamingpath + @"\iiko\Chain\Default\config\backclient.config.xml";
            }
            else
            {
                backclientconfig = roamingpath + @"\iiko\Rms\Default\config\backclient.config.xml";
            }

            XElement userList = XElement.Load(backclientconfig);
            userList.RemoveAll();


            var uriparser = new Uri(mUrl);
            var serverListXml = new XElement("ServersList",
                                        new XElement("ServerName", serverProperties.ServerName),
                                        new XElement("Version", serverProperties.Version),
                                        new XElement("ComputerName", serverProperties.computerName),
                                        new XElement("Protocol", uriparser.Scheme),
                                        new XElement("ServerAddr", uriparser.Host),
                                        new XElement("ServerSubUrl", uriparser.PathAndQuery),
                                        new XElement("Port", uriparser.Port.ToString()),
                                        new XElement("IsPresent", serverProperties.isPresent)
                                        );


            userList.Add(serverListXml);
            var login = new XElement("Login", tb_Login.Text);
            userList.Element("ServersList").AddAfterSelf(login);
            userList.Save(backclientconfig);
        }

        private void OpenBackOffice()
        {

            var serverProperties = GetServerProperties();
            //BackClientConfigEdit();
           
            string versionName = serverProperties.Version.Remove(8, 2);
            string edition = "*Office*";

            if (serverProperties.Edition == "chain")
            {
                edition = "*Chain*Office*";
            }
            else
            {
                edition = "*Office*";
            }

            string searchPattern = edition + versionName;


            var directories = Directory.EnumerateDirectories(tb_Path.Text, searchPattern, SearchOption.AllDirectories);
            try
            {
                foreach (var directory in directories)
                {
                    if (directory.Contains("Chain") && serverProperties.Edition != "chain")
                    {
                        continue;
                    }
                    else if (!(File.Exists(directory + @"\BackOffice.exe")))
                    {
                        continue;
                    }

                    else
                    {
                        tb_Console.Text += string.Format("Открываю " + directory + @"\BackOffice.exe");
                        using (Process myProcess = new Process())
                        {
                            myProcess.StartInfo.UseShellExecute = false;
                            myProcess.StartInfo.FileName = directory + @"\BackOffice.exe";
                            myProcess.StartInfo.CreateNoWindow = true;
                            myProcess.Start();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                tb_Console.Text += string.Format(e.Message);
            }


        }

        private void Authorization()
        {
            //while (true) работает тут
            for (int i = 0; i < 1000;)
            {
                IntPtr authWindow = FindWindow(null, "Вход в систему");
                if (authWindow.ToInt32() != 0)
                {
                    List<IntPtr> all_hwnd_child_window = GetChildWindows(authWindow);
                    foreach (var hwnd_child_window in all_hwnd_child_window)
                    {
                        IntPtr editWindow = FindWindowEx(hwnd_child_window, new IntPtr(0), null, "");
                        SendMessage(editWindow, 0x000C, 0, tb_Passwd.Text);

                        IntPtr bttnLogin = FindWindowEx(hwnd_child_window, new IntPtr(0), null, "Войти");
                        SendMessage(bttnLogin, (int)0x201, (IntPtr)1, IntPtr.Zero);
                        SendMessage(bttnLogin, (int)0x202, IntPtr.Zero, IntPtr.Zero);
                    }
                    i++;

                }
                else { Thread.Sleep(1000); i++; }
            }

        }
        private void AddServerToList()
        {
            var serverProperties = GetServerProperties();
            ListViewItem item = new ListViewItem(tb_Url.Text);
            string[] serverPropertiesArray = { serverProperties.Version, serverProperties.Edition, serverProperties.ServerName };
            //item.SubItems.AddRange(serverPropertiesArray);
            //lv_Servers.Items.Add(item);
            //tb_Url.Clear();
            bool isExist = false;
            foreach (ListViewItem t in lv_Servers.Items)
            {
                if (t.Text == tb_Url.Text)
                { isExist = true; break; }
            }
            if (!isExist)
            {
                item.SubItems.AddRange(serverPropertiesArray);
                lv_Servers.Items.Add(item);

            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Url.Text))
            { return; }
            mUrl = tb_Url.Text;
            var serverProperties = GetServerProperties();
            AddServerToList();

            //ListViewItem item = new ListViewItem(tb_Url.Text);
            //string[] serverPropertiesArray = { serverProperties.Version, serverProperties.Edition, serverProperties.ServerName };
            ////item.SubItems.AddRange(serverPropertiesArray);
            ////lv_Servers.Items.Add(item);
            ////tb_Url.Clear();
            //bool isExist = false;
            //foreach (ListViewItem t in lv_Servers.Items)
            //{
            //    if (t.Text == tb_Url.Text)
            //    { isExist = true; break; }
            //}
            //if (!isExist)
            //{
            //    item.SubItems.AddRange(serverPropertiesArray);
            //    lv_Servers.Items.Add(item);

            //}
            tb_Url.Clear();
            tb_Console.Text = string.Format("ServerName: {0} \r\nServerVersion: {1} \r\nServerState: {2}\r\nEdition {3}",
            serverProperties.ServerName, serverProperties.Version, serverProperties.ServerState, serverProperties.Edition);


        }

        private void lv_Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Url.Text = lv_Servers.FocusedItem.Text;
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_path.ShowDialog() == DialogResult.OK)
            {
                string rootDir = folderBrowserDialog_path.SelectedPath;
                tb_Path.Text = rootDir;
                Properties.Settings.Default.Path = tb_Path.Text;
                Properties.Settings.Default.Save();
            }
        }



        private void tb_Passwd_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Passwd = tb_Passwd.Text;
            Properties.Settings.Default.Save();
        }

        private void lv_Servers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mUrl = lv_Servers.FocusedItem.Text;
            BackClientConfigEdit();
            OpenBackOffice();
            Authorization();
        }

        private void tb_Login_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Login = tb_Login.Text;
            Properties.Settings.Default.Save();
        }
    }
}
