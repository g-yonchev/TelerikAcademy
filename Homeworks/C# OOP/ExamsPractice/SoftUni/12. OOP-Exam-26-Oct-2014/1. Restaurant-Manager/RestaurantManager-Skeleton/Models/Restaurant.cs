namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Restaurant : IRestaurant
    {
        private string name;
        private string location;
        private IList<IRecipe> recipes;

        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = new List<IRecipe>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                RequiredValidator(value, this.GetType().GetProperty("Name").Name);

                this.name = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                RequiredValidator(value, this.GetType().GetProperty("Location").Name);

                this.location = value;
            }
        }
        public IList<IRecipe> Recipes
        {
            get
            {
                return new List<IRecipe>(this.recipes);
            }
            private set
            {
                this.recipes = value;
            }
        }

        public void AddRecipe(IRecipe recipe)
        {
            this.recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("***** {0} - {1} *****", this.Name, this.Location));

            if (this.Recipes.Count == 0)
            {
                result.Append("No recipes... yet");
            }
            else
            {
                var drinks = this.Recipes
                    .Where(r => r is Drink)
                    .OrderBy(r => r.Name);

                if (drinks.Count() > 0)
                {
                    result.AppendLine("~~~~~ DRINKS ~~~~~");
                    foreach (var drink in drinks)
                    {
                        result.AppendLine(drink.ToString());
                    }
                }

                var salads = this.Recipes
                    .Where(r => r is Salad)
                    .OrderBy(r => r.Name);

                if (salads.Count() > 0)
                {
                    result.AppendLine("~~~~~ SALADS ~~~~~");
                    foreach (var salad in salads)
                    {
                        result.AppendLine(salad.ToString());
                    }
                }

                var mainCourses = this.Recipes
                    .Where(r => r is MainCourse)
                    .OrderBy(r => r.Name);

                if (mainCourses.Count() > 0)
                {
                    result.AppendLine("~~~~~ MAIN COURSES ~~~~~");
                    foreach (var mainCourse in mainCourses)
                    {
                        result.AppendLine(mainCourse.ToString());
                    }
                }

                var desserts = this.Recipes
                    .Where(r => r is Dessert)
                    .OrderBy(r => r.Name);

                if (desserts.Count() > 0)
                {
                    result.AppendLine("~~~~~ DESSERTS ~~~~~");
                    foreach (var dessert in desserts)
                    {
                        result.AppendLine(dessert.ToString());
                    }
                }
            }

            return result.ToString().Trim();
        }

        private void RequiredValidator(string value, string p)
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
            {
                throw new ArgumentException(string.Format("The {0} is required", p));
            }
        }

        //private string OrderRecipes<T>(string text)
        //{
        //    StringBuilder sortedRecipes = new StringBuilder();

        //    var recipes = this.Recipes
        //            .Where(r => r is T)
        //            .OrderBy(r => r.Name);

        //    if (recipes.Count() > 0)
        //    {
        //        sortedRecipes.AppendLine(text);
        //        foreach (var recipe in recipes)
        //        {
        //            sortedRecipes.Append((recipe as Recipe).ToString());
        //        }
        //    }

        //    return recipes.ToString();
        //}
    }
}
