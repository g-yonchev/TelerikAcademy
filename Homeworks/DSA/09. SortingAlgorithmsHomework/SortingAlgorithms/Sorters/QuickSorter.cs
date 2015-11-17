namespace SortingAlgorithms.Sorters
{
	using System;
	using System.Collections.Generic;

	public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
	{
		private IList<T> array;

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
			QuickSort(0, collection.Count - 1);
		}

		private void QuickSort(int lelftValue, int rightValue)
        {
            if (rightValue - lelftValue <= 0)
            {
                return;
            }

            int pivotIndex = Partition(array[rightValue], lelftValue, rightValue);

            QuickSort(lelftValue, pivotIndex - 1);
            QuickSort(pivotIndex + 1, rightValue);
        }

        private int Partition(T pivot, int leftIndex, int rightIndex)
        {
            int currentLeft = leftIndex;
            int currentRight = rightIndex - 1;

            while (true)
            {
                while (this.array[currentLeft].CompareTo(pivot) < 0)
                {
                    currentLeft++;
                }

                while (currentRight > 0 && this.array[currentRight].CompareTo(pivot) > 0)
                {
                    currentRight--;
                }

                if (currentLeft >= currentRight)
                {
                    break;
                }

				this.Swap(currentLeft, currentRight);
            }

			this.Swap(currentLeft, rightIndex);

            return currentLeft;
        }

		private void Swap(int a, int b)
		{
			T swapValue = array[a];
			array[a] = array[b];
			array[b] = swapValue;
		}
	}
}