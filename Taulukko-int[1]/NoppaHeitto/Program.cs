using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int tulos;
            
            int heitot;
            Console.WriteLine("Kuinka monta heittoa?");
            heitot = int.Parse(Console.ReadLine());

            
            int[] jakauma = new int[7];

            for (int i = 0; i < heitot; i++)
            {
                tulos = rnd.Next(1, 7);
               
                jakauma[tulos]++;
            }
            Console.WriteLine("Tulokset jakautuivat seuraavasti:");
            for (int i = 1; i < jakauma.Length; i++)
            {
                Console.WriteLine(i+ ":" +jakauma[i]);
            }

        }
    }
}
