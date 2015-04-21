using Estates.Interfaces;

namespace Estates.Data
{
    class Apartment : BuildingEstate, IApartment
    {
        public Apartment()
        {
            this.Type = EstateType.Apartment;
        }
    }
}
