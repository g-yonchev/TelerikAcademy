namespace Dividers
{
	using System;
	using System.Collections.Generic;

	// http://bgcoder.com/Contests/Practice/Index/132#2

	public class Program
	{
		private static readonly List<int> numbers = new List<int>();

		public static void Main()
		{
			var n = int.Parse(Console.ReadLine());

			var digits = new int[n];

			for (int i = 0; i < n; i++)
			{
				var digit = int.Parse(Console.ReadLine());
				digits[i] = digit;
			}

			Array.Sort(digits);

			PermuteRep(digits, 0, digits.Length);


			var result = -1;
			var minDivider = int.MaxValue;

			foreach (var num in numbers)
			{
				var currDivider = 0;
				for (int i = 2; i < num; i++)
				{
					if (num % i == 0)
					{
						currDivider++;
					}
				}

				if (currDivider < minDivider)
				{
					minDivider = currDivider;
					result = num;
				}
			}

			Console.WriteLine(result);
		}

		private static void PermuteRep(int[] arr, int start, int n)
		{
			var num = int.Parse(string.Join("", arr));
			numbers.Add(num);

			for (int left = n - 2; left >= start; left--)
			{
				for (int right = left + 1; right < n; right++)
					if (arr[left] != arr[right])
					{
						Swap(ref arr[left], ref arr[right]);
						PermuteRep(arr, left + 1, n);
					}
				var firstElement = arr[left];
				for (int i = left; i < n - 1; i++)
					arr[i] = arr[i + 1];
				arr[n - 1] = firstElement;
			}
		}

		private static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
	}
}
