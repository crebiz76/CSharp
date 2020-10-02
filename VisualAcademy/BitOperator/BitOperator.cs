using System;

class test
{
    static void Main(string[] args)    
    {
#if Debug
        // Bit Operator
        byte x = 0b1010;
        byte y = 0b1100;

        Console.WriteLine($"   {Convert.ToString(x, 2)} -> {x}");
        Console.WriteLine($"   {Convert.ToString(y, 2)} -> {y}");
        Console.WriteLine($"--------------");
        Console.WriteLine($"[&]{Convert.ToString(x & y, 2)} -> {x & y}");
        Console.WriteLine($"[|]{Convert.ToString(x | y, 2)} -> {x | y}");
        Console.WriteLine($"[^]{Convert.ToString(x ^ y, 2).PadLeft(4,'0')} -> {x ^ y}");
        
        Console.WriteLine();
        Console.WriteLine($"   {Convert.ToString(x, 2).PadLeft(8,'0')} -> {x}");
        Console.WriteLine($"[~]{Convert.ToString((byte)~x, 2).PadLeft(8,'0')} -> {~x}");

        // Shift Operator
        System.Console.WriteLine("<--C# Shift Left Operator-->");
        byte x = 0x02;  //0b0000_0010

        System.Console.WriteLine($"{nameof(x), 10}: {Convert.ToString(x, 2).PadLeft(8,'0')} -> {x,3}");
        System.Console.WriteLine($"x = x << 1: {Convert.ToString(x << 1, 2).PadLeft(8,'0')} -> {x << 1,3}");
        System.Console.WriteLine($"x = x << 2: {Convert.ToString(x << 2, 2).PadLeft(8,'0')} -> {x << 2,3}");
        System.Console.WriteLine($"x = x << 3: {Convert.ToString(x << 3, 2).PadLeft(8,'0')} -> {x << 3,3}");
        System.Console.WriteLine($"x = x << 6: {Convert.ToString(x << 3, 2).PadLeft(8,'0')} -> {x << 6,3}");

        System.Console.WriteLine("<--C# Shift Right Operator-->");
        byte y = 0b001_1000;    
        System.Console.WriteLine($"{nameof(y), 10}: {Convert.ToString(y, 2).PadLeft(8,'0')} -> {y,3}");
        System.Console.WriteLine($"y = y >> 1: {Convert.ToString(y >> 1, 2).PadLeft(8,'0')} -> {y >> 1,3}");
        System.Console.WriteLine($"y = y >> 2: {Convert.ToString(y >> 2, 2).PadLeft(8,'0')} -> {y >> 2,3}");
        System.Console.WriteLine($"y = y >> 3: {Convert.ToString(y >> 3, 2).PadLeft(8,'0')} -> {y >> 3,3}");
        System.Console.WriteLine($"y = y >> 4: {Convert.ToString(y >> 4, 2).PadLeft(8,'0')} -> {y >> 4,3}");
        System.Console.WriteLine($"y = y >> 5: {Convert.ToString(y >> 5, 2).PadLeft(8,'0')} -> {y >> 5,3}");

#else
        // Conditional Operator
        int number = 3;
        string result = (number % 2 == 0)? "짝수": "홀수";
        System.Console.WriteLine($"{number}은(는) {result}입니다. ");
#endif
    }
}