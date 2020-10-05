using System;
using System.Linq;
using System.Collections.Generic;

namespace SortAlgorithm
{
    class Program
    {
        // Selection Sort
        static void Main(string[] args)
        {
            // [1] Sort
            System.Console.WriteLine("// [1] Sort ");         
            int[] a = {3, 2, 1, 5, 4};
            Array.Sort(a);
            for(int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine(a[i]);
            }

            // [2] OrderBy
            System.Console.WriteLine("// [2] OrderBy");
            int[] b = {3, 4, 1, 5, 2};
            var result = b.OrderBy(d => d);
            foreach(int res in result)
            {
                System.Console.WriteLine(res);
            }

            // [3] Sort Algorithm
            System.Console.WriteLine("// [3] Sort Algorithm");
            int[] c = {2, 4, 1, 3, 5};
            for(int i = 0; i < c.Length - 1 ; i++)
            {
                for(int j = i + 1; j < c.Length; j++)
                {
                    if(c[i] > c[j]) 
                    {
                        int temp = c[i];
                        c[i] = c[j];
                        c[j] = temp;
                    }
                }
            }
            
            for(int k = 0; k < c.Length; k++)
            {
                System.Console.WriteLine(c[k]);
            }
        }
    }
}
