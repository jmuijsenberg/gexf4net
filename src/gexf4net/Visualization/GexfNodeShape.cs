using System;
using System.Xml;

namespace gexf4net.Visualization
{
    // RelaxNG specification
    //
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
    // node-shape-type =  [ a:defaultValue = "disc" ] 
    //     string "disc" |
    //     string "square" |
    //     string "triangle" |
    //     string "diamond" |
    //     string "image"
    //
    internal class GexfNodeShape : IGexfElement
    {
        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
