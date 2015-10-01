namespace AllArtistsXPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    /*  Write program that extracts all different artists which are found in the catalog.xml.
        For each author you should print the number of albums in the catalogue.
        Use XPath.
     */

    public class Program
    {
        private const string XmlPath = "../../../catalogue.xml";
        private const string XPathQuery = "/catalogue/album/artist";

        public static void Main()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlPath);

            var artists = GetAllArtists(xmlDocument);

            PrintAllArtists(artists);
        }

        private static void PrintAllArtists(IDictionary<string, int> artists)
        {
            Console.WriteLine("All artists:");
            foreach (var artist in artists)
            {
                Console.WriteLine(string.Format("{0} - {1} albums", artist.Key, artist.Value));
            }
        }

        private static IDictionary<string, int> GetAllArtists(XmlNode rootNode)
        {
            var allArtists = new Dictionary<string, int>();

            var artists = rootNode.SelectNodes(XPathQuery);

            foreach (XmlNode artist in artists)
            {
                string artistName = artist.InnerText;

                if (!allArtists.ContainsKey(artistName))
                {
                    allArtists.Add(artistName, 1);
                }
                else
                {
                    allArtists[artistName]++;
                }
            }

            return allArtists;
        }
    }
}
