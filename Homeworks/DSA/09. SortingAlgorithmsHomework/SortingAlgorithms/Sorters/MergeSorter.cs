namespace SortingAlgorithms.Sorters
{
	using System;
	using System.Collections.Generic;

	public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
	{
		private IList<T> array;
		private IList<T> mergeArray;

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

			this.array = collection;
			this.mergeArray = new T[collection.Count];

			this.MergeSort(0, collection.Count - 1);
		}

		private void MergeSort(int lowerBound, int upperBound)
		{
			if (lowerBound == upperBound)
			{
				return;
			}

			int mid = (lowerBound + upperBound) >> 1;

			this.MergeSort(lowerBound, mid);
			this.MergeSort(mid + 1, upperBound);

			this.Merge(lowerBound, mid + 1, upperBound);
		}

		private void Merge(int low, int mid, int upper)
		{
			int tempLow = low;
			int tempMid = mid - 1;
			int index = 0;

			while (low <= tempMid && mid <= upper)
			{
				if (this.array[low].CompareTo(this.array[mid]) < 0)
				{
					this.mergeArray[index++] = this.array[low++];
				}
				else
				{
					this.mergeArray[index++] = this.array[mid++];
				}
			}

			while (low <= tempMid)
			{
				this.mergeArray[index++] = this.array[low++];
			}

			while (mid <= upper)
			{
				this.mergeArray[index++] = this.array[mid++];
			}

			for (int i = 0; i < upper - tempLow + 1; i++)
			{
				this.array[tempLow + i] = this.mergeArray[i];
			}
		}
	}
}