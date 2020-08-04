using System;
using System.Xml;

namespace gexf4net.Metadata
{
    // RelaxNG specification
    //
    // element description { text }?
    //
    internal class GexfDescriptionMetadata : IGexfElement
    {
        private const string XmlElementName = "description";

        public string Description { get; set; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            if (!string.IsNullOrEmpty(Description))
            {
                writer.WriteStartElement(XmlElementName);
                writer.WriteValue(Description);
                writer.WriteEndElement();
            }
        }
    }
}
