namespace Estates.Data
{
    using System;
    using Estates.Interfaces;
    using System.Text;

    public class Garage : Estate, IGarage, IEstate
    {
        private int width;
        private int height;

        public Garage(EstateType type)
            : base(type)
        {

        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendFormat(", Width: {0}, Height: {1}",this.Width, this.Height);
            return result.ToString();
        }
    }
}
