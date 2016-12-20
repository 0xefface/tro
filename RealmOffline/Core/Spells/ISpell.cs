using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public interface ISpell
    {
        short SpellID { get; set; }
        short SpellEffectID { get; set; }
        string SpellName { get; set; }
        Enum SpellSchool { get; set; }
        string MagicWords { get; set; }
        string SpellEffectWords { get; set; }
        // What does the spell do ?
        void ApplyEffect(uint caster, uint target);
    }
}
