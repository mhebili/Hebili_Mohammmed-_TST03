using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCity
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] CityinBelgium = new string[8] { "Brussel", "Antwerpen", "Turnhout ", "Kortrijk", "Gent", "Dendermonde", "Aalst", "Oudenaarde" };
            int[] postCode = { 1000, 2000, 2300, 8500, 9000, 9200, 9300, 9700 };

            Console.WriteLine("choose one code from here:" +
                              " 1000, 2000, 2300, 8500, 9000, 9200, 9300, 9700");

            FindCityMethod(CityinBelgium, postCode);
        }
        private static void FindCityMethod(string[] cityinBelgium, int[] postCode)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    int post = Array.IndexOf(postCode, result);
                    if (post >= 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nInput accepted\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"your code is from a city: \n{cityinBelgium[post]}\n");

                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("choose option please.");
                    }
                }
            }
        }
    }
}