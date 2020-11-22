using System;

namespace DiscountInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put your amount's invoice for discount: \n");

            double giving = double.Parse(Console.ReadLine());
            discount(giving);
        }
        private static void discount(double giving)
        {
            if (giving > 5000)
            {

                double discountCalculate = (giving / 100) * 5;
                double total = giving - discountCalculate;

                Console.Clear();
                Console.WriteLine("\n pay again with discount: " + total + "\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n no discount \n");
                Console.ResetColor();
            }
        }
    }
}
