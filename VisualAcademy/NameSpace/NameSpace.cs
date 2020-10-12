using System;

// Goto Foo.cs
// namespace Foo
// {
//     public class Car
//     {
//         public void Go()
//         {
//             System.Console.WriteLine("Foo.Car Run...");
//         }
//     }
// }

// Goto Bar.cs
// namespace Bar
// {
//     public class Car
//     {
//         public void Go()
//         {
//             System.Console.WriteLine("Bar.Car Run...");
//         }
//     }
// }

namespace MyNameSpace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("NameSpace");
            Foo.Car car1 = new Foo.Car();
            car1.Go();

            var car2 = new Bar.Car();
            car2.Go();
        }
    }
}