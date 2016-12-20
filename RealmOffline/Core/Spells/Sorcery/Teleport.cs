using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Spells.Sorcery
{
    public class Teleport : Spell
    {
        public Teleport()
            : base(0x0A)
        {
        }
        public override short SpellEffectID
        {
            get
            {
                return 0x22;
            }
        }
        public override Enum SpellSchool
        {
            get
            {
                return BaseSpell.Sorcery.Teleport;
            }
        }
        public override string SpellName
        {
            get
            {
                return "Teleport";
            }
        }
        public override string MagicWords
        {
            get
            {
                return "Elanon sadar!";
            }
        }
        public override string SpellEffectWords
        {
            get
            {
                return "vanishes in a puff of smoke.";
            }
        }
        public override void ApplyEffect(uint caster, uint target)
        {
            // Where da magic happens
            base.ApplyEffect(caster, target);
        }
    }
}
