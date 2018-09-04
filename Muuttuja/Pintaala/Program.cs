using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pintaala
{
    class Program
    {
        static void Main(string[] args)
        {
            string muoto;
            int kanta;
            int korkeus;
            int vastaus;
            double sade;

            Console.WriteLine("Syötä Kolmio, Suorakulmio tai ympyrä.");
            Console.Write("Syötä: ");
            muoto = Console.ReadLine();
            if (muoto == "kolmio" || muoto == "Kolmio")
            {
                Console.Write("Syötä Kanta: ");
                kanta = int.Parse(Console.ReadLine());
                Console.Write("Syötä korkeus: ");
                korkeus = int.Parse(Console.ReadLine());
                vastaus = kanta * korkeus / 2;
                Console.WriteLine("Kolmion pinta-ala on " + vastaus);

            }
            else if (muoto == "ympyrä")
            {
                Console.Write("Syötä säde: ");
                sade = double.Parse(Console.ReadLine());
                double vas;
                double pii = Math.PI;

                vas = pii * (sade * sade);

                
                Console.WriteLine("Ympyrän pinta-ala on " + vas);
            }
            else if (muoto == "suorakulmio")
            {
                Console.Write("Syötä Kanta: ");
                kanta = int.Parse(Console.ReadLine());
                Console.Write("Syötä korkeus: ");
                korkeus = int.Parse(Console.ReadLine());
                vastaus = kanta * korkeus;
                Console.WriteLine("Suorakulmion pinta-ala on " + vastaus);
            }

        }
    }
}
