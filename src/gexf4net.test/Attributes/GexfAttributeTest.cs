using gexf4net.Attributes;
using gexf4net.test.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Attributes
{
    [TestClass]
    public class GexfAttributeTest
    {
        private const string XmlOutput = "<attribute id=\"1\" title=\"my−string−attribute\" type=\"string\">\r\n" +
                                         "  <default>foo</default>\r\n" +
                                         "  <options>foo|bar|foobar</options>\r\n" +
                                         "</attribute>";

        [TestMethod]
        public void TestMethod1()
        {
            const string XmlOutput = "<attribute id=\"1\" title=\"my−string−attribute\" type=\"string\" />";

            GexfAttribute attribute = new GexfAttribute() { Id = "1", Title = "my−string−attribute" , Type=GexfAttributeType.String};
            XmlTestWriter writer = new XmlTestWriter(attribute, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
