namespace DeleteAlbumsOverTenPrice
{
    using System;
    using System.Xml;

    /* Using the DOM parser write a program to delete from catalog.xml all albums having price > 20. */
    public class Program
    {
        private const string XmlPath = "../../../catalogue.xml";
        private const int MinPriceOfAlbum = 10;

        public static void Main()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlPath);

            XmlNode rootNode = xmlDocument.DocumentElement;

            foreach (XmlElement album in rootNode.ChildNodes)
            {
                var price = double.Parse(album["price"].InnerText);
                
                if (price < MinPriceOfAlbum)
                {
                    rootNode.RemoveChild(album);
                }
            }

            xmlDocument.Save("../../../newCatalogue.xml");
        }
    }
}
