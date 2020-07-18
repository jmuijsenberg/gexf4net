namespace gexf4net.Impl.Writer
{
    public class StringEntityWriter extends AbstractEntityWriter<String> {

	private String characters = null;
	public StringEntityWriter(XMLStreamWriter writer, String entity, String characters) {
		super(writer, entity);
		Contract.Requires(characters != null, "Characters cannot be null.");
		
		this.characters = characters;
		write();
	}

	
	protected String getElementName() {
		return entity;
	}

	
	protected void writeElements() throws XMLStreamException {
		writer.writeCharacters(characters);
	}
	
	
	protected void writeAttributes() throws XMLStreamException {
		// do nothing
	}
}