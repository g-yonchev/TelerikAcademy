namespace FurnitureManufacturer.Models
{
    using System;
    using System.Text;

    using FurnitureManufacturer.Engine.Factories;
    using FurnitureManufacturer.Interfaces;
    

    public abstract class Furniture : IFurniture
    {
        private const int MinimumSymbolInModel = 3;

        private string model;
        private string material;
        private decimal price;
        private decimal height;
        private MaterialType materialType;

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
            this.materialType = FurnitureFactory.GetMaterialType(material);
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The model of the furniture cannot be null or empty");
                }

                if (value.Length < MinimumSymbolInModel)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The model of the furniture has to be at least with {0} symbols", MinimumSymbolInModel));
                }

                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.material;
            }
            set
            {
                this.material = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price of the furniture cannot be less or equal to $0.00");
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height of the furniture cannot be less or equal to 0.00 m");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                this.GetType().Name, this.Model, this.materialType, this.Price, this.Height);

            return result.ToString();
        }
    }
}
