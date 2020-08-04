namespace gexf4net.Graph
{
    // RelaxNG specification
    // 
    // id-type = 
    //     xsd:string | xsd:integer
    // 
    // idtype-type = [ a:defaultValue = "string" ] 
    //     string "integer" |
    //     string "string"
    //
    public enum GexfIdType
    {
        Integer,
        String
    }
}
