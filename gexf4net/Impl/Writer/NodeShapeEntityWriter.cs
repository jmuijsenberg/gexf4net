namespace gexf4net.Impl.Writer
{
    public class NodeShapeEntityWriter extends AbstractEntityWriter<NodeShapeEntity> {
	private static final String ENTITY = "viz:shape";
	private static final String ATTRIB_VALUE = "value";
	private static final String ATTRIB_URI = "uri";
	
	public NodeShapeEntityWriter(XMLStreamWriter writer, NodeShapeEntity entity) {
		super(writer, entity);
		write();
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeAttributes() throws XMLStreamException {
		writer.writeAttribute(
				ATTRIB_VALUE,
				entity.getNodeShape().toString().toLowerCase());
		
		if (entity.hasUri()) {
			writer.writeAttribute(
					ATTRIB_URI,
					entity.getUri());
		}
	}

	
	protected void writeElements() throws XMLStreamException {
		// do nothing
	}
}