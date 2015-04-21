namespace RestaurantManager.Models
{
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Dessert : Meal, IDessert, IMeal, IRecipe
    {
        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsVegan = isVegan;
            this.WithSugar = true;
        }

        public bool WithSugar { get; private set; }

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (!this.WithSugar)
            {
                result.Append("[NO SUGAR] ");
            }

            result.Append(base.ToString());
            return result.ToString().Trim();
        }
    }
}
