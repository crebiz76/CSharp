using System;

namespace FunctionDemo
{
    class Program
    {
        static void Hi()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            Hi();
            Show();
            ShowMessage("Hello Programming");

            int result = SquareFunction(2);
            System.Console.WriteLine(result);

            double summation = GetSumTwoNumber(3.0, 4.5);
            System.Console.WriteLine(summation);

            System.Console.WriteLine(MaxFunction(3,5));
            System.Console.WriteLine(MinFunction(3,5));
        }

        // Show method(function)
        static void Show()
        {
            Console.WriteLine("Hello C#!");
        }

        // Function Parameter
        static void ShowMessage(string msg)
        {
            System.Console.WriteLine(msg);
        }

        // Function Return Value
        static int SquareFunction(int x)
        {
            int r = x * x;
            return r;
        }

        static double GetSumTwoNumber(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        static int MaxFunction(int x, int y)
        {
            return (x > y)? x : y;
        }

        static int MinFunction(int x, int y)
        {
            if (x >= y) return y;
            else return x;
        }
    }
}
