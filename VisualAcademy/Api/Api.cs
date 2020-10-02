using System;

class Api
{
    static void Main(string[] args)
    {
        // System.Math Class
        // Static Member
        System.Console.WriteLine("\n<--System.Math class - Static Member");
        System.Console.WriteLine(Math.PI);
        System.Console.WriteLine(Math.Max(3,5));
        System.Console.WriteLine(Math.Abs(-10));

        // System.Random Class
        // Instance Member
        System.Console.WriteLine("\n<--System.Random class - Instance Member");
        Random dice = new Random();
        var dice2 = new Random();
        System.Console.WriteLine($"Dice throw: {dice.Next(1,7)}");
        System.Console.WriteLine($"Dice throw: {dice2.Next(1,7)}");
    }
}