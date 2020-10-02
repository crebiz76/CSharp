using System;

class RelationalOperator
{
    static void Main(string[] args)
    {
#if Debug
        // Relational Operator
        int first = 10;
        int second = 5;

        bool r = false;         
        r = (first > second);    // True
        System.Console.WriteLine(r);

        r = (first <= second);  // False
        System.Console.WriteLine(r);

        r = (first == second);  // False
        System.Console.WriteLine(r);

        r = (first != second);  // True
        System.Console.WriteLine(r);

#else
        // Logical Operator
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3) && (j !=3 );
        System.Console.WriteLine(r);
        
        r = (i != 3) || (j ==3 );
        System.Console.WriteLine(r);

        r = (i >= 5);
        System.Console.WriteLine(!r);        

#endif
    }
}