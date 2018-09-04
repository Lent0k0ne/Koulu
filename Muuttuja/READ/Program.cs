using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace READ
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string line1;
            Console.WriteLine("Syötä tietosi tänne niin saat parempaa palvelua!");
            Console.WriteLine();
            Console.Write("Etunimi: ");
            line = Console.ReadLine();
            
            //Console.WriteLine("Nimesi on " + line);

            Console.Write("Sukunimi: ");
            line1 = Console.ReadLine();
            
            //Console.WriteLine("Sukunimesi on " + line1);

            Console.Write("Ikä: ");
            int luku = int.Parse(Console.ReadLine());

            Console.WriteLine("Etunimi " + line + ",Sukunimi " + line1 + ",Ikäsi on " + luku);
            Console.WriteLine("Kiitos kun täytit tämän lomakkeen!");

           /* int tulos = 5 + 6;

            int luki1 = 6;
            int luku2 = 8;

            int x = 13;
            int y = 4;
            int yli = x % y;

            int lkm = (x - y) / y;

            Console.WriteLine(lkm);*/

            

        }
    }
}
