using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5309 : Room
{
public Room5309()
: base(5309, "Magical Monmouth")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x22, 0xC5, 0x09, 0x41, 0x00, 0x23, 0x00, 0x00, 0x00, 0xC5, 0x09, 0x79, 0x00, 0x2C, 0x00, 0x00, 0x00, 0xC6, 0x09, 0x58, 0x00, 0x35, 0x00, 0x00, 0x00, 0x20, 0x0A, 0x30, 0x01, 0x8B, 0x00, 0x00, 0x00, 0x21, 0x0A, 0x4A, 0x00, 0x8A, 0x00, 0x00, 0x00, 0xD8, 0x09, 0x07, 0x01, 0x1A, 0x00, 0x00, 0x00, 0x20, 0x0A, 0xD0, 0x01, 0x8B, 0x00, 0x00, 0x00, 0xCE, 0x09, 0x3D, 0x01, 0x16, 0x00, 0xE7, 0xFF, 0x03, 0x00, 0x10, 0x02, 0xBD, 0x00, 0x00, 0x00, 0x9E, 0x0A, 0x78, 0x01, 0xA8, 0x00, 0xEC, 0xFF, 0x9D, 0x0A, 0x75, 0x01, 0xCD, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0xDD, 0x01, 0xCC, 0x00, 0x00, 0x00, 0x30, 0x8A, 0x9D, 0x01, 0x2F, 0x00, 0x00, 0x00, 0x98, 0x8A, 0xEB, 0x01, 0x16, 0x00, 0xAA, 0xFF, 0xC7, 0x09, 0x6F, 0x01, 0x04, 0x00, 0x00, 0x00, 0x1B, 0x0A, 0x55, 0x00, 0x9D, 0x00, 0x00, 0x00, 0xD1, 0x09, 0xD8, 0x01, 0x1C, 0x00, 0x00, 0x00, 0x98, 0x0A, 0x2E, 0x00, 0xCD, 0x00, 0x00, 0x00, 0xB1, 0x0A, 0x1B, 0x01, 0x4E, 0x00, 0x00, 0x00, 0x03, 0x00, 0x68, 0x00, 0xCD, 0x00, 0x00, 0x00, 0x1A, 0x0A, 0x49, 0x01, 0x9D, 0x00, 0x00, 0x00, 0x1A, 0x0A, 0xE9, 0x01, 0x9D, 0x00, 0x00, 0x00, 0x2F, 0x0A, 0xB7, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x2F, 0x0A, 0x7A, 0x00, 0x34, 0x00, 0x00, 0x00, 0x19, 0x00, 0x54, 0x02, 0x61, 0x00, 0x00, 0x00, 0x17, 0x00, 0xBE, 0xFF, 0x7F, 0x00, 0x00, 0x00, 0x67, 0x00, 0x06, 0x00, 0xBF, 0x00, 0x00, 0x00, 0x17, 0x00, 0xC2, 0xFF, 0x31, 0x00, 0x00, 0x00, 0x6D, 0x80, 0xFC, 0xFF, 0xA3, 0x00, 0x00, 0x00, 0x17, 0x80, 0x27, 0x00, 0xA8, 0x00, 0x00, 0x00, 0x17, 0x80, 0x45, 0x02, 0x02, 0x00, 0xA2, 0xFF, 0x18, 0x80, 0x95, 0x02, 0x86, 0x00, 0x00, 0x00, 0xB8, 0x00, 0x5B, 0x02, 0x80, 0x00, 0x00, 0x00, 0x86, 0x0A, 0x7B, 0x00, 0x65, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0x65, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xBD, 0x14, 0xE9, 0x00, 0xD3, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
