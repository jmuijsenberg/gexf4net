using gexf4net.dynamic;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    // TODO: Purpose Spellable<?>>
    public abstract class SpellableEntityWriter<T> : DynamicEntityWriter<T>  where T : Spellable<T>
    {
        public SpellableEntityWriter(XmlWriter writer, T entity) : base(writer, entity)
        {
        }

        protected override void writeAttributes()
        {
            // do nothing
            base.writeAttributes();
        }


        protected override void writeElements()
        {
            //if (!entity.getSpells().isEmpty())
            //{
            //    new SpellsEntityWriter(writer, entity.getSpells());
            //}
            base.writeElements();
        }
    }
}