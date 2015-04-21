namespace MobilePhone
{
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        // implement!!
        private static GSM iPhone4S;

        

        private string modelOfGsm;
        private string manufacturerOfGsm;
        private int priceOfGsm;
        private string ownerOfGsm;
        private Battery batteryOfGsm;
        private Display displayOfGsm;

        public GSM(string manufacturer, string model)
        {
            this.manufacturerOfGsm = manufacturer;
            this.modelOfGsm = model;
        }

        public GSM(string manufacturer, string model, int price, string owner)
            : this(manufacturer, model)
        {
            this.priceOfGsm = price;
            this.ownerOfGsm = owner;
        }

        public GSM(string manufacturer, string model, int price, string owner, Battery battery, Display display)
            : this(manufacturer, model, price, owner)
        {
            this.batteryOfGsm = battery;
            this.displayOfGsm = display;
        }

        // implement!!
        public List<Call> CallHistory
        { get; set; }

        public string Manufacturer
        {
            get
            {
                return this.manufacturerOfGsm;
            }
        }
        
        public string Model
        {
            get
            {
                return this.modelOfGsm;
            }
        }

        public int Price
        {
            get
            {
                return this.priceOfGsm;
            }
        }

        public string Owner
        {
            get
            {
                return this.ownerOfGsm;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.batteryOfGsm;
            }
        }

        public Display Display
        {
            get
            {
                return this.displayOfGsm;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Information about the GSM:");
            result.AppendLine("Manufacturer: " + this.manufacturerOfGsm);
            result.AppendLine("Model: " + this.modelOfGsm);
            result.AppendLine("Price: " + this.priceOfGsm.ToString());
            result.AppendLine("Owner: " + this.ownerOfGsm);
            return result.ToString();
        }

        // implement!!
        public int AddCall()
        {
            return 0;
        }

        // implement!!
        public int DeleteCall()
        {
            return 0;
        }

        // implement!!
        public int ClearHistory()
        {
            return 0;
        }

        // implement!!
        public int CalculateCallsPrice()
        {
            return 0;
        }
    }
}
