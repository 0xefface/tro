using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room7012 : Room
{
public Room7012()
: base(7012, "Magic Mysteries")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x29, 0xD4, 0x09, 0xA2, 0x01, 0x07, 0x00, 0x00, 0x00, 0x2F, 0x0A, 0xF6, 0x00, 0x93, 0x00, 0x00, 0x00, 0xCD, 0x09, 0xC0, 0x00, 0x68, 0x00, 0xE2, 0xFF, 0x8A, 0x0A, 0xBD, 0x01, 0x98, 0x00, 0x00, 0x00, 0x88, 0x0B, 0x07, 0x00, 0xCA, 0x00, 0x00, 0x00, 0x2F, 0x8A, 0x12, 0x02, 0xA2, 0x00, 0x00, 0x00, 0xD9, 0x09, 0x3E, 0x02, 0x98, 0x00, 0x00, 0x00, 0xC8, 0x09, 0x59, 0x01, 0x12, 0x00, 0x00, 0x00, 0x87, 0x0B, 0x22, 0x00, 0x2B, 0x01, 0x00, 0x00, 0xB6, 0x0A, 0x5B, 0x02, 0x0C, 0x00, 0xCE, 0xFF, 0x03, 0x00, 0x78, 0x02, 0xCD, 0x00, 0x00, 0x00, 0xB6, 0x0A, 0xE5, 0xFF, 0x1C, 0x00, 0xCE, 0xFF, 0xED, 0x09, 0x12, 0x01, 0xB8, 0x00, 0xEC, 0xFF, 0xF0, 0x09, 0x20, 0x01, 0xBD, 0x00, 0x00, 0x00, 0xDA, 0x09, 0x52, 0x02, 0x9F, 0x00, 0x00, 0x00, 0x03, 0x00, 0x4A, 0x02, 0xD9, 0x00, 0x00, 0x00, 0xB9, 0x0A, 0x47, 0x02, 0x24, 0x00, 0xCE, 0xFF, 0x97, 0x0A, 0x69, 0x02, 0xDE, 0x00, 0x00, 0x00, 0x15, 0x00, 0x3D, 0x00, 0x16, 0x01, 0x00, 0x00, 0x16, 0x00, 0x55, 0x00, 0x5C, 0x00, 0xCE, 0xFF, 0x17, 0x80, 0x1D, 0x00, 0xE9, 0x00, 0x00, 0x00, 0x15, 0x00, 0x5D, 0x00, 0x68, 0x00, 0xBA, 0xFF, 0x15, 0x00, 0x6A, 0x00, 0x1E, 0x00, 0xB0, 0xFF, 0x16, 0x00, 0x45, 0x00, 0x12, 0x00, 0xEC, 0xFF, 0xB6, 0x0A, 0xA3, 0x00, 0x1C, 0x00, 0xCE, 0xFF, 0x16, 0x80, 0x17, 0x00, 0x4C, 0x00, 0x00, 0x00, 0x16, 0x80, 0x33, 0x00, 0x3B, 0x00, 0x00, 0x00, 0x15, 0x00, 0x7F, 0x02, 0x5B, 0x00, 0x9C, 0xFF, 0x8B, 0x8B, 0x79, 0x00, 0xCD, 0x00, 0x00, 0x00, 0x15, 0x00, 0x17, 0x00, 0xCE, 0x00, 0x00, 0x00, 0x87, 0x0B, 0x1B, 0x00, 0x8B, 0x00, 0x00, 0x00, 0x87, 0x0B, 0x06, 0x00, 0x4C, 0x01, 0x00, 0x00, 0x8C, 0x0B, 0x1B, 0x00, 0x33, 0x01, 0x00, 0x00, 0x8C, 0x0B, 0x6E, 0x02, 0xE3, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x0C, 0x02, 0xEA, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x2C, 0x01, 0xD5, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x4C, 0x01, 0xD1, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0xED, 0x01, 0xE3, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0xCD, 0x01, 0xDF, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x36, 0x02, 0xE6, 0x00, 0x00, 0x00, 0x5E, 0x00, 0x69, 0x01, 0x04, 0x00, 0xCE, 0xFF };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0x10, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x64, 0x1B, 0x88, 0x01, 0xD5, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}