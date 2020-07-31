using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    class GexfMetadata
    {
        private const string NodeName = "metadata";
        private const string CreatorNodeName = "creator";
        private const string DescriptionNodeName = "description";
        private const string KeywordsNodeName = "keywords";
        private const string LastModifiedDataName = "lastmodified";

        public string Creator { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(NodeName);
            writer.WriteAttributeString(LastModifiedDataName, LastModifiedDate.ToString());

            writer.WriteStartElement(CreatorNodeName);
            writer.WriteValue(Creator);
            writer.WriteEndElement();

            writer.WriteStartElement(DescriptionNodeName);
            writer.WriteValue(Description);
            writer.WriteEndElement();

            writer.WriteStartElement(KeywordsNodeName);
            writer.WriteValue(Keywords);
            writer.WriteEndElement();

            writer.WriteEndElement();
        }
    }
}
