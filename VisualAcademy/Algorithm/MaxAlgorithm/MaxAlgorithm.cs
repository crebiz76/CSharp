using System;
using System.Linq;

// [0] 주어진 데이터 중에서 가장 큰 값
class MaxAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Initialize
        int max = int.MinValue;
        // [2] Input
        int[] numbers = {-2 -5, -3, -7, -1};
        
        // [3] Process
        for(int i = 0; i < numbers.Length; i++)
        {
            if(max < numbers[i])
            {
                max = numbers[i];
            }
        }
        // [4] Output
        System.Console.WriteLine($"최대값(문): {max}");
        System.Console.WriteLine($"최대값(식): {numbers.Max()}");
    }
}