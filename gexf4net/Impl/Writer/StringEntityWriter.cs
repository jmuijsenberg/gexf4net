using System.Diagnostics.Contracts;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    public class StringEntityWriter : AbstractEntityWriter<string>
    {
        private string characters = null;

        public StringEntityWriter(XmlWriter writer, string entity, string characters) : base(writer, entity)
        {
            Contract.Requires(characters != null, "Characters cannot be null.");

            this.characters = characters;
            write();
        }
        
        protected override string getElementName()
        {
            return entity;
        }
        
        protected override void writeElements()
        {
            //writer.writeCharacters(characters);
        }
        
        protected override void writeAttributes()
        {
            // do nothing
        }
    }
}