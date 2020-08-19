using System;
using System.Collections.Generic;
using System.Xml;

namespace gexf4net.Attributes
{
    // RelaxNG specification
    //
    // attributes-content =
    //     attribute class { class-type }
    //   & attribute mode { mode-type }?
    //   & element attribute { attribute-content }*
    // 
    // class-type =  
    //     string "node" | 
    //     string "edge" 
    //
    internal class GexfAttributeList : IGexfElement
    {
        private const string XmlElementName = "attributes";
        private const string XmlAttibuteNameClass = "class";
        private const string XmlAttibuteNameMode = "mode";

        private List<GexfAttribute> _attributes = new List<GexfAttribute>();

        public string Class { get; set; }
        public GexfMode Mode { get; set; }
        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteAttributeString(XmlAttibuteNameClass, Class);
            writer.WriteAttributeString(XmlAttibuteNameMode, Mode.ToString().ToLower());

            foreach (GexfAttribute attribute in _attributes)
            {
                attribute.Write(writer, progress);
            }

            writer.WriteEndElement();
        }

        public void AddAttribute(string id, string title, GexfAttributeType type, string defaultValue, IEnumerable<string> options)
        {
            GexfAttribute attribute = new GexfAttribute() { Id = id, Title = title, Type = type, Default = defaultValue, Options = options };
            _attributes.Add(attribute);
        }
    }
}
