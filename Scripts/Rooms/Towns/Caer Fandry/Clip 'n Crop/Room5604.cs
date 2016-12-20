using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5604 : Room
{
public Room5604()
: base(5604, "Clip 'n Crop")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.UpRight;
byte[] roomDecItems = { 0x28, 0xC5, 0x09, 0x7C, 0x00, 0x23, 0x00, 0x00, 0x00, 0xC6, 0x09, 0xD6, 0x00, 0x40, 0x00, 0x00, 0x00, 0xC5, 0x09, 0x2C, 0x01, 0x3E, 0x00, 0x00, 0x00, 0xD8, 0x09, 0xBA, 0x01, 0x2D, 0x00, 0x00, 0x00, 0x35, 0x0A, 0x51, 0x01, 0x47, 0x00, 0x00, 0x00, 0x36, 0x0A, 0xDD, 0x00, 0x33, 0x00, 0x00, 0x00, 0x36, 0x0A, 0xA0, 0x00, 0x28, 0x00, 0x00, 0x00, 0x42, 0x0A, 0xC9, 0x00, 0x42, 0x00, 0x00, 0x00, 0x45, 0x0A, 0xAE, 0x00, 0x3E, 0x00, 0x00, 0x00, 0x44, 0x0A, 0xFB, 0x00, 0x4A, 0x00, 0x00, 0x00, 0xF3, 0x09, 0x6A, 0x01, 0xCE, 0x00, 0x00, 0x00, 0xF4, 0x09, 0xB2, 0x00, 0xA3, 0x00, 0x00, 0x00, 0xF9, 0x09, 0x7B, 0x01, 0xB3, 0x00, 0x00, 0x00, 0xFA, 0x09, 0xB2, 0x00, 0x9D, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x2E, 0x02, 0x2F, 0x00, 0x00, 0x00, 0x10, 0x00, 0xFB, 0x00, 0xEF, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x38, 0x00, 0xBC, 0x00, 0x00, 0x00, 0x6D, 0x00, 0x11, 0x00, 0xB8, 0x00, 0x00, 0x00, 0x6D, 0x00, 0x86, 0x02, 0xC4, 0x00, 0x00, 0x00, 0x67, 0x00, 0x90, 0x02, 0xC6, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x65, 0x02, 0xBA, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x0A, 0x00, 0xA7, 0x00, 0x00, 0x00, 0x9C, 0x8A, 0x59, 0x02, 0xD1, 0x00, 0x00, 0x00, 0x9C, 0x8A, 0x16, 0x02, 0xCC, 0x00, 0x00, 0x00, 0xB7, 0x0A, 0x3A, 0x02, 0x28, 0x00, 0xCD, 0xFF, 0xB7, 0x0A, 0xEE, 0xFF, 0x22, 0x00, 0x9D, 0xFF, 0x95, 0x00, 0x11, 0x00, 0x10, 0x00, 0xB0, 0xFF, 0xB7, 0x0A, 0x61, 0x02, 0x23, 0x00, 0x9D, 0xFF, 0x8C, 0x8B, 0x59, 0x02, 0x9D, 0x00, 0x00, 0x00, 0x8E, 0x0B, 0x4D, 0x00, 0xAC, 0x00, 0x00, 0x00, 0x8E, 0x0B, 0x3A, 0x00, 0x94, 0x00, 0x00, 0x00, 0x8E, 0x8B, 0x1C, 0x02, 0xC8, 0x00, 0x00, 0x00, 0x8E, 0x8B, 0x1C, 0x02, 0x9F, 0x00, 0x00, 0x00, 0x9C, 0x0A, 0x0C, 0x00, 0x84, 0x00, 0x00, 0x00, 0x9C, 0x8A, 0x54, 0x02, 0x20, 0x00, 0x9D, 0xFF, 0xF3, 0x09, 0xC3, 0x01, 0xC6, 0x00, 0x00, 0x00, 0xF9, 0x09, 0xD4, 0x01, 0xAB, 0x00, 0x00, 0x00, 0x5C, 0x0A, 0xD4, 0x01, 0x33, 0x00, 0x00, 0x00, 0x5D, 0x0A, 0xEF, 0x01, 0x3B, 0x00, 0x00, 0x00, 0x99, 0x0A, 0x35, 0x02, 0x8C, 0x00, 0x32, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0xDD, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xE4, 0x15, 0x15, 0x01, 0xE0, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
