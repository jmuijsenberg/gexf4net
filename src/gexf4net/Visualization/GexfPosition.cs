using System;
using System.Xml;

namespace gexf4net.Visualization
{
    // RelaxNG specification
    //
    // position-content =
    //     attribute x { space-point }
    //   & attribute y { space-point }
    //   & attribute z { space-point }
    //   & (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //   & element spells { spells-content }?
    // 
    // space-point = 
    //     xsd:float
    //
    internal class GexfPosition : IGexfElement
    {
        private const string XmlElementPrefix = "viz";
        private const string XmlElementName = "position";
        private const string XmlElementNamespace = "http://www.gexf.net/1.2draft/viz";

        private const string XmlAttibuteNameX = "x";
        private const string XmlAttibuteNameY = "y";
        private const string XmlAttibuteNameZ = "z";

        public float? X { get; set;}
        public float? Y { get; set; }
        public float? Z { get; set; }

        public GexfPosition()
        {
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            if (X.HasValue && Y.HasValue && Z.HasValue)
            {
                writer.WriteStartElement(XmlElementPrefix, XmlElementName, XmlElementNamespace);
                writer.WriteAttributeString(XmlAttibuteNameX, X.Value.ToString());
                writer.WriteAttributeString(XmlAttibuteNameY, Y.Value.ToString());
                writer.WriteAttributeString(XmlAttibuteNameZ, Z.Value.ToString());
                writer.WriteEndElement();
            }
        }
    }
}
