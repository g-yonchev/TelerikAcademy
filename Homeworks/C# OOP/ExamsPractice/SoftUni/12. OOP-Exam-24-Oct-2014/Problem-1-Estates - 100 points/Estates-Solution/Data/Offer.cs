using System;
using Estates.Interfaces;

namespace Estates.Data
{
    abstract class Offer : IOffer
    {
        private OfferType type;
        private IEstate estate;
        protected decimal price;

        public OfferType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public IEstate Estate
        {
            get { return this.estate; }
            set { this.estate = value; }
        }

        public override string ToString()
        {
            return String.Format(
                "{0}: Estate = {1}, Location = {2}, Price = {3}",
                this.Type, this.Estate.Name, this.Estate.Location, this.price);
        }
    }
}
