using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    class GexfEdge : IGexfEdge
    {
        private GexfSpellList _spells;

        public GexfEdge()
        {
            EdgeType = GexfEdgeType.Undirected;
            Weight = 1.0;
            AttributeValues = new Dictionary<string, string>();
        }

        public string Id { get; set; }
        public GexfEdgeType EdgeType { get; set; }
        public string Label { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public double Weight { get; set; }
        public IDictionary<string, string> AttributeValues { get; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }

        public void Add(DateTime additionTime)
        {
            if (_spells ==null)
            {
                _spells = new GexfSpellList();
            }

            _spells.AddStart(additionTime, true);
        }

        public void Remove(DateTime removalTime)
        {
            if (_spells == null)
            {
                _spells = new GexfSpellList();
            }
            _spells.AddEnd(removalTime, true);
        }

        public bool IsValid(DateTime? dateTime)
        {
            if ((_spells != null) && dateTime.HasValue)
            {
                return _spells.InRange(dateTime.Value);
            }
            else
            {
                return true;
            }
        }
    }
}
