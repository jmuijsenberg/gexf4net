using System;
using System.Xml;

namespace gexf4net.Metadata
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

        private readonly GexfCreatorMetadata _creatorMetadata = new GexfCreatorMetadata();
        private readonly GexfDescriptionMetadata _descriptionMetadata = new GexfDescriptionMetadata();
        private readonly GexfKeywordsMetadata _keywordsMetadata = new GexfKeywordsMetadata();

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
