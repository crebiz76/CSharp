using System;

enum Animal
{
    None,   // None
    Pig,    // Do
    Dog,    // Gae
    Sheep,  // Girl
    Cow,    // Yut
    Horse   // Mo
}

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 내장형
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"{nameof(ConsoleColor.Red)}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"{nameof(ConsoleColor.Green)}, {nameof(ConsoleColor.Yellow)}");
            Console.ResetColor();

            // 
            Animal animal = Animal.None;
            System.Console.Write("What do you have a Yut? _\b");
            int mal = Convert.ToInt32(Console.ReadLine());
            
            switch(mal)
            {
                case 1:
                    animal = Animal.Pig;
                    System.Console.WriteLine($"{animal}: 도!");
                    break;
                case 2:
                    animal = Animal.Dog;
                    System.Console.WriteLine($"{animal}: 개!");
                    break;
                case 3:
                    animal = Animal.Sheep;
                    System.Console.WriteLine($"{animal}: 걸!");
                    break;
                case 4:
                    animal = Animal.Cow;
                    System.Console.WriteLine($"{animal}: 윷!");
                    break;
                case 5:
                    animal = Animal.Horse;
                    System.Console.WriteLine($"{animal}: 모!");
                    break;
                default:
                    animal = Animal.Horse;
                    System.Console.WriteLine("Select again!");
                    break;
            }
            

            // switch(animal)
            // {
            //     case Animal.Pig:
            //         System.Console.WriteLine("도!");
            //     case Animal.Dog:
            //         System.Console.WriteLine("개!");
            //     case Animal.Sheep:
            //         System.Console.WriteLine("걸!");
            //     case Animal.Cow:
            //         System.Console.WriteLine("윷!");
            //     case Animal.Horse:
            //         System.Console.WriteLine("모!");
            //     default:
            //         System.Console.WriteLine("Select again!");
            //     break;
            // }

            
            // System.Console.WriteLine(Animal.Dog);
            // System.Console.WriteLine(Convert.ToInt32(Animal.Dog));
            // System.Console.WriteLine(animal);
            // System.Console.WriteLine(Convert.ToInt32(animal));


            // System.Console.WriteLine($"Name:{nameof(animal)}, Value:{(int)dog}");
            // System.Console.WriteLine($"Name:{nameof(dog)}, Value:{(int)dog}");
            // System.Console.WriteLine($"Name:{nameof(dog)}, Value:{(int)dog}");
            // System.Console.WriteLine($"Name:{nameof(dog)}, Value:{(int)dog}");
        }
    }
}
