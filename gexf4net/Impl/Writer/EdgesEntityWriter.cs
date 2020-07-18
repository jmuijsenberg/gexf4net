using System.Collections.Generic;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class EdgesEntityWriter : AbstractEntityWriter<List<Edge>>
    {
        private const string ENTITY = "edges";
        private const string ATTRIB_COUNT = "count";

        public EdgesEntityWriter(XmlWriter writer, List<Edge> entity) : base(writer, entity)
        {
            if (entity.Count > 0)
            {
                write();
            }
        }


        protected override string getElementName()
        {
            return ENTITY;
        }


        protected override void writeElements()
        {
            foreach (Edge e in entity)
            {
                new EdgeEntityWriter(writer, e);
            }
        }


        protected override void writeAttributes()
        {
            //writer.writeAttribute(
            //        ATTRIB_COUNT,
            //        Integer.toString(entity.size()));
        }
    }
}