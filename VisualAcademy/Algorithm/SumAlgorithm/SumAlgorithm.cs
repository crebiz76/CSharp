using System;
using System.Linq;

//[0] n명의 국어 점수 중에서 80점 이상인 점수의 합계
class SumAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Input: n명의 국어 점수
        int[] scores = {100, 75, 50, 37, 90, 95};
        
        // [2] Process
        int total = 0;
        // Case 1
        int sum1 = 0;
        for(int i = 0; i < scores.Length; i++)
        {
            if(scores[i] >= 80) sum1 += scores[i];
            total += scores[i];
        }

        // Case 2
        int sum2 = scores.Where(s => s >= 80).Sum();

        // [3] Output: 화면 출력
        System.Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상의 총점: {sum1}/{total}");
        System.Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상의 총점: {sum2}/{total}");
    }
}