using System.Collections.Generic;

namespace gexf4net
{
    public interface HasNodes
    {
        /**
         * Creates a new Node
         * @return the built Node
         */
        Node createNode();

        /**
         * Creates a new Node with a specific ID
         * @param id the ID of the Node
         * @return the built Node
         */
        Node createNode(string id);

        /**
         * Returns the list of all the Nodes
         * @return the list of all the Nodes
         */
        List<Node> getNodes();

        /**
         * Return a specific node
         * @return the node with the specified ID
         */
        Node getNode(string id);

        /**
         * Returns the list of all the Edges
         * @return the list of all the Edges
         */
        List<Edge> getAllEdges();
    }
}