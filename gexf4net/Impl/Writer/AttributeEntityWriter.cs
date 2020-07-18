using gexf4net.data;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class AttributeEntityWriter : AbstractEntityWriter<Attribute>
    {
        private const string ENTITY = "attribute";
        private const string ATTRIB_ID = "id";
        private const string ATTRIB_TITLE = "title";
        private const string ATTRIB_TYPE = "type";
        private const string ENTITY_DEFAULT = "default";
        private const string ENTITY_OPTIONS = "options";

        public AttributeEntityWriter(XmlWriter writer, Attribute entity)
        {
            base(writer, entity);
            write();
        }

        protected string getElementName()
        {
            return ENTITY;
        }


        protected void writeAttributes()
        {
            writer.writeAttribute(
                ATTRIB_ID,
                entity.getId());

            writer.writeAttribute(
                ATTRIB_TITLE,
                entity.getTitle());

            writer.writeAttribute(
                ATTRIB_TYPE,
                entity.getAttributeType().toString().toLowerCase());
        }


        protected void writeElements()
        {
            if (entity.hasDefaultValue())
            {
                new StringEntityWriter(writer, ENTITY_DEFAULT, entity.getDefaultValue());
            }

            if (entity.getOptions().Count > 0)
            {
                String options = Joiner.on(',').skipNulls().join(entity.getOptions());
                new StringEntityWriter(writer, ENTITY_OPTIONS, options);
            }
        }
    }
}