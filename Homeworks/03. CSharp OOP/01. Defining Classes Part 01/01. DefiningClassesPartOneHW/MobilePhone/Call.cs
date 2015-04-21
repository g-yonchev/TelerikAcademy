namespace MobilePhone
{
    using System;

    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialedPhoneNumber;
        private int duration;

        // implement!!

        public Call(DateTime date, DateTime time, string dialed, int duration)
        {
            this.date = date;
            this.time = time;
            this.dialedPhoneNumber = dialed;
            this.duration = duration;
        }
    }
}
