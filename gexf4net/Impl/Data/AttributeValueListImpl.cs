using gexf4net.data;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl.Data
{
    /**
     * AttributeValueListImpl class is an implementation of the AttributeValueList interface.
     *
     */
    public class AttributeValueListImpl : List<AttributeValue>, AttributeValueList
    {
        private const long serialVersionUID = 7730475001078826140L;

        /**
         * Constructs an AttributeValueListImpl object
         */
        public AttributeValueListImpl() { }


        public AttributeValueList addValue(Attribute attribute, string value)
        {
            createValue(attribute, value);
            return this;
        }


        public AttributeValue createValue(Attribute attribute, string value)
        {
            Contract.Requires(value != null, "Value cannot be null.");

            AttributeValue rv = new AttributeValueImpl(attribute);
            rv.setValue(value);
            Add(rv);

            return rv;
        }
    }
}