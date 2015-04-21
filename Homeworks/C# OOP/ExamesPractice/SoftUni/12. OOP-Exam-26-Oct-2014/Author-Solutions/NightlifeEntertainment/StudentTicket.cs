namespace NightlifeEntertainment
{
    public class StudentTicket : Ticket
    {
        public StudentTicket(IPerformance performance)
            : base(performance, TicketType.Student)
        {
        }

        protected override decimal CalculatePrice()
        {
            base.CalculatePrice();
            return this.Performance.BasePrice * 0.8m;
        }
    }
}
