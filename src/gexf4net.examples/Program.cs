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

            IGexfNode nodeA = model.Graph.AddNode("1", "a");
            IGexfNode nodeB = model.Graph.AddNode("2", "b");
            IGexfNode nodeC = model.Graph.AddNode("3", "c");
            IGexfEdge edge1 = model.Graph.AddEdge("1", nodeA, nodeB, 2.0);
            IGexfEdge edge2 = model.Graph.AddEdge("2", nodeB, nodeC);
            model.Write(null);
        }
    }
}
