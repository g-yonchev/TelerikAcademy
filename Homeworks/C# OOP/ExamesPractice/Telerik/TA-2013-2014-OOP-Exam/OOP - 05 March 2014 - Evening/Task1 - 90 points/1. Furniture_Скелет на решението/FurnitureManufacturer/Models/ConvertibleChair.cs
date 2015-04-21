namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class ConvertibleChair : Chair, IConvertibleChair, IChair, IFurniture
    {
        private const decimal HeightWhenIsConverted = 0.10M;
        
        private bool isConverted;
        private decimal initialHeight;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.IsConverted = false;
            this.initialHeight = height;
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
            private set { this.isConverted = value; }
        }

        public void Convert()
        {
            if (this.IsConverted)
            {
                this.IsConverted = false;
                this.Height = initialHeight;
            }
            else
            {
                this.IsConverted = true;
                this.Height = HeightWhenIsConverted;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendFormat(", State: {0}", this.IsConverted ? "Converted" : "Normal");
            return result.ToString();
        }
    }
}
