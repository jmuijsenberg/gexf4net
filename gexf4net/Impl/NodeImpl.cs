using gexf4net.viz;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl
{
    /**
     * NodeImpl class is an implementation of the Node interface.
     *
     */
    public class NodeImpl : SpellableDatumBase<Node>, Node
    {
        private string id = "";
        private string label = "";
        private Color color = null;
        private string pid = null;
        private Position position = null;
        private NodeShapeEntity shape = null;
        private float size = float.MinValue;
        private List<Node> nodes = null;
        private List<Edge> edges = null;
        private List<Node> parentForList = null;

        /**
         * Constructs a Node
         */
        public NodeImpl()
        {
            this(System.Guid.NewGuid().ToString());
        }

        /**
         * Constructs a Node with a specific ID
         * @param id the ID of the Node
         */
        public NodeImpl(string id)
        {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(id.Trim().Length > 0, "ID cannot be blank.");

            this.id = id;
            this.nodes = new List<Node>();
            this.edges = new List<Edge>();
            this.parentForList = new List<Node>();
            this.shape = new NodeShapeImpl();
        }

        protected Node getSelf()
        {
            return this;
        }

        public Node clearColor()
        {
            color = null;
            return this;
        }

        public Color getColor()
        {
            Contract.Requires(hasColor(), "Color has not been set.");
            return color;
        }


        public bool hasColor()
        {
            return (color != null);
        }


        public Node setColor(Color color)
        {
            Contract.Requires(color != null, "Color cannot be null.");
            this.color = color;
            return this;
        }


        public Node clearPID()
        {
            pid = null;
            return this;
        }


        public Node clearPosition()
        {
            position = null;
            return this;
        }


        public Node clearShape()
        {
            shape = null;
            return this;
        }


        public Node clearSize()
        {
            size = float.MinValue;
            return this;
        }


        public List<Edge> getEdges()
        {
            return edges;
        }


        public string getId()
        {
            return id;
        }


        public string getLabel()
        {
            return label;
        }


        public string getPID()
        {
            Contract.Requires(hasPID(), "PID has not been set.");
            return pid;
        }


        public List<Node> getParentForList()
        {
            return parentForList;
        }


        public Position getPosition()
        {
            Contract.Requires(hasPosition(), "Position has not been set.");
            return position;
        }


        public NodeShapeEntity getShapeEntity()
        {
            return shape;
        }


        public float getSize()
        {
            Contract.Requires(hasSize(), "Size has not been set.");
            return size;
        }


        public bool hasPID()
        {
            return (pid != null);
        }


        public bool hasPosition()
        {
            return (position != null);
        }


        public bool hasShape()
        {
            return (shape.getNodeShape() != NodeShape.NOTSET);
        }


        public bool hasSize()
        {
            return (size != float.MinValue);
        }


        public Node setLabel(string label)
        {
            Contract.Requires(label != null, "Label cannot be null.");
            this.label = label;
            return this;
        }


        public Node setPID(string pid)
        {
            Contract.Requires(pid != null, "PID cannot be null.");
            Contract.Requires(pid.Trim().Length > 0, "PID cannot be empty or blank.");
            this.pid = pid;
            return this;
        }


        public Node setPosition(Position position)
        {
            Contract.Requires(position != null, "Position cannot be null.");
            this.position = position;
            return this;
        }


        public Node setSize(float size)
        {
            this.size = size;
            return this;
        }


        public Edge connectTo(Node target)
        {
            return connectTo(System.Guid.NewGuid().ToString(), target);
        }


        public Edge connectTo(string id, Node target)
        {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(id.Trim().Length > 0, "ID cannot be blank.");
            Contract.Requires(target != null, "Target cannot be null.");
            Contract.Requires(!hasEdgeTo(target.getId()), "Edge already exists.");

            Edge rv = new EdgeImpl(id, this, target);
            edges.Add(rv);
            return rv;
        }


        public Edge connectTo(string id, string label, Node target)
        {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(id.Trim().Length > 0, "ID cannot be empty or blank.");
            Contract.Requires(label != null, "label cannot be null.");
            Contract.Requires(target != null, "Target cannot be null.");
            Contract.Requires(!hasEdgeTo(target.getId()), "Edge already exists.");

            Edge rv = new EdgeImpl(id, this, target);
            rv.setLabel(label);
            edges.Add(rv);
            return rv;
        }


        public Edge connectTo(string id, string label, EdgeType edgeType, Node target)
        {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(id.Trim().Length > 0, "ID cannot be blank.");
            Contract.Requires(label != null, "label cannot be null.");
            Contract.Requires(target != null, "Target cannot be null.");
            Contract.Requires(!hasEdgeTo(target.getId()), "Edge already exists.");

            Edge rv = new EdgeImpl(id, this, target);
            rv.setLabel(label).setEdgeType(edgeType);
            edges.Add(rv);
            return rv;
        }


        public bool hasEdgeTo(string id)
        {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(id.Trim().Length > 0, "ID cannot be blank.");

            foreach (Edge e in edges)
            {
                if (e.getTarget().getId().Equals(id))
                {
                    return true;
                }
            }

            return false;
        }


        public Node createNode()
        {
            return createNode(System.Guid.NewGuid().ToString());
        }

        public Node createNode(string id)
        {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(id.Trim().Length > 0, "ID cannot be blank.");

            Node rv = new NodeImpl(id);
            nodes.Add(rv);
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

            foreach (Node node in getNodes())
            {
                if (node.getId().Equals(id))
                {
                    return node;
                }
            }
            return null;
        }


        public List<Edge> getAllEdges()
        {
            List<Edge> rv = new List<Edge>();

            foreach (Node n in getNodes())
            {
                _getEdges(rv, n);
            }

            return rv;
        }

        private List<Edge> _getEdges(List<Edge> soFar, Node n)
        {
            // add the nodes' edges
            soFar.AddRange(n.getEdges());

            // call this function on all of the sub nodes
            foreach (Node subNode in n.getNodes())
            {
                _getEdges(soFar, subNode);
            }

            return soFar;
        }
    }
}