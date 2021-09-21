using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ex5
    {
        public void InitShowArray(int[,] arr)
        {
            var rand = new Random();
            for(int i=0; i< arr.GetLength(0); ++i)
            {
                Console.Write("|");
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    arr[i, j] = rand.Next(0, 9);
                    Console.Write(arr[i, j] + "|");
                }
                Console.Write("\n");
            }
        }
    }
}
