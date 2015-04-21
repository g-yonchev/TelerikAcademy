namespace RestaurantManager.Models
{
    using System.Text;

    using RestaurantManager.Interfaces;

    public abstract class Meal : Recipe, IMeal, IRecipe
    {
        public Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.Unit = MetricUnit.Grams;
        }

        public bool IsVegan { get; protected set; }

        public void ToggleVegan()
        {
            this.IsVegan = !this.IsVegan;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.IsVegan)
            {
                result.Append("[VEGAN] ");
            }
            result.Append(base.ToString());
            return result.ToString();
        }
    }
}
