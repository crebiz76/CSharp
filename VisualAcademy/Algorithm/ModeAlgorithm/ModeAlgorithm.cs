using System;
using System.Linq;

// 최빈값 알고리즘(Mode Algorithm)
// : 점수 인텍스(0~n)의 갯수(Count)의 최대값(Max)
// [0] 주어진 데이터에서 가장 많이 나타난(중복된) 값
class ModeAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Input
        int[] scores = {1, 3, 4, 3, 5};
        int[] indexes = new int[5 + 1];
        int max = int.MinValue;
        int mode = 0;
        // [2] Process
        // Case 1
        var q = scores.GroupBy(v => v).OrderByDescending(g => g.Count()).First();
        int modeCount = q.Count();
        int frequency = q.Key;
        System.Console.WriteLine($"최빈값(식): {frequency}는 {modeCount}번 나타남");

        // Case 2
        foreach(var s in scores) System.Console.Write($"{s}\t");
        System.Console.WriteLine();

        int[] index = new int[scores.Length+1];
        foreach(var i in index) System.Console.Write($"{i}\t");
        System.Console.WriteLine();

        for(int i = 0; i < scores.Length; i++)
        {
            index[scores[i]]++;
            System.Console.Write($"{index[i]}\t");
        }
        System.Console.WriteLine();

        for(int i = 0; i < index.Length; i++)
        {
            if(index[i] > max)
            {
                max = index[i];
                mode = i;
            }
        }
        // [3] Output
        System.Console.WriteLine($"최빈값(문): {mode}는 {max}번 나타남");

    }
}