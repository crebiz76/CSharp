using System;

namespace Destructors
{
    class Car
    {
        public string Name;
        public Car() => Name = "My Car";
        public void Go() => System.Console.WriteLine($"{Name} is Running...");
        // .NET Framework 기반에서 실행됨.
        // .NET Core에서는 실행 안 됨. 
        ~Car()
        {
            System.Console.WriteLine($"{Name} 소멸자");
        }
    }

    class Vehicle
    {
        private string _name;
        public Vehicle() : this("기본자동차") {}
        public Vehicle(string name)
        {
            _name = name;
            System.Console.WriteLine($"[1] {this._name} 생성, 조립, 시동");
        }
        public void Go() => System.Console.WriteLine($"[2] {this._name} 달리다.");
        // .NET Framework 기반에서 실행됨.
        // .NET Core에서는 실행 안 됨. 
        ~Vehicle()
        {
            System.Console.WriteLine($"[3] {this._name}소멸");
        }
    }

    class Destructor
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Go();
            System.Console.WriteLine();

            Vehicle veh = new Vehicle();
            veh.Go();

            Vehicle veh2 = new Vehicle("캠핑카");
            veh2.Go();
        }
    }
}