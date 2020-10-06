using System;
using System.Linq;

// [0] 명의 점수 중에서 80점 이상 95점 이하인 점수의 평균
class AverageAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Input
        int[] data = {90, 65, 78, 50, 95};

        // [2] Process
        int sum1 = 0;
        int count1 = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if((data[i] >= 80) && (data[i] <= 95))
            {
                sum1 += data[i];
                count1++;
            }
        }
        double avg1 = sum1/(double)count1;

        // [3] Output
        System.Console.WriteLine($"80점 이상 95점 이하인 점수의 평균: {avg1}");
    }
}
