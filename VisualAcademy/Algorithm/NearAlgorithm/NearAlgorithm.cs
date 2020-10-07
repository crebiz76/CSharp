using System;
using System.Linq;

// 근사값 알고리즘: 차이값의 절대값의 최소값
// [0] 원본 데이터 중에서 대상 데이터와 가장 가까운 값
class NearAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Initialization
        int min = Int32.MaxValue;

        // [2] Input
        int[] numbers = {10, 20, 30, 27, 17};
        int target = 25;

        // [3] Process
        
        // [4] Output
        var minimum = numbers.Min(m => Math.Abs(m - target));
        var closest = numbers.First(n => Math.Abs(n - target) == minimum);
        System.Console.WriteLine($"{target}와(과) 가장 가까운 값(식): {closest} (차이: {minimum})");
        
        int ABS(int num) => (num < 0) ? -num : num;
        var minimum1 = numbers.Min(m => ABS(m - target));
        var closest1 = numbers.First(n => ABS(n - target) == minimum1);
        System.Console.WriteLine($"{target}와(과) 가장 가까운 값(식): {closest1} (차이: {minimum1})");

        int near = default;
        for(int i = 0; i < numbers.Length; i++)
        {
            int abs = Math.Abs(numbers[i] - target);
            if(abs < min)
            {
                min = abs;
                near = numbers[i];
            }
        }
        System.Console.WriteLine($"{target}와(과) 가장 가까운 값(문): {near} (차이: {min})");
    }
}