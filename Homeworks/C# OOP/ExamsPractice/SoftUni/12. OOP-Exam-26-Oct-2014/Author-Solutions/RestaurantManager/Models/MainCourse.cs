namespace RestaurantManager.Models
{
    using System.Text;
    using RestaurantManager.Interfaces;

    public class MainCourse : Meal, IMainCourse
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing, 
            int timeToPrepare, bool isVegan, MainCourseType type)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.Type = type;
        }

        public MainCourseType Type { get; private set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString())
                .AppendFormat("Type: {0}", this.Type.ToString());
            return result.ToString();
        }
    }
}
