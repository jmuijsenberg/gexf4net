using gexf4net.Edges;
using gexf4net.test.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Edges
{
    [TestClass]
    public class GexfEdgeListTest
    {
        private const string XmlOutput = "<edges count=\"2\">\r\n" +
                                         "  <edge id=\"0\" source=\"2\" target=\"4\" />\r\n" +
                                         "  <edge id=\"1\" source=\"3\" target=\"5\" />\r\n" +
                                         "</edges>";

        [TestMethod]
        public void GivenNodeWhenWritingXmlThenIdAndLabelAreWritten()
        {
            GexfEdge edge1 = new GexfEdge(GexfEdgeType.Directed) { Id = "0", Source = "2", Target = "4" };
            GexfEdge edge2 = new GexfEdge(GexfEdgeType.Directed) { Id = "1", Source = "3", Target = "5" };
            GexfEdgeList edgeList = new GexfEdgeList();
            edgeList.Add(edge1);
            edgeList.Add(edge2);
            XmlTestWriter writer = new XmlTestWriter(edgeList, XmlOutput);

            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
