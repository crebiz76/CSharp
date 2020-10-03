using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
#if Debug
            // try-catch-finally vs. throw
            // try-catch
            try
            {
                int[] arr = new int[2];
                arr[100] = 1234;
            }
            catch
            {
                System.Console.WriteLine("에러가 발생했습니다. ");
            }
    
            // try-catch(Exception)
            try
            {
                int[] arr = new int[2];
                arr[100] = 1234;
            }
            catch(System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            // try-catch(FormatException)
            string inputNumber = "3.14";
            int number = 0;

            try
            {
                number = Convert.ToInt32(inputNumber);
                System.Console.WriteLine($"입력한 값: {number}");
            }
            catch(System.FormatException fe)
            {
                System.Console.WriteLine($"에러 발생: {fe.Message}");
                System.Console.WriteLine($"{inputNumber}은(는) 정수여야 합니다. ");
            }

            // try-catch(ex)
            try
            {
                int now = DateTime.Now.Second;
                System.Console.WriteLine($"[0] 현재 초: {now}");

                int result = 2/(now%2);
                System.Console.WriteLine("[1] 홀수 초에서는 정상처리");
            }
            catch
            {
                System.Console.WriteLine("[2] 짝수 초에서는 런타임 에러 발생");
            }

            // try-catch-finally
            int x = 5;
            int y = 0;  // int y = 1;
            int r;

            try
            {
                r = x / y;
                System.Console.WriteLine($"{x} / {y} = {r}");
            }
            catch(System.Exception ex)
            {
                System.Console.WriteLine($"에러 발생: {ex.Message}");
            }
            finally
            {
                System.Console.WriteLine("프로그램을 종료합니다. ");
            }
            
            // throw
            throw new System.Exception();
            throw new System.ArgumentException();
#else

            // throw(ex)
            System.Console.WriteLine("[1] 시작");

            try
            {
                System.Console.WriteLine("[2] 실행");
                throw new System.Exception("<- 내가 만들 에러");
            }
            catch(System.Exception ex)
            {
                System.Console.WriteLine($"[3] 에러: {ex.Message}");
            }
            finally
            {
                System.Console.WriteLine("[4] 종료");
            }
#endif
        }
    }
}
