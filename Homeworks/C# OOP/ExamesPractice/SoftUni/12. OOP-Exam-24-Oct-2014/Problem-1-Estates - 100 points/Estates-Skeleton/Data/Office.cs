namespace Estates.Data
{
    using System;
    using Estates.Interfaces;

    public class Office : BuildingEstate, IOffice, IBuildingEstate, IEstate
    {
        public Office(EstateType type)
            : base(type)
        {

        }
    }
}
