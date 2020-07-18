namespace gexf4net.viz
{
    /**
     * Interface for the NodeShapeEntity.
     *
     */
    public interface NodeShapeEntity
    {
        /**
         * Returns the shape of the Node
         * @return an instance of the NodeShape enum
         */
        NodeShape getNodeShape();

        /**
         * Sets the shape of the Node
         * @param shape an instance of the NodeShape enum
         * @return the current NodeShapeEntity
         */
        NodeShapeEntity setNodeShape(NodeShape shape);

        /**
         * Checks if the NodeShapeEntity has a URI
         * @return true if the NodeShapeEntity has a URI
         */
        bool hasUri();

        /**
         * Clears the URI of the NodeShapeEntity
         * @return the current NodeShapeEntity
         */
        NodeShapeEntity clearUri();

        /**
         * Returns the URI of the NodeShapeEntity
         * @return the URI as String
         */
        string getUri();

        /**
         * Sets the URI for the NodeShapeEntity
         * @param uri the URI as String
         * @return the current NodeShapeEntity
         */
        NodeShapeEntity setUri(string uri);
    }
}