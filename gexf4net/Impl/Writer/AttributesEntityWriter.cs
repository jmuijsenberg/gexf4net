namespace gexf4net.Impl.Writer
{
    public class AttributesEntityWriter extends DynamicEntityWriter<AttributeList> {
	private static final String ENTITY = "attributes";
	private static final String ATTRIB_CLASS = "class";
	private static final String ATTRIB_MODE = "mode";
	
	public AttributesEntityWriter(XMLStreamWriter writer, AttributeList entity) {
		super(writer, entity);
		
		if (!entity.isEmpty()) {
			write();
		}
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeAttributes() throws XMLStreamException {
		writer.writeAttribute(
				ATTRIB_CLASS,
				entity.getAttributeClass().toString().toLowerCase());

		writer.writeAttribute(
				ATTRIB_MODE,
				entity.getMode().toString().toLowerCase());
	}

	
	protected void writeElements() throws XMLStreamException {
		for (Attribute attrib : entity) {
			new AttributeEntityWriter(writer, attrib);
		}
	}
}