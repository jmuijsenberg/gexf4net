using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    internal class GexfSpellList : IGexfElement
    {
        private List<GexfSpell> _spells = new List<GexfSpell>();

        public GexfSpellList()
        {
            _spells = new List<GexfSpell>();
        }

        public IEnumerable<GexfSpell> Spells => _spells;

        public bool InRange(DateTime dateTime)
        {
            return Find(dateTime) != null;
        }

        private GexfSpell Find(DateTime dateTime)
        {
            GexfSpell found = null;

            foreach (GexfSpell spell in _spells)
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
            _spells.Add(new GexfSpell() { Start = start, StartInclusive = inclusive});
        }

        public void AddEnd(DateTime end, bool inclusive)
        {
            Contract.Requires(Find(end) != null);
            GexfSpell current = Find(end);
            current.End = end;
            current.EndInclusive = inclusive;
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
