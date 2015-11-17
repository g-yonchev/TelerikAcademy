namespace SortingAlgorithms.Sorters
{
	using System;
	using System.Collections.Generic;

	public class BubbleSorter<T>
		: ISorter<T> where T : IComparable<T>
	{
		public void Sort(IList<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection", "Collection cannot be null");
			}

			if (collection.Count <= 1)
			{
				return;
			}

			int n = collection.Count;
			bool swapIsDone = true;

			while (swapIsDone)
			{
				swapIsDone = false;

				for (int i = 1; i < n; i++)
				{
					if (collection[i - 1].CompareTo(collection[i]) > 0)
					{
						Helper.Swap(collection, i, i - 1);
						swapIsDone = true;
					}
				}
			}
		}
	}
}