using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Ex6
    {
        public struct Arrays
        {
            public Arrays(int[] arr1Param, int[] arr2Param, int NumberSeuilParam, int rabaisParam)
            {
                var ex4 = new Ex4();

                arr1 = arr1Param;
                arr2 = arr2Param;
                NumberSeuil = NumberSeuilParam;
                rabais = rabaisParam;

                sorted_arr1 = ex4.ArrayFilter(arr1, rabais, NumberSeuil);
                sorted_arr2 = ex4.ArrayFilter(arr2, rabais, NumberSeuil);

                sorted_res_array = new List<int>();
                sorted_res_array.AddRange(sorted_arr1);
                sorted_res_array.AddRange(sorted_arr2);
            }

            public int[] arr1 { get; }
            public int[] arr2 { get; }
            public int NumberSeuil { get; }
            public int rabais { get; }
            public List<int> sorted_arr1 { get; }
            public List<int> sorted_arr2 { get; }
            public List<int> sorted_res_array { get; }

            

            public override string ToString() => $"Array_1: {string.Join(",", arr1)}\nArray_2: {string.Join(",", arr2)}\nNumberSeuil: {NumberSeuil}\nRabais: {rabais}\nSorted array_1: {string.Join(",", sorted_arr1)}\nSorted array_2: {string.Join(",", sorted_arr2)}\nSorted result array: {string.Join(",", sorted_res_array)}";
        }
        public Arrays array = new Arrays();
    }
}
