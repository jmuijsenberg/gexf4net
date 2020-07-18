namespace gexf4net.Impl.Writer
{
    public class ValueEntityWriter<T extends Object> extends AbstractEntityWriter<T> {
	private static final String ATTRIB_VALUE = "value";
	
	private String name = "";
	
	public ValueEntityWriter(XMLStreamWriter writer, String name, T value) {
		super(writer, value);
		this.name = name;
		write();
	}

	
	protected String getElementName() {
		return name;
	}

	
	protected void writeAttributes() throws XMLStreamException {
		writer.writeAttribute(
				ATTRIB_VALUE,
				entity.toString());
	}

	
	protected void writeElements() throws XMLStreamException {
		// do nothing
	}
}