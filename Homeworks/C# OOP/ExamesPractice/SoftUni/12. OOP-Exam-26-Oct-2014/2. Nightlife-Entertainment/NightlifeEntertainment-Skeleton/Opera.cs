using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NightlifeEntertainment
{
    public class Opera : Venue, IVenue
    {
        public Opera(string name, string location, int numberOfSeats)
            : base(name, location, numberOfSeats, new List<PerformanceType> { PerformanceType.Opera, PerformanceType.Theatre})
        {
        }
    }
}
