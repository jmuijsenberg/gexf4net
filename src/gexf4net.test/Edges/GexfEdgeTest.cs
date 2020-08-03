using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.test.Utils;

namespace gexf4net.test.Edges
{
    [TestClass]
    public class GexfEdgeTest
    {
        private const string XmlOutput = "<edge id=\"1\" source=\"2\" target=\"3\" />";

        [TestMethod]
        public void GivenNodeWhenWritingXmlThenIdAndLabelAreWritten()
        {
            GexfEdge edge = new GexfEdge(GexfEdgeType.Undirected) { Id = "1", Source= "2", Target="3" };
            XmlTestWriter writer = new XmlTestWriter(edge, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
