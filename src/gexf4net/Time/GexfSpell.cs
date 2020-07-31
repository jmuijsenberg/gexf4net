﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    class GexfSpell
    {
        public GexfSpell()
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
    }
}