namespace MusicShop.Models
{
    using System;
    using System.Text;

    using MusicShopManager.Interfaces;

    class ElectricGuitar : Guitar, IElectricGuitar, IGuitar, IInstrument, IArticle
    {
        private int numberOfAdapters;
        private int numberOfFrets;

        public ElectricGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, int numberOfAdapters, int numberOfFrets)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.NumberOfAdapters = numberOfAdapters;
            this.NumberOfFrets = numberOfFrets;
            this.IsElectronic = true;
        }

        public int NumberOfAdapters
        {
            get
            {
                return this.numberOfAdapters;
            }
            set
            {
                string parametar = "number of adapters on the electric guitar";
                ValidateData.ValidateNonNegativeRule(value, parametar);

                this.numberOfAdapters = value;
            }
        }

        public int NumberOfFrets
        {
            get
            {
                return this.numberOfFrets;
            }
            set
            {
                string parametar = "number of frets on the electric guitar";
                ValidateData.ValidatePositiveRule(value, parametar);

                this.numberOfFrets = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());

            result.AppendLine(string.Format("Adapters: {0}", this.NumberOfAdapters));
            result.AppendLine(string.Format("Frets: {0}", this.NumberOfFrets));

            return result.ToString();
        }
    }
}
