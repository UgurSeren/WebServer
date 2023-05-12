using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Server server = new Server();
            Webseite google = new Webseite("www.google.com", "123.123.233.121" );

            Webseite webseite = new Webseite("www.microsoft.com", "123.21.32.43");

            Client client = new Client();
            client.name = "Ugurs Computer";
            client.IPAddress = "127.0.0.1";

            client.Anfordern(webseite, client);
            client.Anfordern(google,client);

            Console.ReadLine();



        }
    }
}
