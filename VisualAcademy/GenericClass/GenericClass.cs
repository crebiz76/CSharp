using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // <-- Stack -->
            System.Console.WriteLine("// <-- Stack -->");
            Stack stack = new Stack();
            stack.Push(100);
            System.Console.WriteLine(stack.Pop());

            Stack<int> stack_Generic = new Stack<int>();
            stack_Generic.Push(200);
            System.Console.WriteLine(stack_Generic.Pop());

            // <-- List -->
            System.Console.WriteLine("// <-- List -->");
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            for (int i = 0; i < numbers.Count ; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }
            foreach(var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            // <-- List<string> -->
            System.Console.WriteLine("// <-- List<string> -->");  
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            // colors.Add("Blue");
            colors.Insert(2,"Blue");
            foreach(var color in colors)
            {
                System.Console.WriteLine($"{color}");
            }

            // <-- List(Enumerable) -->
            System.Console.WriteLine("// <-- List(Enumerable) -->");
            List<int> Sequences = new List<int>();
            
            List<int> range = new List<int>();
            range.AddRange(Enumerable.Range(1, 5));
            List<int> repeat = new List<int>();
            for(int i = 0; i < range.Count; i++) System.Console.Write(range[i]);
            System.Console.WriteLine();
            repeat.AddRange(Enumerable.Repeat(1, 5));
            for(int j = 0; j < range.Count; j++) System.Console.Write(repeat[j]);
            System.Console.WriteLine();

            Sequences.AddRange(Enumerable.Range(1,10));
            for(int k = 0; k < Sequences.Count; k++)System.Console.Write(Sequences[k]);
            System.Console.WriteLine();

            // <-- Dictionary -->
            System.Console.WriteLine("// <-- Dictionary -->");
            Dictionary<int, string> todos = new Dictionary<int, string>();
            todos.Add(1, "C#");
            todos.Add(2, "ASP.NET");
            todos.Add(3, "...");
            foreach(var item in todos)
            {
                System.Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
