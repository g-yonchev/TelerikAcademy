namespace DoublePasswords
{
	using System;

	// http://bgcoder.com/Contests/Practice/Index/132#0

	public class Program
	{
		public static void Main()
		{
			var password = Console.ReadLine();
			var pow = 0;

			foreach (var ch in password)
			{
				if (ch == '*')
				{
					pow++;
				}
			}

			ulong result = 1;

			for (int i = 0; i < pow; i++)
			{
				result *= 2;
			}
			
			Console.WriteLine(result);
		}
	}
}
