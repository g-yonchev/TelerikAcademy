using DocumentSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class Document : IDocument
    {
        public Document(string name)
        {
            this.Name = name;
        }

        public Document(string name, string content)
            : this (name)
        {
            this.Content = content;
        }

        public string Name { get; private set; }

        public string Content { get; private set; }

        public void LoadProperty(string key, string value)
        {
            throw new NotImplementedException();
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }
    }
}
