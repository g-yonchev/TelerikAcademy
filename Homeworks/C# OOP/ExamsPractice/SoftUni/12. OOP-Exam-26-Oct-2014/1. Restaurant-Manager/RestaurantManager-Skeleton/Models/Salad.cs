namespace RestaurantManager.Models
{
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Salad : Meal, ISalad, IMeal, IRecipe
    {
        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsVegan = true;
            this.ContainsPasta = containsPasta;
        }
        public bool ContainsPasta { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.Append(string.Format("Contains pasta: {0}", this.ContainsPasta ? "yes" : "no"));

            return result.ToString();
        }
    }
}
