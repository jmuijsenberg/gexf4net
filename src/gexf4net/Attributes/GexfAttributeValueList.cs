using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net.Attributes
{
    // RelaxNG specification
    //
    // # new point
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
