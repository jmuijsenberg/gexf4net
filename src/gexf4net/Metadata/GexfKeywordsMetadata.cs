using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    // Example XML output:
    //
    // <keywords>hello world</keywords>
    //
    internal class GexfKeywordsMetadata : IGexfElement
    {
        private const string XmlElementName = "keywords";

        public string Keywords { get; set; }

        public GexfKeywordsMetadata()
        {
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            if (!string.IsNullOrEmpty(Keywords))
            {
                writer.WriteStartElement(XmlElementName);
                writer.WriteValue(Keywords);
                writer.WriteEndElement();
            }
        }
    }
}
