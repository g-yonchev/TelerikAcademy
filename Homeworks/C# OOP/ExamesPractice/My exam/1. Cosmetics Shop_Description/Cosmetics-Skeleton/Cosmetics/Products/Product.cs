namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        protected const string TextFormatWhenStringIsNull = "{0} of the product cannot be null or empty";

        private const int MinimumNameLenght = 3;
        private const int MaximumNameLenght = 10;
        private const int MinimumBrandLenght = 2;
        private const int MaximumBrandLenght = 10;

        private string name;
        private string brand;
        private decimal price;

        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(TextFormatWhenStringIsNull, "Name"));

                Validator.CheckIfStringLengthIsValid(
                    value, MaximumNameLenght, MinimumNameLenght,
                    string.Format("Product name must be between {0} and {1} symbols long!", MinimumNameLenght, MaximumNameLenght));

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(TextFormatWhenStringIsNull, "Brand"));

                Validator.CheckIfStringLengthIsValid(
                    value, MaximumBrandLenght, MinimumBrandLenght,
                    string.Format("Product brand must be between {0} and {1} symbols long!", MinimumBrandLenght, MaximumBrandLenght));

                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                Validator.CheckIfNull(value, string.Format(TextFormatWhenStringIsNull, "Price"));

                this.price = value;
            }

        }

        public GenderType Gender { get; private set; }

        public virtual string Print()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.AppendLine(string.Format("  * For gender: {0}", this.Gender));

            return result.ToString().Trim();
        }
    }
}
