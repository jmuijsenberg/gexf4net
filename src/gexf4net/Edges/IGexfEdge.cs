using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    public interface IGexfEdge
    {
        string Id { get; set; }
        GexfEdgeType EdgeType { get; set; }
        string Label { get; set; }
        string Source { get; set; }
        string Target { get; set; }
        double Weight { get; set; }
    }
}
