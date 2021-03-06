using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5904 : Room
{
public Room5904()
: base(5904, "Asgard General Goods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x1C, 0xC8, 0x09, 0xDF, 0x01, 0x07, 0x00, 0x00, 0x00, 0xF1, 0x85, 0xA2, 0x00, 0x77, 0x00, 0xC4, 0xFF, 0x29, 0x8A, 0xAF, 0x02, 0xAF, 0x00, 0x20, 0x00, 0x14, 0x00, 0x61, 0x02, 0xDA, 0x00, 0x00, 0x00, 0xC1, 0x08, 0xA5, 0x00, 0xAF, 0x00, 0x00, 0x00, 0x14, 0x00, 0x0A, 0x02, 0x27, 0x01, 0x00, 0x00, 0xF1, 0x09, 0xB6, 0x01, 0x8E, 0x00, 0x00, 0x00, 0x8B, 0x8B, 0xF4, 0x01, 0xCE, 0x00, 0x00, 0x00, 0xF1, 0x05, 0xD9, 0x00, 0xB4, 0x00, 0x00, 0x00, 0x3D, 0x0A, 0xFE, 0x02, 0x92, 0x00, 0x00, 0x00, 0xF1, 0x09, 0xF0, 0x00, 0x8B, 0x00, 0x00, 0x00, 0xC1, 0x08, 0x53, 0x02, 0xE9, 0x00, 0x00, 0x00, 0xCA, 0x09, 0xC9, 0x01, 0x26, 0x00, 0x00, 0x00, 0xEE, 0x09, 0xF3, 0x00, 0x88, 0x00, 0xF7, 0xFF, 0x16, 0x80, 0x6D, 0x02, 0x1B, 0x01, 0x00, 0x00, 0xC4, 0x88, 0xEE, 0x01, 0xCB, 0x00, 0x00, 0x00, 0x29, 0x8A, 0x76, 0x02, 0xBA, 0x00, 0x20, 0x00, 0xC9, 0x09, 0xA6, 0x01, 0x02, 0x00, 0x00, 0x00, 0xEE, 0x09, 0xB9, 0x01, 0x89, 0x00, 0xF7, 0xFF, 0x40, 0x0A, 0xE4, 0x00, 0x26, 0x00, 0x00, 0x00, 0xD1, 0x09, 0x3A, 0x01, 0x13, 0x00, 0x00, 0x00, 0xC5, 0x09, 0xDE, 0x00, 0x10, 0x00, 0x00, 0x00, 0x29, 0x0A, 0x1A, 0x01, 0x54, 0x00, 0x20, 0x00, 0x10, 0x00, 0x1C, 0x01, 0xD6, 0x00, 0x00, 0x00, 0x10, 0x00, 0xFC, 0x01, 0xD9, 0x00, 0x00, 0x00, 0x10, 0x00, 0x8C, 0x02, 0xF1, 0x00, 0x00, 0x00, 0x88, 0x0B, 0x6E, 0x02, 0x33, 0x01, 0x00, 0x00, 0x8C, 0x0B, 0x6E, 0x02, 0x3A, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0x27, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x10, 0x17, 0x3A, 0x01, 0xB7, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
