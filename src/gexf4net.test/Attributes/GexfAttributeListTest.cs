using gexf4net.Attributes;
using gexf4net.test.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Attributes
{



    [TestClass]
    public class GexfAttributeListTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string XmlOutput = "<attributes class=\"node\">\r\n" +
                                     "  <attribute id=\"0\" title=\"url\" type=\"string\"/>\r\n" +
                                     "  <attribute id=\"1\" title=\"indegree\" type=\"float\"/>\r\n" +
                                     "</attributes>";

            GexfAttributeList attributeList = new GexfAttributeList() { Mode = GexfMode.Static, Class = "node" }
;            attributeList.AddAttribute("0", "url", GexfAttributeType.String, null, null);
            attributeList.AddAttribute("1", "indegree", GexfAttributeType.Float, null, null);
            XmlTestWriter writer = new XmlTestWriter(attributeList, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
