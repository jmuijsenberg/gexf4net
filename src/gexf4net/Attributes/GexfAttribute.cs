using System;
using System.Collections.Generic;
using System.Xml;

namespace gexf4net.Attributes
{
    // RelaxNG specification
    //
    // attribute-content =
    //     attribute id { id-type }
    //   & attribute title { xsd:string }
    //   & attribute type { attrtype-type }
    //   & element default { text }?
    //   & element options { text }?
    //
    internal class GexfAttribute : IGexfElement
    {
        private const string XmlElementName = "attribute";
        private const string XmlAttibuteNameId = "id";
        private const string XmlAttibuteNameTitle = "title";
        private const string XmlAttibuteNameType = "type";

        public string Id { get; set; }
        public string Title { get; set; }
        public string Default { get; set; }
        public bool HasDefault { get; set; }
        public IEnumerable<string> Options { get; set; }
        public GexfAttributeType Type { get; set; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteAttributeString(XmlAttibuteNameId, Id);
            writer.WriteAttributeString(XmlAttibuteNameTitle, Title);
            writer.WriteAttributeString(XmlAttibuteNameType, Type.ToString().ToLower());
            writer.WriteEndElement();
        }
    }
}
