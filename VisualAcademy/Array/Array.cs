using System;

class Array
{
    static void Main(string[] args)
    {
        // string
        string arr = "C#8";
        for(int i=0; i<arr.Length; i++)
        {
            System.Console.WriteLine(arr[i]);
        }

        //
        System.Console.WriteLine();

        int[] numbers;
        numbers = new int[3];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        for(int i=0; i<numbers.Length; i++) System.Console.WriteLine(numbers[i]);

        //
        System.Console.WriteLine();

        int[] xs = {1,2,3};
        for(int i=0; i<xs.Length; i++) System.Console.WriteLine(xs[i]);

        //
        System.Console.WriteLine();

        int[,] ys = {{1,2,3},{4,5,6}};
        for(int i=0; i<ys.GetLength(0); i++)
        {
            for(int j=0; j<ys.GetLength(1); j++)
            {
                System.Console.Write($"{ys[i,j]}\t");
            }
            System.Console.WriteLine();
        }

        //
        System.Console.WriteLine();
        string[] names = {"C#", "Window Forms", "ASP.NET"};
        foreach(string name in names)
        {
            System.Console.WriteLine(name);
        }
    }
}