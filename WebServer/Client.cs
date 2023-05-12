using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace WebServer
{
    internal class Client
    {
        public string IPAddress { get; set; }
        public string name { set; get; }

       

        
       
        

        public void Anfordern(Webseite w,Client c)
        {
            
            Server server = new Server();
            server.Receiving(w,c);
            
        }
        public void Antwort(bool b,Webseite w)
        {
            if (b==true)
            {
                Console.Clear();
                string url = $"{w.name}";


                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"{w.name} wird geöffnet");

                Process.Start(url);
                
            }
            else
            {

                Console.Clear();
                string url = "www..com";
                Console.WriteLine("Hmmm...diese Seite ist leider nicht erreichbar");
                Process.Start(url);
            }
            
        }
    }
}
