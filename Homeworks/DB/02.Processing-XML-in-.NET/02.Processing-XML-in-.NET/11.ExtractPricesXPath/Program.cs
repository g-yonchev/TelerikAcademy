namespace ExtractPricesXPath
{
    using System;
    using System.Xml;

    /* Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier. Use XPath query. */
    public class Program
    {
        private const string XmlPath = "../../../catalogue.xml";

        public static void Main()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlPath);

            int currentYear = DateTime.Now.Year;
            string xPathQuery = string.Format("/catalogue/album[year>{0}]/price", currentYear - 5);

            XmlNodeList prices = xmlDocument.SelectNodes(xPathQuery);

            Console.WriteLine("Albums's prices, published 5 years ago or earlier:");
            foreach (XmlNode price in prices)
            {
                Console.WriteLine("Price: " + price.InnerText);
            }
        }
    }
}
