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
    // <meta lastmodifieddate = "2009􀀀03􀀀20" >
    //   <creator>Gephi.org</creator>
    //   <description>A hello world! file</description>
    //   <keywords>hello world</keywords>
    // </meta>
    //
    class GexfMetadata
    {
        private const string XmlElementName = "meta";
        private const string XmlAttibuteNameLastModifiedDate = "lastmodifieddate";

        private GexfCreatorMetadata _creatorMetadata = new GexfCreatorMetadata();
        private GexfDescriptionMetadata _descriptionMetadata = new GexfDescriptionMetadata();
        private GexfKeywordsMetadata _keywordsMetadata = new GexfKeywordsMetadata();

        public GexfMetadata()
        {
        }

        public DateTime LastModifiedDate { get; set; }

        public string Creator
        {
            get { return _creatorMetadata.Creator; }
        }

        public string Description
        {
            get { return _descriptionMetadata.Description; }
            set { _descriptionMetadata.Description = value; }
        }

        public string Keywords
        {
            get { return _keywordsMetadata.Keywords; }
            set { _keywordsMetadata.Keywords = value; }
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteAttributeString(XmlAttibuteNameLastModifiedDate, LastModifiedDate.ToString());

            _creatorMetadata.Write(writer, progress);
            _descriptionMetadata.Write(writer, progress);
            _keywordsMetadata.Write(writer, progress);

            writer.WriteEndElement();
        }
    }
}
