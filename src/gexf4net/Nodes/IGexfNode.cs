using System.Drawing;

namespace gexf4net.Nodes
{
    public interface IGexfNode
    {
        string Id { get; set; }
        string Label { get; set; }
        Color? Color { get; set; }

        float? X { get; set; }
        float? Y { get; set; }
        float? Z { get; set; }
        float? Size { get; set; }
        string Shape { get; set; }
    }
}
