using System;

class SwitchStatement
{   
    static void Main(string[] args)
    {
        System.Console.WriteLine("정수를 입력하세요. ");
        int ans = Convert.ToInt32(Console.ReadLine());
        
        switch (ans)
        {
            case 1:
            case 2:
            case 3:
                System.Console.WriteLine($"You chose a {ans}");
                break;
                
            default:
                System.Console.WriteLine($"You chose a wrong input");
                break;
        }
    }
}
