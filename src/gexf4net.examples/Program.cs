using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net.examples
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("demo.gexf");
            GexfModel model = new GexfModel(fileInfo, GexfMode.Static, DateTime.Now);
            model.Description = "some description";
            model.Keywords = "some keywords";

            IGexfNode nodeA = model.AddNode("1", "a");
            IGexfNode nodeB = model.AddNode("2", "b");
            IGexfNode nodeC = model.AddNode("3", "c");
            IGexfEdge edge1 = model.AddEdge("1", nodeA, nodeB, GexfEdgeType.Directed, 2.0);
            IGexfEdge edge2 = model.AddEdge("2", nodeB, nodeC, GexfEdgeType.Mutual);
            IGexfEdge edge3 = model.AddEdge("3", nodeA, nodeC, GexfEdgeType.Undirected);
            model.Write(null);
        }
    }
}
