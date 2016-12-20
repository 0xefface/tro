using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public abstract class Spell : ISpell
    {
        public virtual short SpellID { get; set; }
        public virtual short SpellEffectID { get; set; }
        public virtual string SpellName { get; set; }
        public virtual Enum SpellSchool { get; set; }
        public virtual string MagicWords { get; set; }
        public virtual string SpellEffectWords { get; set; }
        public Spell() { } // for scripts
        public Spell(short spellID)
        {
            this.SpellID = spellID;
        }
        public virtual void ApplyEffect(uint caster, uint target)
        {
        }
    }
}
