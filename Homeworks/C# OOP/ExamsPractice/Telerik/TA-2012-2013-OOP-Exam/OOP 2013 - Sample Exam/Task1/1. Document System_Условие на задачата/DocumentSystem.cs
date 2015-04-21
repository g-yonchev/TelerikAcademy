using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class DocumentSystem
    {
        private IList<IDocument> documents;

        public DocumentSystem()
        {
            this.documents = new List<IDocument>();
        }

        public void AddTextDocument(string[] attributes)
        {
            // TODO
        }

        public void AddPdfDocument(string[] attributes)
        {
            // TODO
        }

        public void AddWordDocument(string[] attributes)
        {
            // TODO
        }

        public void AddExcelDocument(string[] attributes)
        {
            // TODO
        }

        public void AddAudioDocument(string[] attributes)
        {
            // TODO
        }

        public void AddVideoDocument(string[] attributes)
        {
            // TODO
        }

        public void ListDocuments()
        {
            // TODO
        }

        public void EncryptDocument(string name)
        {
            // TODO
        }

        public void DecryptDocument(string name)
        {
            // TODO
        }

        public void EncryptAllDocuments()
        {
            // TODO
        }

        public void ChangeContent(string name, string content)
        {
            // TODO
        }
    }
}
