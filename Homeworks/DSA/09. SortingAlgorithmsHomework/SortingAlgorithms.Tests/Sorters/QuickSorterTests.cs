namespace SortingAlgorithms.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using SortingAlgorithms.Sorters;

	[TestClass]
	public class QuickSorterTests
	{
		[TestMethod]
		public void QuickSorter()
		{
			var collection = new SortableCollection<int>(new[] { 3, 3, 5, 1, 6, 4, 7, 10, 22, 0, 20, -5 });
			collection.Sort(new QuickSorter<int>());

			for (int i = 0; i < collection.Items.Count - 1; i++)
			{
				Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
			}
		}

		[TestMethod]
		public void QuickSorterTestReversed()
		{
			var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
			collection.Sort(new QuickSorter<int>());

			for (int i = 0; i < collection.Items.Count - 1; i++)
			{
				Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
			}
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void QuickSorterShouldThrowIfCollectionIsNull()
		{
			var collection = GetNull();
			collection.Sort(new QuickSorter<int>());
		}

		private SortableCollection<int> GetNull()
		{
			return null;
		}
	}
}
