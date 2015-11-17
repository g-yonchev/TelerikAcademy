namespace SortingAlgorithms
{
	using System;

	using SortingAlgorithms.Sorters;

	internal class Startup
	{
		private static SortableCollection<int> collection;

		internal static void Main(string[] args)
		{
			collection = Helper.GetCollection();
			PrintCollectionBeforeSorting(collection);
			PrintCollectionAfterSorting(collection, new SelectionSorter<int>());

			collection = Helper.GetCollection();
			PrintCollectionAfterSorting(collection, new BubbleSorter<int>());

			collection = Helper.GetCollection();
			PrintCollectionAfterSorting(collection, new InsertionSorter<int>());

			collection = Helper.GetCollection();
			PrintCollectionAfterSorting(collection, new QuickSorter<int>());

			collection = Helper.GetCollection();
			PrintCollectionAfterSorting(collection, new MergeSorter<int>());

			Console.WriteLine("Linear search 101:");
			Console.WriteLine(collection.LinearSearch(101));
			Console.WriteLine();

			Console.WriteLine("Binary search 101:");
			Console.WriteLine(collection.BinarySearch(int.MaxValue - 2));
			Console.WriteLine();

			Console.WriteLine("Shuffle:");
			collection.Shuffle();
			collection.PrintAllItemsOnConsole();
			Console.WriteLine();

			Console.WriteLine("Shuffle again:");
			collection.Shuffle();
			collection.PrintAllItemsOnConsole();
		}

		private static void PrintCollectionAfterSorting<T>(SortableCollection<T> collection, ISorter<T> strategy)
			where T : IComparable<T>
		{
			Console.WriteLine($"{strategy.GetType().Name} result:");
			collection.Sort(strategy);
			collection.PrintAllItemsOnConsole();
			Console.WriteLine();
		}

		private static void PrintCollectionBeforeSorting<T>(SortableCollection<T> collection)
			where T : IComparable<T>
		{
			Console.WriteLine("All items before sorting:");
			collection.PrintAllItemsOnConsole();
			Console.WriteLine();
		}
	}
}
