using gexf4net.dynamic;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class SpellEntityWriter : DynamicEntityWriter<Spell>
    {
        private const string ENTITY = "spell";

        public SpellEntityWriter(XmlWriter writer, Spell entity) : base(writer, entity)
        {
            write();
        }
        
        protected override string getElementName()
        {
            return ENTITY;
        }
    }
}