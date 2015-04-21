namespace NightlifeEntertainment
{
    public class VipTicket : Ticket
    {
        public VipTicket(IPerformance performance)
            : base(performance, TicketType.VIP)
        {
        }

        protected override decimal CalculatePrice()
        {
            base.CalculatePrice();
            return this.Performance.BasePrice * 1.5m;
        }
    }
}
