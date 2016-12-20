using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Accounts;
using RealmOffline.Base;
using RealmOffline.Core;

namespace RealmOffline.Packets
{
    public class CharacterPacket
    {
        public Character[] Characters { get; set; }
        public Account GameAccount { get; private set; }

        public CharacterPacket(Account account, Character[] characters)
        {
            this.GameAccount = account;
            this.Characters = characters;
        }
        
        #region Packet0x12 (Char Packet)
        public byte[] Packet0x12(Account a)
        {
            PacketWriter w = new PacketWriter(0x12);
            w.WriteUInt32(a.AccountId);
            w.WriteUInt32(0);
            // add chars
            w.WriteByte((byte)this.Characters.Length); // Number of chars 4 max
            // Thats it, just add the char packets
            for (int i = 0; i < this.Characters.Length; i++)
            {
                w.WriteBytes(this.Characters[i].GenerateCharacterPacket());
            }
            w.WriteShort(0x00);
            w.WriteByte(0x20);
            w.WriteByte(0xFF);
            return w.ToArray();
        }
        #endregion
    }
}
