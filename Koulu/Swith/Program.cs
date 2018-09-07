using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swith
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikäsi: ");
            int a = int.Parse(Console.ReadLine());

            int b = a % 5;

            int vastaus = 5 - b;

            Console.WriteLine("Saat seuravaat pisteet " + vastaus + " vuoden päästä");
        }
    }
}
