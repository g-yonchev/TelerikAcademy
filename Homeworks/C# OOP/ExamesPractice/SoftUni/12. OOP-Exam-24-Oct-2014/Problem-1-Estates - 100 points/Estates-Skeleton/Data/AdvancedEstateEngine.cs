using Estates.Engine;
using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    class AdvancedEstateEngine : EstateEngine
    {
        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "find-rents-by-price":
                    return this.ExecuteFindRentsByPriceCommand(cmdArgs[0], cmdArgs[1]);
                case "find-rents-by-location":
                    return this.ExecuteFindRentsByLocationCommand(cmdArgs[0]);
                default:
                    return base.ExecuteCommand(cmdName, cmdArgs);
            }

        }

        private string ExecuteFindRentsByPriceCommand(string p1, string p2)
        {
            decimal minPrice = decimal.Parse(p1);
            decimal maxPrice = decimal.Parse(p2);

            var offers = this.Offers
                .Where(o => o.Type == OfferType.Rent)
                .Cast<IRentOffer>()
                .Where(o => o.PricePerMonth >= minPrice && o.PricePerMonth <= maxPrice)
                .OrderBy(o => o.PricePerMonth)
                .ThenBy(o => o.Estate.Name);
            return FormatQueryResults(offers);
        }

        private string ExecuteFindRentsByLocationCommand(string location)
        {

            var offers = this.Offers
                .Where(o => o.Estate.Location == location && o.Type == OfferType.Rent)
                .OrderBy(o => o.Estate.Name);
            return FormatQueryResults(offers);
        }
    }
}
