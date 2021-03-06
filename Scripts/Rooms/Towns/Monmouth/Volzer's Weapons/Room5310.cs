using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5310 : Room
{
public Room5310()
: base(5310, "Volzer's Weapons")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x25, 0xC8, 0x09, 0xB5, 0x00, 0x10, 0x00, 0x00, 0x00, 0xD4, 0x09, 0xA7, 0x00, 0x14, 0x00, 0x00, 0x00, 0xD9, 0x09, 0x9B, 0x01, 0x95, 0x00, 0x00, 0x00, 0xD9, 0x09, 0xB9, 0x01, 0x8F, 0x00, 0x00, 0x00, 0xDA, 0x09, 0xAA, 0x01, 0x9D, 0x00, 0x00, 0x00, 0x2F, 0x0A, 0xCA, 0xFF, 0xB1, 0x00, 0x00, 0x00, 0x98, 0x8A, 0xB3, 0x01, 0xD9, 0x00, 0x00, 0x00, 0x2F, 0x8A, 0x72, 0x01, 0x9B, 0x00, 0x0B, 0x00, 0x8B, 0x0B, 0x38, 0x00, 0xD8, 0x00, 0x00, 0x00, 0x96, 0x0A, 0x99, 0x00, 0xA6, 0x00, 0x70, 0x00, 0xF3, 0x0A, 0xB2, 0x00, 0x78, 0x00, 0x28, 0x00, 0xF1, 0x09, 0xFA, 0x00, 0xA6, 0x00, 0x0A, 0x00, 0x98, 0x0A, 0x7B, 0x01, 0xE1, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x49, 0x00, 0x32, 0x01, 0x00, 0x00, 0x9C, 0x8A, 0x3B, 0x02, 0x2B, 0x00, 0x00, 0x00, 0x3D, 0x0A, 0xF4, 0x01, 0x97, 0x00, 0x11, 0x00, 0x42, 0x0A, 0x5A, 0xFF, 0x97, 0x00, 0x00, 0x00, 0x15, 0x00, 0xCE, 0x01, 0x08, 0x00, 0x00, 0x00, 0x16, 0x00, 0x38, 0x02, 0x01, 0x00, 0x00, 0x00, 0x16, 0x80, 0x1A, 0x02, 0x1E, 0x00, 0x00, 0x00, 0x17, 0x80, 0x0E, 0x02, 0x22, 0x00, 0x00, 0x00, 0x14, 0x00, 0x53, 0x01, 0xD3, 0x00, 0x00, 0x00, 0xB8, 0x00, 0x6B, 0x01, 0xE2, 0x00, 0x00, 0x00, 0xB8, 0x00, 0xD1, 0x01, 0xDB, 0x00, 0x00, 0x00, 0xB8, 0x80, 0x9E, 0x01, 0xE3, 0x00, 0x00, 0x00, 0x14, 0x00, 0xB8, 0x01, 0xD3, 0x00, 0x00, 0x00, 0x14, 0x00, 0xE3, 0x01, 0xCA, 0x00, 0x00, 0x00, 0xF7, 0x0A, 0x9F, 0x00, 0x70, 0x00, 0x00, 0x00, 0xEE, 0x09, 0xFA, 0x00, 0xA0, 0x00, 0x00, 0x00, 0x17, 0x80, 0x4D, 0x00, 0x10, 0x01, 0x00, 0x00, 0x18, 0x00, 0xF1, 0x01, 0x1C, 0x01, 0x00, 0x00, 0x9C, 0x0A, 0x16, 0x02, 0x3A, 0x00, 0x00, 0x00, 0x9C, 0x0A, 0x43, 0x02, 0x1C, 0x00, 0x00, 0x00, 0xAF, 0x8A, 0x60, 0x00, 0x83, 0x00, 0x00, 0x00, 0xAC, 0x8A, 0x45, 0x01, 0xDC, 0x00, 0x00, 0x00, 0xAD, 0x8A, 0x1D, 0x01, 0xB9, 0x00, 0x00, 0x00, 0x8C, 0x8B, 0x5C, 0x01, 0xDD, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0x66, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xBE, 0x14, 0x83, 0x00, 0xD1, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
