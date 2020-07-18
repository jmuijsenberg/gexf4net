namespace gexf4net.Impl.Writer
{
    public class AttValueEntityWriter extends DynamicEntityWriter<AttributeValue>{
	private static final String ENTITY = "attvalue";
	private static final String ATTRIB_FOR = "for";
	private static final String ATTRIB_VALUE = "value";
	
	public AttValueEntityWriter(XMLStreamWriter writer, AttributeValue entity) {
		super(writer, entity);
		write();
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeAttributes() throws XMLStreamException {
		writer.writeAttribute(
				ATTRIB_FOR,
				entity.getAttribute().getId());
		
		writer.writeAttribute(
				ATTRIB_VALUE,
				entity.getValue());
		
		super.writeAttributes();
	}
}