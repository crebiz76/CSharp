using System;

class Variable
{
    static void Main()
    {
        var Number = 1234;
        int i;
        i = 1234;
        int j = 1234;
        int k = 12341234;

        int num1, num2, num3, num4;
        num1 = 1;
        num2 = 2;
        num3 = 3;
        num4 = 4;

        int a, b, c;
        a = b = c = 10;

        const int MAX = 100;
        // MAX = 200;

        const double PI = 3.141592;
        
        Console.WriteLine(Number);
        Console.WriteLine(3.14F);
        Console.WriteLine('A');
        Console.WriteLine("Hello");
        
        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(k);

        // Console.WriteLine(num1, num2, num3, num4);    
        Console.WriteLine("{0} {1} {2} {3}", num1, num2, num3, num4);

        Console.WriteLine("{0}, {1}, {2}", a, b, c);
        Console.WriteLine("최대값: {0}", MAX); 
        Console.WriteLine("Pi: {0}", PI); 
    }
}
