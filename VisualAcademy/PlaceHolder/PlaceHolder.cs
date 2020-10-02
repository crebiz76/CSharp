using System;

class PlaceHolder
{
    static void Main()
    {
        Console.WriteLine("{0}", "Hello, C#");
        Console.WriteLine("{0} {0}", "Hello, C#");
        Console.WriteLine("{0} {1}", "Hello", "C#");
        Console.WriteLine("{1} {0}", "Hello", "C#");
    }
}