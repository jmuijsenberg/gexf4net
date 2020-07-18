using gexf4net.data;
using System.Collections.Generic;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class AttValuesEntityWriter : AbstractEntityWriter<List<AttributeValue>>
    {
        private const string ENTITY = "attvalues";

        public AttValuesEntityWriter(XmlWriter writer, List<AttributeValue> entity) : base(writer, entity)
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
            foreach (AttributeValue attval in entity)
            {
                new AttValueEntityWriter(writer, attval);
            }
        }


        protected override void writeAttributes()
        {
            // do nothing
        }
    }
}