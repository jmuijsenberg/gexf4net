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
            string expectedOutput = "<meta>\n" +
                                    "  <creator>John Doe</Creator>\n" +
                                    "  <description>Some description</description>\n" +
                                    "  <keywords>Keyword Metadata</keywords>\n" +
                                    "</meta>";
            GexfMetadata metadata = new GexfMetadata();
            metadata.Creator = "John Doe";
            metadata.Description = "Some description";
            metadata.Keywords = "Keyword Metadata";
            //metadata.LastModifiedDate = new DateTime(2020, 8, 1); // TODO: Add date
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.AreEqual(expectedOutput, writer.ActualOutput);
        }

        [TestMethod]
        public void GivenMetadatIsEmptyWhenWritingXmlThenMetadataIsNotWritten()
        {
            string expectedOutput = @"﻿";
            GexfMetadata metadata = new GexfMetadata();
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.AreEqual(expectedOutput, writer.ActualOutput);
        }
    }
}
