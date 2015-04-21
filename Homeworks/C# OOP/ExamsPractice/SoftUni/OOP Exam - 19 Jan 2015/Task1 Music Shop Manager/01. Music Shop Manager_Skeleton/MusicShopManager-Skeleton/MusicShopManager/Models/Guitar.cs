namespace MusicShop.Models
{
    using System;
    using System.Text;

    using MusicShopManager.Interfaces;

    public abstract class Guitar : Instrument, IGuitar, IInstrument, IArticle
    {
        private string bodyWood;
        private string fingerboardWood;

        public Guitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
            : base(make,model,price,color)
        {
            this.BodyWood = bodyWood;
            this.FingerboardWood = fingerboardWood;
            this.NumberOfStrings = 6;
        }

        public string BodyWood
        {
            get
            {
                return this.bodyWood;
            }
            set
            {
                string parametar = "body wood of the guitar";
                ValidateData.ValidateRequiredRule(value, parametar);

                this.bodyWood = value;
            }
        }

        public string FingerboardWood
        {
            get
            {
                return this.fingerboardWood;
            }
            set
            {
                string parametar = "fingerboard wood of the guitar";
                ValidateData.ValidateRequiredRule(value, parametar);

                this.fingerboardWood = value;
            }
        }

        public int NumberOfStrings { get; protected set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());

            result.AppendLine(string.Format("Strings: {0}", this.NumberOfStrings));
            result.AppendLine(string.Format("Body wood: {0}", this.BodyWood));
            result.AppendLine(string.Format("Fingerboard wood: {0}", this.FingerboardWood));

            return result.ToString();
        }
    }
}
