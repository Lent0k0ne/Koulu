using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swith2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kysely on matemaattinen");

            Console.Write("Matti paljonko sinulla on rahaa(Syötä Euroina); ");
            int rahat = int.Parse(Console.ReadLine());

            Console.Write("Matti kuinka monta lasta sinulla on; ");
            int lapset = int.Parse(Console.ReadLine());

            int matinrahat = 0;
            int plusrahat = rahat - 50;

            if (plusrahat > 0)
            {
                matinrahat += plusrahat;
                rahat = 50;
            }
            matinrahat += rahat % lapset;

            Console.WriteLine("Lapset saavat rahaa " + rahat / lapset + " Euroa ");

            Console.WriteLine(" ");

            Console.WriteLine("Matille jäävät rahat " + matinrahat + " Euroa");

        }
    }
}
