using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
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
