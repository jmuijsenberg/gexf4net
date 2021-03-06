using gexf4net.dynamic;
using System.Collections.Generic;

namespace gexf4net
{
    /**
     * Interface for the Graph element.
     *
     */
    public interface Graph : Dynamic<Graph>, HasNodes
    {
        /**
         * Returns the default type of the Edges
         * @return an EdgeType enum for the Graph
         */
        EdgeType getDefaultEdgeType();

        /**
         * Sets the default type of the Edges
         * @param edgeType an instance of the EdgeType enum
         * @return the current Graph
         */
        Graph setDefaultEdgeType(EdgeType edgeType);

        /**
         * Returns the type of the ID
         * @return an IDType enum for the Graph
         */
        IDType getIDType();

        /**
         * Sets the type of the ID
         * @param idType an instance of IDType enum
         * @return the current Graph
         */
        Graph setIDType(IDType idType);

        /**
         * Returns the mode of the Graph
         * @return a Mode enum for the Graph
         */
        Mode getMode();

        /**
         * Sets the mode of the Graph
         * @param graphMode an instance of the Mode enum
         * @return the current Graph
         */
        Graph setMode(Mode graphMode);

        /**
         * Returns the type of time
         * @return the type of time as String
         */
        string getTimeType();

        /**
         * Sets the type of time
         * @param timeType a type of time as String
         * @return the current Graph
         */
        Graph setTimeType(string timeType);

        /**
         * Returns the list of the Graph's attributes
         * @return the list of the attributes for the Graph
         */
        List<data.AttributeList> getAttributeLists();
    }
}