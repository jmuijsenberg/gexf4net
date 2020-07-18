using System;
using System.Collections.Generic;

namespace gexf4net
{
    /**
     * Interface for Metadata.
     *
     */
    public interface Metadata
    {
        /**
         * Checks if the Metadata is empty
         * @return true if the Metadata is empty
         */
        bool isEmpty();

        /**
         * Clears Metadata
         * @return the current Metadata
         */
        Metadata clearMetadata();

        /**
         * Checks if the GEXF file has a value for the field lastmodifieddate
         * @return true if the Metadata has a value for the field lastmodifieddate
         */
        bool hasLastModified();

        /**
         * Clears the lastmodifieddate field
         * @return the current Metadata
         */
        Metadata clearLastModified();

        /**
         * Returns the value of the lastmodifieddate field
         * @return the last modified date as Date
         */
        DateTime? getLastModified();

        /**
         * Sets the value for the lastmodifieddate field
         * @param lastModified an instance of Date
         * @return the current Metadata
         */
        Metadata setLastModified(DateTime? lastModified);

        /**
         * Checks if the GEXF file has a creator
         * @return true if the Metadata has a creator
         */
        bool hasCreator();

        /**
         * Clears the creator field
         * @return the current Metadata
         */
        Metadata clearCreator();

        /**
         * Returns the creator of the GEXF file
         * @return the creator as String
         */
        string getCreator();

        /**
         * Sets the creator for the GEXF file
         * @param creator the author as String
         * @return the current Metadata
         */
        Metadata setCreator(string creator);

        /**
         * Checks if the GEXF file has a description
         * @return true if the GEXF file has a description
         */
        bool hasDescription();

        /**
         * Clears the description of the GEXF file
         * @return the current Metadata
         */
        Metadata clearDescription();

        /**
         * Returns the description of the GEXF file
         * @return the description as String
         */
        string getDescription();

        /**
         * Sets the description for the GEXF file
         * @param description the description as String
         * @return the current Metadata
         */
        Metadata setDescription(string description);

        /**
         * Returns a list of keywords of the GEXF file
         * @return a list of keywords
         */
        List<string> getKeywords();
    }
}