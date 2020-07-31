using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    class GexfAttribute<OwnerType>
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public GexfMode Mode { get; set; }
        public string Default { get; set; }
        public bool HasDefault { get; set; }
        public IEnumerable<string> Options { get;  set; }
    }
}
