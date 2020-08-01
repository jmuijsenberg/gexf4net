using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.test.Utils;
using gexf4net;

namespace gexf4net.test.Metadata
{
    [TestClass]
    public class GexfDescriptionMetadataTest
    {
        [TestMethod]
        public void GivenCreatorIsNotEmptyWhenWritingXmlThenCreatorIsWritten()
        {
            string expectedOutput = @"﻿<description>Some description</description>";
            GexfDescriptionMetadata metadata = new GexfDescriptionMetadata();
            metadata.Description = "Some description";
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.AreEqual(expectedOutput, writer.ActualOutput);
        }

        [TestMethod]
        public void GivenCreatorIsEmptyWhenWritingXmlThenCreatorIsNotWritte()
        {
            string expectedOutput = @"﻿";
            GexfDescriptionMetadata metadata = new GexfDescriptionMetadata();
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.AreEqual(expectedOutput, writer.ActualOutput);
        }
    }
}
