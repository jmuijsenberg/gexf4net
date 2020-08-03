using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    // RelaxNG specification
    //
    // attrtype-type =
    //     string "integer" | 
    //     string "long" | 
    //     string "double" | 
    //     string "float" | 
    //     string "boolean" | 
    //     string "liststring" | 
    //     string "string" |
    //     string "anyURI"
    // 
    public enum GexfAttributeType
    {
        Integer,
        Long,
        Double,
        Float,
        Boolean,
        ListString,
        Strig,
        AnyURI
    }
}
