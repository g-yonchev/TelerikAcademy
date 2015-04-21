using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NightlifeEntertainment
{
    public class StudentTicket : Ticket, ITicket
    {
        public StudentTicket(IPerformance performance)
            : base(performance, TicketType.Student)
        {
        }

        protected override decimal CalculatePrice()
        {
            // TODO: Check this out
            if (this.Performance != null)
            {
                this.Price = this.Performance.BasePrice * 0.8M;
                return this.Price;
            }
            return base.CalculatePrice();
        }
    }
}
