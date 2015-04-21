namespace FurnitureManufacturer.Models
{
    using System;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, ITable, IFurniture
    {
        private decimal length;
        private decimal width;
        private decimal area;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price,height)
        {
            this.Length = length;
            this.Width = width;
            this.Area = this.Length * this.Width;
        }
        public decimal Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Length of the table cannot be less or equal to 0.00 m");
                }
                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width of the table cannot be less or equal to 0.00 m");
                }
                this.width = value;
            }
        }

        public decimal Area { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendFormat(", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area);

            return result.ToString();
        }
    }
}
