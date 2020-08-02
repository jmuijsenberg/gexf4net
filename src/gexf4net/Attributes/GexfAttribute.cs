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
    // # new point
    // attribute-content =
    //     attribute id { id-type }
    //   & attribute title { xsd:string }
    //   & attribute type { attrtype-type }
    //   & element default { text }?
    //   & element options { text }?
    // 
    // # extension point
    // attributes-content &= (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //
    internal class GexfAttribute<OwnerType> : IGexfElement
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public GexfMode Mode { get; set; }
        public string Default { get; set; }
        public bool HasDefault { get; set; }
        public IEnumerable<string> Options { get; set; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
