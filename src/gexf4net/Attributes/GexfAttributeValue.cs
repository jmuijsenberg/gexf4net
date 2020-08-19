using System;
using System.Xml;

namespace gexf4net.Attributes
{
    // RelaxNG specification
    //
    // attvalue-content =
    //     attribute for { id-type }
    //   & attribute value { xsd:string }
    // 
    // attvalue-content &= (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //
    internal class GexfAttributeValue : IGexfElement
    {
        private const string XmlElementName = "attvalue";
        private const string XmlAttibuteNameFor = "for";
        private const string XmlAttibuteNameValue = "value";

        private GexfAttribute _attribute;

        public GexfAttributeValue(GexfAttribute attribute)
        {
            _attribute = attribute;
        }

        public string Value { get; set; }

        //public bool IsValid(DateTime? dateTime)
        //{
        //    if ((_spells != null) && dateTime.HasValue)
        //    {
        //        return _spells.InRange(dateTime.Value);
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteAttributeString(XmlAttibuteNameFor, _attribute.Id);
            writer.WriteAttributeString(XmlAttibuteNameValue, Value);
            writer.WriteEndElement();
        }
    }
}
