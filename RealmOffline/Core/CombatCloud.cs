using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Base;

namespace RealmOffline.Core
{
    public class CombatCloud : Entity, IDisposable
    {
        /// <summary>
        /// Color invalid for this object
        /// </summary>
        public override ushort Color { get; set; }
        public override uint GameID { get; set; }
        public override ushort GraphicID { get; set; }
        /// <summary>
        /// Name invalid for this object
        /// </summary>
        public override string Name { get; set; }
        public Account CloudOwner { get; set; }
        public List<Mobile> Combatants { get; set; }
        public void AddCombatant(Mobile mob)
        {
            if (this.Combatants == null)
                this.Combatants = new List<Mobile>();
            if (!this.Combatants.Contains(mob)) this.Combatants.Add(mob);
        }
        public void RemoveCombatant(Mobile mob)
        {
            if (this.Combatants == null) return;
            if (this.Combatants.Contains(mob)) this.Combatants.Remove(mob);
        }
        public override byte[] Serialize(out uint itemID)
        {
            itemID = 0;
            if(this.CloudOwner == null)return null;
            if (this.GameID == 0)
            {
                byte[] pak = Packets.Packet.WrapCloud(this.CloudOwner, 1, out itemID);
                this.GameID = itemID;
            }
            return Packets.Packet.WrapCloud(this.CloudOwner, 1, this.GameID);
        }
        public override void Deserialize(byte[] data)
        {
            
        }
        public virtual void Dispose() { }
    }
}
