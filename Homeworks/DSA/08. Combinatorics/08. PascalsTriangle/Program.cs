namespace PascalsTriangle
{
	using System;
	using System.Text;

	// http://bgcoder.com/Contests/Practice/Index/132#7
	// I think there is a problem with bgcoder and this task. Because it throws compile error, but I'm testing local and everything seems ok.

	public class Program
	{
		static int[] lastPascalTriangleRow;
		static int[] currentPascalTriangleRow;

		public static void Main()
		{
			var expression = Console.ReadLine();
			var power = int.Parse(Console.ReadLine());

			lastPascalTriangleRow = new int[power + 1];
			currentPascalTriangleRow = new int[power + 1];

			if (power == 0)
			{
				Console.WriteLine(1);
				return;
			}

			var firstSymbol = expression[1];
			var secondSymbol = expression[3];
			

			for (int i = 0; i < power; i++)
			{
				bool reachedLastRowEnd = false;
				currentPascalTriangleRow[0] = 1;
				int c = 1;

				while (!reachedLastRowEnd)
				{
					currentPascalTriangleRow[c] = lastPascalTriangleRow[c - 1] + lastPascalTriangleRow[c];
					if (lastPascalTriangleRow[c] == 0)
					{
						reachedLastRowEnd = true;
					}
					c++;
				}

				int lastMeaningColumn = c;

				for (int j = 0; j < lastMeaningColumn; j++)
				{
					lastPascalTriangleRow[j] = currentPascalTriangleRow[j];
				}
			}

			var result = new StringBuilder();
			result.AppendFormat("({0}^{1})", firstSymbol, power);

			int col = 1;
			while (currentPascalTriangleRow[col] != 0)
			{
				if (power - col == 0)
				{
					result.AppendFormat("+({0}^{1})", firstSymbol, col); 
				}
				else
				{
					result.AppendFormat("+{0}({1}^{2})({3}^{4})", currentPascalTriangleRow[col], firstSymbol, power - col, secondSymbol, col);
				}
				col++;
			}

			Console.WriteLine(result.ToString());
		}
	}
}
