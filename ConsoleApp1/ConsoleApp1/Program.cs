using System;

namespace ConsoleApp1
{
    class Program
    {

        static public void ShowArray(int [] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Let's test)\n");
            /*
            var exercice1 = new Ex1();
            Console.WriteLine("| Euclid rest |");
            Console.WriteLine("Enter 2 numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:\n" + exercice1.EuclidRest(a, b) + "\n");

            var exercice2 = new Ex2();
            Console.WriteLine("| Volume sphere |");
            Console.WriteLine("Enter radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result:\n" + exercice2.VolumeSphere(radius) + "\n");
            
            var exercice3 = new Ex3();
            Console.WriteLine("| Discount price |");
            Console.WriteLine("Enter price and discount:");
            double price = Convert.ToDouble(Console.ReadLine());
            int discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:\n" + exercice3.DiscountPrice(price, discount));
            */

            var exercice4 = new Ex4();
            var rand = new Random();
            Console.WriteLine("| Arrays Filtre |");
            // int[] arr1, int[] arr2, int NumberSeuil, int rabais
            int[] arr1;
            int[] arr2;
            arr1 = new int[10];
            arr2 = new int[10];

            for(int i = 0; i < 10; i++)
            {
                arr1[i] = rand.Next(0, 101);
                arr2[i] = rand.Next(0, 101);
            }
            int NumberSeuil = rand.Next(0, 101);
            int rabais = rand.Next(0, 101);
            Console.WriteLine("Arr1:");
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine("Arr2:");
            Console.WriteLine(string.Join(" ", arr2));
            Console.WriteLine("NumberSeuil: " + NumberSeuil);
            Console.WriteLine("rabais: " + rabais);

            Console.WriteLine("Result:");
            Console.WriteLine(string.Join(" ", exercice4.ArrayFilter(arr1, arr2, NumberSeuil, rabais)));

        }
    }
}
