﻿using System;
using System.Xml;

namespace gexf4net.Visualization
{
    // RelaxNG specification
    //
    // edge-shape-content =
    //     attribute value { edge-shape-type }
    //   & (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //   & element spells { spells-content }?
    // 
    // edge-shape-type =  [ a:defaultValue = "solid" ] 
    //     string "solid" |
    //     string "dotted" |
    //     string "dashed" |
    //     string "double"
    //
    internal class GexfEdgeShape : IGexfElement
    {
        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}