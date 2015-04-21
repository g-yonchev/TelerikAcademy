namespace Cosmetics.Products
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Category : ICategory
    {
        private const int MinimumNameLenght = 2;
        private const int MaximumNameLenght = 15;

        private string name;
        private ICollection<IProduct> cosmetics;

        public Category(string name)
        {
            this.Name = name;
            this.cosmetics = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(
                    value, MaximumNameLenght, MinimumNameLenght,
                    string.Format("Category name must be between {0} and {1} symbols long!", MinimumNameLenght, MaximumNameLenght));

                this.name = value;
            }
        }
        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, "Cannot add null or empty cosmetics");

            this.cosmetics.Add(cosmetics);

        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            bool isContains = this.cosmetics.Remove(cosmetics);

            if (!isContains)
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
        }

        public string Print()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("{0} category - {1} {2} in total",
                this.Name,
                this.cosmetics.Count.ToString(),
                this.cosmetics.Count == 1 ? "product" : "products"));

            // I decited to sort here because printing operation is less often than adding operation :)
            var sortedCosmetics = this.cosmetics
                .OrderBy(c => c.Brand)
                .ThenByDescending(c => c.Price);

            foreach (var cosmetics in sortedCosmetics)
            {
                result.AppendLine(cosmetics.Print());
            }

            return result.ToString().Trim();
        }
    }
}
