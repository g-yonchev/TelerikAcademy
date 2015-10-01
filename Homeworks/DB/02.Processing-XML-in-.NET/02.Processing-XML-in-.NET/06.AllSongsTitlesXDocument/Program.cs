namespace AllSongsTitlesXDocument
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    /* Write a program, which using XDocument and LINQ query extracts all song titles from catalog.xml. */
    public class Program
    {
        private const string XmlPath = "../../../catalogue.xml";

        public static void Main()
        {
            XDocument xmlDocument = XDocument.Load(XmlPath);
            var songs =
                from song in xmlDocument.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value
                };

            Console.WriteLine("All songs:");
            foreach (var song in songs)
            {
                Console.WriteLine("Song: " + song.Title);
            }
        }
    }
}
