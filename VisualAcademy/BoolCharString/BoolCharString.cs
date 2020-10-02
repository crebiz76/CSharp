using System;

class BoolCharString
{
    static void Main()
    {   
        Console.WriteLine("\n<-- Char -->");

        char grade = 'A';
        char kor = '가';
        char es = '\n';
        
        Console.WriteLine(grade);
        Console.WriteLine(kor);
        Console.WriteLine(es);

        Console.WriteLine("\n<-- String -->");
        
        string hi = "hello world";
        string name = "도현이";
        string multilines = @"
             안녕하세요. 
             반갑습니다. 
             ";
        Console.WriteLine(hi);
        Console.WriteLine("안녕하세요. {0}입니다.", name);
        Console.WriteLine(multilines);

        Console.WriteLine("\n<-- String Interpolation -->");
        // 문자열 보간법(New)
        int number = 3;
        string result = "홀수";
        Console.WriteLine($"{number}은(는) {result}입니다. ");

        // string.Format(Old)
        string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요. ");
        Console.WriteLine(msg);

        string message = "String Interpolation";
        Console.WriteLine("Message: {0}", message);
        Console.WriteLine("Message: " + message);
        Console.WriteLine(String.Format("Message: {0}", message));
        Console.WriteLine($"Message: {message}");

        string lang = "C#";
        string version = "8.0";
        Console.WriteLine("{0} {1}", lang, version);
        Console.WriteLine($"{lang} {version}");

        Console.WriteLine("\n<-- Boolean -->");
        bool bln = true;
        bool isFalse = false;
        Console.WriteLine($"{bln}, {isFalse}");

        Char c = 'A';   // struct
        String s = "안녕하세요.";   // class
        Console.WriteLine($"{c}, {s}");

        int number1 = 1234;  // int keyword: basic type
        Int32 number2 = 1234;  // System.Int32 class: .NET type
        Console.WriteLine($"{number1}, {number2}");

        string str1 = "안녕!";  // string keyword: basic type
        String str2 = "안녕~";  // System.String class: .NET Type(Wrap Type)
        Console.WriteLine($"{str1}, {str2}");

        Console.WriteLine($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}");
    }
}