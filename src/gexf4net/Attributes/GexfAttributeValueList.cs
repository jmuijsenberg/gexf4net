using System;
using System.Xml;

namespace gexf4net.Attributes
{
    // RelaxNG specification
    //
    // attvalues-content =
    //     element attvalue { attvalue-content }*
    //
    internal class GexfAttributeValueList : IGexfElement
    {
        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
