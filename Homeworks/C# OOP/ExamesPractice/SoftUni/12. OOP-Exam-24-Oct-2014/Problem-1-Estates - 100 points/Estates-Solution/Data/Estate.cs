using System;
using Estates.Interfaces;

namespace Estates.Data
{
    abstract class Estate : IEstate
    {
        private const int MinArea = 0;
        private const int MaxArea = 10000;

        private string name;
        private EstateType type;
        private double area;
        private string location;
        private bool isFurnished;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public EstateType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public double Area
        {
            get { return this.area; }
            set
            {
                if (value < MinArea || value > MaxArea)
                {
                    throw new ArgumentOutOfRangeException(
                        String.Format("Area should be in range [{0}...{1}]",
                        MinArea, MaxArea));
                }
                this.area = value;
            }
        }

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public bool IsFurnished
        {
            get { return this.isFurnished; }
            set { this.isFurnished = value; }
        }

        public override string ToString()
        {
            return String.Format(
                "{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}",
                this.Type, this.Name, this.Area, 
                this.Location, this.isFurnished ? "Yes" : "No");
        }
    }
}
