using gexf4net.data;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class GraphEntityWriter : DynamicEntityWriter<Graph> {
        private const string ENTITY = "graph";
        private const string ATTRIB_EDGETYPE = "defaultedgetype";
        private const string ATTRIB_MODE = "mode";
        private const string ATTRIB_IDTYPE = "idtype";
        private const string ATTRIB_TIMETYPE = "timeformat";

        public GraphEntityWriter(XmlWriter writer, Graph entity) : base(writer, entity)
        {
            write();
        }


        protected override string getElementName() {
            return ENTITY;
        }


        protected override void writeAttributes() {
            //AbstractEntityWriter.writerTimeType = entity.getTimeType();

            //writer.writeAttribute(
            //        ATTRIB_EDGETYPE,
            //        entity.getDefaultEdgeType().toString().toLowerCase());

            //writer.writeAttribute(
            //        ATTRIB_IDTYPE,
            //        entity.getIDType().toString().toLowerCase());

            //writer.writeAttribute(
            //        ATTRIB_MODE,
            //        entity.getMode().toString().toLowerCase());

            //if (entity.getMode().equals(Mode.DYNAMIC)) {
            //    writer.writeAttribute(
            //            ATTRIB_TIMETYPE,
            //            AbstractEntityWriter.writerTimeType);
            //}

            ///** Dynamic information */
            //super.writeAttributes();
        }


        protected override void writeElements() {
            foreach (AttributeList attList in entity.getAttributeLists()) {
                new AttributesEntityWriter(writer, attList);
            }

            new NodesEntityWriter(writer, entity.getNodes());
            new EdgesEntityWriter(writer, entity.getAllEdges());
            base.writeElements();
        }
    }
}