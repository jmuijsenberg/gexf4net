namespace gexf4net.data
{
    /**
     * Interface for Datum.
     *
     */
    public interface Datum
    {
        /**
         * Returns a list of attribute values
         * @return an instance of AttributeValueList class
         */
        AttributeValueList getAttributeValues();
    }
}