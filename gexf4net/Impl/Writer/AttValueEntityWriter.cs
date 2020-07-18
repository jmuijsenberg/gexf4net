using gexf4net.data;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class AttValueEntityWriter : DynamicEntityWriter<AttributeValue>
    {
        private const string ENTITY = "attvalue";
        private const string ATTRIB_FOR = "for";
        private const string ATTRIB_VALUE = "value";

        public AttValueEntityWriter(XmlWriter writer, AttributeValue entity) : base(writer, entity)
        {
            write();
        }


        protected override string getElementName()
        {
            return ENTITY;
        }


        protected override void writeAttributes()
        {
            //writer.writeAttribute(
            //		ATTRIB_FOR,
            //		entity.getAttribute().getId());

            //writer.writeAttribute(
            //		ATTRIB_VALUE,
            //		entity.getValue());

            //super.writeAttributes();
        }
    }
}