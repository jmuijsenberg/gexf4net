using gexf4net.viz;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl.Viz
{
    /**
     * NodeShapeImpl class is an implementation of the NodeShapeEntity interface.
     *
     */
    public class NodeShapeImpl : NodeShapeEntity
    {
        private NodeShape shape = NodeShape.NOTSET;
        private string uri = null;

        /**
         * Constructs a NodeShapeImpl object
         */
        public NodeShapeImpl() { }

        public NodeShapeEntity clearUri()
        {
            uri = null;
            return this;
        }

        public NodeShape getNodeShape()
        {
            return shape;
        }

        public string getUri()
        {
            Contract.Requires(hasUri(), "URI has not been set.");
            return uri;
        }

        public bool hasUri()
        {
            return (uri != null);
        }

        public NodeShapeEntity setNodeShape(NodeShape shape)
        {
            Contract.Requires(shape != NodeShape.NOTSET, "Node Shape cannot be NOTSET.");
            this.shape = shape;
            return this;
        }


        public NodeShapeEntity setUri(string uri)
        {
            Contract.Requires(uri != null, "URI cannot be set to null.");
            this.uri = uri;
            return this;
        }
    }
}