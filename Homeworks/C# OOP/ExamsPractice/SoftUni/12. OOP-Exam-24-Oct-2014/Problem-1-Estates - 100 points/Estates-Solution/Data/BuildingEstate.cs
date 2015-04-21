using System;
using Estates.Interfaces;

namespace Estates.Data
{
    abstract class BuildingEstate : Estate, IBuildingEstate
    {
        private const int MinRooms = 0;
        private const int MaxRooms = 20;

        private int rooms;
        private bool hasElevator;

        public int Rooms
        {
            get { return this.rooms; }
            set
            {
                if (value < MinRooms || value > MaxRooms)
                {
                    throw new ArgumentOutOfRangeException(
                        String.Format("Rooms should be in range [{0}...{1}]",
                        MinRooms, MaxRooms));
                }
                this.rooms = value;
            }
        }

        public bool HasElevator
        {
            get { return this.hasElevator; }
            set { this.hasElevator = value; }
        }

        public override string ToString()
        {
            return base.ToString() + 
                String.Format(", Rooms: {0}, Elevator: {1}", 
                this.Rooms, this.hasElevator ? "Yes" : "No");
        }
    }
}
