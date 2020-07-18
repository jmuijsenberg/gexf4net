namespace gexf4net
{
    /**
     * Interface for the GEXF element.
     *
     */
    public interface Gexf
    {
        /**
         * Returns the version of the GEXF file format
         * @return the GEXF version
         */
        string getVersion();

        /**
         * Checks if the GEXF has the variant
         * @return true if the GEXF has the variant
         */
        bool hasVariant();

        /**
         * Clears the variant of the GEXF
         * @return the current GEXF object
         */
        Gexf clearVariant();

        /**
         * Returns the variant of the GEXF
         * @return the variant as String
         */
        string getVariant();

        /**
         * Sets the variant for the GEXF
         * @param variant
         * @return the current GEXF object
         */
        Gexf setVariant(string variant);

        /**
         * Returns the Metadata of the GEXF
         * @return an instance of Metadata
         */
        Metadata getMetadata();

        /**
         * Returns the Graph of the GEXF
         * @return the instantiated Graph
         */
        Graph getGraph();

        /**
         * Checks if the GEXF has a visualization
         * @return true if the GEXF has a visualization
         */
        bool hasVisualization();

        /**
         * Sets the visualization for the GEXF
         * @param viz true if you want to set the visualization
         * @return the current GEXF object
         */
        Gexf setVisualization(bool viz);
    }
}