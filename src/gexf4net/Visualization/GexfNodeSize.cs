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
    internal class GexfNodeSize : IGexfElement
    {
        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
