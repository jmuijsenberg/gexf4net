using System.Drawing;

namespace gexf4net.Nodes
{
    public interface IGexfNode
    {
        string Id { get; set; }
        string Label { get; set; }
        Color? Color { get; set; }
    }
}
