using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class EdgeEntityWriter : SpellableDatumEntityWriter<Edge>
    {
        private const string ENTITY = "edge";
        private const string ATTRIB_ID = "id";
        private const string ATTRIB_LABEL = "label";
        private const string ATTRIB_SOURCE = "source";
        private const string ATTRIB_TARGET = "target";
        private const string ATTRIB_WEIGHT = "weight";
        private const string ATTRIB_TYPE = "type";

        public EdgeEntityWriter(XmlWriter writer, Edge entity) : base(writer, entity)
        {
            write();
        }


        protected override string getElementName()
        {
            return ENTITY;
        }


        protected virtual void writeElements()
        {
            base.writeElements();

            //if (entity.hasColor())
            //{
            //    new ColorEntityWriter(writer, entity.getColor());
            //}

            //if (entity.hasThickness())
            //{
            //    new ValueEntityWriter<Float>(writer,
            //            "viz:thickness",
            //            entity.getThickness());
            //}

            //if (entity.getShape() != EdgeShape.NOTSET)
            //{
            //    new ValueEntityWriter<String>(writer,
            //            "viz:shape",
            //            entity.getShape().toString().toLowerCase());
            //}
        }


        protected void writeAttributes()
        {
            base.writeAttributes();

            //writer.writeAttribute(
            //        ATTRIB_ID,
            //        entity.getId());

            //writer.writeAttribute(
            //        ATTRIB_SOURCE,
            //        entity.getSource().getId());

            //writer.writeAttribute(
            //        ATTRIB_TARGET,
            //        entity.getTarget().getId());

            //writer.writeAttribute(
            //        ATTRIB_TYPE,
            //        entity.getEdgeType().toString().toLowerCase());

            //if (entity.hasLabel())
            //{
            //    writer.writeAttribute(
            //            ATTRIB_LABEL,
            //            entity.getLabel());
            //}

            //if (entity.hasWeight())
            //{
            //    writer.writeAttribute(
            //            ATTRIB_WEIGHT,
            //            Float.toString(entity.getWeight()));
            //}
        }
    }
}