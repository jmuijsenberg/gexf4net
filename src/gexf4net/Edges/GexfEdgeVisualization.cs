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
    // # extension point
    // edge-content &=
    //     element color { color-content }?
    //   & element thickness { thickness-content }?
    //   & element shape { edge-shape-content }?
    // 
    // # new point
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
    // # new datatype
    // thickness-type = [ a:defaultValue = "1.0" ] 
    //     xsd:float { minInclusive = "0.0"}
    // 
    // # new datatype
    // edge-shape-type =  [ a:defaultValue = "solid" ] 
    //     string "solid" |
    //     string "dotted" |
    //     string "dashed" |
    //     string "double"
    //
    internal class GexfEdgeVisualization : IGexfElement
    {
        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
