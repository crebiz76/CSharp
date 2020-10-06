using System;
using System.Linq;

// [0] 1부터 1000까지의 정수 중 13의 배수의 개수
class CountAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Input: 정수(1~1000) 
        
        // [2] Process
        // Case 1
        int count1 = 0;
        for(int i = 1; i <= 1000; i++)
        {
            if(i % 13 == 0) count1++;
        }

        // Case 2
        int count2 = Enumerable.Range(1, 1000).ToArray()
                        .Where(n => n % 13 == 0).Count();

        // Case 3
        int count3 = Enumerable.Range(1, 1_000).ToArray().Count(n => n % 13 ==0);
        
        // [3] Output
        System.Console.WriteLine($"1부터 1000까지의 정수 중 13의 배수의 개수: {count1}");
        System.Console.WriteLine($"1부터 1000까지의 정수 중 13의 배수의 개수: {count2}");
        System.Console.WriteLine($"1부터 1000까지의 정수 중 13의 배수의 개수: {count3}");

    }
}
