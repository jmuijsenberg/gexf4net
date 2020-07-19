using System.Xml;

namespace gexf4net.Impl.Writer
{
    public abstract class SpellableDatumEntityWriter<T> : SpellableEntityWriter<T> where T : SpellableDatum<T>
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