using System.Collections.Generic;

namespace gexf4net.dynamic
{
    public interface Spellable<T> : Dynamic<T>
    {
        List<Spell> getSpells();
    }
}