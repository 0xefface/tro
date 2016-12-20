using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Base;
using RealmOffline.Packets;

namespace RealmOffline.Core
{
    public class DebugInfo
    {
        public int RecordID { get; set; }
        public uint AccountID { get; set; }
        public uint CharID { get; set; }
        public string DateTime { get; set; }
        public string Error { get; set; }
        public DebugInfo() { }
        public DebugInfo(Account a, byte[] pak)
        {
            this.AccountID = a.AccountId;
            //this.CharID = a.CurrentCharacter.CharId;
            try
            {
                //PacketReader p = new PacketReader(pak);
                //p.ReadBytes(8);
                
                byte[] data = new byte[pak.Length - 12];
                Array.Copy(pak, 8, data, 0, data.Length);
                this.Error = Encoding.ASCII.GetString(data);
                this.DateTime = System.DateTime.Now.ToString();
            }
            catch { }
        }
    }
}
