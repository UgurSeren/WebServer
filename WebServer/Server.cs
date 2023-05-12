using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebServer
{
    internal class Server
    {
        public List<Webseite> webseites = new List<Webseite>();
        bool b = false;
        bool v = true;
        

        public void Receiving(Webseite w,Client c)
        {
            
            Console.WriteLine($"Die Client: {c.name}({c.IPAddress}) anforndern auf die Webseite {w.name} zuzugreifen");
            Console.WriteLine();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" 1)Erlauben\t 2)keine Zugang");

            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.BackgroundColor= ConsoleColor.Green;
                    Console.WriteLine("Ok");
                    Accepted(c, w, v);

                    break;
                case 2:
                    Console.WriteLine("Ok...");
                    Console.BackgroundColor=ConsoleColor.Red;
                    Negative(c,w, b);
                    break;
                default:
                    break;
            }
            
        }
        
        public void Accepted(Client c,Webseite w,bool i)
        {
            c.Antwort(i,w);
        }
        public void Negative(Client c,Webseite w, bool i)
        {
            Console.WriteLine($"Client: {c.name}({c.IPAddress}) wird nicht von Server akzeptiert, Um {w.name} zuzugreifen  ");
            Thread.Sleep(3000);
            c.Antwort(i,w);
        }
    }
}
