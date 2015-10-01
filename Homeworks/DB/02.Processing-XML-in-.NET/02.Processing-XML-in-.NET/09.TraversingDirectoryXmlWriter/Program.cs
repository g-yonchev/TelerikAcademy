namespace TraversingDirectoryXmlWriter
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;

    /*  Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
        Use tags <file> and <dir> with appropriate attributes.
        For the generation of the XML document use the class XmlWriter.
     */
    public class Program
    {
        private const string RootDirectory = "../../../../02.Processing-XML-in-.NET";
        private const string XmlPathDirectory = "../../direcorty.xml";

        public static void Main()
        {
            var rootDirectory = new DirectoryInfo(RootDirectory);
            var encoding = Encoding.GetEncoding("utf-8");

            using (XmlTextWriter writer = new XmlTextWriter(XmlPathDirectory, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("root");

                TraverseDirectory(RootDirectory, writer);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        static void TraverseDirectory(string dir, XmlTextWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                TraverseDirectory(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                writer.WriteAttributeString("ext", Path.GetExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}
