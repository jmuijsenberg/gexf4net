namespace gexf4net.Edges
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
