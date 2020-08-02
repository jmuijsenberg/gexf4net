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
        public string ExpectedNormalizedXmlOutput { get; private set; }
        public string ActualNormalizedXmlOutput { get; private set; }

        public XmlTestWriter(IGexfElement element, string expectedXmlOutput)
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

            ActualNormalizedXmlOutput = Encoding.UTF8.GetString(stream.ToArray()).StripByteOrderMark();
            ExpectedNormalizedXmlOutput = expectedXmlOutput.StripByteOrderMark();

            LogDifferences();
        }

        private void LogDifferences()
        {
            char[] e = ExpectedNormalizedXmlOutput.ToCharArray();
            char[] a = ActualNormalizedXmlOutput.ToCharArray();

            int l = Math.Min(e.Length, a.Length);

            for (int i = 0; i < l; i++)
            {
                if (e[i] != a[i])
                {
                    Console.WriteLine("First diff at {0}:  expected={1} actua={2}", i, e[i], a[i]);
                }
            }
        }
    }
}
