using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();

            Console.WriteLine("Syötä 3 numeroa, jotka ovat 1-20 sisällä.");

            Console.Write("Anna enimmäinen; ");
            int v1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen; ");
            int v2 = int.Parse(Console.ReadLine());

            Console.Write("Anna kolmas; ");
            int v3 = int.Parse(Console.ReadLine());

            if (v1 > 20 || v2 > 20 || v3 > 20)
            {
                Console.WriteLine("Syötä kelvolliset luvut!");
                Environment.Exit(0);
            }

            int r1 = a.Next(1, 11);
            int r2 = a.Next(1, 11);
            int r3 = a.Next(1, 11);

            int oikein = 0;

            if (r1 == v1 || r1 == v2 || r1 == v3)
            {
                oikein++;
            }
            if (r2 == v1 || r2 == v2 || r2 == v3)
            {
                oikein++;
            }
            if (r3 == v1 || r3 == v2 || r3 == v3)
            {
                oikein++;
            }
            if (oikein == 3)
            {
                Console.WriteLine("Sinulla oli kaikki oikein ");
            }
            else if (oikein > 0)
            {
                Console.WriteLine("Sinulla oli oikein " + oikein);
                Console.WriteLine("Oikeat numerot olisi ollut " + r1 + " " + r2 + " " + r3);

                Console.WriteLine("Sinun rivisi oli " + v1 + " " + v2 + " " + v3);
            }
            else
            {
                Console.WriteLine("Sinulla ei osunut yksikään.");
                Console.WriteLine("Oikeat numerot olisi ollut " + r1 + " " + r2 + " " + r3);
                Console.WriteLine("Sinun rivisi oli " + v1 + " " + v2 + " " + v3);
            }

            
            

        }
    }
}
