using iiko_it_getversion_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace iikoBOS_v0._02
{
    public partial class Form1 : Form
    {
        private string mUrl = string.Empty;
        public Form1()
        {
            InitializeComponent();
            TB_path.Text = Properties.Settings.Default.Path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_path.ShowDialog() == DialogResult.OK)
            {
                string rootDir = folderBrowserDialog_path.SelectedPath;
                TB_path.Text = rootDir;
                Properties.Settings.Default.Path = TB_path.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void BTN_start_Click(object sender, EventArgs e)
        {
            TB_console.Clear();
            GetServerPropertiesAndOpenBackOffice();
        }

        private void GetServerProperties()
        {
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
            TB_console.Text = string.Format("ServerVersion: {0}+ \r\nServerState: {1}\r\nEdition {2}",
                 serverProperties.Version, serverProperties.ServerState, serverProperties.Edition);

        }

        private void GetServerPropertiesAndOpenBackOffice()
        {

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
            TB_console.Text = string.Format("ServerVersion: {0}+ \r\nServerState: {1}\r\nEdition {2}",
                 serverProperties.Version, serverProperties.ServerState, serverProperties.Edition);
        

       
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
                TB_console.Text += string.Format(e.Message);
            }
        }



        private void TB_url_TextChanged(object sender, EventArgs e)
        {
            mUrl = TB_url.Text;
        }

        private void LA_path_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TB_console.Clear();
            GetServerProperties();

        }
    }
}
