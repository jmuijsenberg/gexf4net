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
    internal class GexfNodePosition : IGexfElement
    {
        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
