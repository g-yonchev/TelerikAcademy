namespace MobilePhone
{
    public class Battery
    {
        // fields
        private string modelOfBattery;
        private int hoursOfIdle;
        private int hoursOfTalk;
        private BatteryType typeOfBattery;

        // constructor with battery model
        public Battery(string model)
        {
            this.modelOfBattery = model;
        }

        // constructor with battery model and hours
        public Battery(string model, int idleHours, int talkHours)
            : this(model)
        {
            this.hoursOfIdle = idleHours;
            this.hoursOfTalk = talkHours;
        }

        // constructor with battery model, hours and battery type
        public Battery(string model, int idleHours, int talkHours, BatteryType type)
            : this(model, idleHours, talkHours)
        {
            this.typeOfBattery = type;
        }

        // property .Model
        public string Model
        {
            get
            {
                return this.modelOfBattery;
            }
        }

        // property .HoursOfIdle
        public int HoursOfIdle
        {
            get
            {
                return this.hoursOfIdle;
            }
        }

        // property .HoursOfTalk
        public int HoursOfTalk
        {
            get
            {
                return this.hoursOfTalk;
            }
        }

        // property .Type
        public BatteryType Type
        {
            get
            {
                return this.typeOfBattery;
            }
        }
    }
}
