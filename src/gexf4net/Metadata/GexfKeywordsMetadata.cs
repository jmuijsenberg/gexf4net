using System;
using System.Xml;

namespace gexf4net.Metadata
{
    // RelaxNG specification
    //
    // element keywords { text }?
    //
    internal class GexfKeywordsMetadata : IGexfElement
    {
        private const string XmlElementName = "keywords";

        public string Keywords { get; set; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            if (!string.IsNullOrEmpty(Keywords))
            {
                writer.WriteStartElement(XmlElementName);
                writer.WriteValue(Keywords);
                writer.WriteEndElement();
            }
        }
    }
}
