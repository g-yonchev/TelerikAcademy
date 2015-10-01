namespace AllArtistsDomParser
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    /*  Write program that extracts all different artists which are found in the catalog.xml.
        For each author you should print the number of albums in the catalogue.
        Use the DOM parser and a hash-table.
     */
    public class Program
    {
        private const string XmlPath = "../../../catalogue.xml";

        public static void Main()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlPath);
            XmlNode rootNode = xmlDocument.DocumentElement;

            var artists = GetAllArtists(rootNode);

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
            var artists = new Dictionary<string, int>();

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                string artist = node["artist"].InnerText;

                if (!artists.ContainsKey(artist))
                {
                    artists.Add(artist, 1);
                }
                else
                {
                    artists[artist]++;
                }
            }

            return artists;
        }
    }
}
