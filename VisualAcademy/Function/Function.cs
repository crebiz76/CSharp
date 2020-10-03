using System;

namespace Function
{
    class Program
    {
        static void ShowMessage(string msg)
        {
            System.Console.WriteLine(msg);
        }

        static void Sum(int first, int second)
        {
            int sum = first + second;
            System.Console.WriteLine($"합계: {sum}");
        }

        static int SumReturn(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        static void Main(string[] args)
        {
            //
            ShowMessage("Hello");
            ShowMessage("world");
            ShowMessage("");

            //
            Sum(3,5);
            int result = SumReturn(3,5);
            System.Console.WriteLine(result);

            // int first = Convert.ToInt32(args[0]);
            // int second = Convert.ToInt32(args[1]);
            // System.Console.WriteLine(first,second);
        }
    }
}
