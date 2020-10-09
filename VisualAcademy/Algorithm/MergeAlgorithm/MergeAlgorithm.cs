using System;
using System.Linq;

// 병합 알고리즘(Merge Algorithm)
// : 오름차순으로 정렬되어 있는 정수 배열을 하나로 병합
// [0] 2개의 정수 배열을 합치기
// : 단, 2개의 배열은 오름차순으로 정렬되어 있다고 가정

class MergeAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Input
        int[] first = {1, 3, 5};
        int[] second = {2, 4};

        int M = first.Length;
        int N = second.Length;

        int[] merge = new int[M+N];
        int i = 0;
        int j = 0;
        int k = 0;

        // [2] Process
        // Case 1
        int[] out1 = (from one in first select one)
                    .Union(from one in second select one)
                    .OrderBy(m => m).ToArray();
        foreach(var o in out1)
        {
            System.Console.Write($"{o}\t");
        }
        System.Console.WriteLine();
        
        // Case 2
        int[] out2 = first.Union(second).OrderBy(m => m).ToArray();
        foreach(var o in out2)
        {
            System.Console.Write($"{o}\t");
        }
        System.Console.WriteLine();

        // Case 3
        merge = first.Union(second).ToArray();
        for(i = 0; i < merge.Length - 1; i++)
        {
            for(j = i + 1; j < merge.Length; j++)
            {   
                // Ascending, Descending
                if(merge[i] > merge[j]) 
                {
                    int temp = merge[i];
                    merge[i] = merge[j];
                    merge[j] = temp;
                }
            }
        }

        foreach(var m in merge)
        {
            System.Console.Write($"{m}\t");
        }
        System.Console.WriteLine();

        // Case 4
        i = 0;
        j = 0;
        k = 0;
        while(i < M && j < N)
        {
            if(first[i] <= second[j])
            {
                merge[k++] = first[i++];
            }
            else
            {
                merge[k++] = second[j++];
            }
        }
        while(i < M)
        {
            merge[k++] = first[i++];
        }
        while(j < N)
        {
            merge[k++] = second[j++];
        }

        // [3] Output
        for(k = 0; k < merge.Length; k++)
        {
            System.Console.Write($"{merge[k]}\t");
        }
    }
}
