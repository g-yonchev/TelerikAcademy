namespace MusicShop.Models
{
    using System;

    using MusicShopManager.Interfaces;

    public class BassGuitar : Guitar, IBassGuitar, IGuitar, IInstrument, IArticle
    {
        public BassGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.NumberOfStrings = 4;
            this.IsElectronic = true;
        }
    }
}
