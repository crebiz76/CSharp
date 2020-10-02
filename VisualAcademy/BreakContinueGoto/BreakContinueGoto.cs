using System;

namespace BreakContinueGoto
{
    class Program
    {
        static void Main(string[] args)
        {   
            // break(for)
            for(int i = 0; i < 100; i++)
            {   
                if(i==5) break;
                System.Console.WriteLine($"{i+1}번 i 반복");
            }

            // break(while)
            int j = 0;
            while(true)
            {
                if(j==5) break;
                System.Console.WriteLine($"{j+1}번 j 반복");
                j++;
            }

            // continue(1~100까지 정수 중 3의 배수를 제외한 수의 합)
            int sum = 0;
            for (int k = 1; k <= 100; k++)
            {
                if(k % 3 == 0) continue;
                else sum += k;                
            }
            System.Console.WriteLine($"1~100까지 정수 중 3의 배수를 제외한 수의 합은 {sum}입니다.");

            // goto
            System.Console.WriteLine("시작");
            START:
                System.Console.Write("1, 2, 3 중 하나 입력: _\b");
                int chapter = Convert.ToInt32(Console.ReadLine());

            if(chapter == 1)
            {
                goto CHAPTER1;                
            }
            else if(chapter == 2)
            {
                goto CHAPTER2;                
            }
            else if(chapter == 3)
            {
                goto CHAPTER3;
            }
            else
            {
                goto END;
            }

            CHAPTER1:
                if(chapter == 1) System.Console.WriteLine($"{chapter}장 입니다.");
            CHAPTER2:
                if(chapter == 2) System.Console.WriteLine($"{chapter}장 입니다.");
            CHAPTER3:
                if(chapter == 3) System.Console.WriteLine($"{chapter}장 입니다.");
            goto START;

            END:
                System.Console.WriteLine("종료");
        }
    }
}
