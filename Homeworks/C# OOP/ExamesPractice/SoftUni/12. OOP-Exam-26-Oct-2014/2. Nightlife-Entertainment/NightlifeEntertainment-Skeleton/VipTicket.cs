using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NightlifeEntertainment
{
    public class VipTicket : Ticket, ITicket
    {
        public VipTicket(IPerformance performance)
            : base(performance, TicketType.VIP)
        {
        }

        protected override decimal CalculatePrice()
        {
            // TODO: Check this out
            if (this.Performance != null)
            {
                this.Price = this.Performance.BasePrice * 1.5M;
                return this.Price;
            }
            return base.CalculatePrice();
        }
    }
}
