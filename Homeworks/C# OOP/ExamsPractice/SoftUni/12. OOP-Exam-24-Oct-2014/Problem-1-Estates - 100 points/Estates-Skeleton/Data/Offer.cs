namespace Estates.Data
{
    using System;
    using Estates.Interfaces;
    using System.Text;

    public class Offer : IOffer
    {
        private OfferType type;
        private IEstate estate;

        public Offer(OfferType type)
        {
            this.Type = type;
        }

        public OfferType Type
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

        public IEstate Estate
        {
            get
            {
                return this.estate;
            }
            set
            {
                this.estate = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0}: Estate = {1}, Location = {2}", this.Type, this.Estate.Name, this.Estate.Location);
            return result.ToString();
        }
    }
}
