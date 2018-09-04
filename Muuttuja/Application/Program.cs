using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mikä on kotimaasi?");
            string kotimaa = Console.ReadLine();

            switch (kotimaa)
            {
                case "Suomi":
                    Console.WriteLine("Olet pohjoismaista");
                    Console.WriteLine("Tervehdys lajitoveri");
                    break;

                case "Ruotsi":
                case "Tanska":
                    Console.WriteLine("Olet pohjoismaista");
                    break;

                case "Englanti":
                case "Irlanti":
                    Console.WriteLine("Olet Britteinsaarilta");
                    break;

                case "USA":
                case "Kanada":
                    Console.WriteLine("Olet Amerikasta");
                    break;

                default:
                    Console.WriteLine("Tä?");
                    break;
            }
        }
    }
}
