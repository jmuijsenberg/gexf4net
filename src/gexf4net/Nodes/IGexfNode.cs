using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    public interface IGexfNode
    {
        string Id { get; set; }
        string Label { get; set; }
    }
}
