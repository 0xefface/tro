using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RealmOffline.Core.Rooms;

namespace RealmOffline.Core
{
    public class RoomLocation
    {
        public uint RoomNumber { get; set; }
        public ushort Facing { get; set; }
        public ushort X { get; private set; }
        public ushort Y { get; private set; }
        public bool IsPopulated { get; private set; }
        public Room CurrentRoom { get; set; }
        Logs.RLog log = new Logs.RLog(Path.Combine(ServerGlobals.BaseDirectory, @"PacketErrors\Error.log"));

        public RoomLocation(uint room, int x, int y, int f)
        {
            this.RoomNumber = room;
            this.Facing = (ushort)f;
            this.X = (ushort)x;
            this.Y = (ushort)y;
            this.IsPopulated = true;
            Room found = null;
            ScriptResolver.ImportedRooms.TryGetRoom(room, out found);
            if (found != null) this.CurrentRoom = found;
        }
        public RoomLocation(byte[] clientPacket41)
        {
            try
            {
                this.PopulateFromArray(clientPacket41);
                this.IsPopulated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Creation "+ex.Message);
                this.IsPopulated = false; 
            }
        }
        public void Repopulate(byte[] pak)
        {
            try
            {
                this.PopulateFromArray(pak);
                this.IsPopulated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Repopulate "+ex.Message);
                this.IsPopulated = false;
            }
        }
        private void PopulateFromArray(byte[] pak)
        {
            /*
             * Other versions of this packet are sent from client, 
             * larger than 10 bytes, but they just contain extra info, so lets just try to parse 
             * out the stuff we need, and if we error, who cares.
             */
            bool handled = false;
            int pckId = 0;
            uint room = 0;
            byte[] payload = Tools.ReadPacket41UntilFF(pak, out pckId, out room);
            if (pckId != 41) throw new ArgumentException(string.Format("Packet 41 Expected, got Packet {0} instead!!", pckId));
            this.RoomNumber = room;

            #region Facing Packet 0x04 (Done)
            if (payload[0] == 0x04)
            {
                #region 8 bytes of data
                // We know what 8 byte packets contain.
                if (payload.Length == 8)
                {
                    if (payload[3] != 0) // This should always be 0, or how we think the packet is, aint..
                    {
                        log.LogMessage(string.Format("Packet 41 error, We assume byte 3 is a 0 spacer, but its value is now {0}!!", 
                            (int)payload[3]), Logs.MessageType.Error);
                    }
                    this.Facing = BitConverter.ToUInt16(payload, 1);
                    this.X = BitConverter.ToUInt16(payload, 4);
                    this.Y = BitConverter.ToUInt16(payload, 6);
                    handled = true;
                }
                else if (payload.Length == 3)
                {
                    // Just a facing update
                    this.Facing = BitConverter.ToUInt16(payload, 1);
                    handled = true;
                }
                #endregion
                else
                {
                    // Just get the facing change, we really do not need all the extra data at this point.
                    // We are not yet sure what the other formats are yet, so lets print them out.
                   this.Facing = BitConverter.ToUInt16(payload, 1);
                    handled = true;
                }
            }
            #endregion

            #region Stop Movement Packet
            if (payload.Length == 10)
            {
                this.X = BitConverter.ToUInt16(payload, 1);
                this.Y = BitConverter.ToUInt16(payload, 3);
                ushort xCheck = BitConverter.ToUInt16(payload, 6);
                ushort yCheck = BitConverter.ToUInt16(payload, 8);
                handled = true;
                if (this.X != xCheck || this.Y != yCheck)
                {
                   // log.LogMessage(string.Format("Packet 41 (Stop Movement) Expected x,y to match, values are X:{0} Y:{1} which does not match X:{2} Y:{3}",
                     //   this.X, this.Y, xCheck, yCheck), Logs.MessageType.Error);
                }
            }
            #region 13 length (Player change move mid move)
            if (payload.Length == 13)
            {
                // we are a move, then face change, then continue move.
                ushort prevX = BitConverter.ToUInt16(payload, 1);
                ushort prevY = BitConverter.ToUInt16(payload, 3);

                if (payload[5] == 0x04)
                {
                    // Face change
                    this.Facing = BitConverter.ToUInt16(payload, 6);
                    // so now we have a spacer, 0x00
                    this.X = BitConverter.ToUInt16(payload, 9);
                    this.Y = BitConverter.ToUInt16(payload, 11);
                }
                if (payload[5] == 0x00)
                {
                    // facing at end, just update that if true, if not no need to worry
                    // client will send good packets before they stop being goofy.
                    if (payload[10] == 0x04)
                    {
                       this.Facing = BitConverter.ToUInt16(payload, 11);
                    }

                }
                handled = true;
            }
            #endregion
            #endregion

            #region UpdateXY Packet

            if (payload.Length == 5)
            {
                this.X = BitConverter.ToUInt16(payload, 1);
                this.Y = BitConverter.ToUInt16(payload, 3);
                handled = true;
            }
            if (payload.Length == 8)
            {
                // Has facing info at end, dunno why
                this.X = BitConverter.ToUInt16(payload, 1);
                this.Y = BitConverter.ToUInt16(payload, 3);
                if (payload[5] == 0x04)
                {
                    this.Facing = BitConverter.ToUInt16(payload, 6);
                }
                handled = true;
            }
            #endregion

            if (payload.Length > 13)
            {
                // Ok so, if player is going zonkers, we really only want the updated facing info
                for (int i = 0; i < payload.Length; i++)
                {
                    if (payload[i] == 0x04)
                    {
                        try
                        {
                            ushort f = BitConverter.ToUInt16(payload, i + 1);

                            if (f < 380) // valid facing
                            {
                               this.Facing = f;
                                handled = true;
                            }
                        }
                        catch { }
                    }
                }
            }
            // If we missed a packet, spill the beans here

            if (!handled)
            {
                // we got all we need, clean this code up for production.
               // log.LogMessage(string.Format("Unknown Packet 41 {0} Length {1}", BitConverter.ToString(payload), payload.Length), Logs.MessageType.Error);
            }
            
        }
        void WriteToConsole(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
