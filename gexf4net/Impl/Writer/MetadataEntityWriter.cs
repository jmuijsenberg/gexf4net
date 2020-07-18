using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class MetadataEntityWriter : AbstractEntityWriter<Metadata>
    {
        private const string ENTITY = "meta";
        private const string ENTITY_CREATOR = "creator";
        private const string ENTITY_DESCRIPTION = "description";
        private const string ENTITY_KEYWORDS = "keywords";
        private const string ATTRIB_LASTMODIFIED = "lastmodifieddate";

        public MetadataEntityWriter(XmlWriter writer, Metadata entity) : base(writer, entity)
        {
            if (!entity.isEmpty())
            {
                write();
            }
        }


        protected override string getElementName()
        {
            return ENTITY;
        }


        protected override void writeAttributes()
        {
            //if (entity.hasLastModified())
            //{
            //    writer.writeAttribute(
            //            ATTRIB_LASTMODIFIED,
            //            toDateString(entity.getLastModified()));
            //}
        }


        protected override void writeElements()
        {
            if (entity.hasCreator())
            {
                new StringEntityWriter(writer, ENTITY_CREATOR, entity.getCreator());
            }

            if (entity.hasDescription())
            {
                new StringEntityWriter(writer, ENTITY_DESCRIPTION, entity.getDescription());
            }

            if (entity.getKeywords().Count > 0)
            {
                //String keywords = Joiner.on(',').skipNulls().join(entity.getKeywords());
                //new StringEntityWriter(writer, ENTITY_KEYWORDS, keywords);
            }
        }
    }
}