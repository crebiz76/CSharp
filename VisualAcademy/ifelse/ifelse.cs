class Ifelse
{
    static void Main(string[] args)
    {
#if Debug
        // if
        int score = 60;
        if (score >= 60)
        {
            System.Console.WriteLine("합격!");
        }
        
        // if..else
        int score =59;
        if (score >= 60)
        {
            System.Console.WriteLine("합격!");
        }
        else
        {
            System.Console.WriteLine("불합격!");
        }
#else

        // elseif
        int score = 59;
        if(score >= 90)
        {
            System.Console.WriteLine("A");
        }
        else if(score >= 80)
        {
            System.Console.WriteLine("B");
        }
        else if(score >= 70)
        {
            System.Console.WriteLine("C");
        }
        else
        {
            System.Console.WriteLine("F");
        }
#endif
    }
}
