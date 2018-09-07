using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swith4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            int b = a.Next(21) * 5;
            Console.WriteLine(b);

            int ba = a.Next(10, 31) * 5;
            Console.WriteLine(ba);

            double bc = a.Next(0, 11) / (double)10;
            Console.WriteLine(bc);
        }
    }
}
