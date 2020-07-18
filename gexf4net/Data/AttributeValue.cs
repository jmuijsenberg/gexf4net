using gexf4net.dynamic;

namespace gexf4net.data
{
    /**
     * Interface for the AttributeValue.
     *
     */
    public interface AttributeValue : Dynamic<AttributeValue>
    {
        /**
         * Returns the Attribute
         * @return an instance of the Attribute class
         */
        Attribute getAttribute();

        /**
         * Returns the value of the Attribute
         * @return the value as String
         */
        string getValue();

        /**
         * Sets the value for that Attribute
         * @param value the value of the Attribute
         * @return the current AttributeValue
         */
        AttributeValue setValue(string value);
    }
}