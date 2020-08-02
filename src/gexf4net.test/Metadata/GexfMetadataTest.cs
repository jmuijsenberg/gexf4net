using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.test.Utils;

namespace gexf4net.test.Metadata
{
    [TestClass]
    public class GexfMetadataTest
    {
        private const string XmlOutput = "<meta lastmodifieddate=\"2009-03-20\">\r\n" +
                                         "  <creator>Gephi.org</creator>\r\n" +
                                         "  <description>A hello world! file</description>\r\n" +
                                         "  <keywords>Keyword Metadata</keywords>\r\n" +
                                         "</meta>";

        //private const string XmlOutput = "<meta >\r\n" +
        //                                 "  <creator>John Doe</creator>\r\n" +
        //                                 "  <description>Some description</description>\r\n" +
        //                                 "  <keywords>Keyword Metadata</keywords>\r\n" +
        //                                 "</meta>";

        [TestMethod]
        public void GivenMetadataIsNotEmptyWhenWritingXmlThenMetadataIsWritten()
        {
            GexfMetadata metadata = new GexfMetadata();
            metadata.Creator = "Gephi.org";
            metadata.Description = "A hello world! file";
            metadata.Keywords = "Keyword Metadata";
            metadata.LastModifiedDate = new DateTime(2009,3, 20);
            XmlTestWriter writer = new XmlTestWriter(metadata, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }

        [TestMethod]
        public void GivenMetadatIsEmptyWhenWritingXmlThenMetadataIsNotWritten()
        {
            GexfMetadata metadata = new GexfMetadata();
            XmlTestWriter writer = new XmlTestWriter(metadata, "");
            Assert.IsTrue(writer.ActualNormalizedXmlOutput.Length == 0);
        }
    }
}
