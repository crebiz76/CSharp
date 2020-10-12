using System;

// 클래스의 의미
// - 현실 세계의 개체를 만들어 내는 설계도
// - 프로그램 세계의 데이터 저장 공간(필드), 기능(메서드)을 하나의 이름으로 관리
// - 메서드 및 데이터의 그룹화 
// - 컨테이너 역할

// 개체 지향 프로그래밍
// - Object Oriented Programming(OOP)
// - 캡슐화, 상속, 다형성 =? 재사용성
class Object
{
    static void Main(string[] args)
    {
        ClassCode classCode1 = new ClassCode();
        classCode1.GetHashCode();
        System.Console.WriteLine(classCode1.GetHashCode()); 

        Car car1 = new Car();
        Car car2 = new Car();
        System.Console.WriteLine(car1.GetHashCode()); 
        System.Console.WriteLine(car2.GetHashCode());

        car1.Go();
        car2.Go();
        Car car3 = new Car();
        car3.Go();
        System.Console.WriteLine(car1);

        // Static memory
        ClassOne.Hi();
        // Instance memory
        // ClassTwo.Hi(); // Can NOT use 
        ClassTwo two = new ClassTwo();
        two.Hi();
    }
}

public class ClassCode{} // empty class
public class Car
{
    public void Go() => System.Console.WriteLine("Run...");
    public override string ToString() => "My car";
}

public class ClassOne
{
    public static void Hi() => System.Console.WriteLine("Hi~");
}

public class ClassTwo
{
    public void Hi() => System.Console.WriteLine("Hi!");
}
