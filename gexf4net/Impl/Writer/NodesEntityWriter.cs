using System.Collections.Generic;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class NodesEntityWriter : AbstractEntityWriter<List<Node>>
    {
        private const string ENTITY = "nodes";
        private const string ATTRIB_COUNT = "count";

        public NodesEntityWriter(XmlWriter writer, List<Node> entity) : base(writer, entity)
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
            foreach (Node n in entity)
            {
                new NodeEntityWriter(writer, n);
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