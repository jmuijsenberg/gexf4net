using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net;
using gexf4net.test.Utils;

namespace gexf4net.test.Metadata
{
    [TestClass]
    public class GexfKeywordsMetadataTest
    {
        [TestMethod]
        public void GivenCreatorIsNotEmptyWhenWritingXmlThenCreatorIsWritten()
        {
            string expectedOutput = @"﻿<keywords>Keyword Metadata</keywords>";
            GexfKeywordsMetadata metadata = new GexfKeywordsMetadata();
            metadata.Keywords = "Keyword Metadata";
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.AreEqual(expectedOutput, writer.ActualOutput);
        }

        [TestMethod]
        public void GivenCreatorIsEmptyWhenWritingXmlThenCreatorIsNotWritte()
        {
            string expectedOutput = @"﻿";
            GexfKeywordsMetadata metadata = new GexfKeywordsMetadata();
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.AreEqual(expectedOutput, writer.ActualOutput);
        }
    }
}
