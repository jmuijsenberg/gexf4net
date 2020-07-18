using System.Collections.Generic;

namespace gexf4net.data
{
    /**
     * Interface for the AttributeValueList
     *
     */
    public interface AttributeValueList : IList<AttributeValue>
    {
        /**
         * Adds a value in the list
         * @param attribute
         * @param value a value for the Attribute
         * @return the current AttributeValueList
         */
        AttributeValueList addValue(Attribute attribute, string value);

        /**
         * Creates a value for the Attribute
         * @param attribute the Attribute that you want to set
         * @param value a value for the Attribute
         * @return the current AttributeValueList
         */
        AttributeValue createValue(Attribute attribute, string value);
    }
}