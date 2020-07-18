using System.Xml;
using gexf4net.viz;

namespace gexf4net.Impl.Writer
{
    public class ColorEntityWriter : AbstractEntityWriter<Color>
    {
        private const string ENTITY = "viz:color";
        private const string ATTRIB_R = "r";
        private const string ATTRIB_G = "g";
        private const string ATTRIB_B = "b";

        public ColorEntityWriter(XmlWriter writer, Color entity) : base(writer, entity)
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
            //        ATTRIB_R,
            //        Integer.toString(entity.getR()));

            //writer.writeAttribute(
            //        ATTRIB_G,
            //        Integer.toString(entity.getG()));

            //writer.writeAttribute(
            //        ATTRIB_B,
            //        Integer.toString(entity.getB()));
        }


        protected override void writeElements()
        {
            // do nothing
        }
    }
}