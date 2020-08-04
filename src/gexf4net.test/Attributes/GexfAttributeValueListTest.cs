using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Attributes
{
    [TestClass]
    public class GexfAttributeValueListTest
    {
        private const string XmlOutput = "<attvalues>\r\n" +
                                         "  <attvalue for=\"0\" value=\"http://gephi.org\"/>\r\n" +
                                         "  <attvalue for=\"1\" value=\"1\"/>\r\n" +
                                         "</attvalues>";


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
