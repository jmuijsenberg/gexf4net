using System.Collections.Generic;

namespace gexf4net.Attributes
{
    public interface IGexfEdgeAttributeValue
    {
        string Title { get; }
        string Value { get; set; }
        IEnumerable<string> Options { get; }
        GexfAttributeType Type { get; }
    }
}
