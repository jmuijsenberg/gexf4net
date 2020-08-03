using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
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
