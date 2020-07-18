namespace gexf4net.Impl.Writer
{
    public class ParentEntityWriter extends AbstractEntityWriter<Node> {
	private static final String ENTITY = "parent";
	private static final String ATTRIB_FOR = "for";
	
	public ParentEntityWriter(XMLStreamWriter writer, Node entity) {
		super(writer, entity);
		write();
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeAttributes() throws XMLStreamException {
		writer.writeAttribute(
				ATTRIB_FOR,
				entity.getId());
	}

	
	protected void writeElements() throws XMLStreamException {
		// do nothing
	}
}