using gexf4net.viz;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class PositionEntityWriter : AbstractEntityWriter<Position>
    {
        private const string ENTITY = "viz:position";
        private const string ATTRIB_X = "x";
        private const string ATTRIB_Y = "y";
        private const string ATTRIB_Z = "z";

        public PositionEntityWriter(XmlWriter writer, Position entity) : base(writer, entity)
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
            //        ATTRIB_X,
            //        Float.toString(entity.getX()));

            //writer.writeAttribute(
            //        ATTRIB_Y,
            //        Float.toString(entity.getY()));

            //writer.writeAttribute(
            //        ATTRIB_Z,
            //        Float.toString(entity.getZ()));
        }


        protected override void writeElements()
        {
            // do nothing
        }
    }
}