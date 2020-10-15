using System;

public class Car
{
    public string name;
    // public string _name;
    public Car()
    {
        name = "기본 자동차";
        // _name = "기본 자동차";
        System.Console.WriteLine("[0] 자동차 개체를 생성합니다. ");
    }

    public Car(string name)
    {
        this.name = name;
        // _name = name;
        System.Console.WriteLine($"[2] {name}가 달린다.");
        // System.Console.WriteLine($"[2] {_name}가 달린다.");
    }

    public void Go() => System.Console.WriteLine($"[1] {name}가 달리다.");
    // public void Go() => System.Console.WriteLine($"[1] {_name}가 달리다.");
}

class Constructor
{
    static void Main(string[] args)
    {
        // [1]
        Car car = new Car();
        car.Go();
        System.Console.WriteLine();
        (new Car()).Go();
        System.Console.WriteLine();
        // [2]
        Car my = new Car("좋은 자동차");
        new Car("좋은 자동차");d
    }
}
