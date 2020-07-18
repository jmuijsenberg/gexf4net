using gexf4net.data;
using gexf4net.Impl.Data;
using gexf4net.Impl.Dynamic;

namespace gexf4net.Impl
{
    public abstract class SpellableDatumBase<T> : SpellableBase<T>, SpellableDatum<T>
    {
        private AttributeValueList attributes = null;

        public SpellableDatumBase()
        {
            attributes = new AttributeValueListImpl();
        }
        
        public AttributeValueList getAttributeValues()
        {
            return attributes;
        }
    }
}