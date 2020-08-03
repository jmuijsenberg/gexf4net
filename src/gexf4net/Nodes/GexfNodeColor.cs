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
    internal class GexfNodeColor : IGexfElement
    {
        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
