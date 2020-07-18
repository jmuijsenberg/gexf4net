using System.Xml;

namespace gexf4net.Impl.Writer
{
    // TODO: Meaning of SpellableDatum<?>>
    public abstract class SpellableDatumEntityWriter<T> : SpellableEntityWriter<T>, SpellableDatum<T>
    {
        public SpellableDatumEntityWriter(XmlWriter writer, T entity) :
                base(writer, entity)
        {
        }

        protected override void writeElements()
        {
            base.writeElements();
            //new AttValuesEntityWriter(writer, entity.getAttributeValues());
        }
    }
}