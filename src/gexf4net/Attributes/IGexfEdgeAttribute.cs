using System.Collections.Generic;

namespace gexf4net.Attributes
{
    interface IGexfEdgeAttribute
    {
        string Id { get; }
        string Title { get; }
        string DefaultValue { get; }
        bool HasDefault { get; set; }
        IEnumerable<string> Options { get; }
        GexfMode Mode { get; }
    }
}
