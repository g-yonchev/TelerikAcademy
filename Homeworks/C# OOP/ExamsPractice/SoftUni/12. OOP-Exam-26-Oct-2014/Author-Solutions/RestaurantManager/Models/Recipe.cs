namespace RestaurantManager.Models
{
    using System;
    using System.Text;
    using RestaurantManager.Interfaces;

    public abstract class Recipe : IRecipe
    {
        private const string RequiredParameterMessage = "The {0} is required.";
        private const string PositiveParameterMessage = "The {0} must be positive.";

        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private MetricUnit unit;
        private int timeToPrepare;

        public Recipe(string name, decimal price, int calories, int quantityPerServing, 
            MetricUnit unit, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.Unit = unit;
            this.TimeToPrepare = timeToPrepare;
        }

        #region Properties
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format(RequiredParameterMessage, "name"));
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PositiveParameterMessage, "price"));
                }

                this.price = value;
            }
        }

        public virtual int Calories
        {
            get
            {
                return this.calories;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PositiveParameterMessage, "calories"));
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get
            {
                return this.quantityPerServing;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(PositiveParameterMessage, "quantity per serving");
                }

                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit
        {
            get
            {
                return this.unit;
            }

            private set
            {
                this.unit = value;
            }
        }

        public virtual int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        string.Format(PositiveParameterMessage, "time to prepare"));
                }

                this.timeToPrepare = value;
            }
        }
        #endregion

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("==  {0} == ${1:F2}", this.Name, this.Price).AppendLine()
                .AppendFormat("Per serving: {0} {1}, {2} kcal", this.QuantityPerServing, this.GetUnitString(), this.Calories).AppendLine()
                .AppendFormat("Ready in {0} minutes", this.TimeToPrepare);
            return result.ToString();
        }

        private string GetUnitString() 
        {
            switch (this.Unit)
            {
                case MetricUnit.Grams:
                    return "g";
                case MetricUnit.Milliliters:
                    return "ml";
                default:
                    throw new InvalidOperationException("Invalid type of unit selected.");
            }
        }
    }
}
