namespace AllSongsTitlesXmlReader
{
    using System;
    using System.Xml;

    /* Write a program, which using XmlReader extracts all song titles from catalog.xml. */
    public class Program
    {
        private const string XmlPath = "../../../catalogue.xml";

        public static void Main()
        {
            using (XmlReader reader = XmlReader.Create(XmlPath))
            {
                Console.WriteLine("All songs:");
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine("Song: " + reader.ReadElementString());
                    }
                }
            }
        }
    }
}
