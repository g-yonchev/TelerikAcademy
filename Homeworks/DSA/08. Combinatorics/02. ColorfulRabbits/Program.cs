namespace ColorfulRabbits
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Program
	{
		public static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			if (n == 1)
			{
				var r = int.Parse(Console.ReadLine());
				Console.WriteLine(r + 1);
				return;
			}

			var answers = new Dictionary<int, int>();

			for (int i = 0; i < n; i++)
			{
				var answer = int.Parse(Console.ReadLine());
				answer++;
				if (!answers.ContainsKey(answer))
				{
					answers[answer] = 0;
				}

				answers[answer]++;
			}

			var result = 0;
			foreach (var pair in answers)
			{
				if (pair.Value > 0)
				{
					result += (int)(Math.Round((double)pair.Value / pair.Key)) * pair.Key;
				}
			}

			Console.WriteLine(result);
		}
	}
}
