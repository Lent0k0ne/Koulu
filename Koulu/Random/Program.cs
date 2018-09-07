using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Randomi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();

            int b = a.Next(51);

            Console.WriteLine(b);

        }
    }
}
