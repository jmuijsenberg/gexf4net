using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class NodeEntityWriter : SpellableDatumEntityWriter<Node>
    {
        private const string ENTITY = "node";
        private const string ATTRIB_ID = "id";
        private const string ATTRIB_LABEL = "label";
        private const string ATTRIB_PID = "pid";

        public NodeEntityWriter(XmlWriter writer, Node entity) : base(writer, entity)
        {
            write();
        }


        protected override string getElementName()
        {
            return ENTITY;
        }


        protected override void writeAttributes()
        {
            base.writeAttributes();

            //writer.writeAttribute(
            //        ATTRIB_ID,
            //        entity.getId());

            //writer.writeAttribute(
            //        ATTRIB_LABEL,
            //        entity.getLabel());

            //if (entity.hasPID())
            //{
            //    writer.writeAttribute(
            //            ATTRIB_PID,
            //            entity.getPID());
            //}
        }


        protected override void writeElements()
        {
            base.writeElements();

            if (entity.hasColor())
            {
                new ColorEntityWriter(writer, entity.getColor());
            }

            if (entity.hasPosition())
            {
                new PositionEntityWriter(writer, entity.getPosition());
            }

            if (entity.hasSize())
            {
                //new ValueEntityWriter<Object>(writer,
                //        "viz:size",
                //        entity.getSize());
            }

            if (entity.hasShape())
            {
                new NodeShapeEntityWriter(writer, entity.getShapeEntity());
            }

            new ParentsEntityWriter(writer, entity.getParentForList());

            new NodesEntityWriter(writer, entity.getNodes());
            // TODO: Verify this is supposed to be commented out.
            // new EdgesEntityWriter(writer, entity.getAllEdges());
        }
    }
}