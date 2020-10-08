using System;
using System.Linq;
using System.Collections.Generic;

// 검색 알고리즘(Search Algorithm)
// [0] 이진 검색: 정렬되어 있는 데이터를 이진 검색을 사용하여 반씩 나눠서 검색
class SearchAlgorithm
{
    static void Main(string[] args)
    {
        // [1] Initial
        int[] unorder = {1, 11, 7, 9, 5, 3};
        // 만약 정렬이 안 되어 있다면...
        System.Console.WriteLine("Original input:");
        var order = unorder.OrderBy(u => u);
        foreach(int o in unorder)
        {
            System.Console.Write($"{o}\t");
        }
        System.Console.WriteLine();

        // [2] Input
        System.Console.WriteLine("New ordered input");
        int[] data = order.ToArray();
        foreach(int d in data)
        {
            System.Console.Write($"{d}\t");
        }
        System.Console.WriteLine();

        int n = data.Length;
        int search = 5;     
                
        // [3] Process
        int low = 0;
        int high = n - 1;
        bool flag = false;
        int index = -1;

        while(low <= high)
        {
            int mid = (low + high);
            if(data[mid] == search)
            {
                flag = true;
                index = mid;
                break;
            }

            if(data[mid] > search) high = mid - 1;
            else low = mid + 1;
        }

        // [4] Output
        if(flag) System.Console.WriteLine($"{search}을(를) {index} 위치에서 찾았습니다. ");
        else System.Console.WriteLine($"{search}을(를)찾지 못했습니다. ");

        /* BinarySearch 사용 */
        System.Console.WriteLine("[BinarySearch 사용]");
        int test = 9;
        var result = data.ToList().BinarySearch(test);
        System.Console.WriteLine($"{test}은(는) {result} 위치에 있습니다.");
        
        test = 21;
        result = data.ToList().BinarySearch(test);
        System.Console.WriteLine($"{test}은(는) {result} 위치에 있습니다.");
    }
}