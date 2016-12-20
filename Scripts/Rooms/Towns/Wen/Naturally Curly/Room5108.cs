using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5108 : Room
{
public Room5108()
: base(5108, "Naturally Curly")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x4D, 0xD8, 0x09, 0x91, 0x01, 0x1B, 0x00, 0x00, 0x00, 0xC5, 0x09, 0x95, 0x00, 0x1F, 0x00, 0x00, 0x00, 0xCC, 0x09, 0xF7, 0x01, 0x2E, 0x00, 0x00, 0x00, 0xC6, 0x09, 0xB2, 0x00, 0x35, 0x00, 0x00, 0x00, 0xC5, 0x09, 0x03, 0x01, 0x34, 0x00, 0x00, 0x00, 0xD1, 0x09, 0x8E, 0x02, 0x40, 0x00, 0x00, 0x00, 0x35, 0x0A, 0x33, 0x01, 0x2C, 0x00, 0x03, 0x00, 0x36, 0x0A, 0xE6, 0x00, 0x6F, 0x00, 0x52, 0x00, 0x35, 0x8A, 0x5D, 0x02, 0x56, 0x00, 0x00, 0x00, 0x42, 0x0A, 0xAA, 0x00, 0x25, 0x00, 0x00, 0x00, 0x3D, 0x0A, 0xE5, 0x02, 0x52, 0x00, 0x00, 0x00, 0x45, 0x0A, 0xEC, 0x00, 0x2F, 0x00, 0x00, 0x00, 0x57, 0x0A, 0x32, 0x01, 0xAD, 0x00, 0x00, 0x00, 0x53, 0x0A, 0x31, 0x01, 0xCE, 0x00, 0x00, 0x00, 0x65, 0x0A, 0x27, 0x01, 0x83, 0x00, 0x00, 0x00, 0x67, 0x0A, 0x26, 0x01, 0xD1, 0x00, 0x00, 0x00, 0x67, 0x0A, 0x52, 0x02, 0xE5, 0x00, 0x00, 0x00, 0x65, 0x0A, 0x66, 0x00, 0x65, 0x00, 0x00, 0x00, 0x67, 0x0A, 0x66, 0x00, 0xB2, 0x00, 0x00, 0x00, 0x53, 0x0A, 0x92, 0x01, 0xCA, 0x00, 0x00, 0x00, 0x53, 0x0A, 0x5E, 0x02, 0xE8, 0x00, 0x00, 0x00, 0x57, 0x0A, 0x92, 0x01, 0x64, 0x00, 0x00, 0x00, 0x52, 0x0A, 0x92, 0x01, 0x9A, 0x00, 0x00, 0x00, 0x51, 0x0A, 0x5E, 0x02, 0xAE, 0x00, 0x00, 0x00, 0x6B, 0x0A, 0x58, 0x02, 0xD9, 0x00, 0x00, 0x00, 0x67, 0x0A, 0x9E, 0x01, 0xCB, 0x00, 0x00, 0x00, 0x66, 0x0A, 0x9E, 0x01, 0x90, 0x00, 0x00, 0x00, 0x66, 0x0A, 0x9E, 0x01, 0x4D, 0x00, 0x00, 0x00, 0x58, 0x0A, 0x31, 0x01, 0xDB, 0x00, 0x00, 0x00, 0x10, 0x00, 0xB2, 0x02, 0x17, 0x01, 0x00, 0x00, 0x5A, 0x0A, 0x51, 0x01, 0xD4, 0x00, 0x00, 0x00, 0x58, 0x0A, 0x6A, 0x02, 0xE5, 0x00, 0x00, 0x00, 0x45, 0x0A, 0x2F, 0x02, 0x59, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xD2, 0x00, 0xEA, 0x00, 0x00, 0x00, 0x10, 0x00, 0xD0, 0x01, 0xE6, 0x00, 0x00, 0x00, 0x6C, 0x0A, 0x65, 0x00, 0xC4, 0x00, 0x00, 0x00, 0x66, 0x0A, 0x66, 0x00, 0xA5, 0x00, 0x00, 0x00, 0x6E, 0x0A, 0xF0, 0x00, 0xDC, 0x00, 0x00, 0x00, 0x6C, 0x0A, 0xAA, 0x01, 0xD6, 0x00, 0x00, 0x00, 0x8D, 0x0B, 0xEE, 0x00, 0xE2, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xBF, 0x00, 0xE6, 0x00, 0x00, 0x00, 0x3F, 0x0A, 0x29, 0x01, 0x58, 0x00, 0x00, 0x00, 0x6E, 0x0A, 0x1E, 0x02, 0xE9, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x6F, 0x02, 0xFF, 0x00, 0x00, 0x00, 0x6D, 0x0A, 0x8A, 0x00, 0xD1, 0x00, 0x00, 0x00, 0x15, 0x0A, 0x7C, 0x00, 0x9F, 0x00, 0x00, 0x00, 0x15, 0x0A, 0xCF, 0x00, 0xAC, 0x00, 0x00, 0x00, 0x14, 0x0A, 0x48, 0x01, 0xAC, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x30, 0x01, 0xEE, 0x00, 0x00, 0x00, 0x20, 0x0A, 0x52, 0x01, 0xAE, 0x00, 0x0E, 0x00, 0x21, 0x0A, 0x8C, 0x00, 0xA5, 0x00, 0x14, 0x00, 0x21, 0x0A, 0xDE, 0x00, 0xB1, 0x00, 0x14, 0x00, 0x66, 0x0A, 0x26, 0x01, 0xC2, 0x00, 0x00, 0x00, 0x31, 0x00, 0x5D, 0x02, 0xED, 0x00, 0x00, 0x00, 0x2E, 0x00, 0x5E, 0x00, 0xE9, 0x00, 0x32, 0x00, 0x2E, 0x80, 0x59, 0x00, 0xAB, 0x00, 0x32, 0x00, 0x44, 0x0A, 0x57, 0x02, 0x47, 0x00, 0xE8, 0xFF, 0x9D, 0x0A, 0x74, 0x00, 0xD1, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0xFC, 0x00, 0xE7, 0x00, 0x00, 0x00, 0x10, 0x80, 0x35, 0x01, 0xE8, 0x00, 0x00, 0x00, 0x8B, 0x8B, 0x54, 0x02, 0xF2, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x46, 0x01, 0xE1, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x8E, 0x00, 0xDE, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xF6, 0x00, 0xEE, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xA9, 0x00, 0xE2, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x18, 0x01, 0xEA, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x2A, 0x02, 0xEA, 0x00, 0x00, 0x00, 0x45, 0x0A, 0x37, 0x01, 0x5A, 0x00, 0x00, 0x00, 0x45, 0x0A, 0xF3, 0x00, 0x50, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x77, 0x00, 0xDD, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x59, 0x00, 0xD7, 0x00, 0x00, 0x00, 0x10, 0x00, 0x33, 0x01, 0xEE, 0x00, 0x00, 0x00, 0x10, 0x80, 0x06, 0x01, 0xEB, 0x00, 0x00, 0x00, 0x10, 0x00, 0xCC, 0x00, 0xDC, 0x00, 0x00, 0x00, 0x10, 0x80, 0x1C, 0x00, 0xC9, 0x00, 0x00, 0x00, 0x10, 0x80, 0x8F, 0x00, 0xDE, 0x00, 0x00, 0x00, 0x10, 0x00, 0xE3, 0x00, 0x42, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0x9D, 0x52, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF4, 0x13, 0xF7, 0x01, 0xDC, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}