namespace gexf4net.Impl.Writer
{
    public class SpellsEntityWriter extends AbstractEntityWriter<List<Spell>> {
	private static final String ENTITY = "spells";
	
	public SpellsEntityWriter(XMLStreamWriter writer, List<Spell> entity) {
		super(writer, entity);
		
		if (!entity.isEmpty()) {
			write();
		}
	}

	
	protected String getElementName() {
		return ENTITY;
	}

	
	protected void writeElements() throws XMLStreamException {
		for (Spell s : entity) {
			new SpellEntityWriter(writer, s);
		}
	}

	
	protected void writeAttributes() throws XMLStreamException {
		// do nothing
	}
}