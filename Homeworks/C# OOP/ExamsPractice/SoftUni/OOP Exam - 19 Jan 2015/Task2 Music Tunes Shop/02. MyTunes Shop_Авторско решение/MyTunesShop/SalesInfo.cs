namespace MyTunesShop
{
    using System;

    public class SalesInfo
    {
        public SalesInfo()
        {
            this.Supplies = 0;
            this.QuantitySold = 0;
        }

        public int Supplies { get; private set; }

        public int QuantitySold { get; private set; }

        public void Supply(int quantity)
        {
            this.Supplies += quantity;
        }

        public void Sell(int quantity)
        {
            if (quantity > this.Supplies)
            {
                throw new ArgumentException("There are not enough supplies.");
            }

            this.QuantitySold += quantity;
            this.Supplies -= quantity;
        }
    }
}
