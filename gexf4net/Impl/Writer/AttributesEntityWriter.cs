using System.Xml;
using gexf4net.data;

namespace gexf4net.Impl.Writer
{
    public class AttributesEntityWriter : DynamicEntityWriter<AttributeList>
    {
        private const string ENTITY = "attributes";
        private const string ATTRIB_CLASS = "class";
        private const string ATTRIB_MODE = "mode";

        public AttributesEntityWriter(XmlWriter writer, AttributeList entity) : base(writer, entity)
        {
            if (entity.Count > 0)
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
            //writer.writeAttribute(
            //        ATTRIB_CLASS,
            //        entity.getAttributeClass().toString().toLowerCase());

            //writer.writeAttribute(
            //        ATTRIB_MODE,
            //        entity.getMode().toString().toLowerCase());
        }


        protected void writeElements()
        {
            foreach (Attribute attrib in entity)
            {
                new AttributeEntityWriter(writer, attrib);
            }
        }
    }
}