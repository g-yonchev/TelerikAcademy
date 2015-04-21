namespace Estates.Data
{
    using System;
    using Estates.Interfaces;
    using System.Text;

    public class RentOffer : Offer, IRentOffer, IOffer
    {
        private decimal pricePerMonth;

        public RentOffer(OfferType type)
            : base(type)
        {

        }

        public decimal PricePerMonth
        {
            get
            {
                return this.pricePerMonth;
            }
            set
            {
                this.pricePerMonth = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendFormat(", Price = {0}", this.PricePerMonth.ToString());
            return result.ToString();
        }
    }
}
