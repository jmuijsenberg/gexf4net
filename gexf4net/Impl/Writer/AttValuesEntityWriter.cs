namespace gexf4net.Impl.Writer
{
    public class AttValuesEntityWriter extends AbstractEntityWriter<List<AttributeValue>>{
	private static final String ENTITY = "attvalues";
	
	public AttValuesEntityWriter(XMLStreamWriter writer,
			List<AttributeValue> entity) {
		super(writer, entity);
		
		if (!entity.isEmpty()) {
			write();
		}
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeElements() throws XMLStreamException {
		for (AttributeValue attval : entity) {
			new AttValueEntityWriter(writer, attval);
		}
	}

	
	protected void writeAttributes() throws XMLStreamException {
		// do nothing
	}
}