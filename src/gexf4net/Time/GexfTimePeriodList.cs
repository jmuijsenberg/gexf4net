using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    // RelaxNG specification
    //
    // spells-content =
    //     element spell { spell-content }+
    //
    internal class GexfTimePeriodList : IGexfElement
    {
        private List<GexfTimePeriod> _spells = new List<GexfTimePeriod>();

        public GexfTimePeriodList()
        {
            _spells = new List<GexfTimePeriod>();
        }

        public IEnumerable<GexfTimePeriod> Spells => _spells;

        public bool InRange(DateTime dateTime)
        {
            return Find(dateTime) != null;
        }

        private GexfTimePeriod Find(DateTime dateTime)
        {
            GexfTimePeriod found = null;

            foreach (GexfTimePeriod spell in _spells)
            {
                if (spell.InRange(dateTime))
                {
                    found = spell;
                }
            }

            return found;
        }

        public void AddStart(DateTime start, bool inclusive)
        {
            Contract.Requires(Find(start) == null);
            _spells.Add(new GexfTimePeriod() { Start = start, StartInclusive = inclusive});
        }

        public void AddEnd(DateTime end, bool inclusive)
        {
            Contract.Requires(Find(end) != null);
            GexfTimePeriod current = Find(end);
            current.End = end;
            current.EndInclusive = inclusive;
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
