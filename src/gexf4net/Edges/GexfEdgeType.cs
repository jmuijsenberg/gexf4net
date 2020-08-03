using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    // RelaxNG specification
    // 
    // edgetype-type = [ a:defaultValue = "undirected" ] 
    //     string "directed" | 
    //     string "undirected" | 
    //     string "mutual"
    // 
    public enum GexfEdgeType
    {
        Directed,
        Undirected,
        Mutual
    }
}
