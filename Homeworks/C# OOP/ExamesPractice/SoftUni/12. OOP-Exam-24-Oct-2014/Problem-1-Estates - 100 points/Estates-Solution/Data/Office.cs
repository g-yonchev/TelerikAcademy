using Estates.Interfaces;

namespace Estates.Data
{
    class Office : BuildingEstate, IOffice
    {
        public Office()
        {
            this.Type = EstateType.Office;
        }
    }
}
