using gexf4net.data;
using gexf4net.Impl.Dynamic;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl.Data
{
    /**
     * AttributeValueImpl class is an implementation of the AttributeValue interface.
     *
     */
    public class AttributeValueImpl : DynamicBase<AttributeValue>, AttributeValue
    {
        private Attribute attribute = null;
        private string value = "";

        /**
         * Constructs an AttributeValue object
         * @param attribute an instance of Attribute interface
         */
        public AttributeValueImpl(Attribute attribute)
        {
            Contract.Requires(attribute != null, "Attribute cannot be null.");
            this.attribute = attribute;
        }
        
        protected override AttributeValue getSelf()
        {
            return this;
        }
        
        public Attribute getAttribute()
        {
            return attribute;
        }
        
        public string getValue()
        {
            return value;
        }
        
        public AttributeValue setValue(string value)
        {
            Contract.Requires(value != null, "Value cannot be null.");
            this.value = value;
            return this;
        }
    }
}