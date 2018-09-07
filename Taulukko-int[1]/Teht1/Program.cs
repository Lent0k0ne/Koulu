using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] luvut = new int[5];

            
            luvut[0] = 1;
            luvut[1] = 2;
            luvut[2] = 3;
            luvut[3] = 4;
            luvut[4] = 5;
            
            for (int i = 0; i < luvut.Length; i++)
            {
                luvut[i] = i + 1;
            }

           
            foreach (int luku in luvut)
            {
                Console.WriteLine(luku);
            }

           
            int[] luvut2 = { 10, 20, 30 };

            
            int uusi = 5;
            luvut2[1] = uusi;

            
            foreach (int luku in luvut2)
            {
                Console.WriteLine(luku);
            }
            Console.WriteLine();
            
            string[] nimet = { "Tiina", "Susanna", "Karvonen" };
           
            
            foreach (string nimi in nimet)
            {
                Console.Write(nimi + " ");
            }
            Console.WriteLine();
            
            int[] taulukko1=new int[10];
            int[] taulukko2=new int[taulukko1.Length];

            for (int i = 0; i < taulukko1.Length; i++)
            {
                Console.WriteLine("Syötä " + (i + 1) + ". luku");
                taulukko1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 0; i < taulukko1.Length; i++)
            {
                taulukko2[i] = taulukko1[i];
            }

            foreach (int x in taulukko1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            foreach (int x in taulukko2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Array.Sort(taulukko2);
            foreach (int x in taulukko1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            foreach (int x in taulukko2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < taulukko1.Length; i++)
            {
                taulukko2[i] = taulukko1[taulukko1.Length-1-i];
            }
            foreach (int x in taulukko1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            foreach (int x in taulukko2)
            {
                Console.Write(x + " ");
            }
        }
    }
}
