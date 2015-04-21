using System.Linq;
using Estates.Engine;
using Estates.Interfaces;

namespace Estates.Data
{
    class EnhancedEstateEngine : EstateEngine
    {
        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "find-rents-by-location":
                    string location = cmdArgs[0];
                    return this.ExecuteFindRentsByLocationCommand(location);
                case "find-rents-by-price":
                    decimal minPrice = decimal.Parse(cmdArgs[0]);
                    decimal maxPrice = decimal.Parse(cmdArgs[1]);
                    return this.ExecuteFindRentsByPriceRangeCommand(minPrice, maxPrice);
                default:
                    return base.ExecuteCommand(cmdName, cmdArgs);
            }
        }

        private string ExecuteFindRentsByLocationCommand(string location)
        {
            var offers = this.Offers
                .Where(o => o.Estate.Location == location && o.Type == OfferType.Rent)
                .OrderBy(o => o.Estate.Name);
            return FormatQueryResults(offers);
        }

        private string ExecuteFindRentsByPriceRangeCommand(decimal minPrice, decimal maxPrice)
        {
            var offers = this.Offers
                .Where(o => o.Type == OfferType.Rent)
                .Cast<IRentOffer>()
                .Where(o => o.PricePerMonth >= minPrice && o.PricePerMonth <= maxPrice)
                .OrderBy(o => o.PricePerMonth)
                .ThenBy(o => o.Estate.Name);
            return FormatQueryResults(offers);
        }
    }
}
