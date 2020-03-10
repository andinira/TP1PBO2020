using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{

    //membuat class untuk client atau penggunanya
    class Client
    {
        public string username { get; set; }
        public string password { get; set; }

        public Client(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Client()
        {

        }
    }
}
