using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class ParentEntityWriter : AbstractEntityWriter<Node>
    {
        private const string ENTITY = "parent";
        private const string ATTRIB_FOR = "for";

        public ParentEntityWriter(XmlWriter writer, Node entity) : base(writer, entity)
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
            //		entity.getId());
        }


        protected override void writeElements()
        {
            // do nothing
        }
    }
}