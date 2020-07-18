namespace gexf4net.Impl.Writer
{
    public abstract class SpellableEntityWriter<T extends Spellable<?>> extends DynamicEntityWriter<T> {

	public SpellableEntityWriter(XMLStreamWriter writer, T entity) {
		super(writer, entity);
	}

	
	protected void writeAttributes() throws XMLStreamException {
		// do nothing
		super.writeAttributes();
	}

	
	protected void writeElements() throws XMLStreamException {
		if (!entity.getSpells().isEmpty()) {
			new SpellsEntityWriter(writer, entity.getSpells());
		}
		super.writeElements();
	}	
}