using System;
using System.Collections.Generic;
using System.Xml;

namespace gexf4net.Attributes
{
    // RelaxNG specification
    //
    // attribute-content =
    //     attribute id { id-type }
    //   & attribute title { xsd:string }
    //   & attribute type { attrtype-type }
    //   & element default { text }?
    //   & element options { text }?
    //
    internal class GexfAttribute : IGexfElement
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
