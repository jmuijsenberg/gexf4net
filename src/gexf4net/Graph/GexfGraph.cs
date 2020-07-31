using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    class GexfGraph : IGexfGraph
    {
        public GexfGraph()
        {
            DefaultEdgeType = GexfEdgeType.Undirected;
            IdType = GexfIdType.String;
            Nodes = new List<IGexfNode>();
            Edges = new List<IGexfEdge>();
        }

        public GexfEdgeType DefaultEdgeType { get; set; }
        public GexfIdType IdType { get; set; }
        public IList<IGexfNode> Nodes { get; }
        public IList<IGexfEdge> Edges { get; }
        public GexfTimeFormat TimeFormat { get; set; }
        public GexfSpell Lifetime { get; set; }
    }
}
