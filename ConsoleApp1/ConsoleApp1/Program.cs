using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.WriteLine("Hello! Let's test)\n");
            Console.WriteLine("Select exercise number: 1,2,3,4,5,6,7,8,9 or 0 for exit \n");
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
                            Console.WriteLine(string.Join(" ", exercice4.Process_exercice(arr1, arr2, NumberSeuil, rabais)));
                            break;

                        case 5:
                            int arr5Len1 = rand.Next(5, 11);
                            int arr5Len2 = rand.Next(5, 11);
                            int[,] arr5 = new int[arr5Len1, arr5Len2];
                            var exercice5 = new Ex5();
                            exercice5.InitShowArray(arr5);
                            break;

                        case 6:
                            var ex6 = new Ex6();
                            arr1 = new int[10];
                            arr2 = new int[10];

                            for (int i = 0; i < 10; i++)
                            {
                                arr1[i] = rand.Next(0, 101);
                                arr2[i] = rand.Next(0, 101);
                            }
                            NumberSeuil = rand.Next(0, 101);
                            rabais = rand.Next(0, 101);
                            ex6.array = new Ex6.Arrays(arr1, arr2, NumberSeuil, rabais);
                            Console.WriteLine(ex6.array.ToString());
                            break;

                        case 7:
                            Ex7 ex7 = new Ex7();
                            int[] arr = new int[10];
                            for (int i = 0; i < 10; i++)
                            {
                                arr[i] = rand.Next(0, 101);
                            }
                            
                            Console.WriteLine("Array: " + string.Join(",", arr));
                            Console.WriteLine("Sorted by selection:\n" + string.Join(",", ex7.SortSelection(arr)));
                            Console.WriteLine("Sorted by bull:\n" + string.Join(",", ex7.SortBull(arr)));
                            break;

                        case 8:
                            Ex8 ex8 = new Ex8();
                            Console.WriteLine("Enter number to calculate Fibonnachi humber:");
                            int choiceN = 0;
                            bool isNumberN = false;
                            while (!isNumberN)
                            {
                                string readN = Console.ReadLine();
                                isNumberN = int.TryParse(readN, out choiceN);
                                if (!isNumberN)
                                {
                                    Console.WriteLine("ERROR. Enter a number correctly");
                                }
                            }
                            Console.WriteLine(ex8.Fibonachi(choiceN));
                            break;

                        case 0: exit = true; break;

                        default: Console.WriteLine("ERROR"); break;
                    }
                    if (!exit)
                    {
                        Console.WriteLine("Select 1,2,3,4,5,6,7,8,9 or 0 for exit");
                    }
                }
            }
        }
    }
}
