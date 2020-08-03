using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.test.Utils;

namespace gexf4net.test.Nodes
{
    [TestClass]
    public class GexfNodeListTest
    {
        private const string XmlOutput = "<nodes count=\"2\">\r\n" +
                                         "  <node id=\"0\" label=\"Hello\" />\r\n" +
                                         "  <node id=\"1\" label=\"World\" />\r\n" +
                                         "</nodes>";

        [TestMethod]
        public void GivenNodeWhenWritingXmlThenIdAndLabelAreWritten()
        {
            GexfNode node1 = new GexfNode() { Id = "0", Label = "Hello" };
            GexfNode node2 = new GexfNode() { Id = "1", Label = "World" };
            GexfNodeList nodeList = new GexfNodeList();
            nodeList.Add(node1);
            nodeList.Add(node2);
            XmlTestWriter writer = new XmlTestWriter(nodeList, XmlOutput);

            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
