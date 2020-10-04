using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum of array
            int[] numbers = {1, 2, 3, 4, 5};
            // Using for statement
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            System.Console.WriteLine($"Sum = {sum}");
            // Using for Linq
            System.Console.WriteLine($"Sum = {numbers.Sum()}");
            System.Console.WriteLine($"Count = {numbers.Count()}");
            System.Console.WriteLine($"Average = {numbers.Average()}");

            // Lambda
            System.Console.WriteLine($"Evens = {numbers.Where(n => n%2 == 0).ToList()}");
            List<int> list = new List<int>();
            list = numbers.Where(n => n%2 != 0).ToList();
            for (int j = 0; j < list.Count; j++) System.Console.WriteLine(list[j]);      

            //
            List<string> techs = new List<string>();
            techs.Add("C#");
            techs.Add("ASP.NET");
            techs.Add("Blazor");
            techs.OrderBy(t => t);
            for (int k = 0; k < techs.Count; k++) System.Console.WriteLine(techs[k]);
            // List<string> arts = new List<string>();
            // arts = techs.OrderBy(t => t);
            // for (int l = 0; l < arts.Count; l++) System.Console.WriteLine(arts[l]);
            
            var integers = Enumerable.Range(1, 100);
            int sumOfInt = integers.Where(i => i%2 == 0).Sum();
            System.Console.WriteLine(sumOfInt);
            // List<int> listOfInt = new List<int>();
            // listOfInt = integers.OrderByDescending(i => i).Where(x => x% 2 == 0).Take(3);
            // for (int m = 0; m < listOfInt.Count; m++) System.Console.WriteLine(listOfInt);

            // var q = from n in integers
            //         where n % 2 == 0
            //         select n;

            // for (int n = 0; n < 50; n++) System.Console.WriteLine($"{q[n]}\t");
        }
    }
}
