using gexf4net.Edges;
using gexf4net.Nodes;

namespace gexf4net.Graph
{
    public interface IGexfGraph
    {
        IGexfNode AddNode(string id, string label);
        IGexfEdge AddEdge(string id, IGexfNode source, IGexfNode target, GexfEdgeType edgeType, double weight, string label);
    }
}
