using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    // RelaxNG specification
    // 
    // id-type = 
    //     xsd:string | xsd:integer
    // 
    // idtype-type = [ a:defaultValue = "string" ] 
    //     string "integer" |
    //     string "string"
    //
    public enum GexfIdType
    {
        Integer,
        String
    }
}
