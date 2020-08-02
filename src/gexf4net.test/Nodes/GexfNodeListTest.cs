using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Nodes
{
    [TestClass]
    public class GexfNodeListTest
    {
        private const string XmlOutput = "<nodes count=\"2\">\r\n" +
                                         "  <node id =\"0\" label=\"Hello\"/>\r\n" +
                                         "  <node id =\"1\" label=\"Word\"/>\r\n" +
                                         "</nodes>";

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
