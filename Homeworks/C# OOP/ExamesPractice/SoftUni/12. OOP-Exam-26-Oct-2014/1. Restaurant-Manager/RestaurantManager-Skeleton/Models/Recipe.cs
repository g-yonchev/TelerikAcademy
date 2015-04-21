namespace RestaurantManager.Models
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;

    public abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;

        public Recipe(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                ValidateName(value, "Name");
                this.name = value;
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
                ValidateValues(value, "Price");
                this.price = value;
            }
        }

        public int Calories
        {
            get
            {
                return this.calories;
            }
            set
            {
                ValidateValues(value, "Calories");
                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get
            {
                return this.quantityPerServing;
            }
            set
            {
                ValidateValues(value, "QuantityPerServing");

                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit { get; protected set; }

        public int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }
            set
            {
                ValidateValues(value, "TimeToPrepare");

                this.timeToPrepare = value;
            }
        }

        private void ValidateName(string value, string p)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(string.Format("The {0} is required", p));
            }
        }

        private void ValidateValues(decimal value, string p)
        {
            if (value <= 0)
            {
                throw new ArgumentException(string.Format("The {0} must be positive", p));
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("==  {0} == ${1:F2}", this.Name, this.Price));
            result.AppendLine(string.Format("Per serving: {0} {1}, {2} kcal",
                this.QuantityPerServing, this.Unit == MetricUnit.Grams ? "g" : "ml", this.Calories));
            result.AppendLine(string.Format("Ready in {0} minutes", this.TimeToPrepare));
            return result.ToString();
        }
    }
}
