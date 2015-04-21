namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class GSM
    {
        private static readonly GSM IPhone4S = new GSM(
            Manufacturer.APPLE, "IPhone 4S");


        public static GSM IPhone4Plus
        {
            get
            {
                return IPhone4S;
            }
        }

        private Manufacturer manufacturer;
        private string model;
        private Battery battery;
        private Display display;
        private decimal price;
        private string owner;
        private List<Call> calls;

        public GSM(Manufacturer manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            calls = new List<Call>();
        }

        public GSM(Manufacturer manufacturer, string model, Battery battery, Display display)
            : this(manufacturer, model)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public GSM(Manufacturer manufacturer, string model, Battery battery, Display display, string owner, decimal price)
            : this(manufacturer, model, battery, display)
        {
            this.Owner = owner;
            this.Price = price;
        }

        public Manufacturer Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be null or empty");
                }
                this.model = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The owner cannot be null or empty");
                }
                this.owner = value;
            }
        }

        public List<Call> Calls
        {
            get
            {
                List<Call> result = new List<Call>(this.calls);
                return result;
            }
        }

        public void AddCall(Call call)
        {
            this.calls.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.calls.Remove(call);
        }

        public void ClearCallHistory(Call call)
        {
            this.calls.Clear();
        }

        public decimal TotalCallPrice(decimal pricePerMinute)
        {
            decimal allCalls = (decimal)(this.calls.Select(x => x.Duration).Sum());
            return pricePerMinute * (allCalls / 60.0m);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("GSM: {0}, {1}", this.Manufacturer, this.Model));
            result.AppendLine(this.Battery.ToString());
            result.AppendLine(this.Display.ToString());
            result.AppendLine(string.Format("Price: {0}", this.Price));
            result.Append(string.Format("Owner: {0}", this.Owner));
            return result.ToString();
        }
    }
}
