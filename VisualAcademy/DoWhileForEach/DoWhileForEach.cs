using System;

class DoWhileForEach
{
    static void Main(string[] args)
    {
#if Debug
        // while
        int count = 0;
        while(count < 3)
        {
            System.Console.WriteLine($"count is {count}.");
            count ++;
        }

        // while(1~100까지 합)
        const int N = 100;
        int sum = 0;
        int i = 1;
        while(i <= N)
        {
            sum += i;
            i++;
        }
        System.Console.WriteLine($"1~100까지 합은 {sum}입니다. ");

        // while(1~100까지 짝수의 합)
        i = sum = 0;
        while(i <= N)
        {
            if(i % 2 == 0) sum += i;
            i++;
        }
        System.Console.WriteLine($"1~100까지 짝수의 합은 {sum}입니다. ");

        // do while(1~10까지의 합)
        i = sum = 0;
        do
        {
            sum += i;
            i++;
        }
        while(i <= 10);
        System.Console.WriteLine($"1~10까지 합은 {sum}입니다. ");
        
        // do while(1~100까지 3의 배수이고 4의 배수인 정수의 합)
        i = sum = 0;
        do
        {
            if((i%3==0) && (i%4==0)) sum += i;
            i++;
        }
        while(i <= 100);
        System.Console.WriteLine($"1~100까지 3의 배수이고 4의 배수인 정수의 합은 {sum}입니다. ");

#else
        // foreach(array)
        string[] names = {"C#", "ASP.NET"};
        foreach(string name in names)
        {
            System.Console.WriteLine(name);
        }

        // foreach(string)
        string str = "ABC123";
        foreach(char c in str)
        {
            System.Console.WriteLine(c);
        }
#endif
    }
}