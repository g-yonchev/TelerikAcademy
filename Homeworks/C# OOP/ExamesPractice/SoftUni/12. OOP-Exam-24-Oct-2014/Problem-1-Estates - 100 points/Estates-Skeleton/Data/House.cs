using Estates.Interfaces;
namespace Estates.Data
{
    using System;
    using Estates.Interfaces;
    using System.Text;

    public class House : Estate, IHouse, IEstate
    {
        private int floors;

        public House(EstateType type)
            : base(type)
        {

        }

        public int Floors
        {
            get
            {
                return this.floors;
            }
            set
            {
                this.floors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendFormat(", Floors: {0}", this.Floors.ToString());

            return result.ToString();
        }
    }
}
