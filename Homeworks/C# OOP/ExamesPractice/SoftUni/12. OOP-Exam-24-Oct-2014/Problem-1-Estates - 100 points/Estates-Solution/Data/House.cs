using System;
using Estates.Interfaces;

namespace Estates.Data
{
    class House : Estate, IHouse
    {
        private int floors;

        private const int MinFloors = 0;
        private const int MaxFloors = 10;

        public House()
        {
            this.Type = EstateType.House;
        }

        public int Floors
        {
            get { return this.floors; }
            set
            {
                if (value < MinFloors || value > MaxFloors)
                {
                    throw new ArgumentOutOfRangeException(
                        String.Format("Floors should be in range [{0}...{1}]",
                        MinFloors, MaxFloors));
                } 
                this.floors = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", Floors: " + this.Floors;
        }
    }
}
