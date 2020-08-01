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
            char[] e = expectedOutput.ToCharArray();
            GexfKeywordsMetadata metadata = new GexfKeywordsMetadata();
            metadata.Keywords = "Keyword Metadata";
            XmlTestWriter writer = new XmlTestWriter(metadata);
            char[] r = writer.ActualOutput.ToCharArray();
            for (int i=0; i< e.Length; i++)
            {
                if(e[i] != r[i])
                {

                }
            }
            Assert.AreEqual(expectedOutput, writer.ActualOutput);
        }

        [TestMethod]
        public void GivenCreatorIsEmptyWhenWritingXmlThenCreatorIsNotWritte()
        {
            GexfKeywordsMetadata metadata = new GexfKeywordsMetadata();
            XmlTestWriter writer = new XmlTestWriter(metadata);
            Assert.IsTrue(writer.ActualOutput.Length == 0);
        }
    }
}
