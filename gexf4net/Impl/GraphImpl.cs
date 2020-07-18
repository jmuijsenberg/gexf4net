using gexf4net.data;
using gexf4net.dynamic;
using gexf4net.Impl.Dynamic;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl
{
    /**
     * GraphImpl class is an implementation of the Graph interface.
     *
     */
    public class GraphImpl : DynamicBase<Graph>, Graph
    {

        private EdgeType edgeType = EdgeType.UNDIRECTED;
        private List<AttributeList> attributeLists = null;
        private IDType idType = IDType.STRING;
        private Mode mode = Mode.STATIC;
        private List<Node> nodes = null;
        private string timeType = TimeFormat.DOUBLE;

        /**
         * This constructor is called by GexfImpl() constructor
         */
        public GraphImpl()
        {
            attributeLists = new List<AttributeList>();
            nodes = new List<Node>();
        }
        
        protected Graph getSelf()
        {
            return this;
        }

        public EdgeType getDefaultEdgeType()
        {
            return edgeType;
        }
        
        public IDType getIDType()
        {
            return idType;
        }


        public Mode getMode()
        {
            return mode;
        }


        public string getTimeType()
        {
            return timeType;
        }


        public Graph setDefaultEdgeType(EdgeType edgeType)
        {
            this.edgeType = edgeType;
            return this;
        }


        public Graph setIDType(IDType idType)
        {
            this.idType = idType;
            return this;
        }


        public Graph setMode(Mode graphMode)
        {
            this.mode = graphMode;
            return this;
        }


        public Graph setTimeType(string timeType)
        {
            this.timeType = timeType;
            return this;
        }


        public Node createNode()
        {
            return createNode(System.Guid.NewGuid().ToString());
        }


        public Node createNode(string id)
        {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(!id.trim().isEmpty(), "ID cannot be empty or blank.");

            Node rv = new NodeImpl(id);
            nodes.Add(rv);
            return rv;
        }


        public List<Edge> getAllEdges()
        {
            List<Edge> rv = new List<Edge>();

            foreach (Node n in nodes)
            {
                rv.AddRange(n.getEdges());
                rv.AddRange(n.getAllEdges());
            }

            return rv;
        }


        public List<Node> getNodes()
        {
            return nodes;
        }


        public Node getNode(string id)
        {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(id.Trim().Length > 0, "ID cannot be empty or blank.");
            foreach (Node node in nodes)
            {
                if (node.getId().Equals(id))
                {
                    return node;
                }
            }
            return null;
        }


        public List<AttributeList> getAttributeLists()
        {
            return attributeLists;
        }
    }