﻿using gexf4net.Metadata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.test.Utils;

namespace gexf4net.test.Metadata
{
    [TestClass]
    public class GexfDescriptionMetadataTest
    {
        private const string XmlOutput = "﻿<description>Some description</description>";

        [TestMethod]
        public void GivenCreatorIsNotEmptyWhenWritingXmlThenCreatorIsWritten()
        {

            GexfDescriptionMetadata metadata = new GexfDescriptionMetadata {Description = "Some description"};
            XmlTestWriter writer = new XmlTestWriter(metadata, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }

        [TestMethod]
        public void GivenCreatorIsEmptyWhenWritingXmlThenCreatorIsNotWritte()
        {
            GexfDescriptionMetadata metadata = new GexfDescriptionMetadata();
            XmlTestWriter writer = new XmlTestWriter(metadata, "");
            Assert.IsTrue(writer.ActualNormalizedXmlOutput.Length == 0);
        }
    }
}
