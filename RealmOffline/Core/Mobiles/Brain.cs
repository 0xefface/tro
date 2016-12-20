using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Mobiles
{
    public class Brain: IDisposable
    {
        public Mob Body { get; set; }
        private System.Timers.Timer Synapse { get; set; }
        Random X = new Random();
        Random Y = new Random();
        public Brain(Mob mob)
        {
            this.Body = mob;
            this.Synapse = new System.Timers.Timer();
            this.Synapse.Interval = 5000;//20000;
            this.Synapse.Elapsed += new System.Timers.ElapsedEventHandler(Synapse_Elapsed);
            this.Synapse.Enabled = true;
        }
        protected virtual void Synapse_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Console.WriteLine("Brain tick mob {0}.", this.Body.GameID);
            // 635 x 400
            X = new Random();
            Y = new Random();
            short locx = (short)X.Next(600);
            short locy = (short)Y.Next(400);
            byte[] move = RealmOffline.Packets.RealmPacketIO.MoveEntityTo(new Base.Account(new Tcp.WorldClient(null), 0x00, 0x00), this.Body, this.Body.Location.CurrentRoom, locx, locy);
            this.Body.Location.CurrentRoom.SendMovePacket(move);
            /*
            Packets.PacketWriter w = new Packets.PacketWriter(0x2A);
            w.WriteUInt32(0x00);
            w.WriteUInt32(0x00);
            w.WriteUInt32(this.Body.GameID);
            w.WriteUInt32(this.Body.Location.CurrentRoom.RoomID);
            w.WriteByte(0x00);
            w.WriteShort(locx);
            w.WriteShort(locy);
            w.WriteByte(0x00);
            w.WriteShort(locx);
            w.WriteShort(locy);
           // w.WriteShort(0x02);
            w.WriteByte(0xFF);
            byte[] move = w.ToArray();
           // if(this.Body.Location.CurrentRoom.PlayerCount != 0) // no need to send to a room noone is in.
           // this.Body.Location.CurrentRoom.SendMovePacket(move);
            */


            try
            {
                // Is random so somtimes gets a divide by zero error
                if (locx % locy == 0)
                {
                    byte[] emote = Packets.Packet.EmotePacket(this.Body.GameID, "Wandering Mob", "looks you up and down");
                    this.Body.Location.CurrentRoom.SendPacket(emote, false);
                }
            }
            catch { }
           
        }
        public void MoveTo(short x, short y, short facing = 2)
        {
            Packets.PacketWriter w = new Packets.PacketWriter(0x2A);
            w.WriteUInt32(0x00); // accountid to send to replaced in roommove
            w.WriteUInt32(0x00);
            w.WriteUInt32(this.Body.GameID);
            w.WriteUInt32(this.Body.Location.CurrentRoom.RoomID);
            w.WriteByte(0x00);
            w.WriteShort(x);
            w.WriteShort(y);
            w.WriteByte(0x00);
            w.WriteShort(x);
            w.WriteShort(y); // stop packet no facing
            //w.WriteShort(0x02);
            w.WriteByte(0xFF);
            byte[] move = w.ToArray();
             if(this.Body.Location.CurrentRoom.PlayerCount != 0) // no need to send to a room noone is in.
             this.Body.Location.CurrentRoom.SendMovePacket(move);
        }
        public void Dispose()
        {
            this.Synapse.Enabled = false;
            this.Synapse.Elapsed -= new System.Timers.ElapsedEventHandler(Synapse_Elapsed);
            this.Synapse = null;
        }
    }
}
