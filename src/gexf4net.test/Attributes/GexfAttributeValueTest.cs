using gexf4net.Attributes;
using gexf4net.test.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Attributes
{
    [TestClass]
    public class GexfAttributeValueTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string XmlOutput = "<attvalue for=\"0\" value=\"http://gephi.org\"/>";

            GexfAttribute attribute = new GexfAttribute() { Id = "1", Title = "my−string−attribute", Type = GexfAttributeType.String };
            GexfAttributeValue attributeValue = new GexfAttributeValue(attribute) { Value = "http://gephi.org" };
            XmlTestWriter writer = new XmlTestWriter(attributeValue, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
