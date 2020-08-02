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
    // # extension point visialization
    // node-content &=
    //     element color { color-content }?
    //   & element position { position-content }?
    //   & element size { size-content }?
    //   & element shape { node-shape-content }?
    // 
    // # data types
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
    // # new datatype
    // color-channel = 
    //     xsd:nonNegativeInteger { maxInclusive = "255" }
    // 
    // # new datatype
    // alpha-channel = [ a:defaultValue = "1.0" ] 
    //     xsd:float { minInclusive = "0.0" maxInclusive = "1.0" }
    // 
    // # new point
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
    // # new point
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
    // # new datatype
    // size-type = [ a:defaultValue = "1.0" ] 
    //     xsd:float { minInclusive = "0.0"}
    // 
    // # new point
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
    // # new point
    // node-shape-content =
    //     attribute value { node-shape-type }
    //   & attribute uri { xsd:anyURI }?
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
    // node-shape-type =  [ a:defaultValue = "disc" ] 
    //     string "disc" |
    //     string "square" |
    //     string "triangle" |
    //     string "diamond" |
    //     string "image"
    // 
    // # new datatype
    // space-point = 
    //     xsd:float
    //
    internal class GexfNodeVisualization : IGexfElement
    {
        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
