namespace TradeCompany
{
	using System;

	public class Article : IComparable<Article>
	{
		private string chashedToStrig;

		public Article(string title, string barcode, string vendor, decimal price)
		{
			this.Title = title;
			this.Barcode = barcode;
			this.Vendor = vendor;
			this.Price = price;
		}

		public string Title { get; set; }

		public string Barcode { get; set; }

		public string Vendor { get; set; }

		public decimal Price { get; set; }

		public override string ToString()
		{
			if (this.chashedToStrig == null)
			{
				this.chashedToStrig = $"{this.Title} ={this.Barcode}= : {this.Price.ToString("F2")} by {this.Vendor}";
			}

			return this.chashedToStrig;
		}

		public int CompareTo(Article other)
		{
			return this.ToString().CompareTo(other.ToString());
		}
	}
}
