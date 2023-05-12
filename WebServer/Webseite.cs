using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    internal class Webseite
    {
        public string name { set; get; }
        public string ipadress { set; get; }
        public Server s { set; get; }
        public Webseite(string s, string m) 
        {
            name = s;
            ipadress=m;
        }

        
    }
}
