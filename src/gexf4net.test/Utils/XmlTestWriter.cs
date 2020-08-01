using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net;
using System.IO;
using System.Xml;
using System.Text;

namespace gexf4net.test.Utils
{
    class XmlTestWriter
    {
        public string ActualOutput { get; private set; }

        public XmlTestWriter(IGexfElement element)
        {
            MemoryStream stream = new MemoryStream();

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = ("  "),
                OmitXmlDeclaration = true,
                Encoding = new UTF8Encoding(false)
            };

            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {
                element.Write(writer, null);
            }

            ActualOutput = Encoding.UTF8.GetString(stream.ToArray());
        }
    }
}
