using System;
using System.Collections.Generic;

namespace Null
{
    class Program
    {
        static void Main(string[] args)
        {
            // <-- Null -->
            System.Console.WriteLine("// <-- Null -->");
            int i = 0;
            string s = null;
            s = "안녕하세요.";
            string e = "";
            System.Console.WriteLine($"{i}, {s}, {e}");
            System.Console.WriteLine();

            // <-- Nullable<T> -->
            System.Console.WriteLine("// <-- Nullable<T> -->");
            Nullable<bool> bln = null;
            System.Console.WriteLine($"{bln.HasValue}");
            bln = false;
            System.Console.WriteLine($"{bln.HasValue}");
            System.Console.WriteLine();

            // Non-nullable -> System.Nullable<T>
            System.Console.WriteLine("// Non-nullable -> System.Nullable<T>");
            Nullable<int> xx = null;
            System.Console.Write($"{xx}");
            xx = 100;
            System.Console.Write($": -> {xx}");
            System.Console.WriteLine();

            // Non-nullable -> Nullable 
            System.Console.WriteLine("// Non-nullable -> Nullable");
            int? xxx = null;
            System.Console.Write($"{xxx}");
            xxx = 1_000_000;
            System.Console.Write($": -> {xxx}");
            System.Console.WriteLine();

            // ?? Null Coalescing Operator(Null 병합 연산자)
            System.Console.WriteLine("// ?? Null Coalescing Operator(Null 병합 연산자)");
            string nullValue = null;
            string message = "";
            if(nullValue == null)
            {
                message = "[1] null이면 새로운 값으로 초기화합니다. ";
            }
            System.Console.WriteLine(message);            
            message = nullValue ?? "[2] null이면 새로운 값으로 초기화합니다.";
            System.Console.WriteLine(message);
            nullValue = "[3] Hello";
            message = nullValue ?? "[3] null이면 새로운 값으로 초기화합니다.";
            System.Console.WriteLine(message);

            // Null 가능 형식에 null로 초기화
            System.Console.WriteLine("// Null 가능 형식에 null로 초기화");
            int? value = null;
            int defaultValue = value??(-1);
            System.Console.WriteLine(defaultValue);

            // default keywor
            System.Console.WriteLine("// default keywor");
            int? x = null;
            int y = x ?? 100;
            int yy = x ?? default(int);
            int z = x ?? default(int);
            int zz = x ?? default;  // recommended
            System.Console.WriteLine($"{x}, {y}, {yy}, {z}, {zz}");

            // Null conditional Operator
            System.Console.WriteLine("// Null conditional Operator");
            double ? d = null;
            System.Console.WriteLine($"{d?.ToString()}");
            
            d = 1.0;
            System.Console.WriteLine($"{d?.ToString()}");
            System.Console.WriteLine($"{d?.ToString("#.00")}");

            // Null conditional Operator(string)
            System.Console.WriteLine("// Null conditional Operator(string)");
            int? len;
            string msg = null;
            len = msg?.Length;
            System.Console.WriteLine(len);
            msg = "Hello";
            len = msg?.Length;
            System.Console.WriteLine(len);

            // Null conditional Operator(List)
            System.Console.WriteLine("// Null conditional Operator(List)");
            List<string> list = null;
            int ? numberOfList;
            // 1. 리스트가 Null이면 Null 반환
            System.Console.WriteLine("// 1. 리스트가 Null이면 Null 반환");
            numberOfList = list?.Count;
            System.Console.WriteLine(numberOfList);

            // 2. 리스트가 Null이 아니면 Count 속성값 반환
            list = new List<string>();
            list.Add("안녕하세요.");
            list.Add("반갑습니다.");
            System.Console.WriteLine("// 2. 리스트가 Null이 아니면 Count 속성값 반환");
            numberOfList = list?.Count;
            System.Console.WriteLine(numberOfList);

            // Null Coalescing & Conditional Operator
            System.Console.WriteLine("// Null Coalescing & Conditional Operator");
            int num;
            List<string> ls;

            ls = null;
            num = ls?.Count ?? 0;
            System.Console.WriteLine(num);

            ls = new List<string>();
            ls.Add("또 만나요.");
            num = ls?.Count ?? 0;
            System.Console.WriteLine($"{ls[0]}, {num}");
        }
    }
}
