using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    public interface IGexfGraph
    {
        IGexfNode AddNode(string id, string label);
        IGexfEdge AddEdge(string id, IGexfNode source, IGexfNode target, double weight = 1.0);
    }
}
