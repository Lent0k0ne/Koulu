using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jokeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); 
            int oikein=0; 
          
            int[] jokeri=new int[7];
            
            for (int i = 0; i < jokeri.Length; i++)
            {
                jokeri[i] = rnd.Next(10);
            }
            
            Console.WriteLine("arvottu jokeririvi on:");
            foreach (int numero in jokeri)
            {
                Console.Write(numero);
            }
            Console.WriteLine();
            
            int[] arvaus = new int[7];
            for (int i = 0; i < arvaus.Length; i++)
            {
                Console.WriteLine("Syötä "+(i+1)+". jokerinumero");
                arvaus[i] = int.Parse(Console.ReadLine());
            }
           
           for (int i = 0; i < jokeri.Length; i++)
            {
                if (jokeri[i] == arvaus[i])
                {
                    oikein++;
                }
            }

            Console.WriteLine("Sinulla oli "+ oikein + " oikein.");

           
            oikein = 0;
            for (int i = 0; i < jokeri.Length; i++)
            {
                if (jokeri[i] == arvaus[i])
                {
                    oikein++;
                }
                else
                {
                    break; 
                }
            }
            Console.WriteLine("sinulla oli alusta " + oikein + " oikein");

        }
    }
}
