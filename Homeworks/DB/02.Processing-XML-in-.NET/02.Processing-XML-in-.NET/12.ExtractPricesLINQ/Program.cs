namespace ExtractPricesLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    /* Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier. Use LINQ query. */
    public class Program
    {
        private const string XmlPath = "../../../catalogue.xml";

        public static void Main()
        {
            XDocument xmlDocument = XDocument.Load(XmlPath);

            int currentYear = DateTime.Now.Year;

            var prices =
                from album in xmlDocument.Descendants("album")
                where int.Parse(album.Element("year").Value) > currentYear - 5
                select album.Element("price").Value;

            Console.WriteLine("Albums's prices, published 5 years ago or earlier:");
            foreach (var price in prices)
            {
                Console.WriteLine("Price: " + price);
            }
        }
    }
}
