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
            nodeA.X = 1.0f;
            nodeA.Y = 2.0f;
            nodeA.Z = 3.0f;
            IGexfNode nodeB = model.AddNode("2", "b");
            nodeB.Shape = "disc";
            nodeB.Size = 1.0f;
            IGexfNode nodeC = model.AddNode("3", "c");
            nodeC.Color = Color.Red;

            IGexfEdge edge1 = model.AddEdge("1", nodeA, nodeB, GexfEdgeType.Directed, 2.0);
            edge1.Color = Color.Blue;
            IGexfEdge edge2 = model.AddEdge("2", nodeB, nodeC, GexfEdgeType.Mutual);
            edge2.Shape = "dotted";
            IGexfEdge edge3 = model.AddEdge("3", nodeA, nodeC, GexfEdgeType.Undirected);
            edge3.Thickness = 2.0f;
            model.Write(null);
        }
    }
}
