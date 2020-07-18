using gexf4net.viz;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl
{
    /**
     * EdgeImpl class is an implementation of the Edge interface.
     *
     */
    public class EdgeImpl : SpellableDatumBase<Edge>, Edge
    {

        private string id = "";
        private string label = null;
        private Node source = null;
        private Node target = null;
        private Color color = null;
        private EdgeShape shape = EdgeShape.NOTSET;
        private float thickness = float.MinValue;
        private float weight = float.MaxValue;
        private EdgeType edgeType = EdgeType.UNDIRECTED;

        /**
         * Constructs an Edge with a specific ID, a source Node and a target Node
         * @param id the ID of the Edge
         * @param source the source node of the Edge
         * @param target the target node of the Edge
         */
        public EdgeImpl(string id, Node source, Node target)
        {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(id.Trim().Length > 0, "ID cannot be blank.");
            Contract.Requires(source != null, "Source Node cannot be null.");
            Contract.Requires(target != null, "Target Node cannot be null.");

            this.id = id;
            this.source = source;
            this.target = target;
        }

        protected Edge getSelf()
        {
            return this;
        }

        public Edge clearLabel()
        {
            label = null;
            return this;
        }

        public Edge clearThickness()
        {
            thickness = float.MinValue;
            return this;
        }


        public Edge clearWeight()
        {
            weight = float.MinValue;
            return this;
        }


        public EdgeType getEdgeType()
        {
            return edgeType;
        }


        public string getId()
        {
            return id;
        }


        public string getLabel()
        {
            Contract.Requires(hasLabel(), "Label has not been set.");
            return label;
        }

        public EdgeShape getShape()
        {
            return shape;
        }

        public Node getSource()
        {
            return source;
        }

        public Node getTarget()
        {
            return target;
        }

        public float getThickness()
        {
            Contract.Requires(hasThickness(), "Thickness has not been set.");
            return thickness;
        }

        public float getWeight()
        {
            Contract.Requires(hasWeight(), "Weight has not been set.");
            return weight;
        }

        public bool hasLabel()
        {
            return (label != null);
        }


        public bool hasThickness()
        {
            return (thickness != float.MinValue);
        }


        public bool hasWeight()
        {
            return (weight != float.MinValue);
        }

        public Edge clearColor()
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

        public Edge setColor(Color color)
        {
            Contract.Requires(color != null, "Color cannot be null.");
            this.color = color;
            return this;
        }

        public Edge setEdgeType(EdgeType edgeType)
        {
            this.edgeType = edgeType;
            return this;
        }

        public Edge setLabel(string label)
        {
            Contract.Requires(label != null, "Label cannot be null.");
            this.label = label;
            return this;
        }

        public Edge setShape(EdgeShape shape)
        {
            this.shape = shape;
            return this;
        }

        public Edge setTarget(Node target)
        {
            Contract.Requires(target != null, "Target cannot be null.");
            this.target = target;
            return this;
        }

        public Edge setThickness(float thickness)
        {
            this.thickness = thickness;
            return this;
        }

        public Edge setWeight(float weight)
        {
            this.weight = weight;
            return this;
        }
    }
}