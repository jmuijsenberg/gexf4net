using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Attributes
{



    [TestClass]
    public class GexfAttributeListTest
    {
        private const string XmlOutput = "<attributes class=\"node\">\r\n" +
                                         "  <attribute id=\"0\" title=\"url\" type=\"string\"/>\r\n" +
                                         "  <attribute id=\"1\" title=\"indegree\" type=\"float\"/>\r\n" +
                                         "  <attribute id=\"2\" title=\"frog\" type=\"boolean\">\r\n" +
                                         "    <default>true</default>\r\n" +
                                         "  </attribute>\r\n" +
                                         "</attributes>";

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
