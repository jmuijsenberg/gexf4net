using System.Collections.Generic;

namespace gexf4net.data
{
    /**
     * Interface for the Attributes.
     *
     */
    public interface Attribute
    {
        /**
         * Returns the ID of the Attribute
         * @return the ID as String
         */
        string getId();

        /**
         * Returns the title of the Attribute
         * @return the title as String
         */
        string getTitle();

        /**
         * Sets the title of the Attribute
         * @param title the Attribute's title as String
         * @return the current Attribute
         */
        Attribute setTitle(string title);

        /**
         * Returns the type of the Attribute
         * @return an AttributeType enum for that Attribute
         */
        AttributeType getAttributeType();

        /**
         * Checks if the Attribute has a default value
         * @return true if the Attribute has a default value
         */
        bool hasDefaultValue();

        /**
         * Clears the default value of the Attribute
         * @return the current Attribute
         */
        Attribute clearDefaultValue();

        /**
         * Returns the default value of the Attribute
         * @return the default value as String
         */
        string getDefaultValue();

        /**
         * Sets the default value of the Attribute
         * @param defaultValue the default value as String
         * @return the current Attribute
         */
        Attribute setDefaultValue(string defaultValue);

        /**
         * Returns the list of the Attribute's options
         * @return the list of the options
         */
        List<string> getOptions();

        /**
         * Creates a value for that Attribute
         * @param value the value of the Attribute as String
         * @return an instance of the AttributeValue class
         */
        AttributeValue createValue(string value);
    }
}