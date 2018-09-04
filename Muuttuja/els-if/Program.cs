using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace els_if
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            Console.WriteLine("Syötä sinun pisteet tänne");

            Console.WriteLine();
            Console.Write("Pisteet: ");
            line = Console.ReadLine();

            int luku = int.Parse(line);


            if (luku >= 10)
            {
                Console.WriteLine("hyvä tulos!");
            }
            else {
                Console.WriteLine("Huono tulos!");
            }


        }
    }
}
