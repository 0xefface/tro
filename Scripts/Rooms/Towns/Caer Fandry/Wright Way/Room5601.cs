using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5601 : Room
{
public Room5601()
: base(5601, "Wright Way")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x24, 0xD1, 0x09, 0x9D, 0x00, 0x3B, 0x00, 0x00, 0x00, 0xD1, 0x09, 0xB6, 0x00, 0x37, 0x00, 0x00, 0x00, 0xD2, 0x09, 0xA4, 0x00, 0x44, 0x00, 0x00, 0x00, 0x8B, 0x8B, 0xB8, 0x01, 0x31, 0x00, 0xBF, 0xFF, 0x15, 0x00, 0x46, 0x02, 0x0C, 0x00, 0xA8, 0xFF, 0xC8, 0x09, 0xC8, 0x00, 0x0F, 0x00, 0x00, 0x00, 0xD9, 0x09, 0xAA, 0x01, 0x50, 0x00, 0xBC, 0xFF, 0x2F, 0x8A, 0x74, 0x01, 0x55, 0x00, 0xB4, 0xFF, 0x1B, 0x0A, 0x24, 0x00, 0xA1, 0x00, 0xED, 0xFF, 0x21, 0x0A, 0x19, 0x00, 0xA1, 0x00, 0x00, 0x00, 0x21, 0x0A, 0x08, 0x01, 0x5C, 0x00, 0xBA, 0xFF, 0x1B, 0x0A, 0x13, 0x01, 0x52, 0x00, 0x9D, 0xFF, 0x2F, 0x8A, 0x73, 0x00, 0x67, 0x00, 0x21, 0x00, 0xCC, 0x09, 0x06, 0x00, 0x28, 0x00, 0x00, 0x00, 0x16, 0x00, 0xA1, 0x00, 0x98, 0x00, 0xCE, 0xFF, 0x8B, 0x8B, 0xF3, 0x00, 0xD3, 0x00, 0x00, 0x00, 0x03, 0x00, 0x9C, 0x01, 0xE8, 0x00, 0x00, 0x00, 0x9A, 0x0A, 0x30, 0x00, 0xD2, 0x00, 0x55, 0x00, 0x98, 0x8A, 0xBA, 0x01, 0xEB, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x2A, 0x00, 0xE4, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x57, 0x00, 0xEC, 0x00, 0x00, 0x00, 0x6D, 0x00, 0x0D, 0x00, 0xCF, 0x00, 0x00, 0x00, 0x2D, 0x00, 0x97, 0x01, 0x44, 0x00, 0xAC, 0xFF, 0x15, 0x00, 0x45, 0x02, 0x04, 0x00, 0x00, 0x00, 0x16, 0x80, 0x1A, 0x02, 0x21, 0x01, 0x00, 0x00, 0x15, 0x00, 0x0C, 0x00, 0xC9, 0x00, 0x00, 0x00, 0xB0, 0x0A, 0x7D, 0x01, 0xC8, 0x00, 0x00, 0x00, 0xAF, 0x8A, 0x63, 0x00, 0x73, 0x00, 0x00, 0x00, 0x98, 0x8A, 0x0A, 0x02, 0x28, 0x00, 0x62, 0xFF, 0x9D, 0x0A, 0x10, 0x02, 0xD3, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xF2, 0x01, 0x4A, 0x00, 0x88, 0xFF, 0x8B, 0x8B, 0xC3, 0x01, 0x0C, 0x00, 0x8A, 0xFF, 0x10, 0x80, 0x5F, 0x01, 0xF6, 0x00, 0x00, 0x00, 0x10, 0x00, 0xFD, 0x01, 0xDC, 0x00, 0x00, 0x00, 0x15, 0x00, 0xE5, 0x01, 0x37, 0x00, 0x00, 0x00, 0x15, 0x00, 0xD4, 0x01, 0x1F, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0xDC, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xE1, 0x15, 0xA8, 0x00, 0xDC, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
