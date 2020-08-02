using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Edges
{
    [TestClass]
    public class GexfEdgeListTest
    {
        private const string XmlOutput = "<edges count=\"2\">\r\n" +
                                         "  <edge id=\"0\" source=\"2\" target=\"4\"/>\r\n" +
                                         "  <edge id=\"1\" source=\"3\" target=\"5\"/>\r\n" +
                                         "</edges>";

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
