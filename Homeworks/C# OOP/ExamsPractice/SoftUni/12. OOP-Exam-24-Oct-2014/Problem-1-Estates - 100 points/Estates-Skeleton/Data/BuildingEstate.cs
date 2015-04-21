namespace Estates.Data
{
    using System;
    using Estates.Interfaces;
    using System.Text;

    public abstract class BuildingEstate : Estate, IBuildingEstate, IEstate
    {
        private int rooms;
        private bool hasElevator;

        public BuildingEstate(EstateType type)
            : base(type)
        {

        }

        public int Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                this.rooms = value;
            }
        }

        public bool HasElevator
        {
            get
            {
                return this.hasElevator;
            }
            set
            {
                this.hasElevator = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendFormat(", Rooms: {0}, Elevator: {1}", this.Rooms.ToString(), this.HasElevator ? "Yes" : "No");

            return result.ToString();
        }
    }
}
