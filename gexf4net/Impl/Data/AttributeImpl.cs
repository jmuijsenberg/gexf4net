using gexf4net.data;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl.Data
{
    /**
     * AttributeImpl class is an implementation of the Attribute interface.
     *
     */
    public class AttributeImpl : Attribute
    {

        private string id = "";
        private string defaultValue = null;
        private AttributeType type = AttributeType.STRING;
        private List<string> options = null;
        private string title = "";

        /**
         * Constructs an Attribute object with ID, type and title
         * @param id the ID of the Attribute
         * @param type an instance of AttributeType enum
         * @param title the title of the Attribute
         */
        public AttributeImpl(string id, AttributeType type, string title)
        {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(id.Trim().Length > 0, "ID cannot be blank.");
            Contract.Requires(title != null, "Title cannot be null.");
            Contract.Requires(title.Trim().Length > 0, "Title cannot be blank.");

            this.id = id;
            this.type = type;
            this.options = new List<string>();
            this.title = title;
        }


        public Attribute clearDefaultValue()
        {
            defaultValue = null;
            return this;
        }
        
        public AttributeType getAttributeType()
        {
            return type;
        }
        
        public string getDefaultValue()
        {
            Contract.Requires(hasDefaultValue(), "Default Value has not been set.");
            return defaultValue;
        }
        
        public string getId()
        {
            return id;
        }
        
        public List<string> getOptions()
        {
            return options;
        }


        public string getTitle()
        {
            return title;
        }


        public bool hasDefaultValue()
        {
            return (defaultValue != null);
        }


        public Attribute setDefaultValue(string defaultValue)
        {
            Contract.Requires(defaultValue != null, "Default Value cannot be null.");
            this.defaultValue = defaultValue;
            return this;
        }


        public Attribute setTitle(string title)
        {
            Contract.Requires(title != null, "Title cannot be null.");
            Contract.Requires(title.Trim().Length > 0, "Title cannot be blank.");
            this.title = title;
            return this;
        }


        public AttributeValue createValue(string value)
        {
            Contract.Requires(value != null, "Value cannot be null.");
            AttributeValue rv = new AttributeValueImpl(this);
            rv.setValue(value);
            return rv;
        }
    }
}