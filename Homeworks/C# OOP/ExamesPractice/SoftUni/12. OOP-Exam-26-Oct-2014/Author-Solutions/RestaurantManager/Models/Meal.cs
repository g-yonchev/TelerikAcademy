namespace RestaurantManager.Models
{
    using System.Text;    
    using RestaurantManager.Interfaces;

    public abstract class Meal : Recipe, IMeal
    {
        public Meal(string name, decimal price, int calories, int quantityPerServing, 
            int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, MetricUnit.Grams, timeToPrepare)
        {
            this.IsVegan = isVegan;
        }

        public bool IsVegan { get; private set; }

        public virtual void ToggleVegan()
        {
            this.IsVegan = !this.IsVegan;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            if (this.IsVegan)
            {
                result.Append("[VEGAN] ");
            }

            result.Append(base.ToString());
            return result.ToString();
        }
    }
}
