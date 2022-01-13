using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_test
{
    [Serializable]
    public class Server
    {
        public List<Server> ServerList { get; set; } = new List<Server>();
        public Server() { }
        public Server(string serverAddr,
                string serverVersion,
                string serverEdition,
                string serverScheme,
                string serverSubUrl,
                string serverPathToBO)
        {
            ServerAddr = serverAddr;
            ServerVersion = serverVersion;
            ServerEdition = serverEdition;
            ServerScheme = serverScheme;
            ServerSubUrl = serverSubUrl;
            ServerPathToBO = serverPathToBO;

        }
        public string ServerAddr { get; set; }
        public string ServerVersion { get; set; }
        public string ServerEdition { get; set; }
        public string ServerScheme { get; set; }
        public string ServerSubUrl { get; set; }
        public string ServerPathToBO { get; set; }
    }
}
