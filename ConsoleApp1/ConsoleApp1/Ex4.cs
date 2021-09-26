using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ex4
    {
        public static int arr_length = 10;
        public List<int> ArrayFilter(int[] arr1, int rabais, int NumberSeuil)
        {
            Ex3 ex3 = new Ex3();
            List<int> res = new List<int>();
            foreach (int element in arr1)
            {
                if (ex3.DiscountPrice(element, rabais) <= NumberSeuil)
                {
                    res.Add(element);
                }
            }
            return res;
        }

        public List<int> Process_exercice(int[] arr1, int[] arr2, int NumberSeuil, int rabais)
        {
            List<int> Filtred = new List<int>();
            Filtred.AddRange(ArrayFilter(arr1, rabais, NumberSeuil));
            Filtred.AddRange(ArrayFilter(arr2, rabais, NumberSeuil));
            return Filtred;
        }
    }
}
