namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;
    using MusicShopManager.Models;
    using System.Text;

    public class AcousticGuitar : Guitar, IAcousticGuitar, IGuitar, IInstrument, IArticle
    {
        public AcousticGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial stringMaterial)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.CaseIncluded = caseIncluded;
            this.StringMaterial = stringMaterial;
            this.IsElectronic = false;
        }

        public bool CaseIncluded { get; private set; }

        public StringMaterial StringMaterial { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());

            result.AppendLine(string.Format("Case included: {0}", this.CaseIncluded ? "yes" : "no"));
            result.AppendLine(string.Format("String material: {0}", this.StringMaterial));

            return result.ToString();
        }
    }
}
