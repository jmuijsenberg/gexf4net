namespace gexf4net.Impl.Writer
{
    public class ColorEntityWriter extends AbstractEntityWriter<Color> {
	private static final String ENTITY = "viz:color";
	private static final String ATTRIB_R = "r";
	private static final String ATTRIB_G = "g";
	private static final String ATTRIB_B = "b";
	
	public ColorEntityWriter(XMLStreamWriter writer, Color entity) {
		super(writer, entity);
		write();
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeAttributes() throws XMLStreamException {
		writer.writeAttribute(
				ATTRIB_R,
				Integer.toString(entity.getR()));
		
		writer.writeAttribute(
				ATTRIB_G,
				Integer.toString(entity.getG()));
		
		writer.writeAttribute(
				ATTRIB_B,
				Integer.toString(entity.getB()));
	}

	
	protected void writeElements() throws XMLStreamException {
		// do nothing
	}
}