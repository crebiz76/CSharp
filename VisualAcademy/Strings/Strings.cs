using System;

class Strings
{
    static void Main(string[] args)
    {
        // Upper, Lower, Replace
        string msg = "Hello, world";
        System.Console.WriteLine(msg.ToUpper());
        System.Console.WriteLine(msg.ToLower());

        System.Console.WriteLine(msg
                                    .Replace("Hello", "안녕하세요")
                                    .Replace("world", "세상"));

        // Class vs. Keyword
        String s1 = "안녕하세요";  // String class
        string s2 = "반갑습니다";  // string keyword
        System.Console.WriteLine($"{s1}, {s2}");

        // 문자연결
        string s3 = "안녕" + "하세요";
        string s4 = String.Concat("반갑", "습니다");
        System.Console.WriteLine($"{s3}, {s4}");

        // 문자열의 길이
        string s5 = "Hello.";
        string s6 = "안녕하세요.";
        System.Console.WriteLine($"{s5.Length}, {s6.Length}");

        // 문자열을 문자의 배열로 변환
        string str = "안녕하세요.";
        char[] ch = str.ToCharArray();
        for(int i = 0; i < ch.Length; i++)
        {
            System.Console.WriteLine(ch[i]);
        }

        // 문자열을 묶는 3가지 표현법
        var displayName = "";
        var firstName = "길동";
        var lastName = "홍";

        displayName = "1. " + lastName + firstName;
        System.Console.WriteLine( displayName);

        displayName = string.Format("2. {0}{1}", lastName, firstName);
        System.Console.WriteLine(displayName);

        displayName = $"3. {lastName}{firstName}";
        System.Console.WriteLine(displayName);

        // 문자열 비교하는 2가지 방법 
        string userName = "RedPlus";
        string userNameInput = "redplus";
        
        //1. 연산자 사용
        if(userName.ToLower() == userNameInput)
        {
            System.Console.WriteLine("같습니다.");
        }
        //2. String.Equals method 사용
        if(string.Equals(userName, userNameInput, StringComparison.InvariantCultureIgnoreCase))
        {
            System.Console.WriteLine("같습니다.");
        }

        // 문자열 값 비교: 대소문자 비교
        string str1 = "Home";
        string str2 = "home";
        if(str1 == str2) System.Console.WriteLine("같다.");
        else System.Console.WriteLine("다르다.");

        if(str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
        {
            System.Console.WriteLine("같다.");
        }
    }
}