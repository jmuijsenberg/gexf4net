using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    class GexfAttributeList<OwnerType>
    {
        private List<GexfAttribute<OwnerType>> _attributes = new List<GexfAttribute<OwnerType>>();

        public GexfAttributeList()
        {
        }
    }
}
