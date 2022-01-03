using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Servers
    {
        public List<Server> ServerList { get; set; } = new List<Server>();
        public Servers () { }
    }
    [Serializable]
    public class Server
    {
        public Server() { }
        public Server(string serverAddr,
                string serverVersion,
                string serverEdition,
                string serverScheme,
                string serverSubUrl,
                string serverPathToBO)
        {
            this.serverAddr = serverAddr;
            this.serverVersion = serverVersion;
            this.serverEdition = serverEdition;
            this.serverScheme = serverScheme;
            this.serverSubUrl = serverSubUrl;
            this.serverPathToBO = serverPathToBO;


        }
        public string serverAddr { get; set; }
        public string serverVersion { get; set; }
        public string serverEdition { get; set; }
        public string serverScheme { get; set; }
        public string serverSubUrl { get; set; }
        public string serverPathToBO { get; set; }
    }
}
