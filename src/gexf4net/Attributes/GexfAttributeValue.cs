using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net
{
    class GexfAttributeValue<OwnerType>
    {
        private GexfAttribute<OwnerType> _attribute;
        private GexfSpellList _spells;

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
    }
}
