using System;
using System.Collections.Generic;
using System.Xml;

namespace gexf4net.Attributes
{
    // RelaxNG specification
    //
    // attvalues-content =
    //     element attvalue { attvalue-content }*
    //
    internal class GexfAttributeValueList : IGexfElement
    {
        private const string XmlElementName = "attvalues";
        private List<GexfAttributeValue> _attributeValues = new List<GexfAttributeValue>();

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);

            foreach (GexfAttributeValue attributeValue in _attributeValues)
            {
                attributeValue.Write(writer, progress);
            }

            writer.WriteEndElement();
        }
    }
}
