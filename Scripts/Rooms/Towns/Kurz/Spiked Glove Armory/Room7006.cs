using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room7006 : Room
{
public Room7006()
: base(7006, "Spiked Glove Armory")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x26, 0xD4, 0x09, 0xA0, 0x00, 0x0C, 0x00, 0x00, 0x00, 0x2F, 0x0A, 0xDB, 0xFF, 0xBA, 0x00, 0x14, 0x00, 0x98, 0x8A, 0x0E, 0x00, 0xE2, 0x00, 0x00, 0x00, 0x88, 0x0B, 0xDE, 0x01, 0x23, 0x00, 0x9C, 0xFF, 0x87, 0x0B, 0x2F, 0x02, 0x1C, 0x01, 0x00, 0x00, 0x03, 0x00, 0x40, 0x00, 0xD5, 0x00, 0x00, 0x00, 0x03, 0x00, 0x04, 0x00, 0xE7, 0x00, 0x00, 0x00, 0x03, 0x00, 0xDD, 0x01, 0x94, 0x00, 0x00, 0x00, 0x87, 0x0A, 0xB3, 0x00, 0x75, 0x00, 0x00, 0x00, 0xC5, 0x09, 0xD6, 0x00, 0x25, 0x00, 0x00, 0x00, 0xDD, 0x09, 0x3B, 0x01, 0x2E, 0x00, 0x00, 0x00, 0xD1, 0x09, 0xA3, 0x01, 0x27, 0x00, 0x00, 0x00, 0x30, 0x0A, 0xFB, 0x00, 0x41, 0x00, 0x00, 0x00, 0x30, 0x8A, 0x6A, 0x01, 0x40, 0x00, 0x00, 0x00, 0x33, 0x0A, 0x38, 0x01, 0x46, 0x00, 0x00, 0x00, 0xEF, 0x09, 0x40, 0x01, 0xA6, 0x00, 0x00, 0x00, 0x87, 0x0B, 0x08, 0x00, 0xEE, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0x33, 0x00, 0xE9, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x14, 0x00, 0xF7, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x36, 0x02, 0x21, 0x01, 0x00, 0x00, 0x8C, 0x0B, 0xD8, 0x01, 0x0E, 0x00, 0x74, 0xFF, 0xF2, 0x09, 0x41, 0x01, 0xA7, 0x00, 0x00, 0x00, 0xF0, 0x09, 0x8C, 0x01, 0xA0, 0x00, 0x00, 0x00, 0xED, 0x09, 0x82, 0x01, 0x99, 0x00, 0xEC, 0xFF, 0x31, 0x00, 0x09, 0x01, 0xD8, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x10, 0x01, 0xDC, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x24, 0x01, 0xD1, 0x00, 0x00, 0x00, 0x8C, 0x8B, 0xFA, 0x00, 0xD2, 0x00, 0x00, 0x00, 0xDC, 0x1E, 0x7D, 0x00, 0xAA, 0x00, 0x00, 0x00, 0xDC, 0x1E, 0x4F, 0x01, 0xAA, 0x00, 0x00, 0x00, 0x5E, 0x00, 0x56, 0x01, 0x0A, 0x00, 0xBA, 0xFF, 0x98, 0x00, 0x60, 0x02, 0x5A, 0x00, 0x00, 0x00, 0x96, 0x00, 0x28, 0x02, 0x1F, 0x00, 0xC4, 0xFF, 0x16, 0x00, 0x28, 0x02, 0x10, 0x00, 0xC4, 0xFF, 0x15, 0x00, 0x30, 0x00, 0xC7, 0x00, 0x00, 0x00, 0x16, 0x00, 0x4D, 0x00, 0x18, 0x01, 0x00, 0x00, 0x17, 0x80, 0x3B, 0x00, 0xED, 0x00, 0x00, 0x00, 0x16, 0x80, 0x06, 0x00, 0x13, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0x00, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x5E, 0x1B, 0x71, 0x00, 0xCC, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
