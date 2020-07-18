namespace gexf4net.Impl.Writer
{
    public class PositionEntityWriter extends AbstractEntityWriter<Position> {
	private static final String ENTITY = "viz:position";
	private static final String ATTRIB_X = "x";
	private static final String ATTRIB_Y = "y";
	private static final String ATTRIB_Z = "z";
	
	public PositionEntityWriter(XMLStreamWriter writer, Position entity) {
		super(writer, entity);
		write();
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeAttributes() throws XMLStreamException {
		writer.writeAttribute(
				ATTRIB_X,
				Float.toString(entity.getX()));
		
		writer.writeAttribute(
				ATTRIB_Y,
				Float.toString(entity.getY()));
		
		writer.writeAttribute(
				ATTRIB_Z,
				Float.toString(entity.getZ()));
	}

	
	protected void writeElements() throws XMLStreamException {
		// do nothing
	}
}