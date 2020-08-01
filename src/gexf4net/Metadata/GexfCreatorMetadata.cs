using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    // Example XML output:
    //
    // <creator>Gephi.org</creator>
    //
    internal class GexfCreatorMetadata : IGexfElement
    {
        private const string XmlElementName = "creator";

        public string Creator { get; set; }

        public GexfCreatorMetadata()
        {
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            if (!string.IsNullOrEmpty(Creator))
            {
                writer.WriteStartElement(XmlElementName);
                writer.WriteValue(Creator);
                writer.WriteEndElement();
            }
        }
    }
}
