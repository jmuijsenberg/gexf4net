namespace gexf4net.Impl.Writer
{
    public class NodesEntityWriter extends AbstractEntityWriter<List<Node>> {
	private static final String ENTITY = "nodes";
	private static final String ATTRIB_COUNT = "count";
	
	public NodesEntityWriter(XMLStreamWriter writer, List<Node> entity) {
		super(writer, entity);
		
		if (!entity.isEmpty()) {
			write();
		}
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeElements() throws XMLStreamException {
		for (Node n : entity) {
			new NodeEntityWriter(writer, n);
		}
	}

	
	protected void writeAttributes() throws XMLStreamException {
		writer.writeAttribute(
				ATTRIB_COUNT,
				Integer.toString(entity.size()));
	}
}