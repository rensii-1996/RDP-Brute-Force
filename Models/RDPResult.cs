using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastRDP.Models
{
    public class RDPResult
    {
        private string username;
        private string password;
        private string hostname;
        private bool status;
        private string err;
        private string port;

        public RDPResult(string username, string password, string hostname, string port, bool status, string err)
        {
            this.username = username;
            this.password = password;
            this.hostname = hostname;
            this.port = port;
            this.status = status;
            this.err = err;
        }

        public string Username { get { return username; } }
        public string Password { get { return password; } }
        public string Hostname { get { return hostname; } }
        public string Port { get { return port; } }
        public bool Status { get { return status; } }
        public string Error { get { return err; } }

    }
}
