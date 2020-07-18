namespace gexf4net.Impl
{
    /**
     * GexfImpl class is an implementation of the Gexf interface.
     *
     */
    public class GexfImpl : Gexf
    {
        private const string VERSION = "1.2";
	
	private string variant = null;
        private Graph graph = null;
        private Metadata meta = null;
        private bool viz = false;

        /**
         * Constructs a GEXF object
         */
        public GexfImpl()
        {
            graph = new GraphImpl();
            meta = new MetadataImpl();
        }
        
        public Graph getGraph()
        {
            return graph;
        }
        
        public Metadata getMetadata()
        {
            return meta;
        }
        
        public string getVersion()
        {
            return VERSION;
        }
        
        public bool hasVariant()
        {
            return (variant != null);
        }
        
        public Gexf clearVariant()
        {
            variant = null;
            return this;
        }


        public string getVariant()
        {
            checkState(hasVariant(), "Variant has not been set.");
            return variant;
        }


        public Gexf setVariant(String variant)
        {
            Contract.Requires(variant != null, "Variant cannot be null.");
            Contract.Requires(!variant.trim().isEmpty(), "Variant cannot be empty or blank.");
            this.variant = variant;
            return this;
        }


        public boolean hasVisualization()
        {
            return viz;
        }


        public Gexf setVisualization(boolean viz)
        {
            this.viz = viz;
            return this;
        }
    }