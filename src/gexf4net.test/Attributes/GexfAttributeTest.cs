using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Attributes
{
    [TestClass]
    public class GexfAttributeTest
    {
        private const string XmlOutput = "<attribute id=\"0\" title=\"my−string−attribute\" type=\"string\">\r\n" +
                                         "  <default>foo</default>\r\n" +
                                         "  <options>foo|bar|foobar</options>\r\n" +
                                         "</attribute>";

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
