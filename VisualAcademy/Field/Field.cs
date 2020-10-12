using System;

namespace MyNameSpace
{
    class MyClass
    {
        private static string message = "안녕하세요. ";
        public static void Hi() => System.Console.WriteLine(message);
        public static void Main(string[] args)
        {
            // 1
            int number = 1234;
            System.Console.WriteLine(number);
            System.Console.WriteLine(message);
            Hi();

            // 2
            System.Console.WriteLine();
            Say say = new Say();
            say.Hi();

            // 3
            System.Console.WriteLine();
            Car car = new Car();
            // System.Console.WriteLine(car.color);
            System.Console.WriteLine(car.GetColor());

            // 4
            System.Console.WriteLine();
            Persons my = new Persons();
            my.ShowProfile();
        }
    }

    public class Say
    {
        public string message = "반갑습니다. ";
        public void Hi()
        {
            System.Console.WriteLine(this.message);
            System.Console.WriteLine(message);
        }
    }

    public class Car
    {
        private string color = "Red";
        public string GetColor() => color;
    }

    public class Persons
    {
        private readonly string name = "crebiz76";
        private const int m_age = 45;
        private string _NickName = "ToBeNew";
        private string[] _websites = {".NET", "ASP.NET"};

        public void ShowProfile()
        {
            System.Console.WriteLine($"{name} - {string.Join(",", _websites)}");
            System.Console.WriteLine(_NickName);
        }

        public void Person()
        {
            _NickName = "RedPlus"; 
        }
    }
}