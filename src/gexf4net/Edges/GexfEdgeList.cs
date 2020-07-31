using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    class GexfEdgeList
    {
        private List<IGexfEdge> _edges = new List<IGexfEdge>();

        public GexfEdgeList()
        {

        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            foreach (GexfEdge edge in _edges)
            {
                edge.Write(writer, progress);
            }
        }
    }
}
