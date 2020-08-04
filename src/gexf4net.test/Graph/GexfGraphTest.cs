using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Graph
{
    [TestClass]
    public class GexfGraphTest
    {
        private const string XmlOutput = "<graph defaultedgetype=\"directed\" mode=\"static\" idtype=\"string\">\r\n" +
                                         "  <nodes count=\"2\">\r\n" +
                                         "    <node id=\"0\" label=\"Hello\" />\r\n" +
                                         "    <node id=\"1\" label=\"World\" />\r\n" +
                                         "  </nodes>\r\n" +
                                         "  <edges count=\"1\">\r\n" +
                                         "    <edge id=\"0\" source=\"0\" target=\"1\" weight=\"3.167\" />\r\n" +
                                         "  </edges>\r\n" +
                                         "</graph>";


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
