namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public class AdjustableChair : Chair, IAdjustableChair, IChair, IFurniture
    {
        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {

        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
