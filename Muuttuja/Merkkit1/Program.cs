using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Merkkit1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arvo = 6;
            char merkkik = 'b';
            double pituus = 5.6;
            string wel = "Tervetuloa";

            bool muuttuja = true;

            arvo = 2;
            merkkik = 'e';
            pituus = 1.2;
            wel = "Welcome";
            muuttuja = false;


            Console.WriteLine(arvo + merkkik + pituus + wel + muuttuja);


            double num1 = 3;
            double num2 = num1;
            double num3 = num1;
            double num4 = num1;

            int luku1 = 1;
            int luku2 = 2;
            int varasto = 4;

            luku1 = 1 + varasto;
            luku2 = 2 + varasto;

            Console.WriteLine(luku1 + " " + luku2);

            /*String
            string etunimi = "Samuel";
            string sukunimi = "Aikio";
            int ikä = 16;

            Console.WriteLine("Tervetuloa " + etunimi + " " + sukunimi + "!");
            Console.WriteLine("Ikäsi on " + ikä);*/



           




        }
    }
}
