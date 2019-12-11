using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string person;
			if (args.Length > 0)	
				person = args[0];
			else
				person = "AnyBody";
			Console.WriteLine("Hello World!");
			Console.WriteLine("Hello, {0}", person);
			Console.ReadKey();
		}
	}
}
