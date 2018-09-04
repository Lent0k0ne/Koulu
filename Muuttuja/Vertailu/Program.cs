using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vertailu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int m = 5;
            string hello = "Hello World";

            if (m >= 5)
                if (m <= 5)
                {
                    Console.WriteLine(hello);
                }
                else {
                    Console.WriteLine("What");
                }*/

            string line;
            Console.WriteLine("Syötä Sijoituksesi 1-3 väliltä");

            Console.WriteLine();
            Console.Write("Sijoitus: ");
            line = Console.ReadLine();

            int luku = int.Parse(line);

            if (luku >= 1)
                if (luku <= 1)
                {
                    Console.WriteLine("Olet ensinmäinen!");
                }
            else if (luku >= 2)
                if (luku <= 2)
                {
                    Console.WriteLine("Olet toinen");
                }

            else if (luku >= 3)
                if (luku <= 3)
                {
                    Console.WriteLine("Olet kolmas");
                }
            else {
                Console.WriteLine("Et päässyt palkinta pallille! LOLOLOLOL");
            }
        }
    }
}
