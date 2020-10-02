using System;

class test
{
    static void Main()
    {
        byte x = 0b1010;
        byte y = 0b1100;

        Console.WriteLine($"  {Convert.ToString(x, 2)} -> {x}");
        Console.WriteLine($"  {Convert.ToString(y, 2)} -> {y}");
        Console.WriteLine($"--------------");
        Console.WriteLine($"  {Convert.ToString(x & y, 2)} -> {x & y}");
    }
}