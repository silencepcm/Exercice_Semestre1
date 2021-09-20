using System;

namespace ConsoleApp1
{

    class Exercice
    {
        public const double PI = 3.1415926535897931;


        public int euclid_rest(int a, int b)
        {
            int div_num = a / b;
            return a - div_num;
        }
        public double volume_sphere(double radius)
        {
            return 4 / 3 * PI * Math.Pow(radius, 3);
        }

        public double discount_price(double price, int int_discount)
        {
            double discount = Convert.ToDouble(int_discount);
            return price - price * discount / 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var exercice = new Exercice();

            Console.WriteLine("Hello! Let's test)\n");

            Console.WriteLine("| Euclid rest |");
            Console.WriteLine("Enter 2 numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:\n" + exercice.euclid_rest(a, b) + "\n");

            Console.WriteLine("| Volume sphere |");
            Console.WriteLine("Enter radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result:\n" + exercice.volume_sphere(radius) + "\n");

            Console.WriteLine("| Discount price |");
            Console.WriteLine("Enter price and discount:");
            double price = Convert.ToDouble(Console.ReadLine());
            int discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:\n" + exercice.discount_price(price, discount));
        }
    }
}
