using System;

class Number
{
    static void Main()
    {
        int number = 1_000_000;

        Console.WriteLine("<--Number-->");
        Console.WriteLine(number);

        int min = Int32.MinValue;
        int max = Int32.MaxValue;

        Console.WriteLine("[int] Max: {0}, Min: {1}", min, max);

        sbyte sb = 127;
        short st = 32767;
        int i = Int32.MaxValue;
        long l = Int64.MaxValue;

        Console.WriteLine("{0}, {1}, {2}, {3}", sb, st, i, l);
        
        Console.WriteLine(byte.MaxValue);
        Console.WriteLine(ushort.MaxValue);
        Console.WriteLine(uint.MaxValue);
        Console.WriteLine(ulong.MaxValue);

        double PI = 3.141593;
        double pi_D = 3.14D;
        double pi_d = 3.14d;
        
        Console.WriteLine("{0}, {1}, {2}", PI, pi_D, pi_d);
        Console.WriteLine("[double] {0}, {1}", double.MaxValue, double.MinValue);

        float f = 3.14F;
        
        Console.WriteLine("[float] {0}, {1}, {2}", float.MaxValue, float.MinValue, f);

        int? x = null;
        int y = 0;
        Console.WriteLine("x, y = {0}, {1}", x, y);
    }
}