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
        [TestMethod]
        public void GivenCreatorIsNotEmptyWhenWritingXmlThenCreatorIsWritten()
        {
            string expectedOutput = "﻿<creator>John Doe</creator>";
            GexfCreatorMetadata metadata = new GexfCreatorMetadata();
            metadata.Creator = "John Doe";
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.AreEqual(expectedOutput.StripBom(), writer.ActualOutput.StripBom());
        }

        [TestMethod]
        public void GivenCreatorIsEmptyWhenWritingXmlThenCreatorIsNotWritte()
        {
            GexfCreatorMetadata metadata = new GexfCreatorMetadata();
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.IsTrue(writer.ActualOutput.StripBom().Length == 0);
        }
    }
}
