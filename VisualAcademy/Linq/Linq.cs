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
            System.Console.WriteLine("[List]");
            List<string> techs = new List<string>();
            techs.Add("C#");
            techs.Add("ASP.NET");
            techs.Add("Blazor");
            techs.OrderBy(t => t);
            for (int k = 0; k < techs.Count; k++) System.Console.WriteLine(techs[k]);
            
            System.Console.WriteLine("[List - OrderBy]");
            IEnumerable<string> arts = techs.OrderBy(t => t);
            foreach(var art in arts) System.Console.WriteLine(art);
            
            var integers = Enumerable.Range(1, 100);
            int sumOfInt = integers.Where(i => i%2 == 0).Sum();
            System.Console.WriteLine(sumOfInt);

            System.Console.WriteLine("[List - WhereToList]");
            IEnumerable<int> listOfInts = integers.OrderByDescending(i => i).Where(x => x% 2 == 0).Take(3);
            foreach (var listOfInt in listOfInts) System.Console.WriteLine(listOfInt);
            
            System.Console.WriteLine("[Query type]");
            var querys = from n in integers
                    where n % 5 == 0
                    select n;
            foreach(var query in querys) System.Console.WriteLine(query);
        }
    }
}
