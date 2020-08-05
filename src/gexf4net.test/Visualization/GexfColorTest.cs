using gexf4net.test.Utils;
using gexf4net.Visualization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace gexf4net.test.Visualization
{
    [TestClass]
    public class GexfEdgeColorTest
    {
        [TestMethod]
        public void GivenNodeWhenWritingXmlThenIdAndLabelAreWritten()
        {
            const string XmlOutput = "<viz:color r=\"239\" g=\"173\" b=\"66\" a=\"0.501960784313725\" xmlns:viz=\"http://www.gexf.net/1.2draft/viz\" />";

            GexfColor color = new GexfColor() { Color = Color.FromArgb(128, 239, 173, 66) };
            XmlTestWriter writer = new XmlTestWriter(color, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }
    }
}
