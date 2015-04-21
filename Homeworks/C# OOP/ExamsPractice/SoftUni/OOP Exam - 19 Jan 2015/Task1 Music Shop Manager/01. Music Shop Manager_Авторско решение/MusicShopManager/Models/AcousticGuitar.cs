namespace MusicShopManager.Models
{
    using System;
    using System.Text;
    using MusicShopManager.Interfaces;
    using MusicShopManager.Models;

    public class AcousticGuitar : Guitar, IAcousticGuitar
    {
        public AcousticGuitar(string make, string model, decimal price, string color, 
            string bodyWood, string fingeboardWood, bool caseIncluded, StringMaterial stringMaterial)
            : base(make, model, price, color, bodyWood, fingeboardWood)
        {
            this.CaseIncluded = caseIncluded;
            this.StringMaterial = stringMaterial;
        }

        public bool CaseIncluded { get; private set; }

        public StringMaterial StringMaterial { get; private set; }

        public override string ToString()
        {
            var acousticGuitar = new StringBuilder();
            acousticGuitar
                .Append(base.ToString())
                .AppendFormat("Case included: {0}", this.CaseIncluded ? "yes" : "no")
                .AppendLine()
                .AppendFormat("String material: {0}", this.StringMaterial.ToString())
                .AppendLine();
            return acousticGuitar.ToString();
        }
    }
}
