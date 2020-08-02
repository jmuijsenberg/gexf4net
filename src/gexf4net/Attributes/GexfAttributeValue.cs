using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    internal class GexfAttributeValue<OwnerType> : IGexfElement
    {
        private GexfAttribute<OwnerType> _attribute;
        private GexfTimePeriodList _spells;

        public GexfAttributeValue(GexfAttribute<OwnerType> attribute)
        {
            _attribute = attribute;
        }

        public string Value { get; set; }

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

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
        }
    }
}
