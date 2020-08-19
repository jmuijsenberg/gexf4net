using gexf4net.Attributes;
using gexf4net.test.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Attributes
{
    [TestClass]
    public class GexfAttributeValueListTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string XmlOutput = "<attvalues>\r\n" +
                                     "  <attvalue for=\"0\" value=\"http://gephi.org\"/>\r\n" +
                                     "  <attvalue for=\"1\" value=\"1\"/>\r\n" +
                                     "</attvalues>";

            GexfAttributeValueList attributeValueList = new GexfAttributeValueList();
            XmlTestWriter writer = new XmlTestWriter(attributeValueList, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
