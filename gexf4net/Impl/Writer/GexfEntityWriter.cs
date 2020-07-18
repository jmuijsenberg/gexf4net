using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class GexfEntityWriter : AbstractEntityWriter<Gexf>
    {
        private const string ENTITY = "gexf";
        private const string ATTRIBUTE_VERSION = "version";
        private const string ATTRIBUTE_VARIANT = "variant";
        private const string XMLNS_URL = "http://www.gexf.net/1.2draft";
        private const string XMLNS_VIZ = "viz";
        private const string XMLNS_VIZ_URL = "http://www.gexf.net/1.2draft/viz";

        public GexfEntityWriter(XmlWriter writer, Gexf entity) : base(writer, entity)
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
            //        ATTRIBUTE_VERSION,
            //        entity.getVersion());

            //if (entity.hasVariant())
            //{
            //    writer.writeAttribute(
            //            ATTRIBUTE_VARIANT,
            //            entity.getVariant());
            //}
        }


        protected void writeStartElement()
        {
            //writer.writeStartElement(getElementName());
            //writer.writeDefaultNamespace(XMLNS_URL);

            //if (entity.hasVisualization())
            //{
            //    writer.writeNamespace(XMLNS_VIZ, XMLNS_VIZ_URL);
            //}
        }


        protected override void writeElements()
        {
            new MetadataEntityWriter(writer, entity.getMetadata());
            new GraphEntityWriter(writer, entity.getGraph());
        }
    }
}