namespace TraversingDirectoryXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    /*  Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
        Use tags <file> and <dir> with appropriate attributes.
        For the generation of the XML document use XDocument, XElement and XAttribute.
     */
    public class Program
    {
        private const string RootDirectory = "../../../../02.Processing-XML-in-.NET";
        private const string XmlPathDirectory = "../../direcorty.xml";

        public static void Main()
        {
            var directory = TraverseDirectory(RootDirectory);
            directory.Save(XmlPathDirectory);
        }

        static XElement TraverseDirectory(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(TraverseDirectory(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }
    }
}
