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

namespace iikoCheckVersion._02
{
    public partial class Form1 : Form
    {
        private string mUrl = string.Empty;
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void GetServerProperties()
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
            TB_console.Text = string.Format("ServerVersion: {0} \r\nServerState: {1}\r\nEdition {2}",
                 serverProperties.Version, serverProperties.ServerState, serverProperties.Edition);

        }

        



        private void TB_url_TextChanged(object sender, EventArgs e)
        {
            mUrl = TB_url.Text;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            TB_console.Clear();
            GetServerProperties();

        }

        private void TB_url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(sender, e);
            }
        }
    }
}
