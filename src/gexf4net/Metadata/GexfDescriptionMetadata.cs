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
    // <description>A hello world! file</description>
    //
    class GexfDescriptionMetadata
    {
        private const string XmlElementName = "description";

        public string Description { get; set; }

        public GexfDescriptionMetadata()
        {
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteValue(Description);
            writer.WriteEndElement();
        }
    }
}
