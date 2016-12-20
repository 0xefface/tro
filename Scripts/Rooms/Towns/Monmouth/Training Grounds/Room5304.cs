using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5304 : Room
{
public Room5304()
: base(5304, "Training Grounds")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x39, 0x34, 0x06, 0x3F, 0x01, 0xD3, 0x00, 0xF6, 0xFF, 0x32, 0x06, 0xC9, 0x00, 0xB9, 0x00, 0xF6, 0xFF, 0x31, 0x06, 0x4E, 0x01, 0x4F, 0x00, 0xF6, 0xFF, 0x2B, 0x00, 0x14, 0x00, 0x23, 0x01, 0x00, 0x00, 0x3C, 0x06, 0x9A, 0x00, 0x71, 0x00, 0xF6, 0xFF, 0x2B, 0x00, 0x09, 0x00, 0x49, 0x01, 0x00, 0x00, 0x3B, 0x06, 0xA0, 0x01, 0x76, 0x00, 0xF6, 0xFF, 0x3B, 0x06, 0xE9, 0x00, 0x75, 0x00, 0xF6, 0xFF, 0x3B, 0x06, 0x51, 0x01, 0x74, 0x00, 0xF6, 0xFF, 0x2B, 0x00, 0x2A, 0x00, 0x4F, 0x01, 0x00, 0x00, 0x3B, 0x06, 0xE5, 0x00, 0x91, 0x00, 0xF6, 0xFF, 0x3B, 0x06, 0x5F, 0x01, 0x92, 0x00, 0xF6, 0xFF, 0x3B, 0x06, 0xD0, 0x01, 0x8C, 0x00, 0xF6, 0xFF, 0x3B, 0x86, 0xD3, 0x00, 0x83, 0x00, 0xF6, 0xFF, 0x3B, 0x86, 0xED, 0x01, 0xA5, 0x00, 0xF6, 0xFF, 0x98, 0x0A, 0x34, 0x00, 0x3D, 0x00, 0x00, 0x00, 0x3B, 0x06, 0x9C, 0x00, 0xA0, 0x00, 0xF6, 0xFF, 0x3B, 0x06, 0x19, 0x01, 0xA6, 0x00, 0xF6, 0xFF, 0x3B, 0x06, 0x9D, 0x01, 0xB1, 0x00, 0xF6, 0xFF, 0x3B, 0x06, 0xED, 0x00, 0xBE, 0x00, 0xF6, 0xFF, 0x2B, 0x00, 0x6A, 0x02, 0x40, 0x01, 0x00, 0x00, 0x3B, 0x06, 0x5E, 0x01, 0xC4, 0x00, 0xF6, 0xFF, 0x32, 0x86, 0x16, 0x02, 0x9C, 0x00, 0xF6, 0xFF, 0x34, 0x06, 0xBC, 0x01, 0xC3, 0x00, 0xF6, 0xFF, 0x16, 0x00, 0x62, 0x00, 0x2B, 0x00, 0x00, 0x00, 0x16, 0x00, 0x5A, 0x00, 0x17, 0x01, 0x00, 0x00, 0x16, 0x80, 0x13, 0x02, 0x1B, 0x01, 0x00, 0x00, 0x16, 0x80, 0x24, 0x02, 0x23, 0x00, 0x00, 0x00, 0x15, 0x00, 0x4A, 0x00, 0x29, 0x00, 0x00, 0x00, 0x15, 0x80, 0x3D, 0x02, 0x28, 0x00, 0x00, 0x00, 0x15, 0x00, 0xA3, 0x02, 0xF3, 0x00, 0x00, 0x00, 0x16, 0x00, 0x6E, 0x02, 0x0C, 0x01, 0x00, 0x00, 0x16, 0x80, 0x01, 0x00, 0x07, 0x01, 0x00, 0x00, 0x15, 0x00, 0x18, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x16, 0x00, 0x92, 0x02, 0x4B, 0x00, 0x00, 0x00, 0x16, 0x80, 0xDC, 0xFF, 0x5E, 0x00, 0x00, 0x00, 0x15, 0x80, 0x97, 0x02, 0xD0, 0x00, 0x00, 0x00, 0x14, 0x00, 0x66, 0x00, 0x3F, 0x00, 0x00, 0x00, 0x14, 0x00, 0xFB, 0x01, 0x3F, 0x00, 0x00, 0x00, 0x14, 0x00, 0x3B, 0x02, 0x57, 0x00, 0x00, 0x00, 0x14, 0x00, 0x34, 0x02, 0xFF, 0x00, 0x00, 0x00, 0x14, 0x00, 0xF9, 0x01, 0x1D, 0x01, 0x00, 0x00, 0x79, 0x00, 0x50, 0x02, 0x46, 0x00, 0x00, 0x00, 0x2D, 0x00, 0x0F, 0x00, 0x63, 0x00, 0x00, 0x00, 0x14, 0x00, 0x23, 0x00, 0x61, 0x00, 0x00, 0x00, 0x14, 0x80, 0x8F, 0x00, 0x20, 0x01, 0x00, 0x00, 0xDE, 0x1E, 0x2B, 0x00, 0x57, 0x01, 0x00, 0x00, 0xDE, 0x1E, 0x41, 0x02, 0x57, 0x01, 0x00, 0x00, 0xDE, 0x1E, 0x32, 0x00, 0x22, 0x00, 0x00, 0x00, 0xDE, 0x1E, 0x42, 0x02, 0x24, 0x00, 0x00, 0x00, 0x14, 0x80, 0x54, 0x00, 0x09, 0x01, 0x00, 0x00, 0x16, 0x00, 0x0C, 0x00, 0x48, 0x00, 0x00, 0x00, 0x15, 0x80, 0x83, 0x00, 0x1B, 0x00, 0x00, 0x00, 0x15, 0x80, 0xDB, 0x01, 0x1A, 0x00, 0x00, 0x00, 0x15, 0x00, 0x06, 0x00, 0xE7, 0x00, 0x00, 0x00, 0x70, 0x00, 0x57, 0x02, 0x46, 0x00, 0x00, 0x00, 0x70, 0x00, 0x27, 0x00, 0x64, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x08, 0x00, 0x01, 0xB9, 0x07, 0x33, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xB8, 0x14, 0x2E, 0x00, 0x6F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB9, 0x07, 0x34, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xB8, 0x14, 0x66, 0x00, 0x4F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB9, 0x07, 0x35, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xB8, 0x14, 0x41, 0x02, 0x67, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB9, 0x07, 0x36, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xB8, 0x14, 0x00, 0x02, 0x50, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB9, 0x07, 0x37, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xB8, 0x14, 0x4C, 0x00, 0x1A, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB9, 0x07, 0x38, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xB8, 0x14, 0x92, 0x00, 0x33, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB9, 0x07, 0x39, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xB8, 0x14, 0x3C, 0x02, 0x0F, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB9, 0x07, 0x3A, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xB8, 0x14, 0xFC, 0x01, 0x2B, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4D, 0x09, 0x01, 0xDB, 0xD7, 0x8C, 0xB5 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}