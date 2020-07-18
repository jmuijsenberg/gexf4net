using gexf4net.viz;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class NodeShapeEntityWriter : AbstractEntityWriter<NodeShapeEntity>
    {
        private const string ENTITY = "viz:shape";
        private const string ATTRIB_VALUE = "value";
        private const string ATTRIB_URI = "uri";

        public NodeShapeEntityWriter(XmlWriter writer, NodeShapeEntity entity) : base(writer, entity)
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
            //        ATTRIB_VALUE,
            //        entity.getNodeShape().toString().toLowerCase());

            //if (entity.hasUri())
            //{
            //    writer.writeAttribute(
            //            ATTRIB_URI,
            //            entity.getUri());
            //}
        }


        protected override void writeElements()
        {
            // do nothing
        }
    }
}