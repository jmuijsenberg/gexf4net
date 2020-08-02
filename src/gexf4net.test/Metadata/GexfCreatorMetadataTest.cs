using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml;
using gexf4net;
using System.Text;
using gexf4net.test.Utils;

namespace gexf4net.test.Metadata
{
    [TestClass]
    public class GexfCreatorMetadataTest
    {
        private const string XmlOutput = "﻿<creator>John Doe</creator>";

        [TestMethod]
        public void GivenCreatorIsNotEmptyWhenWritingXmlThenCreatorIsWritten()
        {
            GexfCreatorMetadata metadata = new GexfCreatorMetadata();
            metadata.Creator = "John Doe";
            XmlTestWriter writer = new XmlTestWriter(metadata, XmlOutput);
            Assert.AreEqual(writer.ExpectedNormalizedXmlOutput, writer.ActualNormalizedXmlOutput);
        }

        [TestMethod]
        public void GivenCreatorIsEmptyWhenWritingXmlThenCreatorIsNotWritte()
        {
            GexfCreatorMetadata metadata = new GexfCreatorMetadata();
            XmlTestWriter writer = new XmlTestWriter(metadata, "");
            Assert.IsTrue(writer.ActualNormalizedXmlOutput.Length == 0);
        }
    }
}
