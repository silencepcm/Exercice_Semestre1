using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.WriteLine("Hello! Let's test)\n");
            Console.WriteLine("Select exercise number: 1,2,3,4,5 or 6 for exit \n");
            bool exit = false;
            while (!exit)
            {
                string read = Console.ReadLine();
                int choice;
                bool isNumber = int.TryParse(read, out choice);
                if (!isNumber)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            var exercice1 = new Ex1();
                            Console.WriteLine("| Euclid rest |");
                            Console.WriteLine("Enter 2 numbers:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Result:\n" + exercice1.EuclidRest(a, b) + "\n");
                            break;

                        case 2:
                            var exercice2 = new Ex2();
                            Console.WriteLine("| Volume sphere |");
                            Console.WriteLine("Enter radius:");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Result:\n" + exercice2.VolumeSphere(radius) + "\n");
                            break;

                        case 3:
                            var exercice3 = new Ex3();
                            Console.WriteLine("| Discount price |");
                            Console.WriteLine("Enter price and discount:");
                            double price = Convert.ToDouble(Console.ReadLine());
                            int discount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Result:\n" + exercice3.DiscountPrice(price, discount));
                            break;

                        case 4:
                            var exercice4 = new Ex4();
                            Console.WriteLine("| Arrays Filtre |");
                            int[] arr1 = new int[10];
                            int[] arr2 = new int[10];

                            for (int i = 0; i < 10; i++)
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
                            break;

                        case 5:
                            int arr5Len1 = rand.Next(5, 11);
                            int arr5Len2 = rand.Next(5, 11);
                            int[,] arr5 = new int[arr5Len1, arr5Len2];
                            var exercice5 = new Ex5();
                            exercice5.InitShowArray(arr5);
                            break;

                        case 6: exit = true; break;

                        default: Console.WriteLine("ERROR"); break;
                    }
                    if (!exit)
                    {
                        Console.WriteLine("Select 1,2,3,4,5 or 6 for exit");
                    }
                }
            }
        }
    }
}
