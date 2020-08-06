using System.Collections.Generic;

namespace gexf4net.Attributes
{
    interface IGexfEdgeAttributeValue
    {
        string Id { get; }
        string Name { get; }
        string Value { get; set; }
        string DefaultValue { get; }
        bool HasDefault { get; }
        IEnumerable<string> Options { get; }
    }
}
