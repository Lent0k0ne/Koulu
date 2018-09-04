using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace while1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            a = 0;

            /*while (a < 21)
            {
                Console.WriteLine(a);
                a += 2;
            }

            while (a < 10)
            {
                Console.WriteLine(a + " *    5");
                a++;
            }*/


          /*  while (a != 0)
            {
                Console.WriteLine("Anna luku tähän");
                a = int.Parse(Console.ReadLine());
            }*/

            int summa = 0;
            a = 0;

            while (a < 5)
            {
                if (a <= 0)
                {
                    Console.WriteLine("Syötä ensinmäinen luku");
                    summa += int.Parse(Console.ReadLine());
                    a++;
                }
                else {
                    Console.WriteLine("Anna lisättävä luku");
                    summa += int.Parse(Console.ReadLine());
                    a++;
                }
                
            }

            Console.WriteLine("Summa on " + summa);
            
        }
    }
}
