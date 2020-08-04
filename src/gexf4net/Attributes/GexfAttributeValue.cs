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
        private GexfAttribute _attribute;
        //private GexfTimePeriodList _spells;

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
        }
    }
}
