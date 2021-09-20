using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ex4
    {
        public static int arr_length = 10;
        public int[] ArrayFilter(int[] arr1, int[] arr2, int NumberSeuil, int rabais)
        {
            var ex3 = new Ex3();
            int[] Filtred;
            Filtred = new int[arr1.Length+arr2.Length];
            int count = 0;


            foreach (int element in arr1)
            {
                if(ex3.DiscountPrice(element, rabais) <= NumberSeuil)
                {
                    Filtred[count] = element;
                    count++;
                }
            }
            foreach (int element in arr2)
            {
                if (ex3.DiscountPrice(element, rabais) <= NumberSeuil)
                {
                    Filtred[count] = element;
                    count++;
                }
            }

            int[] result;
            result = new int[count];
            for (int i=0; i< result.Length; ++i)
            {
                result[i] = Filtred[i];
            }
            return result;
        }
    }
}
