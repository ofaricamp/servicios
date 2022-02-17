using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SERVBol3_Ejer3
{
    class Cliente
    {
        private string userName;
        private IPEndPoint ip;
        private Socket socket;

        public string UserName { set; get; }

        public IPEndPoint Ip { set; get; }

        public Socket Socket { set; get; }
    }
}
