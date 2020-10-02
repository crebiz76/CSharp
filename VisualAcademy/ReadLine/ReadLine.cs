using System;

class ReadLine
{
    static void Main(string[] args)
    {
#if debug
        // Console.WriteLine(Console.ReadLine());
        
        System.Console.Write("이름: ______\b\b\b\b\b\b");
        string name = System.Console.ReadLine();
        System.Console.WriteLine($"{name}님, 안녕하세요.");

        int x = Console.Read();
        System.Console.WriteLine(x);    // ASCII
        System.Console.WriteLine(Convert.ToChar(x));

        long l = long.MaxValue;
        int i = (int)l;
        System.Console.WriteLine($"{l}, {l.GetType()}");
        System.Console.WriteLine($"{i}, {i.GetType()}");

        System.Console.WriteLine("정수: ");
        string num = Console.ReadLine();    //"1234"
        int number = Convert.ToInt32(num);  // 1234
        System.Console.WriteLine(num +"\t"+ number);

        int number = 10; // 0000 1010
        System.Console.WriteLine(Convert.ToString(number, 2));
        System.Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));

        int b1 = 0b0100;
        int b2 = 0b1010;
        int b3 = 0b0000_0100;
        int b4 = 0b0000_____1010;
        int x1 = 0x0a;
        int x2 = 0x0c;

        System.Console.WriteLine($"{b1}, {b2}, {b3}, {b4}");
        System.Console.WriteLine($"{x1}, {x2}");
        
        var c = 'C';
        System.Console.WriteLine($"{c}");
        
        dynamic d = 123;
        System.Console.WriteLine($"{d}");
        d = c;
        System.Console.WriteLine($"{d}");
#else

        int i = default;
        double d = default;
        char c = default;   // '\0\'
        string s = default; // 'null'
        System.Console.WriteLine($"{i}, {d}, {c}, {s}");
#endif
    }    
}