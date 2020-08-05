using System;
using System.Xml;

namespace gexf4net.Visualization
{
    // RelaxNG specification
    //
    // thickness-content =
    //     attribute value { thickness-type }
    //   & (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //   & element spells { spells-content }?
    // 
    // thickness-type = [ a:defaultValue = "1.0" ] 
    //     xsd:float { minInclusive = "0.0"}
    // 
    internal class GexfThickness : IGexfElement
    {
        private const string XmlElementPrefix = "viz";
        private const string XmlElementName = "thickness";
        private const string XmlElementNamespace = "http://www.gexf.net/1.2draft/viz";

        private const string XmlAttibuteNameValue = "value";

        public float? Thickness { get; set; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            if (Thickness.HasValue)
            {
                writer.WriteStartElement(XmlElementPrefix, XmlElementName, XmlElementNamespace);
                writer.WriteAttributeString(XmlAttibuteNameValue, Thickness.Value.ToString());
                writer.WriteEndElement();
            }
        }
    }
}
