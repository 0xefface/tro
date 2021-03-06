using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5039 : Room
{
public Room5039()
: base(5039, "Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x21, 0x16, 0x80, 0x28, 0x02, 0x2C, 0x00, 0x00, 0x00, 0xBC, 0x0A, 0xE4, 0x01, 0x4A, 0x00, 0x00, 0x00, 0x9E, 0x0A, 0x5F, 0x02, 0x63, 0x00, 0x00, 0x00, 0x16, 0x00, 0x4B, 0x02, 0x48, 0x00, 0x00, 0x00, 0x98, 0x0A, 0x2F, 0x00, 0x70, 0x00, 0x00, 0x00, 0x98, 0x0A, 0x79, 0x00, 0x72, 0x00, 0x00, 0x00, 0x98, 0x0A, 0xB5, 0x00, 0x72, 0x00, 0x00, 0x00, 0x9A, 0x0A, 0x3E, 0x00, 0x5F, 0x00, 0x00, 0x00, 0x9A, 0x0A, 0xAE, 0x00, 0x71, 0x00, 0x00, 0x00, 0x16, 0x00, 0x6E, 0x00, 0x1B, 0x01, 0x00, 0x00, 0x16, 0x00, 0xAC, 0x00, 0x4B, 0x00, 0x00, 0x00, 0x16, 0x80, 0x8C, 0x00, 0x68, 0x00, 0x00, 0x00, 0x40, 0x00, 0x0C, 0x00, 0x8B, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x09, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x97, 0x0A, 0x20, 0x00, 0x7D, 0x00, 0x00, 0x00, 0x97, 0x0A, 0x4B, 0x00, 0x7E, 0x00, 0x00, 0x00, 0x97, 0x0A, 0x77, 0x00, 0x7E, 0x00, 0x00, 0x00, 0x97, 0x0A, 0xA0, 0x00, 0x7F, 0x00, 0x00, 0x00, 0x97, 0x0A, 0xC7, 0x00, 0x80, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x90, 0x00, 0x88, 0x00, 0x00, 0x00, 0x40, 0x00, 0x54, 0x00, 0x87, 0x00, 0x00, 0x00, 0x40, 0x00, 0xB6, 0x00, 0x87, 0x00, 0x00, 0x00, 0x40, 0x00, 0x33, 0x00, 0x89, 0x00, 0x00, 0x00, 0x40, 0x00, 0x93, 0x00, 0x88, 0x00, 0x00, 0x00, 0x40, 0x00, 0x71, 0x00, 0x8A, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x74, 0x00, 0x89, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xB4, 0x00, 0x87, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x52, 0x00, 0x8D, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x2D, 0x00, 0x88, 0x00, 0x00, 0x00, 0x15, 0x00, 0x4D, 0x00, 0x81, 0x00, 0x00, 0x00, 0x16, 0x80, 0x1D, 0x02, 0x1E, 0x01, 0x00, 0x00, 0xDD, 0x1E, 0x3E, 0x02, 0x4C, 0x00, 0x00, 0x00, 0xDC, 0x1E, 0x61, 0x00, 0x80, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
