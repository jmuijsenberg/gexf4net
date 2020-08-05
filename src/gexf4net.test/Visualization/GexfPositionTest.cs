using gexf4net.test.Utils;
using gexf4net.Visualization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gexf4net.test.Visualization
{
    [TestClass]
    public class GexfPositionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string XmlOutput = "<viz:position x=\"15.7835\" y=\"40.1092\" z=\"3.1\" xmlns:viz=\"http://www.gexf.net/1.2draft/viz\" />";

            GexfPosition position = new GexfPosition() { X=15.7835f, Y=40.1092f, Z=3.1f };
            XmlTestWriter writer = new XmlTestWriter(position, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
