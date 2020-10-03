using System;

struct Point
{
    public int x;
    public int y;

    // private int z;
}

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            // struct
            Point point;
            point.x = 100;
            point.y = 200;

            System.Console.WriteLine($"X:{point.x}, Y:{point.y}");

            // DateTime class
            System.Console.WriteLine($"YYYY:{DateTime.Now.Year}, MM:{DateTime.Now.Month}, DD:{DateTime.Now.Day}");

            // TimeSpan
            TimeSpan tpassed = (DateTime.Now - (new DateTime(2020,1,1)));
            TimeSpan tremain = (new DateTime(2020,12,31) - DateTime.Now); 
            System.Console.WriteLine($"{Convert.ToInt32(tpassed.TotalDays)} days passed");
            System.Console.WriteLine($"{Convert.ToInt32(tremain.TotalDays)} days remained");
            System.Console.WriteLine($"{Convert.ToInt32(tpassed.TotalDays + tremain.TotalDays)} days for year");

            // TimeSpan
            TimeSpan tlived = (DateTime.Now - (new DateTime(1976,10,28)));
            System.Console.WriteLine($"I have lived for {Math.Ceiling(tlived.TotalDays)} days.");

            // Char
            char a = Char.ToUpper('a');
            bool b = Char.IsWhiteSpace(' ');
            System.Console.WriteLine($"{a}, {b}");

            // Guid(Global unique identifier)
            string guid = Guid.NewGuid().ToString();
            System.Console.WriteLine(guid);
        }
    }
}
