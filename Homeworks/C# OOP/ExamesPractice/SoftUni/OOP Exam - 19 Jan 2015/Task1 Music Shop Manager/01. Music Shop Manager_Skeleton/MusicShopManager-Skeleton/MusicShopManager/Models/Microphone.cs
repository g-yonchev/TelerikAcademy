namespace MusicShop.Models
{
    using System;
    using System.Text;

    using MusicShopManager.Interfaces;

    public class Microphone : Article, IMicrophone, IArticle
    {
        public Microphone(string make, string model, decimal price, bool hasCable)
            : base(make, model, price)
        {
            this.HasCable = hasCable;
        }

        public bool HasCable { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine(string.Format("Cable: {0}", this.HasCable ? "yes" : "no"));
            return result.ToString();
        }
        
    }
}
