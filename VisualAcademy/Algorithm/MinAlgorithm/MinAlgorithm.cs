using System;
using System.Linq;

// [0] 주어진 데이터 중에서 가장 큰 값
class MinAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Initialize
        int min = int.MaxValue;
        // [2] Input
        // int[] numbers = {-2 -5, -3, -7, -1};
        int[] numbers = {0b0010, 0b0101, 0b0011, 0b0111, 0b0001};
        
        // [3] Process
        for(int i = 0; i < numbers.Length; i++)
        {
            if(min > numbers[i])
            {
                min = numbers[i];
            }
        }
        // [4] Output
        System.Console.WriteLine($"최대값(문): {min}");
        System.Console.WriteLine($"최대값(식): {numbers.Min()}");

        // 짝수 최소값 구하기
        min = Int32.MaxValue;
        for(int i = 0; i < numbers.Length; i++)
        {
            if((min > numbers[i]) && (numbers[i] % 2 ==0))
            {
                min = numbers[i];
            }
        }
        System.Console.WriteLine($"최대값(문): {min}");
        System.Console.WriteLine($"최대값(식): {numbers.Where(n => n % 2 == 0).Min()}");
    }
}