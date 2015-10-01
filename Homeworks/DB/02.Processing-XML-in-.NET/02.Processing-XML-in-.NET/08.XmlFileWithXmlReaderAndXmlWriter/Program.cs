namespace XmlFileWithXmlReaderAndXmlWriter
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml;

    /* Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml, in which stores in appropriate way the names of all albums and their authors. */
    public class Program
    {
        private const string XmlPath = "../../../catalogue.xml";

        private const string AlbumsXmlPath = "../../albums.xml";

        public static void Main()
        {
            var albums = ReadAlbums();

            WriteAlbums(albums, AlbumsXmlPath);
        }

        private static void WriteAlbums(IDictionary<string, string> albums, string path)
        {
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            using (XmlTextWriter writer = new XmlTextWriter(path, encoding))
	        {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("albums");
                writer.WriteAttributeString("name", "My albums");

                foreach (var album in albums)
                {
                    var name = album.Key;
                    var artist = album.Value;

                    WriteAlbum(writer, name, artist);
                }

                writer.WriteEndDocument();
	        }

        }

        private static void WriteAlbum(XmlTextWriter writer, string name, string artist)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", name);
            writer.WriteElementString("artist", artist);
            writer.WriteEndElement();
        }

        private static IDictionary<string, string> ReadAlbums()
        {
            var albums = new Dictionary<string, string>();

            using (XmlReader reader = XmlReader.Create(XmlPath))
            {
                var albumName = string.Empty;
                var artistName = string.Empty;

                while (reader.Read())
                {
                    if (reader.Name == "name")
                    {
                        albumName = reader.ReadElementString();
                    }

                    if (reader.Name == "artist")
                    {
                        artistName = reader.ReadElementString();
                        albums.Add(albumName, artistName);
                    }
                }
            }

            return albums;
        }
    }
}
