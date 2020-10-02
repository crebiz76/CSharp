using System;

namespace ForStatement
{
    class Program
    {
        static void Main(string[] args)
        {
#if Debug
            // 반복 횟수 구하기 
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i}");
            }

            // * 표시하기
            for (var i = 0; i < 5; i++)
            {
                for(var j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            // 100이하의 정수에서 3의 배수이고 4의 배수인 숫자의 합
            var sum = 0;
            for (var i = 0; i <= 100; i++)
            {
                if((i%3==0) && (i%4==0))
                {
                    sum += i;
                }
            }
            System.Console.WriteLine($"100이하의 정수에서 3의 배수이고 4의 배수인 숫자의 합은 {sum}입니다.");

#else
            char input = ' ';
            var in1 = 0;
            var in2 = 0;
            do
            {
                Console.Write("원하는 구구단을 입력하세요(2~9)? ");
                input = Convert.ToChar(Console.ReadLine());
                // input = Console.ReadLine();
                
            }
            while(!((input >= '2') && (input <= '9')));
            Console.WriteLine($"입력값은 {input}입니다.");

            // in1 = Convert.ToInt16(input) - 48;
            // in1 = Convert.ToInt16(input) - '0';
            in1 = Convert.ToInt16(input - '0');
            for(in2 = 1; in2 < 10; in2++)
            {
                System.Console.WriteLine($"{in1} * {in2} = {in1*in2}");            
            }
#endif            
        }
    }
}
