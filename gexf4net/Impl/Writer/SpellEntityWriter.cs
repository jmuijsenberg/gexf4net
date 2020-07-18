namespace gexf4net.Impl.Writer
{
    public class SpellEntityWriter extends DynamicEntityWriter<Spell> {
	private static final String ENTITY = "spell";
	
	public SpellEntityWriter(XMLStreamWriter writer, Spell entity) {
		super(writer, entity);
		write();
	}

	
	protected String getElementName() {
		return ENTITY;
	}
}