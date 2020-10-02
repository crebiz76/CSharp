using System;

class   Operator
{
    static void Main(string[] args)
    {
#if debug
        // Expression
        var num = 1000;
        var number = num + 1234;
        System.Console.WriteLine($"{num}, {number}");

        // Unary Operator
        var value = 8;
        value = -value;
        System.Console.WriteLine(value);

        //
        var number1 = 3.14;
        System.Console.WriteLine(number1);
        var number2 = System.Convert.ToInt32(number1);
        System.Console.WriteLine(number2);

#else
        double a = 60;
        double b = 23;
        double c = a / b;
        double quotient = System.Math.Truncate(c); // 몫
        double remainder = a % b;  // 나머지
        System.Console.WriteLine($"{c.ToString()}, 몫: {quotient.ToString()}, 나머지: {remainder.ToString()}");
#endif
    }
}