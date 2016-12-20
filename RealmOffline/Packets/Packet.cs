using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Base;
using RealmOffline.Core;
using RealmOffline.Accounts;
using RealmOffline.Core.Rooms;
using RealmOffline.Core.Mobiles;
using RealmOffline.Core.Items.Base;
using System.IO;
using System.Reflection;

namespace RealmOffline.Packets
{
    public enum ServerMessageType
    {
        BottomRight,
        GossipChatUser,
        GossipChatAll,
        Overhead,
        PopUp,
        RoomChat
    }
    public static class Packet
    {
        public static byte[] ListChannels(Account acct)
        {
            PacketWriter writer = new PacketWriter();
            writer.WriteInt32(61);
            writer.WriteUInt32(acct.AccountId); 
            writer.WriteInt32(2); 
            writer.WriteByte(0);
            writer.WriteUShort((ushort)ScriptResolver.ImportedChannels.Count);
            writer.WriteShort(0);
            // Order the channels
            //ScriptResolver.ImportedChannels.OrderChannels();
            for (int i = 0; i < ScriptResolver.ImportedChannels.Count; i++)
            {
                writer.WriteBytes(ScriptResolver.ImportedChannels[i].ChannelNumber.ToLengthPrefixedString());
                writer.WriteBytes(ScriptResolver.ImportedChannels[i].ChannelTitle.ToLengthPrefixedString());
                writer.WriteBytes((ScriptResolver.ImportedChannels[i].IsPublic ? "Yes" : "No").ToLengthPrefixedString());
                writer.WriteBytes(ScriptResolver.ImportedChannels[i].Moderator.ToLengthPrefixedString());
                writer.WriteBytes(ScriptResolver.ImportedChannels[i].CurrentUsers.ToString().ToLengthPrefixedString());
            }
            // end this
            //writer.Writeshort(1);
            //writer.WriteByte(0x30);
            writer.WriteShort(0);
            writer.WriteBytes(new byte[] { 0x78, 0x74, 0x65 });
            return writer.ToArray();
        }
        public static void JoinChannel(int channel, Account account)
        {
            List<byte> builder = new List<byte>();
            switch (channel)
            {
                case 0:
                case 4:
                    {
                        
                        byte[] join = { 0x40, 0x00, 0x00, 0x00, 
                                        0x26, 0x00, 0x00, 0x00, 
                                        0x93, 0x62, 
                                        0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 

                                        0x7C, 0x63, 0x34, 0x33, 0x7C, 0x49, 
                                        0x6E, 0x66, 0x6F, 0x3E, 0x20, 0x59, 
                                        0x6F, 0x75, 0x20, 0x68, 0x61, 0x76, 
                                        0x65, 0x20, 0x6A, 0x6F, 0x69, 0x6E, 
                                        0x65, 0x64, 0x20, 0x63, 0x68, 0x61, 
                                        0x6E, 0x6E, 0x65, 0x6C, 0x20, 0x34, 
                                        0x28, 0x47, 0x61, 0x6D, 0x65, 0x20, 
                                        0x48, 0x65, 0x6C, 0x70, 0x29, 0x2E, 
                                        
                                        0x0A, 0x00, 0x01, 0x01, 
                                        0xB4, 0xE2, 0x9E, 0x82 };
                         
                        //byte[] join = ChatPacket(43, 4, "Joined Channel 4", "Info");
                        
                        account.Socket.Send(ref join);
                        //byte[] topic = { 0x6C, 0x00, 0x00, 0x00, 0x26, 0x00, 0x00, 0x00, 0x93, 0x62, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0x63, 0x34, 0x33, 0x7C, 0x49, 0x6E, 0x66, 0x6F, 0x3E, 0x20, 0x54, 0x6F, 0x70, 0x69, 0x63, 0x3A, 0x20, 0x4F, 0x75, 0x72, 0x20, 0x63, 0x6F, 0x75, 0x72, 0x74, 0x65, 0x6F, 0x75, 0x73, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x68, 0x65, 0x6C, 0x70, 0x66, 0x75, 0x6C, 0x20, 0x47, 0x61, 0x6D, 0x65, 0x20, 0x4D, 0x65, 0x6E, 0x74, 0x6F, 0x72, 0x73, 0x20, 0x77, 0x69, 0x6C, 0x6C, 0x20, 0x61, 0x6E, 0x73, 0x77, 0x65, 0x72, 0x20, 0x67, 0x61, 0x6D, 0x65, 0x20, 0x70, 0x6C, 0x61, 0x79, 0x20, 0x71, 0x75, 0x65, 0x73, 0x74, 0x69, 0x6F, 0x6E, 0x73, 0x20, 0x68, 0x65, 0x72, 0x65, 0x2E, 0x0A, 0x00, 0xB0, 0x34, 0xEA, 0x16 };
                        byte[] topic = { 0x6C, 0x00, 0x00, 0x00, 0x26, 0x00, 0x00, 0x00, 0x93, 0x62, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0x63, 0x34, 0x33, 0x7C, 0x49, 0x6E, 0x66, 0x6F, 0x3E, 0x20, 0x54, 0x6F, 0x70, 0x69, 0x63, 0x3A, 0x20, 0x4F, 0x75, 0x72, 0x20, 0x63, 0x6F, 0x75, 0x72, 0x74, 0x65, 0x6F, 0x75, 0x73, 0x20, 0x61, 0x6E, 0x64, 0x20, 0x68, 0x65, 0x6C, 0x70, 0x66, 0x75, 0x6C, 0x20, 0x47, 0x61, 0x6D, 0x65, 0x20, 0x4D, 0x65, 0x6E, 0x74, 0x6F, 0x72, 0x73, 0x20, 0x77, 0x69, 0x6C, 0x6C, 0x20, 0x61, 0x6E, 0x73, 0x77, 0x65, 0x72, 0x20, 0x67, 0x61, 0x6D, 0x65, 0x20, 0x70, 0x6C, 0x61, 0x79, 0x20, 0x71, 0x75, 0x65, 0x73, 0x74, 0x69, 0x6F, 0x6E, 0x73, 0x20, 0x68, 0x65, 0x72, 0x65, 0x2E, 0x0A, 0x00, 0xB0, 0x35, 0xEA, 0x16 };
                        account.Socket.Send(ref topic);
                        byte[] ok1 = { 0x20, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x93, 0x62, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x5C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                        builder.AddRange(ok1);

                        builder.AddRange(BitConverter.GetBytes(account.CurrentCharacter.Location.CurrentRoom.RoomID));

                        byte[] ok2 = { 0x02, 0x02, 0x2D, 0x01, 0x02, 0x00, 0x02, 0x00, 0xDF, 0xC7, 0xD5, 0xA9 };
                        builder.AddRange(ok2);
                        byte[] finalReply = builder.ToArray();
                        builder.Clear();

                        account.Socket.Send(ref finalReply);
                       // byte[] myinfo = RealmOffline.Packets.RealmPacketIO.BuildGossipPacket(1,
                         //   "Testing colors, try typing /say 10 or any other number!", "Emulator");
                      //  account.Socket.Send(ref myinfo);
                    }
                    break;
            }
        }
        public static byte[] RoomChatMessage(Account account, string message, uint fromID = 0)
        {
            PacketWriter writer = new PacketWriter();
            writer.WriteInt32(38);
            writer.WriteUInt32(account.AccountId);
            writer.WriteUInt32(fromID);
            writer.WriteBytes(Encoding.ASCII.GetBytes(message));
            writer.WriteShort(10);
            writer.WriteByte(0);
            writer.WriteByte(157); // This changes type maybe, this emote ? ?
            return writer.ToArray();
        }
        public static byte[] RoomChatMessage(Account account, string message, ushort chatColor, string from)
        {
            PacketWriter writer = new PacketWriter(38);
            writer.WriteUInt32(account.AccountId);
            writer.WriteUInt32(account.AccountId);
            string msg = string.Format("|c{0}|{1}> {2}", chatColor, from, message);
            writer.WriteBytes(Encoding.ASCII.GetBytes(msg));
            writer.WriteShort(10);
            writer.WriteByte(0);
            writer.WriteByte(0);
            return writer.ToArray();
        }
        public static byte[] ChatPacket(int chatColor, int channel, string message, string from)
        {
            List<byte> builder = new List<byte>();
            byte[] begin = { 0x26, 0x00, 0x00, 0x00, 0x93, 0x62, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00 };
            builder.AddRange(begin);
            builder.Add(0x7C);// |
            builder.AddRange(Encoding.ASCII.GetBytes(channel.ToString()));
            builder.Add(0x7c); // |
            builder.AddRange(Encoding.ASCII.GetBytes(from + ":> "));
            builder.Add(0x7C);// |
            builder.AddRange(Encoding.ASCII.GetBytes(chatColor.ToString()));
            builder.Add(0x7c); // |
            builder.AddRange(Encoding.ASCII.GetBytes(message));
            byte[] payload = builder.ToArray();
            builder.Clear();
            builder.AddRange(BitConverter.GetBytes(payload.Length));
            builder.AddRange(payload);
            builder.AddRange(new byte[4]);
            return builder.ToArray();
        }
        public static byte[] EmotePacket(uint fromChar, string from, string emote)
        {
            PacketWriter w = new PacketWriter(0x26);
            w.WriteUInt32(0x00); // no account set in room
            w.WriteUInt32(fromChar);
            w.WriteString(string.Format("{0} {1}.", from, emote), false);
            w.WriteShort(0xA);
            return w.ToArray();
        }
        public static byte[] ReplyWith26(uint toAccountID, int toPacketID, byte[] data)
        {
            PacketWriter writer = new PacketWriter(26);
            writer.WriteUInt32(toAccountID);
            writer.WriteInt32(0);
            writer.WriteInt32(toPacketID);
            writer.WriteBytes(data);
            return writer.ToArray();
        }
        public static byte[] ReplyWith25(uint toAccountID, int toPacketID, byte[] data)
        {
            PacketWriter writer = new PacketWriter(25);
            writer.WriteUInt32(toAccountID);
            writer.WriteInt32(0);
            writer.WriteInt32(toPacketID);
            writer.WriteBytes(data);
            return writer.ToRealmPacket();
        }
      
        public static byte[] OpenDoor42(Account acct, uint doorId)
        {
            PacketWriter writer = new PacketWriter(42);
            writer.WriteUInt32(acct.AccountId);
            writer.WriteInt32(0x00);
            writer.WriteUInt32(acct.CurrentCharacter.GameID);
            // I do not know what this is
            writer.WriteUInt32(acct.CurrentCharacter.Location.CurrentRoom.RoomID);
            // 4 spins you in a circle non stop heee!
            // 5, 6, 7, 8 nothing
            // 9 crashed me A crashed and B nothing
            // C crsh
            writer.WriteByte(0x0A);// or A ?
            writer.WriteUInt32(acct.CurrentCharacter.GameID);
            // the door id
            writer.WriteUInt32(doorId);
            // no clue here
            writer.WriteBytes(new byte[] {0x21, 0xFF, 0x00 });
            return writer.ToArray();

        }
        public static byte[] TeleportRequest(Account acct, Room room)
        {
            uint priorRoom = acct.CurrentCharacter.Location.CurrentRoom.RoomID;
            //Room priorRoom = acct.CurrentCharacter.Location.CurrentRoom;
            try
            {
                // Go ahead and set it all up
                acct.CurrentCharacter.Location.CurrentRoom.RemoveEntity(acct.CurrentCharacter, acct);
                room.AddEntity(acct.CurrentCharacter, acct);
                acct.CurrentCharacter.Location.CurrentRoom = room;
            }
            catch (Exception ex) { Console.WriteLine("Teleport Error! {0} : {1}", ex.Message, ex.StackTrace); return new byte[0]; }
            PacketWriter writer = new PacketWriter(0x2A);
            writer.WriteUInt32(acct.AccountId);
            writer.WriteUInt32(0x00);
            writer.WriteUInt32(acct.CurrentCharacter.GameID); // char seeing this
            // what room are we comming from ?
            writer.WriteUInt32(priorRoom); // from room
            writer.WriteByte(0x2A);
            writer.WriteUInt32(acct.CurrentCharacter.GameID); // char going through it
            writer.WriteUInt32(acct.CurrentCharacter.GameID); // char going hrough it
            // what room we want to goto ?
            writer.WriteUInt32(room.RoomID); // the room to goto
            writer.WriteByte(0xFF);
            return writer.ToArray();
        }
        public static byte[] GossipMessage(Account toAccount, string from, Channel channel, byte[] message, ushort color = 103)
        {
            PacketWriter writer = new PacketWriter(38);
            writer.WriteUInt32(toAccount.AccountId);
            writer.WriteInt32(0);
            writer.WriteString("|c", false);
            writer.WriteString(channel.ChannelNumber, false);
            writer.WriteString("|", false);
            writer.WriteString(channel.ChannelTitle, false);
            writer.WriteString(">|c", false);
            // here is the persons color they use in chat
            writer.WriteString(color.ToString(), false);
            writer.WriteString("|", false);
            // name
            writer.WriteString(from, false);
            writer.WriteString(": ", false);
            writer.WriteBytes(message);
            writer.WriteBytes(new byte[] { 0x0A, 0x00, 0x14, 0x75, 0x03 });
            return writer.ToArray();
        }
        public static byte[] GossipMessage(Account toAccount, string from, Channel channel, string message, ushort color = 103)
        {
            PacketWriter writer = new PacketWriter(38);
            writer.WriteUInt32(toAccount.AccountId);
            writer.WriteInt32(0);
            writer.WriteString("|c", false);
            writer.WriteString(channel.ChannelNumber, false);
            writer.WriteString("|", false);
            writer.WriteString(channel.ChannelTitle, false);
            writer.WriteString(">|c", false);
            // here is the persons color they use in chat
            writer.WriteString(color.ToString(), false);
            writer.WriteString("|", false);
            // name
            writer.WriteString(from, false);
            writer.WriteString(": ", false);
            writer.WriteString(message, false);
            writer.WriteBytes(new byte[] { 0x0A, 0x00, 0x14, 0x75, 0x03 });
            return writer.ToArray();
        }
        public static byte[] GossipMessage(Account fromAccount, byte[] message, ushort color = 103)
        {
            PacketWriter writer = new PacketWriter(38);
            writer.WriteUInt32(fromAccount.AccountId);
            writer.WriteInt32(0);
            writer.WriteString("|c", false);
            writer.WriteString(fromAccount.CurrentChannel.ChannelNumber, false);
            writer.WriteString("|", false);
            writer.WriteString(fromAccount.CurrentChannel.ChannelTitle, false);
            writer.WriteString(">|c", false);
            // here is the persons color they use in chat
            writer.WriteString(color.ToString(), false);
            writer.WriteString("|", false);
            // name
            writer.WriteString(fromAccount.CurrentCharacter.Name, false);
            writer.WriteString(": ", false);
            writer.WriteBytes(message);
            writer.WriteBytes(new byte[] { 0x0A, 0x00, 0x14, 0x75, 0x03 });
            return writer.ToArray();
        }
        public static byte[] GossipMessage(Account fromAccount, string message, ushort color = 103)
        {
            PacketWriter writer = new PacketWriter(38);
            writer.WriteUInt32(fromAccount.AccountId);
            writer.WriteInt32(0);
            writer.WriteString("|c", false);
            writer.WriteString(fromAccount.CurrentChannel.ChannelNumber, false);
            writer.WriteString("|", false);
            writer.WriteString(fromAccount.CurrentChannel.ChannelTitle, false);
            writer.WriteString(">|c", false);
            // here is the persons color they use in chat
            writer.WriteString(color.ToString(), false);
            writer.WriteString("|", false);
            // name
            writer.WriteString(fromAccount.CurrentCharacter.Name, false);
            writer.WriteString(": ", false);
            writer.WriteString(message, false);
            writer.WriteBytes(new byte[] { 0x0A, 0x00, 0x14, 0x75, 0x03 });
            return writer.ToArray();
        }
        public static byte[] DropItemInRoom(Account acct, uint itemID)
        {
            PacketWriter writer = new PacketWriter(42);
            writer.WriteUInt32(acct.AccountId);
            writer.WriteUInt32(0);
            writer.WriteUInt32(acct.CurrentCharacter.GameID);
            writer.WriteUInt32(acct.CurrentCharacter.Location.CurrentRoom.RoomID);
            writer.WriteByte(0x06);
            writer.WriteUInt32(acct.CurrentCharacter.GameID);
            writer.WriteUInt32(itemID);
            writer.WriteBytes(new byte[] { 0x21, 0xFF, 0x00 });
            return writer.ToArray();
        }
        public static byte[] PickupItemInRoom(Account acct, uint itemID)
        {
            PacketWriter writer = new PacketWriter(42);
            writer.WriteUInt32(acct.AccountId);
            writer.WriteUInt32(0);
            writer.WriteUInt32(acct.CurrentCharacter.GameID);
            writer.WriteUInt32(acct.CurrentCharacter.Location.CurrentRoom.RoomID);
            //writer.WriteByte(0x05);
            writer.WriteBytes(new byte[] { 0x04, 0x00, 0x00, 0x05 });
            writer.WriteUInt32(acct.CurrentCharacter.GameID);
            writer.WriteUInt32(itemID);
            writer.WriteBytes(new byte[] { 0x21, 0xFF, 0x00, 0xFF });
            return writer.ToArray();
        }
        public static byte[] ServerMessage(ServerMessageType type, string message)
        {
            return null;
        }
        public static byte[] ServerMessage(ServerMessageType type, byte[] message)
        {
            return null;
        }
        public static byte[] GoodLogon(Account acct)
        {
            PacketWriter w = new PacketWriter(0x0E);
            w.WriteUInt32(acct.AccountId);
            w.WriteUInt32(0);
            w.WriteUInt32(acct.AccountId);
            w.WriteInt32(1);
            w.WriteUInt32(0);
            w.WriteBytes(new byte[] { 0x00, 0x00, 0x5E, 0x01 }); // last 2 bytes change, dunno why
            return w.ToArray();
        }
        public static byte[] BadLogon(string message)
        {
            byte[] msg = null;
            try
            {
                msg = Encoding.ASCII.GetBytes(message);
            }
            catch { msg = Encoding.ASCII.GetBytes("Invalid Username or Password, please try again."); }

            PacketWriter w = new PacketWriter(0x0E);
            w.WriteInt32(-1);
            w.WriteInt32(0);
            w.WriteInt32(-1);
            w.WriteInt32(2);
            w.WriteByte(0x00);
            w.WriteShort((short)msg.Length);
            w.WriteBytes(msg);
            w.WriteShort(0);
            w.WriteByte(0x12);
            return w.ToArray();
        }
       /* public static byte[] EnterDunRoom(ushort accountID, out int roomNum)
        {
            byte[] reply = { 0x74, 0x01, 0x00, 0x00, 
                             0x21, 0x00, 0x00, 0x00, 
                             0xD1, 0x33, 
                             0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 
                             0x01, 
                             0x0F, 0x00, 
                             0x53, 0x6F, 0x75, 0x74, 0x68, 0x20, 0x48, 0x61, 0x76, 0x65, 0x6E, 0x77, 0x6F, 0x6F, 0x64, 
                             
                             0x00, 0x1D, 
                             0xCE, 0x0F, 0x00, 0x00, 
                             0xB8, 0x0B, 0x00, 0x0F, 0x00, 0x07, 0x25, 0xB6, 0x0A, 0x6B, 0x00, 0x6F, 0x00, 0x00, 0x00, 0xB6, 0x0A, 0x38, 0x02, 0x7C, 0x00, 0x00, 0x00, 0x30, 0x00, 0x81, 0x01, 0x0A, 0x01, 0x00, 0x00, 0x30, 0x00, 0x58, 0x01, 0x0F, 0x01, 0x00, 0x00, 0x30, 0x00, 0xC0, 0x01, 0x0D, 0x01, 0x00, 0x00, 0x31, 0x00, 0xF9, 0x00, 0xB9, 0x00, 0x00, 0x00, 0x72, 0x00, 0x80, 0x01, 0x13, 0x01, 0x00, 0x00, 0x71, 0x00, 0x93, 0x00, 0xB8, 0x00, 0x00, 0x00, 0xAF, 0x80, 0xB7, 0x01, 0x6A, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x59, 0x02, 0x8A, 0x00, 0x00, 0x00, 0x70, 0x00, 0xBF, 0x00, 0xB7, 0x00, 0x00, 0x00, 0x70, 0x00, 0xEE, 0x00, 0xBA, 0x00, 0x00, 0x00, 0x70, 0x00, 0xCD, 0x01, 0x13, 0x01, 0x00, 0x00, 0x87, 0x0B, 0x9D, 0x01, 0x11, 0x01, 0x00, 0x00, 0x9A, 0x00, 0x33, 0x00, 0x77, 0x00, 0x00, 0x00, 0x9A, 0x00, 0xC8, 0x01, 0x80, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x16, 0x02, 0x87, 0x00, 0x00, 0x00, 0x98, 0x00, 0x7D, 0x00, 0x7C, 0x00, 0x00, 0x00, 0xC6, 0x04, 0xBF, 0x00, 0xC0, 0x00, 0x00, 0x00, 0xC6, 0x04, 0x72, 0x01, 0x09, 0x01, 0x00, 0x00, 0x05, 0x00, 0xEC, 0x01, 0x87, 0x00, 0x00, 0x00, 0x05, 0x00, 0x04, 0x02, 0x87, 0x00, 0x00, 0x00, 0x05, 0x00, 0x1C, 0x02, 0x87, 0x00, 0x00, 0x00, 0x05, 0x00, 0x33, 0x02, 0x87, 0x00, 0x00, 0x00, 0x05, 0x00, 0x47, 0x02, 0x8B, 0x00, 0x00, 0x00, 0x05, 0x00, 0x5F, 0x02, 0x8B, 0x00, 0x00, 0x00, 0x05, 0x00, 0x6F, 0x02, 0x8B, 0x00, 0x00, 0x00, 0x05, 0x00, 0x9E, 0x00, 0x7C, 0x00, 0x00, 0x00, 0x05, 0x00, 0x87, 0x00, 0x7C, 0x00, 0x00, 0x00, 0x05, 0x00, 0x6F, 0x00, 0x7C, 0x00, 0x00, 0x00, 0x05, 0x00, 0x5A, 0x00, 0x7C, 0x00, 0x00, 0x00, 0x05, 0x00, 0x44, 0x00, 0x77, 0x00, 0x00, 0x00, 0x05, 0x00, 0x2C, 0x00, 0x77, 0x00, 0x00, 0x00, 0x05, 0x00, 0x14, 0x00, 0x77, 0x00, 0x00, 0x00, 0x72, 0x00, 0x95, 0x00, 0x0D, 0x01, 0x00, 0x00, 0x70, 0x00, 0xC9, 0x00, 0x0C, 0x01, 0x00, 0x00, 0x72, 0x00, 0xF2, 0x00, 0x00, 0x01, 0x00, 0x00, 0x01, 0x00, 0x01, 0xB6, 0x07, 0xC2, 0x53, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xCE, 0x0F, 0xBB, 0x00, 0x0A, 0x01, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x65, 0x22, 0x9C, 0x99, 0x57 };
            byte[] acctid = BitConverter.GetBytes(accountID);
            reply[8] = acctid[0];
            reply[9] = acctid[1];
            roomNum = 4046;
            return reply;
        } */
        public static void RemoveObjectFromCurrentRoom(Account acct, int objId)
        {
            // Working for players
            int room = (int)acct.CurrentCharacter.Location.CurrentRoom.RoomID;
            PacketWriter w = new PacketWriter(0x2D);
            w.WriteUInt32(acct.AccountId);
            w.WriteInt32(0);
            w.WriteInt32(room); // Room to remove from
            w.WriteInt32(objId); // obj to remove
            w.WriteBytes(new byte[] { 0x00, 0x15, 0x00, 0x69 });
            byte[] rem = w.ToArray();
            acct.Socket.Send(ref rem);
        }
        public static byte[] ServerMessageBottom(Account acct, string message)
        {
            PacketWriter w = new PacketWriter(0x51);
            w.WriteUInt32(acct.AccountId);
            w.WriteInt32(0);
            w.WriteBytes(Encoding.ASCII.GetBytes(message));

            return w.ToArray();
        }
        public static byte[] P42(Account acct)
        {
            // So far the known format of the most used packet id 42
            PacketWriter w = new PacketWriter(0x2A);

            return w.ToArray();
        }
        public static byte[] Pickup(Account acct)
        {
            // Test packet 25 pick up item
            PacketWriter w = new PacketWriter(0x19);
            w.WriteUInt32(acct.AccountId);
            w.WriteInt32(0);
            w.WriteInt32(0x96);
            w.WriteInt32(0);
            return w.ToArray();
        }
        public static byte[] NPCDialog(Account acct)
        {
            PacketWriter w = new PacketWriter(0x19);
            w.WriteUInt32(acct.AccountId);
            w.WriteInt32(0);
            w.WriteInt32(0x68);
            w.WriteInt32(0);
            // Topic
            w.WriteString("What the fucko Chucko !!");
            // How many Questions ?
            w.WriteByte(0x03); // 1 fo now
            w.WriteByte(0x01); // 1 for show question, 0 for no
            w.WriteString("Man i gots a question jack.");
            w.WriteByte(0x01);
            w.WriteString("Do you sometimes poop yellow ?");
            w.WriteByte(0x01);
            w.WriteString("Are Umbrella's Sexual toys ?");
            w.WriteBytes(new byte[] { 0x00, 0x00, 0x00, 0x42 }); // end
            return w.ToArray();
        }
        public static byte[] GeneratePacket18(Account acct)
        {
            PacketWriter w = new PacketWriter(0x12);
            w.WriteUInt32(acct.AccountId);
            w.WriteUInt32(0);
            // Start chars
            w.WriteShort(0);
            w.WriteBytes(new byte[] { 0x6A, 0x3F }); // End
            return w.ToArray();
        }
        public static byte[] CreateItem(Account acct, ushort itemGraphicId, ushort color, string name = "")
        {
            PacketWriter w = new PacketWriter();
            w.WriteByte(1);
            w.WriteUShort(itemGraphicId);
            uint id = ServerGlobals.GetNextAvailableID();
            w.WriteUInt32(id);
            ServerGlobals.CharacterIDsInUse.Add(id);
            
            w.WriteUShort(color);
            if (name != "")
            {
                w.WriteByte(1);
                w.WriteString(name);
                w.WriteByte(0x4A);
                w.WriteByte(0xFF);
            }
            else w.WriteBytes(new byte[] { 0x00, 0xFF });

            w.WriteShort(0);
            w.WriteByte(1);
            w.WriteByte(0); // not equiped
            w.WriteShort(0);
            w.WriteUInt32(0);
            return w.ToArray();
        }
        public static void EquipItem(Account acct, Item item)
        {
            // Starts with packet 25
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(acct.AccountId);
            w25.WriteUInt32(0);
            w25.WriteUInt32(0x99);
            w25.WriteBytes(new byte[] { 0x65, 0x25, 0x05, 0x08 });
            byte[] p25 = w25.ToArray();
            acct.Socket.Send(ref p25);

            PacketWriter w42 = new PacketWriter(0x2A);
            w42.WriteUInt32(acct.AccountId);
            w42.WriteInt32(0);
            w42.WriteUInt32(acct.CurrentCharacter.GameID);
            w42.WriteUInt32(acct.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42.WriteByte(0x07);
            w42.WriteUInt32(acct.CurrentCharacter.GameID);
            w42.WriteUInt32(item.GameID);
            w42.WriteByte(0x2F);
            w42.WriteUInt32(acct.CurrentCharacter.GameID);
            w42.WriteUInt32(acct.CurrentCharacter.GameID);

            // These are item stats  ? figure them out
            //w42.WriteBytes(new byte[] { 0x2D, 0x00, 0x00, 0x00, 0x21, 0xFF });
            // sets max hp, use the chars current if no change
            w42.WriteUInt32((uint)acct.CurrentCharacter.TotalHP);

            w42.WriteBytes(new byte[] { 0x21, 0xFF });
            //w42.WriteBytes(new byte[] { 0x00, 0x12 }); // not sure
            //w42.WriteBytes(new byte[] { 0xA1, 0xF3 });
            w42.WriteBytes(new byte[4]);
            byte[] p42 = w42.ToArray();

            item.Equipped = true;
            // Try to actually equip it via sql
            //bool equip = item.Equip(acct);
           // Console.WriteLine("Equip = {0}", equip ? "True" : "False");
            acct.Socket.Send(ref p42);

        }
        public static void UnequipItem(Account acct, Item item)
        {
            // Starts with packet 25
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(acct.AccountId);
            w25.WriteUInt32(0);
            w25.WriteUInt32(0x9A);
            w25.WriteBytes(new byte[] { 0x65, 0x25, 0x05, 0x08 });
            byte[] p25 = w25.ToArray();
            acct.Socket.Send(ref p25);

            // Need to send the to everyone in room
            PacketWriter w42 = new PacketWriter(0x2A);
            w42.WriteUInt32(acct.AccountId);
            w42.WriteInt32(0);
            w42.WriteUInt32(acct.CurrentCharacter.GameID);
            w42.WriteUInt32(acct.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42.WriteByte(0x08);
            w42.WriteUInt32(acct.CurrentCharacter.GameID);
            w42.WriteUInt32(item.GameID);
            w42.WriteByte(0x2F);
            w42.WriteUInt32(acct.CurrentCharacter.GameID);
            w42.WriteUInt32(acct.CurrentCharacter.GameID);

            // These are item stats  ? figure them out
            //w42.WriteBytes(new byte[] { 0x2D, 0x00, 0x00, 0x00, 0x21, 0xFF });
            // sets max hp, use the chars current if no change
            w42.WriteUInt32((uint)acct.CurrentCharacter.TotalHP);

            w42.WriteBytes(new byte[] { 0x21, 0xFF });
            //w42.WriteBytes(new byte[] { 0x00, 0x00 }); // not sure
            //w42.WriteBytes(new byte[] { 0x00, 0x6A });
            w42.WriteBytes(new byte[4]);
            byte[] p42 = w42.ToArray();
            item.Equipped = false;
            //bool un = Managers.MySqlManager.EquipItem(acct.CurrentCharacter.SqlCharId, item.CurrentGameID, true);
           // if (!un) Console.WriteLine("Failed to unequip");
            acct.Socket.Send(ref p42);


        }
        public static byte[] DD(Account acct)
        {
            PacketWriter w = new PacketWriter(0x19);
            w.WriteUInt32(acct.AccountId);
            w.WriteUInt32(0);
            w.WriteUInt32(0x47);
            w.WriteUInt32(0);
            byte[] a = {
                           0x02, 0x00, 0x00, 0x01, 
0xFF, 0xFF, 0x00, 0x00, 
0x00, 0x00, 0x00, 0x00, 

0x12, 0x00, 0x47, 0x65, 0x6E, 0x65, 0x72, 0x69, 0x63, 0x20, 0x53, 0x68, 0x6F, 0x70, 0x6B, 0x65, 0x65, 0x70, 0x65, 0x72, 0x05, 0x00, 0x01, 0x8B, 0xC7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x07, 0x00, 0x44, 0x61, 0x67, 0x67, 0x65, 0x72, 0x73, 0x05, 0x00, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0x32, 0x00, 0x00, 0x00, 0x18, 0x00, 0x46, 0x61, 0x6D, 0x69, 0x6C, 0x69, 0x61, 0x72, 0x69, 0x74, 0x79, 0x20, 0x77, 0x69, 0x74, 0x68, 0x20, 0x44, 0x61, 0x67, 0x67, 0x65, 0x72, 0x73, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xC8, 0x00, 0x00, 0x00, 0x12, 0x00, 0x44, 0x61, 0x67, 0x67, 0x65, 0x72, 0x20, 0x50, 0x72, 0x6F, 0x66, 0x69, 0x63, 0x69, 0x65, 0x6E, 0x63, 0x79, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0x90, 0x01, 0x00, 0x00, 0x16, 0x00, 0x45, 0x78, 0x70, 0x65, 0x72, 0x74, 0x69, 0x73, 0x65, 0x20, 0x77, 0x69, 0x74, 0x68, 0x20, 0x44, 0x61, 0x67, 0x67, 0x65, 0x72, 0x73, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xEE, 0x02, 0x00, 0x00, 0x0E, 0x00, 0x44, 0x61, 0x67, 0x67, 0x65, 0x72, 0x20, 0x4D, 0x61, 0x73, 0x74, 0x65, 0x72, 0x79, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xE8, 0x03, 0x00, 0x00, 0x14, 0x00, 0x44, 0x61, 0x67, 0x67, 0x65, 0x72, 0x20, 0x47, 0x72, 0x61, 0x6E, 0x64, 0x2D, 0x4D, 0x61, 0x73, 0x74, 0x65, 0x72, 0x79, 0x01, 0x8B, 0xC7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0C, 0x00, 0x53, 0x68, 0x6F, 0x72, 0x74, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x73, 0x05, 0x00, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0x32, 0x00, 0x00, 0x00, 0x1D, 0x00, 0x46, 0x61, 0x6D, 0x69, 0x6C, 0x69, 0x61, 0x72, 0x69, 0x74, 0x79, 0x20, 0x77, 0x69, 0x74, 0x68, 0x20, 0x53, 0x68, 0x6F, 0x72, 0x74, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x73, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xC8, 0x00, 0x00, 0x00, 0x17, 0x00, 0x53, 0x68, 0x6F, 0x72, 0x74, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x20, 0x50, 0x72, 0x6F, 0x66, 0x69, 0x63, 0x69, 0x65, 0x6E, 0x63, 0x79, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0x90, 0x01, 0x00, 0x00, 0x15, 0x00, 0x53, 0x68, 0x6F, 0x72, 0x74, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x20, 0x45, 0x78, 0x70, 0x65, 0x72, 0x74, 0x69, 0x73, 0x65, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xEE, 0x02, 0x00, 0x00, 0x21, 0x00, 0x54, 0x68, 0x65, 0x20, 0x4D, 0x61, 0x73, 0x74, 0x65, 0x72, 0x27, 0x73, 0x20, 0x42, 0x6F, 0x6F, 0x6B, 0x20, 0x6F, 0x66, 0x20, 0x53, 0x68, 0x6F, 0x72, 0x74, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x73, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xE8, 0x03, 0x00, 0x00, 0x19, 0x00, 0x53, 0x68, 0x6F, 0x72, 0x74, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x20, 0x47, 0x72, 0x61, 0x6E, 0x64, 0x2D, 0x4D, 0x61, 0x73, 0x74, 0x65, 0x72, 0x79, 0x01, 0x8B, 0xC7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0B, 0x00, 0x4C, 0x6F, 0x6E, 0x67, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x73, 0x05, 0x00, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0x32, 0x00, 0x00, 0x00, 0x1C, 0x00, 0x46, 0x61, 0x6D, 0x69, 0x6C, 0x69, 0x61, 0x72, 0x69, 0x74, 0x79, 0x20, 0x77, 0x69, 0x74, 0x68, 0x20, 0x4C, 0x6F, 0x6E, 0x67, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x73, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xC8, 0x00, 0x00, 0x00, 0x16, 0x00, 0x4C, 0x6F, 0x6E, 0x67, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x20, 0x50, 0x72, 0x6F, 0x66, 0x69, 0x63, 0x69, 0x65, 0x6E, 0x63, 0x79, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0x90, 0x01, 0x00, 0x00, 0x1A, 0x00, 0x45, 0x78, 0x70, 0x65, 0x72, 0x74, 0x69, 0x73, 0x65, 0x20, 0x77, 0x69, 0x74, 0x68, 0x20, 0x4C, 0x6F, 0x6E, 0x67, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x73, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xEE, 0x02, 0x00, 0x00, 0x12, 0x00, 0x4C, 0x6F, 0x6E, 0x67, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x20, 0x4D, 0x61, 0x73, 0x74, 0x65, 0x72, 0x79, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xE8, 0x03, 0x00, 0x00, 0x18, 0x00, 0x4C, 0x6F, 0x6E, 0x67, 0x20, 0x53, 0x77, 0x6F, 0x72, 0x64, 0x20, 0x47, 0x72, 0x61, 0x6E, 0x64, 0x2D, 0x4D, 0x61, 0x73, 0x74, 0x65, 0x72, 0x79, 0x01, 0x8B, 0xC7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00, 0x54, 0x68, 0x72, 0x6F, 0x77, 0x69, 0x6E, 0x67, 0x20, 0x57, 0x65, 0x61, 0x70, 0x6F, 0x6E, 0x73, 0x05, 0x00, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0x32, 0x00, 0x00, 0x00, 0x21, 0x00, 0x46, 0x61, 0x6D, 0x69, 0x6C, 0x69, 0x61, 0x72, 0x69, 0x74, 0x79, 0x20, 0x77, 0x69, 0x74, 0x68, 0x20, 0x54, 0x68, 0x72, 0x6F, 0x77, 0x69, 0x6E, 0x67, 0x20, 0x57, 0x65, 0x61, 0x70, 0x6F, 0x6E, 0x73, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xC8, 0x00, 0x00, 0x00, 0x1B, 0x00, 0x54, 0x68, 0x72, 0x6F, 0x77, 0x69, 0x6E, 0x67, 0x20, 0x57, 0x65, 0x61, 0x70, 0x6F, 0x6E, 0x20, 0x50, 0x72, 0x6F, 0x66, 0x69, 0x63, 0x69, 0x65, 0x6E, 0x63, 0x79, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0x90, 0x01, 0x00, 0x00, 0x1F, 0x00, 0x45, 0x78, 0x70, 0x65, 0x72, 0x74, 0x69, 0x73, 0x65, 0x20, 0x77, 0x69, 0x74, 0x68, 0x20, 0x54, 0x68, 0x72, 0x6F, 0x77, 0x69, 0x6E, 0x67, 0x20, 0x57, 0x65, 0x61, 0x70, 0x6F, 0x6E, 0x73, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xEE, 0x02, 0x00, 0x00, 0x17, 0x00, 0x54, 0x68, 0x72, 0x6F, 0x77, 0x69, 0x6E, 0x67, 0x20, 0x57, 0x65, 0x61, 0x70, 0x6F, 0x6E, 0x20, 0x4D, 0x61, 0x73, 0x74, 0x65, 0x72, 0x79, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xE8, 0x03, 0x00, 0x00, 0x1D, 0x00, 0x54, 0x68, 0x72, 0x6F, 0x77, 0x69, 0x6E, 0x67, 0x20, 0x57, 0x65, 0x61, 0x70, 0x6F, 0x6E, 0x20, 0x47, 0x72, 0x61, 0x6E, 0x64, 0x2D, 0x4D, 0x61, 0x73, 0x74, 0x65, 0x72, 0x79, 0x01, 0x8B, 0xC7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0C, 0x00, 0x53, 0x68, 0x69, 0x65, 0x6C, 0x64, 0x20, 0x55, 0x73, 0x61, 0x67, 0x65, 0x05, 0x00, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0x32, 0x00, 0x00, 0x00, 0x1A, 0x00, 0x54, 0x68, 0x65, 0x20, 0x42, 0x61, 0x73, 0x69, 0x63, 0x73, 0x20, 0x6F, 0x66, 0x20, 0x53, 0x68, 0x69, 0x65, 0x6C, 0x64, 0x20, 0x55, 0x73, 0x61, 0x67, 0x65, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xC8, 0x00, 0x00, 0x00, 0x1D, 0x00, 0x50, 0x72, 0x6F, 0x66, 0x69, 0x63, 0x69, 0x65, 0x6E, 0x63, 0x69, 0x65, 0x73, 0x20, 0x69, 0x6E, 0x20, 0x53, 0x68, 0x69, 0x65, 0x6C, 0x64, 0x20, 0x55, 0x73, 0x61, 0x67, 0x65, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0x90, 0x01, 0x00, 0x00, 0x26, 0x00, 0x55, 0x73, 0x69, 0x6E, 0x67, 0x20, 0x59, 0x6F, 0x75, 0x72, 0x20, 0x53, 0x68, 0x69, 0x65, 0x6C, 0x64, 0x3A, 0x20, 0x41, 0x6E, 0x20, 0x45, 0x78, 0x70, 0x65, 0x72, 0x74, 0x20, 0x44, 0x69, 0x73, 0x63, 0x6F, 0x75, 0x72, 0x73, 0x65, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xEE, 0x02, 0x00, 0x00, 0x14, 0x00, 0x4D, 0x61, 0x73, 0x74, 0x65, 0x72, 0x69, 0x6E, 0x67, 0x20, 0x74, 0x68, 0x65, 0x20, 0x53, 0x68, 0x69, 0x65, 0x6C, 0x64, 0x02, 0xEF, 0xC7, 0x53, 0xFF, 0xE8, 0x03, 0x00, 0x00, 

0x22, 0x00, 0x53, 0x68, 0x69, 0x65, 0x6C, 0x64, 0x73, 0x3A, 0x20, 0x44, 0x65, 0x66, 0x65, 0x6E, 0x73, 0x65, 0x20, 0x62, 0x79, 0x20, 0x61, 0x20, 0x47, 0x72, 0x61, 0x6E, 0x64, 0x2D, 0x4D, 0x61, 0x73, 0x74, 0x65, 0x72, 

0xCB, 
/*
 * All prices
 * 50
 * 200
 * 400
 * 750
 * 1000
 * Daggers
 * Short Swords
 * Long Swords
 * Throwing Weapons
 * Shield Usage
*/
0x05, 0x00,  // 5 total selections ?
0x00, 
0x05, 0x00,  // 5 items in first yes.
0x05, 0x00,  // 5 items in second yes
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x05, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x05, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00,
0x0A, 0x00, 
0x0A, 0x00, 
0x05, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x05, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 
0x0A, 0x00, 

0x00};
            w.WriteBytes(a);
            return w.ToArray();
        }
        public static byte[] RoomChatPacket(Account speaker, uint toPlayerID, byte[] chatData)
        {
            PacketWriter w = new PacketWriter(0x26);
            w.WriteUInt32(toPlayerID);
            w.WriteUInt32(speaker.AccountId);
            byte[] name = Encoding.ASCII.GetBytes(string.Format("{0}:",speaker.CurrentCharacter.Name));
            w.WriteBytes(name);
            w.WriteBytes(chatData);
            w.WriteShort(0x0A);
            w.WriteUInt32(0);
            return w.ToArray();
        }
        public static byte[] CreateCharacterRoomPacket(Account toSendTo, Character charToUpdate)
        {
            // Adds to exisiting room, not on room load
            PacketWriter w = new PacketWriter(0x2A);
            w.WriteUInt32(toSendTo.AccountId);
            w.WriteUInt32(0);
            w.WriteBytes(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
            w.WriteUInt32(toSendTo.CurrentCharacter.Location.RoomNumber);
            w.WriteBytes(charToUpdate.GetAppearance(toSendTo.CurrentCharacter.Location.RoomNumber));
            w.WriteBytes(new byte[3]);
            w.WriteByte(0xFF);

            return w.ToArray();
        }
        public static byte[] TopicPopup(Account toSendTo, string topic, string message)
        {
            PacketWriter w = new PacketWriter(0x18);
            w.WriteUInt32(toSendTo.AccountId);
            w.WriteUInt32(0x00);
            w.WriteString(topic);
            w.WriteString(message);
            w.WriteByte(0x2E);
            return w.ToArray();
        }
        /*
        /// <summary>
        /// Wraps a mob to place in packet 42
        /// for adding to screen
        /// </summary>
        /// <param name="mob"></param>
        /// <returns></returns>
        public static byte[] WrappedMob(Mobile mob)
        {
            PacketWriter e = new PacketWriter();

            // if(mob is NPC) e.WriteBytes(mob.Serialize());

            //else 
            e.WriteBytes(mob.AppearInRoom());
            
            byte[] ew = e.GetRawPacket();
            PacketWriter wrap = new PacketWriter();
            wrap.WriteShort((short)ew.Length);
            wrap.WriteUInt32(mob.GameID);
            wrap.WriteBytes(ew);
            return wrap.GetRawPacket();
        }
    */
        /// <summary>
        /// Wraps a mob to place in packet 42
        /// for adding to screen
        /// </summary>
        /// <param name="mob"></param>
        /// <returns></returns>
        public static byte[] WrappedMob(Mobile mob)
        {
            PacketWriter e = new PacketWriter();

            if (mob is NPC)
            {
                NPC n = mob as NPC;
                e.WriteBytes(n.Serialize());
            }

            else e.WriteBytes(mob.AppearInRoom());

            byte[] ew = e.GetRawPacket();
            PacketWriter wrap = new PacketWriter();
            wrap.WriteShort((short)ew.Length);
            wrap.WriteUInt32(mob.GameID);
            wrap.WriteBytes(ew);
            return wrap.GetRawPacket();
        }

        /* Does not crash client, but does not summon npc
         public static byte[] WrappedNPC(NPC n, RoomLocation l)
        {
            PacketWriter w = new PacketWriter(0x2A);
            w.WriteUInt32(0x00); // blank acct id
            w.WriteUInt32(0x00);
            w.WriteInt32(-1);
            w.WriteUInt32(l.CurrentRoom.RoomID);
            w.WriteByte(0x40); // start wrap

            byte[] npc = n.Serialize();//AppearInRoom();

            PacketWriter w1 = new PacketWriter(); // holds 
            w1.WriteShort((short)(npc.Length));
            w1.WriteUInt32(n.GameID);
            w1.WriteBytes(npc);
            w.WriteBytes(w1.GetRawPacket());
            byte[] reply = w.ToArray();
            WritePacketToFile(reply, "NPCAppear.txt");
            return reply;
        }*/
    public static byte[] WrappedNPC(NPC n, RoomLocation l)
        {
            PacketWriter w = new PacketWriter(0x2A);
            w.WriteUInt32(0x00); // blank acct id
            w.WriteUInt32(0x00);
            w.WriteInt32(-1);
            w.WriteUInt32(l.CurrentRoom.RoomID);
            w.WriteByte(0x40); // start wrap

            byte[] npc = n.Serialize();//AppearInRoom();

            PacketWriter w1 = new PacketWriter(); // holds 
            w1.WriteShort((short)(npc.Length));
            w1.WriteUInt32(n.GameID);
            w1.WriteBytes(npc);
            w.WriteBytes(w1.GetRawPacket());
            /*
            w1.WriteUInt32(n.GameID);
            w1.WriteBytes(npc);
            byte[] wrap = w1.GetRawPacket();
            w.WriteShort((short)wrap.Length);
            w.WriteBytes(wrap);
            */
            byte[] reply = w.ToArray();
            WritePacketToFile(reply, "NPCAppear.txt");
            return reply;
        }
        public static byte[] WrappedItem(Account a, BaseGameItem item)
        {
            uint itemID = 0;
            PacketWriter e = new PacketWriter();
            e.WriteBytes(item.Serialize());
            a.IDsInUse.Add(itemID);
            e.WriteByte(0xFF);
            byte[] ew = e.GetRawPacket();
            PacketWriter wrap = new PacketWriter();
            wrap.WriteShort((short)ew.Length);
            wrap.WriteUInt32(a.CurrentCharacter.GameID); // the char it came from
            wrap.WriteBytes(ew);
            return wrap.GetRawPacket();
        }
        public static byte[] WrapWeather(uint room, short weatherID, out uint gameID)
        {
            PacketWriter wrap = new PacketWriter();
            wrap.WriteByte(0x3F); // wrapped animation

            
            #region Object
            PacketWriter ob = new PacketWriter();
            // now the object
            ob.WriteByte(0x01);
            ob.WriteShort(weatherID);
            // Static id
            //uint newid = //ServerGlobals.GetNextAvailableID();
            gameID = 200001;
            ob.WriteUInt32(gameID);
            ob.WriteBytes(new byte[3]);
            ob.WriteShort(0xFF);
            // Now room stuff
            if (room < 65534)
            {
                ob.WriteByte(0x01);
                ob.WriteShort((short)room);
            }
            else
            {
                ob.WriteByte(0x02);
                ob.WriteUInt32(room);
            }
            ob.WriteUShort(0x00);
            ob.WriteUShort(300);
            ob.WriteUShort(0x00);
            ob.WriteBytes(new byte[5]);
            ob.WriteByte(0xFF);
            #endregion
            byte[] obp = ob.GetRawPacket();
            wrap.WriteShort((short)obp.Length);
            wrap.WriteUInt32(0x00);
            wrap.WriteBytes(obp);
            return wrap.GetRawPacket();

        }
        public static byte[] WrapCloud(Account a, short graphicid, out uint id)
        {
            PacketWriter wrap = new PacketWriter();
            wrap.WriteByte(0x3F); // wrapped animation

            #region Object
            PacketWriter ob = new PacketWriter();
            // now the object
            ob.WriteByte(0x01);
            ob.WriteShort(graphicid);
            uint newid = ServerGlobals.GetNextAvailableID();
            id = newid;
            ob.WriteUInt32(id);
            ob.WriteBytes(new byte[3]);
            ob.WriteShort(0xFF);
            // Now room stuff
            if (a.CurrentCharacter.Location.CurrentRoom.RoomID < 65534)
            {
                ob.WriteByte(0x01);
                ob.WriteShort((short)a.CurrentCharacter.Location.CurrentRoom.RoomID);
            }
            else
            {
                ob.WriteByte(0x02);
                ob.WriteUInt32(a.CurrentCharacter.Location.CurrentRoom.RoomID);
            }
            ob.WriteUShort(a.CurrentCharacter.Location.X);
            ob.WriteUShort(a.CurrentCharacter.Location.Y);
            ob.WriteUShort(a.CurrentCharacter.Location.Facing);
            ob.WriteBytes(new byte[5]);
            ob.WriteByte(0xFF);
            #endregion
            byte[] obp = ob.GetRawPacket();
            wrap.WriteShort((short)obp.Length);
            wrap.WriteUInt32(0x00);
            wrap.WriteBytes(obp);
            return wrap.GetRawPacket();
        }
        public static byte[] WrapCloud(Account a, short graphicid, uint id)
        {
            PacketWriter wrap = new PacketWriter();
            wrap.WriteByte(0x3F); // wrapped animation

            #region Object
            PacketWriter ob = new PacketWriter();
            // now the object
            ob.WriteByte(0x01);
            ob.WriteShort(graphicid);
            ob.WriteUInt32(id);
            ob.WriteBytes(new byte[3]);
            ob.WriteShort(0xFF);
            // Now room stuff
            if (a.CurrentCharacter.Location.CurrentRoom.RoomID < 65534)
            {
                ob.WriteByte(0x01);
                ob.WriteShort((short)a.CurrentCharacter.Location.CurrentRoom.RoomID);
            }
            else
            {
                ob.WriteByte(0x02);
                ob.WriteUInt32(a.CurrentCharacter.Location.CurrentRoom.RoomID);
            }
            ob.WriteUShort(a.CurrentCharacter.Location.X);
            ob.WriteUShort(a.CurrentCharacter.Location.Y);
            ob.WriteUShort(a.CurrentCharacter.Location.Facing);
            ob.WriteBytes(new byte[5]);
            ob.WriteByte(0xFF);
            #endregion
            byte[] obp = ob.GetRawPacket();
            wrap.WriteShort((short)obp.Length);
            wrap.WriteUInt32(0x00);
            wrap.WriteBytes(obp);
            return wrap.GetRawPacket();
        }
        public static byte[] CastSpell(short spellID, short spellGraphicID, IEntity caster, IEntity target)
        {
            // caster always has to be a npc/mob or human
            // Target can be item, or npc/mob/human
            if (target is Item)
            {
                BaseGameItem b = target as BaseGameItem;
                Console.WriteLine("We wanna cast Spell {0}, with Spellgraphic {1}, on item id {2} Name {3}.",
                    spellID, spellGraphicID, b.GameID, b.Name);
            }
            else if (target is Mobile)
            {
                if(target is Mob)// nah we are a npc or mob
                {
                    Mob b = target as Mob;
                    Console.WriteLine("We wanna cast Spell {0}, with Spellgraphic {1}, on Monster id {2} Name {3}.",
                    spellID, spellGraphicID, b.GameID, b.Name);
                }
                else if (target is NPC)
                {
                    NPC b = target as NPC;
                    Console.WriteLine("We wanna cast Spell {0}, with Spellgraphic {1}, on NPC id {2} Name {3}.",
                    spellID, spellGraphicID, b.GameID, b.Name);
                }
            }
            else if (target is Character)
            {
                Character b = target as Character;
                Console.WriteLine("We wanna cast Spell {0}, with Spellgraphic {1}, on Player id {2} Name {3}.",
                spellID, spellGraphicID, b.GameID, b.Name);
            }
            return new byte[0];
        }
        public static void WritePacketToFile(byte[] pak, string fileName)
        {
            string fileLocation = Path.Combine(
                        Path.GetDirectoryName(Assembly.GetExecutingAssembly()
                       .Location), fileName);
                   File.WriteAllText(fileLocation, BitConverter.ToString(pak));
        }
    }
}
