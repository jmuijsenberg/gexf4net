using System;
using System.IO;
using gexf4net.Edges;
using gexf4net.Model;
using gexf4net.Nodes;
using System.Drawing;

namespace gexf4net.examples
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("demo.gexf");
            GexfModel model = new GexfModel(fileInfo, GexfMode.Static, DateTime.Now)
            {
                Description = "some description",
                Keywords = "some keywords"
            };

            IGexfNode nodeA = model.AddNode("1", "a");
            IGexfNode nodeB = model.AddNode("2", "b");
            IGexfNode nodeC = model.AddNode("3", "c");

            nodeA.X = 1.0f;
            nodeA.Y = 2.0f;
            nodeA.Z = 3.0f;
            nodeB.Shape = "disc";
            nodeB.Size = 1.0f;
            nodeC.Color = Color.Red;
            model.AddEdge("1", nodeA, nodeB, GexfEdgeType.Directed, 2.0);
            model.AddEdge("2", nodeB, nodeC, GexfEdgeType.Mutual);
            model.AddEdge("3", nodeA, nodeC, GexfEdgeType.Undirected);
            model.Write(null);
        }
    }
}
