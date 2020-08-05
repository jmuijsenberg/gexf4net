using System;
using System.Xml;

namespace gexf4net.Visualization
{
    // RelaxNG specification
    //
    // size-content =
    //     attribute value { size-type }
    //   & (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //   & element spells { spells-content }?
    // 
    // size-type = [ a:defaultValue = "1.0" ] 
    //     xsd:float { minInclusive = "0.0"}
    //
    internal class GexfSize : IGexfElement
    {
        private const string XmlElementPrefix = "viz";
        private const string XmlElementName = "size";
        private const string XmlElementNamespace = "http://www.gexf.net/1.2draft/viz";

        private const string XmlAttibuteNameValue = "value";

        public float? Size { get; set; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            if (Size.HasValue)
            {
                writer.WriteStartElement(XmlElementPrefix, XmlElementName, XmlElementNamespace);
                writer.WriteAttributeString(XmlAttibuteNameValue, Size.Value.ToString());
                writer.WriteEndElement();
            }
        }
    }
}
