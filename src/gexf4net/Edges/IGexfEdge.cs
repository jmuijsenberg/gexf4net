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
    }
}
