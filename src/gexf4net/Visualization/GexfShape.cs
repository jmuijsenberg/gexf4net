using System;
using System.Xml;

namespace gexf4net.Visualization
{
    // RelaxNG specification
    //
    // edge-shape-content =
    //     attribute value { edge-shape-type }
    //   & (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //   & element spells { spells-content }?
    // 
    // edge-shape-type =  [ a:defaultValue = "solid" ] 
    //     string "solid" |
    //     string "dotted" |
    //     string "dashed" |
    //     string "double"
    //
    internal class GexfShape : IGexfElement
    {
        private const string XmlElementPrefix = "viz";
        private const string XmlElementName = "shape";
        private const string XmlElementNamespace = "http://www.gexf.net/1.2draft/viz";

        private const string XmlAttibuteNameValue = "value";

        public string Shape { get; set; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            if (!string.IsNullOrEmpty(Shape))
            {
                writer.WriteStartElement(XmlElementPrefix, XmlElementName, XmlElementNamespace);
                writer.WriteAttributeString(XmlAttibuteNameValue, Shape);
                writer.WriteEndElement();
            }
        }
    }
}
