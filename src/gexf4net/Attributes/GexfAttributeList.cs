using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    // RelaxNG specification
    //
    // # new point
    // attributes-content =
    //     attribute class { class-type }
    //   & attribute mode { mode-type }?
    //   & element attribute { attribute-content }*
    // 
    // # new datatype
    // class-type =  
    //     string "node" | 
    //     string "edge" 
    //
    internal class GexfAttributeList<OwnerType> : IGexfElement
    {
        private List<GexfAttribute<OwnerType>> _attributes = new List<GexfAttribute<OwnerType>>();

        public GexfAttributeList()
        {
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
