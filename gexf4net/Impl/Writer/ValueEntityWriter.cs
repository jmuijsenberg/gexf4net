using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class ValueEntityWriter<T> : AbstractEntityWriter<T>
    {
        private const string ATTRIB_VALUE = "value";

        private string name = "";

        public ValueEntityWriter(XmlWriter writer, string name, T value) : base(writer, value)
        {
            ;
            this.name = name;
            write();
        }


        protected override string getElementName()
        {
            return name;
        }


        protected override void writeAttributes()
        {
            //writer.writeAttribute(
            //        ATTRIB_VALUE,
            //        entity.toString());
        }


        protected override void writeElements()
        {
            // do nothing
        }
    }
}