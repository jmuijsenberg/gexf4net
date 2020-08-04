using System;
using System.Xml;

namespace gexf4net.Metadata
{
    // RelaxNG specification
    //
    // element creator { text }?
    //
    internal class GexfCreatorMetadata : IGexfElement
    {
        private const string XmlElementName = "creator";

        public string Creator { get; set; }

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
