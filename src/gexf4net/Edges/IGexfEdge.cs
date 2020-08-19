using gexf4net.Attributes;
using System.Collections.Generic;
using System.Drawing;

namespace gexf4net.Edges
{
    public interface IGexfEdge
    {
        string Id { get; set; }
        GexfEdgeType EdgeType { get; set; }
        string Label { get; set; }
        string Source { get; set; }
        string Target { get; set; }
        double Weight { get; set; }

        Color? Color { get; set; }
        float? Thickness { get; set; }
        string Shape { get; set; }

        IEnumerable<IGexfEdgeAttributeValue> AttributeValues { get; }
    }
}
