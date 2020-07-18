namespace gexf4net.Impl.Writer
{
    public class EdgesEntityWriter extends AbstractEntityWriter<List<Edge>> {
	private static final String ENTITY = "edges";
	private static final String ATTRIB_COUNT = "count";
	
	public EdgesEntityWriter(XMLStreamWriter writer, List<Edge> entity) {
		super(writer, entity);
		
		if (!entity.isEmpty()) {
			write();
		}
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeElements() throws XMLStreamException {
		for (Edge e : entity) {
			new EdgeEntityWriter(writer, e);
		}
	}

	
	protected void writeAttributes() throws XMLStreamException {
		writer.writeAttribute(
				ATTRIB_COUNT,
				Integer.toString(entity.size()));
	}
}