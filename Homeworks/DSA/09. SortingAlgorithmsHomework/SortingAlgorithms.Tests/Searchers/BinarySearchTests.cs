namespace SortingAlgorithms.Tests.Searchers
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class BinarySearchTests
	{
		[TestMethod]
		public void BinarySearch()
		{
			var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

			bool result = collection.BinarySearch(8);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void BinarySearchLast()
		{
			var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

			bool result = collection.BinarySearch(0);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void BinarySearchFirst()
		{
			var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

			bool result = collection.BinarySearch(9);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void BinarySearchNonExisting()
		{
			var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

			bool result = collection.BinarySearch(-1);

			Assert.IsFalse(result);
		}

	}
}
