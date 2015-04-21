namespace Estates.Data
{
    using System;
    using Estates.Interfaces;
    using System.Text;

    public class SaleOffer : Offer, ISaleOffer, IOffer
    {
        private decimal price;

        public SaleOffer(OfferType type)
            : base(type)
        {

        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendFormat(", Price = {0}", this.Price.ToString());
            return result.ToString();
        }
    }
}
