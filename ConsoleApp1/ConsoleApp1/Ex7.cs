using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ex7
    {
        public int[] SortSelection(int[] arr)
        {
            int[] res = arr;
            for (int i = 0; i < res.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < res.Length; j++)
                {
                    if (res[j] < res[min])
                    {
                        min = j;
                    }
                }
                int temp = res[i];
                res[i] = res[min];
                res[min] = temp;
            }
            return res;

        }
        public int[] SortBull(int[] arr)
        {
            int[] res = arr;
            int len = res.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (res[j] > res[j + 1])
                    {
                        int temp = res[j];
                        res[j] = res[j + 1];
                        res[j + 1] = temp;
                    }
                }
            }
            return res;

        }
    }
}
