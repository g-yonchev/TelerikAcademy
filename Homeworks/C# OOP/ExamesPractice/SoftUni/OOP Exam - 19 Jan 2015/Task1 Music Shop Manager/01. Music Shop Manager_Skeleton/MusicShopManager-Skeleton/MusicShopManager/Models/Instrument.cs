namespace MusicShop.Models
{
    using System;
    using System.Text;

    using MusicShopManager.Interfaces;

    public abstract class Instrument : Article, IInstrument, IArticle
    {
        private string color;

        public Instrument(string make, string model, decimal price, string color)
            : base(make,model,price)
        {
            this.Color = color;
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                string parametar = "color of the instrument";
                ValidateData.ValidateRequiredRule(value, parametar);
                this.color = value;
            }
        }

        public bool IsElectronic { get;  protected set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());

            result.AppendLine(string.Format("Color: {0}", this.Color));
            result.AppendLine(string.Format("Electronic: {0}", this.IsElectronic ? "yes" : "no"));

            return result.ToString();
        }
    }
}
