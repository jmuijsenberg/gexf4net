using System.Collections.Generic;
using gexf4net.dynamic;

namespace gexf4net.data
{
    /**
     * Interface for the AttributeList
     *
     */
    public interface AttributeList : IList<Attribute>, Dynamic<AttributeList>
    {
        /**
         * Returns the AttributeClass for the list of Attributes
         * @return an AttributeClass enum for that list
         */
        AttributeClass getAttributeClass();

        /**
         * Returns the Mode of the list of Attributes
         * @return a Mode enum
         */
        Mode getMode();

        /**
         * Sets the Mode for that list of Attributes
         * @param mode an instance of Mode enum
         * @return the current AttributeList
         */
        AttributeList setMode(Mode mode);

        /**
         * Creates and adds an Attribute to the AttributeList
         * @param type the type of the Attribute as AttributeType enum
         * @param title the title of the Attribute as String
         * @return the built Attribute
         */
        Attribute createAttribute(AttributeType type, string title);

        /**
         * Creates and adds an Attribute to the AttributeList
         * @param id the ID of the Attribute as String
         * @param type the type of the Attribute as AttributeType enum
         * @param title the title of the Attribute as String
         * @return the built Attribute
         */
        Attribute createAttribute(string id, AttributeType type, string title);

        /**
         * Creates and adds an Attribute to the AttributeList
         * @param type the type of the Attribute as AttributeType enum
         * @param title the title of the Attribute as String
         * @return the current AttributeList
         */
        AttributeList addAttribute(AttributeType type, string title);

        /**
         * Creates and adds an Attribute to the AttributeList
         * @param id the ID of the Attribute as String
         * @param type the type of the Attribute as AttributeType enum
         * @param title the title of the Attribute as String
         * @return the current AttributeList
         */
        AttributeList addAttribute(string id, AttributeType type, string title);
    }
}