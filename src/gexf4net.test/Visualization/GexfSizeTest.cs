using gexf4net.test.Utils;
using gexf4net.Visualization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Visualization
{
    [TestClass]
    public class GexfSizeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string XmlOutput = "<viz:size value=\"2.03757\" xmlns:viz=\"http://www.gexf.net/1.2draft/viz\" />";

            GexfSize shape = new GexfSize() { Size = 2.03757f };
            XmlTestWriter writer = new XmlTestWriter(shape, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
