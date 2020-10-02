using System;

class AssignmentOperator
{
    static void Main(string[] args)
    {

#if ex1
        // 할당, 대입 연산자 
        var name = "C#";
        var version = "8.0";
        System.Console.WriteLine(name + " " + version);
        
        // Swap
        var i = 100;
        var j = 200;
        System.Console.WriteLine($"처음: {i}, {j}");
        var temp = i;
        i = j;
        j = temp;
        System.Console.WriteLine($"변경: {i}, {j}");

        // Increment number
        int num = 10;
        num = num + 1;
        System.Console.WriteLine(num);

        // Decrement number
        int num = 10;
        num = num - 1;
        System.Console.WriteLine(num);


        // Shortcut Operator
        int x = 3;
        int y = 3;
        x = x + 2;  // Basic
        y += 2;     // Abbr.
        System.Console.WriteLine($"x={x}, y={y}");

        // Shortcut Operator Demo
        int a = 3;
        int b = 5;
        b += a;
        System.Console.WriteLine($"a={a}, b={b}");
        b -= a;
        System.Console.WriteLine($"a={a}, b={b}");

        // Increment Operator
        int num = 100;
        num = num + 1;
        num += 1;
        num++;
        System.Console.WriteLine($"num={num}");

        // Dncrement Operator
        int num = -100;
        num = num - 1;
        num -= 1;
        num--;
        System.Console.WriteLine($"num={num}");

        // Prefix Operator
        int i = 3;
        int j = ++i;
        System.Console.WriteLine($"i={i}, j={j}");

        // Postfix Operator
        int x = 3;
        int y = x++;
        System.Console.WriteLine($"x={x}, y={y}");

#else
        // Increment-Decrement Practice
        int number1 = 3;
        int number2 = 5;

        int result1 = 0;
        int result2 = 0;

        number1--;
        result1 = ++number1;

        ++number2;
        result2 = number2--;

        System.Console.WriteLine($"result1 is {result1}");
        System.Console.WriteLine($"result2 is {result2}");
#endif 
    }
}