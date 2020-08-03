using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
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
    internal class GexfEdgeThickness : IGexfElement
    {
        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
