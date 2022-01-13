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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string mUrl = string.Empty;
        public Form1()
        {
            InitializeComponent();
            TB_path.Text = Properties.Settings.Default.Path;
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

            bool res = Uri.IsWellFormedUriString(mUrl, UriKind.Absolute);
            if (res == false)
            {
                TB_console.Text = string.Format("ERROR: URL адрес " + mUrl + " не верный. Используй URL формата" +
                                      " https://exmple.iiko.it или https://exmple.iiko.it/resto ");
            }
            var url = mUrl + "/get_server_info.jsp?encoding=UTF-8";
            UrlService urlService = new UrlService();

            var serverProperties = urlService.GetServerProperties(url);
            string[] serverPropertiesArray = {
                serverProperties.ServerName,
                serverProperties.Version, 
                serverProperties.Edition};
            
            ListViewItem item = new ListViewItem(TB_url.Text);
            //bool isExist = false;
            //foreach (ListViewItem t in lv_Servers.Items)
            //{
            //    if (t.Text == serverProperties.ServerName)
            //    { isExist = true; break; }
            //}
            //if (!isExist)
            //{


               item.SubItems.AddRange(serverPropertiesArray);
                lv_Servers.Items.Add(item);
            //}
            
           
            TB_url.Clear();
            


            return serverProperties;

        }

        private void OpenBackOffice()
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
            foreach (XElement el in userList.Elements())
            {
                if (el.Name == "ServersList")
                {
                    el.Remove();
                }
            }

            var uriparser = new Uri(mUrl);
            var content = new XElement("ServersList",
                                        new XElement("ServerName", serverProperties.ServerName),
                                        new XElement("Version", serverProperties.Version),
                                        new XElement("ComputerName", serverProperties.computerName),
                                        new XElement("Protocol", uriparser.Scheme),
                                        new XElement("ServerAddr", uriparser.Host),
                                        new XElement("ServerSubUrl", uriparser.PathAndQuery),
                                        new XElement("Port", uriparser.Port.ToString()),
                                        new XElement("IsPresent", serverProperties.isPresent)
                                        );

            userList.Element("serverChooserIsOpened").AddBeforeSelf(content);

            userList.Save(backclientconfig);


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


            var directories = Directory.EnumerateDirectories(TB_path.Text, searchPattern, SearchOption.AllDirectories);
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
                        TB_console.Text += string.Format("Открываю " + directory + @"\BackOffice.exe");
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
                //TB_console.Text += string.Format(e.Message);
            }
        }

        private void Authorization()
        {
            //while (true) работает тут
            for (int i = 0; i<1000;)
            {
                IntPtr authWindow = FindWindow(null, "Вход в систему");
                if (authWindow.ToInt32() != 0)
                {
                    List<IntPtr> all_hwnd_child_window = GetChildWindows(authWindow);
                    foreach (var hwnd_child_window in all_hwnd_child_window)
                    {
                        IntPtr editWindow = FindWindowEx(hwnd_child_window, new IntPtr(0), null, "");
                        SendMessage(editWindow, 0x000C, 0, TB_passwd.Text);

                        IntPtr bttnLogin = FindWindowEx(hwnd_child_window, new IntPtr(0), null, "Войти");
                        SendMessage(bttnLogin, (int)0x201, (IntPtr)1, IntPtr.Zero);
                        SendMessage(bttnLogin, (int)0x202, IntPtr.Zero, IntPtr.Zero);
                    }
                    i++;
                    
                }
                else { Thread.Sleep(1000); i++; }
            }
            
        }

        //private void Test()
        //{
        //    var serverProperties = GetServerProperties();
        //    Server server = new Server();
        //    serverProperties.ServerName),
        //    serverProperties.Version),
        //    serverProperties.computerName),
        //    uriparser.Scheme),
        //    uriparser.Host),
        //    uriparser.PathAndQuery),
        //    uriparser.Port.ToString()),
        //    serverProperties.isPresent));
        //}


        private void BTN_check_Click(object sender, EventArgs e)
        {
            var serverProperties = GetServerProperties();
            TB_console.Text = string.Format("ServerVersion: {0}+ \r\nServerState: {1}\r\nEdition {2}",
            serverProperties.Version, serverProperties.ServerState, serverProperties.Edition);
           
        }

        private void TB_url_TextChanged(object sender, EventArgs e)
        {
            mUrl = TB_url.Text;
        }

        private void BTN_path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string rootDir = folderBrowserDialog1.SelectedPath;
                TB_path.Text = rootDir;
                Properties.Settings.Default.Path = TB_path.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void BTN_open_Click(object sender, EventArgs e)
        {
            OpenBackOffice();

            Authorization();
            

        }

        private void BTN_auth_Click(object sender, EventArgs e)
        {
            Authorization();
        }

        private void lv_Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_url.Text = lv_Servers.FocusedItem.Text;
        }
    }
}
