using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room7020 : Room
{
public Room7020()
: base(7020, "Mirror 'n Gear")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x1C, 0xBD, 0x0A, 0xE9, 0x00, 0x02, 0x00, 0x9D, 0xFF, 0xBD, 0x0A, 0x62, 0x02, 0x05, 0x00, 0x9D, 0xFF, 0xC5, 0x09, 0x0E, 0x00, 0x2B, 0x00, 0x00, 0x00, 0xD1, 0x09, 0xD1, 0x00, 0x20, 0x00, 0x00, 0x00, 0x2A, 0x0A, 0x33, 0x00, 0x43, 0x00, 0x00, 0x00, 0x2A, 0x8A, 0x9D, 0x00, 0x67, 0x00, 0x32, 0x00, 0x9D, 0x0A, 0x30, 0x01, 0x13, 0x00, 0xA6, 0xFF, 0x9D, 0x0A, 0x94, 0x02, 0x17, 0x00, 0xA6, 0xFF, 0x8A, 0x0B, 0x03, 0x01, 0x01, 0x00, 0xC6, 0xFF, 0x03, 0x00, 0x09, 0x00, 0xCA, 0x00, 0x00, 0x00, 0x9B, 0x0A, 0xE5, 0x01, 0x02, 0x00, 0xA6, 0xFF, 0x9A, 0x0A, 0xEC, 0x01, 0x1D, 0x00, 0xC4, 0xFF, 0xE3, 0x1E, 0x04, 0x00, 0xE2, 0x00, 0x00, 0x00, 0xB1, 0x0A, 0x76, 0x00, 0x80, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0xF3, 0x01, 0x16, 0x00, 0xB5, 0xFF, 0xC4, 0x08, 0x85, 0x00, 0xDA, 0x00, 0x00, 0x00, 0xD1, 0x09, 0x70, 0x00, 0x30, 0x00, 0x00, 0x00, 0x2A, 0x8A, 0x47, 0x00, 0x42, 0x00, 0x00, 0x00, 0xD2, 0x09, 0x9F, 0x00, 0x33, 0x00, 0x00, 0x00, 0x8A, 0x0B, 0xEE, 0xFF, 0xDE, 0x00, 0x00, 0x00, 0xC1, 0x08, 0x63, 0x00, 0xDE, 0x00, 0x00, 0x00, 0x1A, 0x00, 0x5D, 0x00, 0x05, 0x01, 0x00, 0x00, 0x19, 0x00, 0x5C, 0x02, 0x16, 0x00, 0x00, 0x00, 0x18, 0x00, 0xF3, 0x01, 0x04, 0x01, 0x00, 0x00, 0x17, 0x00, 0x38, 0x02, 0x68, 0x00, 0x00, 0x00, 0x16, 0x00, 0x2B, 0x02, 0xE8, 0x00, 0x00, 0x00, 0x15, 0x00, 0xE2, 0x01, 0x67, 0x00, 0x00, 0x00, 0x14, 0x00, 0x9C, 0x01, 0xD5, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x02, 0x00, 0x01, 0xDC, 0x02, 0x0C, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x6C, 0x1B, 0xCD, 0x00, 0xC4, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB0, 0x0A, 0x0D, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x6C, 0x1B, 0xF4, 0x01, 0xFA, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
