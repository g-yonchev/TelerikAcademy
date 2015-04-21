namespace MobilePhone
{
    using System;

    public class Battery
    {
        private BatteryType type;
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, int hoursIdle, int hoursTalk)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
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
                    throw new ArgumentNullException("Model of the battery cannot be null or empty");
                }

                this.model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery hours idle cannot be negative");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery hours talk cannot be negative");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        { 
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Battery: {0}, {1}h talk, {2}h idle", this.Model, this.HoursTalk, this.HoursIdle);
        }
        
    }
}
