namespace RestaurantManager.Models
{
    using System;
    using System.Text;    
    using RestaurantManager.Interfaces;

    public class Salad : Meal, ISalad
    {
        public Salad(string name, decimal price, int calories, int quantityPerServing, 
            int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantityPerServing, timeToPrepare, true)
        {
            this.ContainsPasta = containsPasta;
        }

        public bool ContainsPasta { get; private set; }

        public override void ToggleVegan()
        {
            throw new InvalidOperationException("A salad must should always be vegan.");
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString())
                .AppendFormat("Contains pasta: {0}", this.ContainsPasta ? "yes" : "no");
            return result.ToString();
        }
    }
}
