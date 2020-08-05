using gexf4net.Edges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.test.Utils;

namespace gexf4net.test.Edges
{
    [TestClass]
    public class GexfEdgeTest
    {

        [TestMethod]
        public void GivenNodeWhenWritingXmlThenAllAttributesAreWritten()
        {
            const string XmlOutput = "<edge id=\"1\" source=\"2\" target=\"3\" weight=\"3.167\" label=\"edgelabel\" type=\"directed\" />";
            GexfEdge edge = new GexfEdge(GexfEdgeType.Undirected) { Id = "1", Source = "2", Target = "3", EdgeType = GexfEdgeType.Directed, Label = "edgelabel", Weight = 3.167 };
            XmlTestWriter writer = new XmlTestWriter(edge, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }

        [TestMethod]
        public void GivenNodeWithDefaultTypeWhenWritingXmlThenTypeAttributeIsNotWritten()
        {
            const string XmlOutput = "<edge id=\"1\" source=\"2\" target=\"3\" weight=\"3.167\" label=\"edgelabel\" />";
            GexfEdge edge = new GexfEdge(GexfEdgeType.Undirected) { Id = "1", Source = "2", Target = "3", EdgeType = GexfEdgeType.Undirected, Label = "edgelabel", Weight = 3.167 };
            XmlTestWriter writer = new XmlTestWriter(edge, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }

        [TestMethod]
        public void GivenNodeWithDefaultWeightWhenWritingXmlThenWeightAttributeIsNotWritten()
        {
            const string XmlOutput = "<edge id=\"1\" source=\"2\" target=\"3\" label=\"edgelabel\" type=\"directed\" />";
            GexfEdge edge = new GexfEdge(GexfEdgeType.Undirected) { Id = "1", Source = "2", Target = "3", EdgeType = GexfEdgeType.Directed, Label = "edgelabel", Weight = 1.0 };
            XmlTestWriter writer = new XmlTestWriter(edge, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }

        [TestMethod]
        public void GivenNodeWithoutLabelWhenWritingXmlThenLabelAttributeIsNotWritten()
        {
            const string XmlOutput = "<edge id=\"1\" source=\"2\" target=\"3\" weight=\"3.167\" type=\"directed\" />";
            GexfEdge edge = new GexfEdge(GexfEdgeType.Undirected) { Id = "1", Source = "2", Target = "3", EdgeType = GexfEdgeType.Directed, Weight = 3.167 };
            XmlTestWriter writer = new XmlTestWriter(edge, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
