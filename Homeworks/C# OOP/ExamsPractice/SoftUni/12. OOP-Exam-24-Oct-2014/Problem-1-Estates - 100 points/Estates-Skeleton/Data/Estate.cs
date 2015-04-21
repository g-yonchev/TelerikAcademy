namespace Estates.Data
{
    using System;
    using Estates.Interfaces;
    using System.Text;

    public abstract class Estate : IEstate
    {
        private EstateType type;
        private string name;
        private double area;
        private string location;
        private bool isFurnished;

        public Estate(EstateType type)
        {
            this.Type = type;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public EstateType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public double Area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area = value;
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
                this.location = value;
            }
        }

        public bool IsFurnished
        {
            get
            {
                return this.isFurnished;
            }
            set
            {
                this.isFurnished = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}",
                this.Type, this.Name, this.Area.ToString(), this.Location, this.IsFurnished ? "Yes" : "No");

            return result.ToString();
        }
    }
}
