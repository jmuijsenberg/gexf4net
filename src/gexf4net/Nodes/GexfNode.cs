using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    class GexfNode : IGexfNode
    {
        private GexfSpellList _spells;

        public GexfNode()
        {
            Children = new List<IGexfNode>();
            AttributeValues = new Dictionary<string, string>();
        }

        public string Id { get; set; }
        public string Label { get; set; }
        public IList<IGexfNode> Children { get; }
        public IDictionary<string, string> AttributeValues { get; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }

        public void Add(DateTime additionTime)
        {
            if (_spells == null)
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
