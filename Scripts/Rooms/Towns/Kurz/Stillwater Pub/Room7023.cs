using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room7023 : Room
{
public Room7023()
: base(7023, "Stillwater Pub")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x1E, 0xB9, 0x0A, 0xD3, 0xFF, 0x62, 0x00, 0x00, 0x00, 0xD1, 0x09, 0x77, 0x01, 0x20, 0x00, 0x00, 0x00, 0x30, 0x8A, 0x7A, 0x01, 0x2D, 0x00, 0x00, 0x00, 0x03, 0x00, 0x7D, 0x01, 0xC9, 0x00, 0x00, 0x00, 0xDD, 0x09, 0xD9, 0x01, 0x0A, 0x00, 0xF1, 0xFF, 0x33, 0x0A, 0x3A, 0x01, 0x33, 0x00, 0x00, 0x00, 0x33, 0x0A, 0xD4, 0x01, 0x79, 0x00, 0x46, 0x00, 0x16, 0x0A, 0xC0, 0x01, 0x9F, 0x00, 0x00, 0x00, 0xC5, 0x09, 0x4E, 0x00, 0x1B, 0x00, 0x00, 0x00, 0xDD, 0x09, 0xB4, 0x00, 0x25, 0x00, 0x00, 0x00, 0xDE, 0x09, 0xF7, 0x00, 0x2A, 0x00, 0x00, 0x00, 0x33, 0x0A, 0xC6, 0x00, 0x38, 0x00, 0x00, 0x00, 0x30, 0x0A, 0x96, 0x00, 0x2A, 0x00, 0x00, 0x00, 0x16, 0x0A, 0xC4, 0x00, 0xA8, 0x00, 0x00, 0x00, 0x16, 0x0A, 0x84, 0x00, 0xA8, 0x00, 0x00, 0x00, 0x16, 0x0A, 0x03, 0x01, 0xA9, 0x00, 0x00, 0x00, 0x8C, 0x0A, 0x97, 0x00, 0x49, 0x00, 0x00, 0x00, 0xDD, 0x09, 0x10, 0x01, 0x24, 0x00, 0x00, 0x00, 0x03, 0x00, 0x8A, 0x00, 0xC7, 0x00, 0x00, 0x00, 0x03, 0x00, 0x13, 0x02, 0xB8, 0x00, 0x00, 0x00, 0x8C, 0x8B, 0x71, 0x01, 0xC4, 0x00, 0x00, 0x00, 0x8C, 0x8B, 0x22, 0x02, 0x19, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0xF8, 0x01, 0xC4, 0x00, 0x00, 0x00, 0x8B, 0x8B, 0xEF, 0x00, 0xC4, 0x00, 0x00, 0x00, 0x8C, 0x8B, 0xA4, 0x00, 0xC5, 0x00, 0x00, 0x00, 0x89, 0x0B, 0x89, 0x01, 0xC3, 0x00, 0x00, 0x00, 0x98, 0x0A, 0xEE, 0xFF, 0x1A, 0x00, 0xD1, 0xFF, 0x19, 0x80, 0x42, 0x02, 0x18, 0x00, 0x00, 0x00, 0xB6, 0x80, 0x5E, 0x02, 0x2F, 0x00, 0x00, 0x00, 0xB6, 0x00, 0x96, 0x02, 0x1D, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0x0F, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x6F, 0x1B, 0x4A, 0x00, 0xBF, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
