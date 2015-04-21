namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IShampoo, IProduct
    {
        private uint milliliters;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }
            private set
            {
                Validator.CheckIfNull(value, string.Format(Product.TextFormatWhenStringIsNull, "Milliliters"));

                this.milliliters = value;
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price * (decimal)this.Milliliters;
            }
            set
            {
                base.Price = value;
            }
        }


        public UsageType Usage { get; private set; }

        public override string Print()
        {
            var result = new StringBuilder();

            result.AppendLine(base.Print());
            result.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            result.AppendLine(string.Format("  * Usage: {0}", this.Usage));

            return result.ToString().Trim();
        }
    }
}
