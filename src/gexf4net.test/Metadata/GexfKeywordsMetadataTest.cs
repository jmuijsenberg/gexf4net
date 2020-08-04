using gexf4net.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.test.Utils;

namespace gexf4net.test.Metadata
{
    [TestClass]
    public class GexfKeywordsMetadataTest
    {
        private const string XmlOutput = "﻿<keywords>Keyword Metadata</keywords>";

        [TestMethod]
        public void GivenCreatorIsNotEmptyWhenWritingXmlThenCreatorIsWritten()
        {

            GexfKeywordsMetadata metadata = new GexfKeywordsMetadata {Keywords = "Keyword Metadata"};
            XmlTestWriter writer = new XmlTestWriter(metadata, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }

        [TestMethod]
        public void GivenCreatorIsEmptyWhenWritingXmlThenCreatorIsNotWritte()
        {
            GexfKeywordsMetadata metadata = new GexfKeywordsMetadata();
            XmlTestWriter writer = new XmlTestWriter(metadata, "");
            Assert.IsTrue(writer.ActualNormalizedXmlOutput.Length == 0);
        }
    }
}
