namespace SortingAlgorithms.Tests.Searchers
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class LinearSearchTests
	{
		[TestMethod]
		public void LinearSearch()
		{
			var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

			bool result = collection.LinearSearch(5);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void LinearSearchLast()
		{
			var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

			bool result = collection.LinearSearch(0);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void LinearSearchFirst()
		{
			var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

			bool result = collection.LinearSearch(9);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void LinearSearchNonExisting()
		{
			var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

			bool result = collection.LinearSearch(-1);

			Assert.IsFalse(result);
		}
	}
}