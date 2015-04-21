using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace NightlifeEntertainment
{
    public class AdvancedCinemaEngine : CinemaEngine
    {
        private StringBuilder outputAdvanced;

        public AdvancedCinemaEngine()
        {
            this.outputAdvanced = new StringBuilder();
        }

        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "opera":
                    var opera = new Opera(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var sportsHall = new SportsHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(sportsHall);
                    break;
                case "concert_hall":
                    var concertHall = new ConcertHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(concertHall);
                    break;
                default:
                    base.ExecuteInsertVenueCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "theatre":
                    {
                        var venue = this.GetVenue(commandWords[5]);
                        var theatre = new Theatre(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                        this.Performances.Add(theatre);
                    }
                    break;
                case "concert":
                    {
                        var venue = this.GetVenue(commandWords[5]);
                        var concert = new Concert(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                        this.Performances.Add(concert);
                    }
                    break;
                default:
                    base.ExecuteInsertPerformanceCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VipTicket(performance));
                    }
                    break;
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }
                    break;
                default:
                    base.ExecuteSupplyTicketsCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSellTicketCommand(string[] commandWords)
        {
            base.ExecuteSellTicketCommand(commandWords);
        }

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            var performance = this.GetPerformance(commandWords[1]);

            decimal allSum = 0.0M;

            foreach (var t in performance.Tickets.Where(t => t.Status == TicketStatus.Sold).ToList())
            {
                allSum += t.Price;
            }

            this.output.AppendLine(string.Format("{0}: {1} ticket(s), total: ${2:F2}",
                performance.Name,
                performance.Tickets.Where(t => t.Status == TicketStatus.Sold).ToList().Count,
                allSum
                ));

            this.output.AppendLine(string.Format("Venue: {0} ({1})", performance.Venue.Name, performance.Venue.Location));

            this.output.AppendLine(string.Format("Start time: {0}", performance.StartTime.ToString()));
        }

        protected override void ExecuteFindCommand(string[] commandWords)
        {
            string searchingPhrase = commandWords[1];
            string dateTimeToString = string.Format("{0} {1}", commandWords[2], commandWords[3]);
            DateTime dateTime = DateTime.ParseExact(dateTimeToString, "M.d.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            output.AppendLine(string.Format("Search for \"{0}\"", searchingPhrase));
            output.AppendLine("Performances:");

            bool hasPerf = false;

            foreach (var performance in base.Performances)
            {
                if (performance.StartTime > dateTime)
                {
                    if (performance.Name.ToLower().Contains(searchingPhrase.ToLower()))
                    {
                        output.AppendLine(string.Format("-{0}", performance.Name));
                        hasPerf = true;
                    }
                }
            }

            if (!hasPerf)
            {
                output.AppendLine("no results");
            }


            bool hasVenue = false;

            foreach (var venue in base.Venues)
            {

            }
        }
    }
}
