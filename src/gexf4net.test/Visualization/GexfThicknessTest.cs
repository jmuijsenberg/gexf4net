using gexf4net.test.Utils;
using gexf4net.Visualization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Visualization
{
    [TestClass]
    public class GexfThicknessTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string XmlOutput = "<viz:thickness value=\"5.124\" xmlns:viz=\"http://www.gexf.net/1.2draft/viz\" />";

            GexfThickness shape = new GexfThickness() { Thickness = 5.124f };
            XmlTestWriter writer = new XmlTestWriter(shape, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
