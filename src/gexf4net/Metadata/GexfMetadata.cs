using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    // RelaxNG specification
    //
    // meta-content =
    //     attribute lastmodifieddate { xsd:date }?
    //   & element creator { text }?
    //   & element keywords { text }?
    //   & element description { text }?
    //
    internal class GexfMetadata : IGexfElement
    {
        private const string XmlElementName = "meta";
        private const string XmlAttibuteNameLastModifiedDate = "lastmodifieddate";

        private GexfCreatorMetadata _creatorMetadata = new GexfCreatorMetadata();
        private GexfDescriptionMetadata _descriptionMetadata = new GexfDescriptionMetadata();
        private GexfKeywordsMetadata _keywordsMetadata = new GexfKeywordsMetadata();

        public GexfMetadata()
        {
        }

        public DateTime? LastModifiedDate { get; set; }

        public string Creator
        {
            get { return _creatorMetadata.Creator; }
            set { _creatorMetadata.Creator = value; }
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
            if (!string.IsNullOrEmpty(Creator) ||
                !string.IsNullOrEmpty(Description) ||
                !string.IsNullOrEmpty(Keywords) ||
                LastModifiedDate.HasValue)
            {
                writer.WriteStartElement(XmlElementName);
                if (LastModifiedDate.HasValue)
                {
                    writer.WriteAttributeString(XmlAttibuteNameLastModifiedDate, LastModifiedDate.Value.ToString("yyyy-MM-dd"));
                }

                _creatorMetadata.Write(writer, progress);
                _descriptionMetadata.Write(writer, progress);
                _keywordsMetadata.Write(writer, progress);

                writer.WriteEndElement();
            }
        }
    }
}
