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
        private List<GexfAttribute> _attributes = new List<GexfAttribute>();

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            foreach (GexfAttribute attribute in _attributes)
            {
                attribute.Write(writer, progress);
            }
        }
    }
}
