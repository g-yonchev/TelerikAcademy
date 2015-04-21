namespace MusicShopManager.Models
{
    using System;
    using System.Text;
    using MusicShopManager.Interfaces;

    public class Drums : Instrument, IDrums
    {
        private int width;
        private int height;

        public Drums(string make, string model, decimal price, string color, int width, int height)
            : base(make, model, price, color)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width of a set of drums must be positive.");
                }

                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height of a set of drums must be positive.");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            var drums = new StringBuilder();
            drums
                .Append(base.ToString())
                .AppendFormat("Size: {0}cm x {1}cm", this.Width, this.Height)
                .AppendLine();
            return drums.ToString();
        }
    }
}
