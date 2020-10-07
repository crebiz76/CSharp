using System;
using System.Linq;

// [0] 주어진 데이터의 순위(등수)를 구하는 로직
class RankAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Initial
        // [2] Input
        int[] scores = {90, 87, 100, 95, 80};
        int[] ranks = Enumerable.Repeat(1, 5).ToArray();
        
        // [3] Process
        var rankings = scores.Select(s => scores.Where(ss => ss > s).Count() + 1).ToArray();
        for(int i = 0; i < scores.Length; i++)
        {
            System.Console.WriteLine($"{scores[i], 3}점: {rankings[i]}등");
        }
        System.Console.WriteLine();

        for(int i = 0; i < scores.Length; i++)
        {
            // ranks[i] = 1;
            for(int j = 0; j < scores.Length; j++)
            {
                if (scores[i] < scores[j]) ranks[i]++;
            }
            System.Console.WriteLine($"{scores[i], 3}점: {ranks[i]}등");
        }
        // [4] Output
    }
}