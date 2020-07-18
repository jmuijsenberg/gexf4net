using gexf4net.dynamic;
using System.Collections.Generic;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class SpellsEntityWriter : AbstractEntityWriter<List<Spell>>
    {
        private const string ENTITY = "spells";

        public SpellsEntityWriter(XmlWriter writer, List<Spell> entity) : base(writer, entity)
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
            foreach (Spell s in entity)
            {
                new SpellEntityWriter(writer, s);
            }
        }


        protected override void writeAttributes()
        {
            // do nothing
        }
    }
}