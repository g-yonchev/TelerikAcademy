namespace TradeCompany
{
	using System;
	using System.IO;

	using Wintellect.PowerCollections;

	public class Startup
	{
		private const string FilePath = @"../../articles.txt";

		private static readonly OrderedMultiDictionary<decimal, Article> articles = new OrderedMultiDictionary<decimal, Article>(true);

		public static void Main()
		{
			using (var reader = new StreamReader(FilePath))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine().Split('|');

					var title = line[0].Trim();
					var barcode = line[1].Trim();
					var vendor = line[2].Trim();
					var price = decimal.Parse(line[3].Trim());

					var article = new Article(title, barcode, vendor, price);
					articles[price].Add(article);
				}
			}

			Console.WriteLine($"Number of articles: {articles.Count}");
			Console.WriteLine("------------------------");
			//PrintArticlesByRange();
			PrintArticlesByRange(10, 20);

			Console.WriteLine();
		}

		private static void PrintArticlesByRange(decimal fromPrice = 5m, decimal toPrice = 200m)
		{
			articles.Range(fromPrice, true, toPrice, true).ForEach(a => Console.WriteLine(a));
		}
	}
}
