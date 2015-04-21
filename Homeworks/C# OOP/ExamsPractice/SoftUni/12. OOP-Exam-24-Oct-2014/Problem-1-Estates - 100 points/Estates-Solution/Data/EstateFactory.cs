using Estates.Engine;
using Estates.Interfaces;
using System;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new EnhancedEstateEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type)
            {
                case EstateType.Apartment:
                    return new Apartment();
                case EstateType.Office:
                    return new Office();
                case EstateType.House:
                    return new House();
                case EstateType.Garage:
                    return new Garage();
                default:
                    throw new NotImplementedException("Estate type not supported: " + type);
            }
        }

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type)
            {
                case OfferType.Rent:
                    return new RentOffer();
                case OfferType.Sale:
                    return new SaleOffer();
                default:
                    throw new NotImplementedException("Offer type not supported: " + type);
            }
        }
    }
}
