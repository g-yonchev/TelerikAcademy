using Estates.Interfaces;

namespace Estates.Data
{
    class RentOffer : Offer, IRentOffer
    {
        public RentOffer()
        {
            this.Type = OfferType.Rent;    
        }

        public decimal PricePerMonth
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
