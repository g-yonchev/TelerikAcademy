namespace MobilePhone
{
    using System;

    public class Call
    {
        private DateTime dateTime;
        private string dialledNumber;
        private double duration;

        public Call(DateTime dateTime, string dialledNumber, double duration)
        {
            this.Date = dateTime;
            this.DialledNumber = dialledNumber;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                if (this.dateTime.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.dateTime;
            }
            private set
            {
                this.dateTime = value;
            }
        }

        public string DialledNumber
        {
            get
            {
                return this.dialledNumber;
            }
            private set
            {
                this.dialledNumber = value;
            }
        }

        public double Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Dialled number: {0}, Duration: {1} sec, at {2}",
                this.DialledNumber, this.Duration, this.Date.ToString("dd/MM/yy - HH:mm:ss")); 
        }
    }
}
