namespace MusicShopManager.Models
{
    using System;
    using MusicShopManager.Interfaces;

    public class BassGuitar : Guitar, IBassGuitar
    {
        private const int DefaultBassGuitarNumberOfStrings = 4;

        public BassGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
        }

        public override int NumberOfStrings
        {
            get
            {
                return DefaultBassGuitarNumberOfStrings;
            }
        }

        public override bool IsElectronic
        {
            get
            {
                return true;
            }
        }
    }
}
