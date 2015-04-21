namespace RestaurantManager.Models
{
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Drink : Recipe, IDrink, IRecipe
    {
        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
            this.Unit = MetricUnit.Milliliters;
        }

        public bool IsCarbonated { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendFormat("Carbonated: {0}", this.IsCarbonated ? "yes" : "no");
            return result.ToString();
        }
    }
}
