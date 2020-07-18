namespace gexf4net.Impl.Writer
{
    public abstract class SpellableDatumEntityWriter<T extends SpellableDatum<?>> extends SpellableEntityWriter<T> {

	public SpellableDatumEntityWriter(XMLStreamWriter writer, T entity) {
		super(writer, entity);
	}

	
	protected void writeElements() throws XMLStreamException {
		super.writeElements();
		new AttValuesEntityWriter(writer, entity.getAttributeValues());
	}	
}