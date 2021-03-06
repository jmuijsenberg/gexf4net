﻿using System;
using System.Xml;

namespace gexf4net.Time
{
    // RelaxNG specification
    //
    // spell-content = (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //
    internal class GexfTimePeriod : IGexfElement
    {
        public GexfTimePeriod()
        {
            StartInclusive = false;
            EndInclusive = false;
        }

        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public bool StartInclusive { get; set; }
        public bool EndInclusive { get; set; }

        public bool InRange(DateTime dateTime)
        {
            return ((!Start.HasValue || (dateTime > Start.Value) || (StartInclusive && (dateTime == Start.Value)) &&
                    (!End.HasValue)  || (dateTime < End.Value)   || (EndInclusive   && (dateTime == End.Value  ))    ));
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
