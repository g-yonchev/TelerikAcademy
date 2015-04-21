namespace MusicShop.Models
{
    using System;
    using System.Text;

    using MusicShopManager.Interfaces;

    public class Drums : Instrument, IDrums, IInstrument, IArticle
    {
        private int width;
        private int height;

        public Drums(string make, string model, decimal price, string color, int width, int height)
            : base(make, model, price, color)
        {
            this.Width = width;
            this.Height = height;
            this.IsElectronic = false;
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                string parametar = "width of the drum";
                ValidateData.ValidatePositiveRule(value, parametar);

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
                string parametar = "height of the drum";
                ValidateData.ValidatePositiveRule(value, parametar);

                this.height = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());

            result.AppendLine(string.Format("Size: {0}cm x {1}cm", this.Width, this.Height));

            return result.ToString();
        }
    }
}
