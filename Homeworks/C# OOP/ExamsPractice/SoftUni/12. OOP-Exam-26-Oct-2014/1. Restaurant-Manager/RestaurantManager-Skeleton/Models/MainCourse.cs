namespace RestaurantManager.Models
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;

    public class MainCourse : Meal, IMainCourse, IMeal, IRecipe
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsVegan = isVegan;
            this.Type = (MainCourseType)Enum.Parse(typeof(MainCourseType), type);
        }

        public MainCourseType Type { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(string.Format("Type: {0}", this.Type));
            return result.ToString();
        }
    }
}
