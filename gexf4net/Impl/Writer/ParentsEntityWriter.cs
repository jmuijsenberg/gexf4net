namespace gexf4net.Impl.Writer
{
    public class ParentsEntityWriter extends AbstractEntityWriter<List<Node>>{
	private static final String ENTITY = "parents";
	
	public ParentsEntityWriter(XMLStreamWriter writer, List<Node> entity) {
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
			new ParentEntityWriter(writer, n);
		}
	}

	
	protected void writeAttributes() throws XMLStreamException {
		// do nothing
	}
}