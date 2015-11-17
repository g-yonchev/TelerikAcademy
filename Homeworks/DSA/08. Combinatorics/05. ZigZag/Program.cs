using System;
using System.Collections.Generic;

namespace ZigZag
{
	// http://bgcoder.com/Contests/Practice/Index/132#4
	public class Program
	{
		static int n;
		static int k;
		static bool[] used;
		static int result;

		// TODO: not yet solved
		static void Main()
		{
			string input = Console.ReadLine();

			var args = input.Split(' ');
			int n = int.Parse(args[0]);
			int k = int.Parse(args[1]);
			int result = Solve(n, k);
			Console.WriteLine(result);
		}

		static int Solve(int testN, int testK)
		{
			n = testN;
			k = testK;

			result = 0;
			used = new bool[n];

			int[] sequence = new int[k];

			PutBigger(sequence, 0, -1);
			return result;
		}

		static void PutBigger(int[] sequence, int index, int current)
		{
			if (index == k)
			{
				result++;
				return;
			}

			if (current == n - 1)
			{
				return;
			}
			for (int i = current + 1; i < n; i++)
			{
				if (!used[i])
				{
					used[i] = true;
					sequence[index] = i;
					PutSmaller(sequence, index + 1, i);
					used[i] = false;
				}
			}
		}

		static void PutSmaller(int[] sequence, int index, int current)
		{
			if (index == k)
			{
				result++;
				return;
			}
			if (current == 0)
			{
				return;
			}
			for (int i = current - 1; i >= 0; i--)
			{
				if (!used[i])
				{
					used[i] = true;
					sequence[index] = i;
					PutBigger(sequence, index + 1, i);
					used[i] = false;
				}
			}
		}
	}
}
