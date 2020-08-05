using gexf4net.test.Utils;
using gexf4net.Visualization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Visualization
{
    [TestClass]
    public class GexfShapeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string XmlOutput = "<viz:shape value=\"disc\" xmlns:viz=\"http://www.gexf.net/1.2draft/viz\" />";

            GexfShape shape = new GexfShape() { Shape = "disc" };
            XmlTestWriter writer = new XmlTestWriter(shape, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
