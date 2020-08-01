using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.test.Utils;

namespace gexf4net.test.Metadata
{
    [TestClass]
    public class GexfMetadataTest
    {
        [TestMethod]
        public void GivenMetadataIsNotEmptyWhenWritingXmlThenMetadataIsWritten()
        {
            string expectedOutput = "<meta>\r\n" +
                                    "  <creator>John Doe</creator>\r\n" +
                                    "  <description>Some description</description>\r\n" +
                                    "  <keywords>Keyword Metadata</keywords>\r\n" +
                                    "</meta>";
            GexfMetadata metadata = new GexfMetadata();
            metadata.Creator = "John Doe";
            metadata.Description = "Some description";
            metadata.Keywords = "Keyword Metadata";
            //metadata.LastModifiedDate = new DateTime(2020, 8, 1); // TODO: Add date
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.AreEqual(expectedOutput.StripBom(), writer.ActualOutput.StripBom());
        }

        [TestMethod]
        public void GivenMetadatIsEmptyWhenWritingXmlThenMetadataIsNotWritten()
        {
            GexfMetadata metadata = new GexfMetadata();
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.IsTrue(writer.ActualOutput.StripBom().Length == 0);
        }
    }
}
