using System.Collections.Generic;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class ParentsEntityWriter : AbstractEntityWriter<List<Node>>
    {
        private const string ENTITY = "parents";

        public ParentsEntityWriter(XmlWriter writer, List<Node> entity) : base(writer, entity)
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
                new ParentEntityWriter(writer, n);
            }
        }


        protected override void writeAttributes()
        {
            // do nothing
        }
    }
}