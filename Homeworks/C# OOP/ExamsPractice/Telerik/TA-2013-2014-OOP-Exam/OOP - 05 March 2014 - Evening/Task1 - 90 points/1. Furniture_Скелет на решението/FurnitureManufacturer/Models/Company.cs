namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private const int MinimumSymbolInName = 5;
        private const int CountOfSymbolsInRegNumber = 10;

        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.Furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the company cannot be null or empty");
                }

                if (value.Length < MinimumSymbolInName)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The name of the company has to be at least with {0} symbols", MinimumSymbolInName));
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                if (value.Length != CountOfSymbolsInRegNumber)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Count of symbols in regristration number must be exact {0} symbols", CountOfSymbolsInRegNumber));
                }

                if (!value.All(x => char.IsDigit(x)))
                {
                    throw new ArgumentException("Registration number must contains only digits");
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return new List<IFurniture>(this.furnitures); }
            private set { this.furnitures = value; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);

            var sortedFurnitures = this.Furnitures
                .OrderBy(x => x.Price)
                .ThenBy(x => x.Model)
                .ToList();

            this.furnitures = sortedFurnitures;
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            IFurniture result = this.Furnitures.FirstOrDefault(f => f.Model == model);
            
            return result;
        }

        public string Catalog()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            if (this.Furnitures.Count > 0)
            {
                result.AppendLine();

                int counter = 1;

                foreach (IFurniture furniture in this.Furnitures)
                {
                    if (counter != this.Furnitures.Count)
                    {
                        result.AppendLine(furniture.ToString());
                    }
                    else
                    {
                        result.Append(furniture.ToString());
                    }
                    counter++;
                }
            }
            return result.ToString();
        }
    }
}
