using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml;
using gexf4net;
using System.Text;

namespace gex4net.test.Metadata
{
    [TestClass]
    public class GexfCreatorMetadataTest
    {
        [TestMethod]
        public void TestWrite()
        {
            MemoryStream stream = new MemoryStream();

            XmlWriterSettings settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
            };

            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {
                GexfCreatorMetadata metadata = new GexfCreatorMetadata();
                metadata.Write(writer, null);
            }

            string output = Encoding.UTF8.GetString(stream.ToArray());
            Assert.AreEqual(@"﻿<creator>DESKTOP-Q6732S7\jvdmu</creator>", output);
        }
    }
}
