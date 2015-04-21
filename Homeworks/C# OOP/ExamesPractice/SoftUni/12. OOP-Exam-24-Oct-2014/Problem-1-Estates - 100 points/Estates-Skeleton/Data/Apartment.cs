namespace Estates.Data
{
    using System;
    using Estates.Interfaces;

    public class Apartment : BuildingEstate, IApartment, IBuildingEstate, IEstate
    {
        public Apartment(EstateType type)
            : base(type)
        {

        }
    }
}
