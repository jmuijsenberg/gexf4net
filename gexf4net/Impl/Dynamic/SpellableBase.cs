using gexf4net.dynamic;
using System.Collections.Generic;

namespace gexf4net.Impl.Dynamic
{

    public abstract class SpellableBase<T> : DynamicBase<T>, Spellable<T>
    {
        private List<Spell> spells = null;

        public SpellableBase()
        {
            spells = new List<Spell>();
        }

        public List<Spell> getSpells()
        {
            return spells;
        }
    }
}