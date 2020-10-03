using System;
using System.Collections;

struct Point 
{
    public int x;
    public int y;
}

enum Animal
{
    Pig,
    Dog,
    Sheep,
    Cow,
    Horse
}

class Square
{
    public int Width;
    public int Height;
}

class Square1
{
    public int Width;
    public int Height;
    public string Name;
}

class Classes
{
    static void Main(string[] args)
    {
        // struct
        Point point;
        point.x = 100;
        point.y = 200;
        System.Console.WriteLine($"X:{point.x}, Y:{point.y}");

        // enum
        System.Console.WriteLine($"Name:{nameof(Animal.Pig)}, Value:{(int)Animal.Dog}");

        // class
        Square sq = new Square();
        sq.Width = 100;
        sq.Height = 200;
        System.Console.WriteLine($"Width:{sq.Width}, Height:{sq.Height}");

        // Class
        Square1 sq1 = new Square1();
        sq1.Width = 10;
        sq1.Height = 20;
        sq1.Name = "ToBeNew"; 
        System.Console.WriteLine($"Width:{sq1.Width}, Height:{sq1.Height}, Name:{sq1.Name}");

        // Built-in(System.Collections)
        System.Console.WriteLine(Environment.OSVersion);
        System.Console.WriteLine(Environment.UserName);
        System.Console.WriteLine(Environment.MachineName);
        System.Console.WriteLine(Environment.Version);

        // Built-in(Random)
        Random random = new Random();
        System.Console.WriteLine(random.Next());
        System.Console.WriteLine(random.Next(1,6));

        // is
        string s = "Foo";
        System.Console.WriteLine(s is string);

        // as
        object o = "1234";
        string t = o as string;
        System.Console.WriteLine(t);
    }
}