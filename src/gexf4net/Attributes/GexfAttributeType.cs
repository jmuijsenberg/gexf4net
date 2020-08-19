namespace gexf4net.Attributes
{
    // RelaxNG specification
    //
    // attrtype-type =
    //     string "integer" | 
    //     string "long" | 
    //     string "double" | 
    //     string "float" | 
    //     string "boolean" | 
    //     string "liststring" | 
    //     string "string" |
    //     string "anyURI"
    // 
    public enum GexfAttributeType
    {
        Integer,
        Long,
        Double,
        Float,
        Boolean,
        ListString,
        String,
        AnyUri
    }
}
