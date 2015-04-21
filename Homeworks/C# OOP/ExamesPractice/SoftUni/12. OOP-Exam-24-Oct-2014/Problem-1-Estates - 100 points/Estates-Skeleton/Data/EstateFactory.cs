using Estates.Engine;
using Estates.Interfaces;
using System;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new AdvancedEstateEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type)
            {
                case EstateType.Apartment:
                    return new Apartment(type);
                case EstateType.Office:
                    return new Office(type);
                case EstateType.House:
                    return new House(type);
                case EstateType.Garage:
                    return new Garage(type);
                default:
                    throw new Exception();
            }
        }

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type)
            {
                case OfferType.Sale:
                    return new SaleOffer(type);
                case OfferType.Rent:
                    return new RentOffer(type);
                default:
                    throw new Exception();
            }
        }
    }
}
