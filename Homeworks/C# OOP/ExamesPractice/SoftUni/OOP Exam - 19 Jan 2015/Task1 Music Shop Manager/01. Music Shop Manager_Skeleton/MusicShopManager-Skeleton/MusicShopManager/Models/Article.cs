namespace MusicShop.Models
{
    using System;
    
    using MusicShopManager.Interfaces;
    using System.Text;

    public abstract class Article : IArticle
    {
        private string make;
        private string model;
        private decimal price;

        public Article(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                string parametar = "make of the article";
                ValidateData.ValidateRequiredRule(value, parametar);

                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                string parametar = "model of the article";
                ValidateData.ValidateRequiredRule(value, parametar);

                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                string parametar = "price of the article";
                ValidateData.ValidatePositiveRule(value, parametar);

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("= {0} {1} =", this.Make, this.Model));
            result.AppendLine(string.Format("Price: ${0:F2}", this.Price));

            return result.ToString();
        }
    }
}
