namespace SortingAlgorithms.Sorters
{
	using System;
	using System.Collections.Generic;

	public class InsertionSorter<T>
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

			for (int i = 1; i < n; i++)
			{
				T valueToInsert = collection[i];
				int pos = i;

				while (pos> 0 && valueToInsert.CompareTo(collection[pos - 1]) < 0)
				{
					collection[pos] = collection[pos - 1];
					pos = pos - 1;
				}
				collection[pos] = valueToInsert;
			}
		}
	}
}