namespace SortingAlgorithms.Tests.Searchers
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class ShuffleTests
	{
		[TestMethod]
		public void Shuffle()
		{
			var collection = new SortableCollection<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

			collection.Shuffle();
			bool shuffled = false;

			for (int i = 0; i < collection.Items.Count - 1; i++)
			{
				if (collection.Items[i] > collection.Items[i + 1])
				{
					shuffled = true;
					break;
				}
			}

			Assert.IsTrue(shuffled);
		}
	}
}
