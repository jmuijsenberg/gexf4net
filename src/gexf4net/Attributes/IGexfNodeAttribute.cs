using System.Collections.Generic;

namespace gexf4net.Attributes
{
    interface IGexfNodeAttribute
    {
        string Id { get; }
        string Name { get; }
        string DefaultValue { get; }
        bool HasDefault { get; set; }
        IEnumerable<string> Options { get; }
        GexfMode Mode { get; }
    }
}
