namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Text;

    public class Toothpaste : Product, IToothpaste, IProduct
    {
        private IList<string> ingredientsList;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredientsList = ingredients;
        }

        public string Ingredients
        {
            get
            {
                string ingredients = string.Join(", ", this.ingredientsList);

                return ingredients;
            }
        }

        public override string Print()
        {
            var result = new StringBuilder();

            result.AppendLine(base.Print());
            result.AppendLine(string.Format("  * Ingredients: {0}", this.Ingredients));

            return result.ToString().Trim();
        }
    }
}
