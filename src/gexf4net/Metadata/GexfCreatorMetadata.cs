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
    // <creator>Gephi.org</creator>
    //
    public class GexfCreatorMetadata
    {
        private const string XmlElementName = "creator";

        public string Creator { get; }

        public GexfCreatorMetadata()
        {
            Creator = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteValue(Creator);
            writer.WriteEndElement();
        }
    }
}
