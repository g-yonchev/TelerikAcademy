namespace SortingAlgorithms
{
	using System;
	using System.Collections.Generic;

	public class Helper
	{
		private static readonly Random random = new Random();
		private static readonly int[] array = GenerateArray();

		public static void Swap<T>(IList<T> arr, int i, int j)
			where T : IComparable<T>
		{
			var temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}

		public static SortableCollection<int> GetCollection()
		{
			return new SortableCollection<int>(array);
		}

		private static int[] GenerateArray(int count = 20, int min = -1000, int max = 1000)
		{
			var arr = new int[count];

			for (int i = 0; i < count; i++)
			{
				int number = random.Next(min, max + 1);
				arr[i] = number;
			}

			return arr;
		}
	}
}