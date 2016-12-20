using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5209 : Room
{
public Room5209()
: base(5209, "Mystic Magic")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Down;
byte[] roomDecItems = { 0x4B, 0xC5, 0x09, 0xF7, 0x00, 0x1A, 0x00, 0x00, 0x00, 0xC6, 0x09, 0x51, 0x01, 0x39, 0x00, 0x00, 0x00, 0xC5, 0x09, 0xB5, 0x01, 0x3B, 0x00, 0x00, 0x00, 0x23, 0x0A, 0x78, 0x02, 0x9D, 0x00, 0x00, 0x00, 0x97, 0x8A, 0x6D, 0x00, 0x3D, 0x01, 0x00, 0x00, 0x97, 0x8A, 0x0B, 0x00, 0xC8, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x81, 0x00, 0x4A, 0x01, 0x00, 0x00, 0x15, 0x80, 0x21, 0x02, 0xD6, 0x00, 0x00, 0x00, 0x2A, 0x0A, 0x6D, 0x01, 0xA1, 0x00, 0x64, 0x00, 0x1A, 0x0A, 0x91, 0x02, 0xAF, 0x00, 0x00, 0x00, 0x2A, 0x0A, 0x1A, 0x01, 0x92, 0x00, 0x64, 0x00, 0xE0, 0x1E, 0xA5, 0x00, 0xC5, 0x00, 0x00, 0x00, 0x8D, 0x0B, 0x29, 0x01, 0xD2, 0x00, 0x00, 0x00, 0x8D, 0x0B, 0x15, 0x02, 0x01, 0x01, 0x00, 0x00, 0x29, 0x0A, 0xEC, 0x01, 0xB5, 0x00, 0x64, 0x00, 0x99, 0x0A, 0x18, 0x00, 0xDD, 0x00, 0x6C, 0x00, 0x67, 0x00, 0x16, 0x00, 0xCC, 0x00, 0x00, 0x00, 0xD1, 0x09, 0x21, 0x02, 0x06, 0x00, 0x00, 0x00, 0x5A, 0x0A, 0x5C, 0x02, 0xD5, 0x00, 0x00, 0x00, 0x53, 0x0A, 0xE5, 0x01, 0x9B, 0x00, 0x00, 0x00, 0x16, 0x00, 0xF8, 0xFF, 0xBB, 0x00, 0x00, 0x00, 0x98, 0x0A, 0x21, 0x00, 0x4E, 0x01, 0x00, 0x00, 0x58, 0x0A, 0xE7, 0x01, 0xEA, 0x00, 0x00, 0x00, 0x5A, 0x0A, 0x1E, 0x02, 0xE1, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x63, 0x02, 0xF6, 0x00, 0x00, 0x00, 0x53, 0x0A, 0xE5, 0x01, 0xE0, 0x00, 0x00, 0x00, 0x23, 0x0A, 0x0F, 0x02, 0xAE, 0x00, 0x00, 0x00, 0x8C, 0x8B, 0xC8, 0x00, 0x17, 0x00, 0x6A, 0xFF, 0x45, 0x0A, 0x4B, 0x01, 0x3B, 0x00, 0x00, 0x00, 0x65, 0x0A, 0xDA, 0x01, 0xE0, 0x00, 0x00, 0x00, 0x67, 0x0A, 0xDA, 0x01, 0x9C, 0x00, 0x00, 0x00, 0x65, 0x0A, 0xC7, 0x00, 0x71, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x08, 0x00, 0xA3, 0x00, 0x00, 0x00, 0x67, 0x0A, 0xC7, 0x00, 0xAD, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x15, 0x02, 0xF5, 0x00, 0x00, 0x00, 0x6C, 0x0A, 0x78, 0x01, 0xE2, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0xAE, 0x02, 0xDF, 0x00, 0x00, 0x00, 0x8D, 0x0B, 0xEC, 0x01, 0xF5, 0x00, 0x00, 0x00, 0x6E, 0x0A, 0xA6, 0x01, 0xEA, 0x00, 0x00, 0x00, 0x6E, 0x0A, 0xF2, 0x00, 0xCA, 0x00, 0x00, 0x00, 0x97, 0x8A, 0x22, 0x00, 0xB7, 0x00, 0x00, 0x00, 0x6C, 0x0A, 0xC6, 0x00, 0xC2, 0x00, 0x00, 0x00, 0x3C, 0x80, 0x81, 0x02, 0xDD, 0x00, 0x00, 0x00, 0x1B, 0x0A, 0xA6, 0x01, 0xBF, 0x00, 0x00, 0x00, 0x1B, 0x0A, 0xF5, 0x00, 0x9F, 0x00, 0x00, 0x00, 0x9A, 0x0A, 0x50, 0x00, 0xD8, 0x00, 0x69, 0x00, 0x24, 0x0A, 0xEA, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x24, 0x0A, 0x9B, 0x01, 0xAC, 0x00, 0x00, 0x00, 0x53, 0x0A, 0x4E, 0x02, 0xD2, 0x00, 0x00, 0x00, 0xD2, 0x09, 0x58, 0x02, 0x07, 0x00, 0x00, 0x00, 0x42, 0x0A, 0x6E, 0x01, 0x42, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x2F, 0x00, 0xD6, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x1B, 0x00, 0xDE, 0x00, 0x00, 0x00, 0x2D, 0x00, 0xC1, 0x00, 0x06, 0x00, 0x60, 0xFF, 0x8E, 0x0B, 0x83, 0x00, 0x4F, 0x01, 0x00, 0x00, 0xD1, 0x09, 0x17, 0x02, 0x3E, 0x00, 0x00, 0x00, 0xD2, 0x09, 0x60, 0x02, 0x3E, 0x00, 0x00, 0x00, 0xC6, 0x09, 0x7C, 0x01, 0x42, 0x00, 0x00, 0x00, 0x67, 0x0A, 0x28, 0x01, 0xC0, 0x00, 0x00, 0x00, 0x65, 0x0A, 0x28, 0x01, 0x82, 0x00, 0x00, 0x00, 0x65, 0x0A, 0x79, 0x01, 0xD2, 0x00, 0x00, 0x00, 0x67, 0x0A, 0x79, 0x01, 0x8E, 0x00, 0x00, 0x00, 0x3F, 0x0A, 0xE5, 0x01, 0x5A, 0x00, 0x00, 0x00, 0x40, 0x0A, 0x2B, 0x02, 0x4F, 0x00, 0x00, 0x00, 0x45, 0x0A, 0xE9, 0x01, 0x57, 0x00, 0x00, 0x00, 0x45, 0x0A, 0x98, 0x01, 0x49, 0x00, 0x00, 0x00, 0x1A, 0x0A, 0x28, 0x02, 0xC0, 0x00, 0x00, 0x00, 0x53, 0x0A, 0x4E, 0x02, 0x92, 0x00, 0x00, 0x00, 0x10, 0x00, 0x38, 0x01, 0xD7, 0x00, 0x00, 0x00, 0x10, 0x00, 0x07, 0x02, 0xFF, 0x00, 0x00, 0x00, 0x10, 0x80, 0xE0, 0x01, 0xFF, 0x00, 0x00, 0x00, 0x10, 0x80, 0x39, 0x02, 0xF0, 0x00, 0x00, 0x00, 0x10, 0x00, 0x78, 0x02, 0xED, 0x00, 0x00, 0x00, 0x10, 0x80, 0x07, 0x01, 0xD3, 0x00, 0x00, 0x00, 0xE0, 0x1E, 0x77, 0x01, 0xE8, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDC, 0x02, 0xEC, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x59, 0x14, 0x4F, 0x01, 0xD4, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
