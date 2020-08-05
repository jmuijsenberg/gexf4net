using System;
using System.Drawing;
using System.Xml;

namespace gexf4net.Visualization
{
    // RelaxNG specification
    //
    // color-content =
    //     attribute r { color-channel }
    //   & attribute g { color-channel }
    //   & attribute b { color-channel }
    //   & attribute a { alpha-channel }?
    //   & (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //   & element spells { spells-content }?
    // 
    // color-channel = 
    //     xsd:nonNegativeInteger { maxInclusive = "255" }
    // 
    // alpha-channel = [ a:defaultValue = "1.0" ] 
    //     xsd:float { minInclusive = "0.0" maxInclusive = "1.0" }
    // 
    internal class GexfColor : IGexfElement
    {
        private const string XmlElementPrefix = "viz";
        private const string XmlElementName = "color";
        private const string XmlElementNamespace = "http://www.gexf.net/1.2draft/viz";

        private const string XmlAttibuteNameRed = "r";
        private const string XmlAttibuteNameGreen = "g";
        private const string XmlAttibuteNameBlue = "b";
        private const string XmlAttibuteNameAlpha = "a";

        public Color? Color { get; set; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            if (Color.HasValue)
            {
                writer.WriteStartElement(XmlElementPrefix, XmlElementName, XmlElementNamespace);
                writer.WriteAttributeString(XmlAttibuteNameRed, Color.Value.R.ToString());
                writer.WriteAttributeString(XmlAttibuteNameGreen, Color.Value.G.ToString());
                writer.WriteAttributeString(XmlAttibuteNameBlue, Color.Value.B.ToString());
                writer.WriteAttributeString(XmlAttibuteNameAlpha, (Color.Value.A / 255.0).ToString());
                writer.WriteEndElement();
            }
        }
    }
}
