namespace gexf4net.Impl.Writer
{
    public class GraphEntityWriter extends DynamicEntityWriter<Graph> {
	private static final String ENTITY = "graph";
	private static final String ATTRIB_EDGETYPE = "defaultedgetype";
	private static final String ATTRIB_MODE = "mode";
	private static final String ATTRIB_IDTYPE = "idtype";
	private static final String ATTRIB_TIMETYPE = "timeformat";
	
	public GraphEntityWriter(XMLStreamWriter writer, Graph entity) {
		super(writer, entity);
		write();
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeAttributes() throws XMLStreamException {
		AbstractEntityWriter.writerTimeType = entity.getTimeType();
		
		writer.writeAttribute(
				ATTRIB_EDGETYPE,
				entity.getDefaultEdgeType().toString().toLowerCase());
		
		writer.writeAttribute(
				ATTRIB_IDTYPE,
				entity.getIDType().toString().toLowerCase());
		
		writer.writeAttribute(
				ATTRIB_MODE,
				entity.getMode().toString().toLowerCase());
		
		if(entity.getMode().equals(Mode.DYNAMIC)) {
			writer.writeAttribute(
					ATTRIB_TIMETYPE,
					AbstractEntityWriter.writerTimeType);
		}
		
		/** Dynamic information */
		super.writeAttributes();
	}

	
	protected void writeElements() throws XMLStreamException {
		for (AttributeList attList : entity.getAttributeLists()) {
			new AttributesEntityWriter(writer, attList);
		}
		
		new NodesEntityWriter(writer, entity.getNodes());
		new EdgesEntityWriter(writer, entity.getAllEdges());
		super.writeElements();
	}
}