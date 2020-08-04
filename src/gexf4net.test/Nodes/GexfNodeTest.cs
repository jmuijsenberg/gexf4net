using gexf4net.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.test.Utils;

namespace gexf4net.test.Nodes
{
    [TestClass]
    public class GexfNodeTest
    {
        private const string XmlOutput = "﻿<node id=\"1\" label=\"Hello\" />";

        [TestMethod]
        public void GivenNodeWhenWritingXmlThenIdAndLabelAreWritten()
        {
            GexfNode node = new GexfNode() { Id = "1", Label = "Hello" };
            XmlTestWriter writer = new XmlTestWriter(node, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
