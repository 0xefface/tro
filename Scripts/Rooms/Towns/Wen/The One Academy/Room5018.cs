using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5018 : Room
{
public Room5018()
: base(5018, "The One Academy")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x5E, 0x9D, 0x0A, 0x54, 0x02, 0xA8, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x69, 0x02, 0x1F, 0x01, 0x00, 0x00, 0x9D, 0x0A, 0x65, 0x00, 0x39, 0x01, 0x00, 0x00, 0xB9, 0x0A, 0x34, 0x02, 0x0D, 0x00, 0x9D, 0xFF, 0x9E, 0x0A, 0x16, 0x02, 0x72, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x20, 0x00, 0x37, 0x01, 0x00, 0x00, 0x8C, 0x0B, 0x3A, 0x02, 0x92, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x3C, 0x00, 0x4E, 0x01, 0x00, 0x00, 0x9D, 0x0A, 0x09, 0x02, 0x7F, 0x00, 0x00, 0x00, 0x6D, 0x00, 0x6A, 0x02, 0x91, 0x00, 0x00, 0x00, 0x1A, 0x00, 0x60, 0x00, 0x09, 0x01, 0x00, 0x00, 0x17, 0x00, 0x38, 0x02, 0x0F, 0x00, 0x00, 0x00, 0x15, 0x80, 0x99, 0x01, 0x06, 0x00, 0x00, 0x00, 0x2D, 0x0A, 0x19, 0x01, 0x44, 0x00, 0x00, 0x00, 0xDE, 0x09, 0x23, 0x00, 0x46, 0x00, 0x00, 0x00, 0xDF, 0x09, 0x9C, 0x00, 0x25, 0x00, 0x00, 0x00, 0xDD, 0x09, 0x26, 0x01, 0x41, 0x00, 0x00, 0x00, 0x2D, 0x0A, 0x9E, 0x00, 0x15, 0x00, 0xCE, 0xFF, 0xDE, 0x09, 0x07, 0x01, 0x45, 0x00, 0x00, 0x00, 0x2D, 0x0A, 0x13, 0x00, 0x48, 0x00, 0x00, 0x00, 0x2E, 0x0A, 0xA0, 0x00, 0x84, 0x00, 0x32, 0x00, 0xFB, 0x09, 0x2C, 0x00, 0xAD, 0x00, 0x00, 0x00, 0xF5, 0x09, 0x16, 0x01, 0xAF, 0x00, 0x00, 0x00, 0xF5, 0x09, 0x2D, 0x00, 0xB0, 0x00, 0x00, 0x00, 0xFB, 0x09, 0x15, 0x01, 0xAC, 0x00, 0x00, 0x00, 0x6F, 0x00, 0x40, 0x01, 0xDF, 0x00, 0x00, 0x00, 0x40, 0x80, 0x54, 0x01, 0xEE, 0x00, 0x00, 0x00, 0x40, 0x00, 0x28, 0x01, 0xE8, 0x00, 0x00, 0x00, 0x40, 0x00, 0x3D, 0x01, 0xE8, 0x00, 0x00, 0x00, 0x40, 0x00, 0x24, 0x01, 0xEF, 0x00, 0x00, 0x00, 0x40, 0x00, 0xFE, 0x00, 0xE8, 0x00, 0x00, 0x00, 0x40, 0x00, 0x14, 0x01, 0xEE, 0x00, 0x00, 0x00, 0x40, 0x80, 0x39, 0x01, 0xE8, 0x00, 0x00, 0x00, 0x40, 0x80, 0x2D, 0x01, 0xE8, 0x00, 0x00, 0x00, 0x40, 0x80, 0x21, 0x01, 0xED, 0x00, 0x00, 0x00, 0x40, 0x80, 0x12, 0x01, 0xE4, 0x00, 0x00, 0x00, 0x70, 0x00, 0x2F, 0x00, 0xDE, 0x00, 0x00, 0x00, 0x71, 0x00, 0x61, 0x00, 0xE1, 0x00, 0x00, 0x00, 0x9C, 0x0A, 0x07, 0x01, 0xE3, 0x00, 0x00, 0x00, 0x6F, 0x80, 0x4C, 0x00, 0xE5, 0x00, 0x00, 0x00, 0x6F, 0x00, 0x0C, 0x00, 0xE5, 0x00, 0x00, 0x00, 0x71, 0x00, 0x25, 0x00, 0xE3, 0x00, 0x00, 0x00, 0x40, 0x00, 0xEF, 0x00, 0xEB, 0x00, 0x00, 0x00, 0x40, 0x80, 0x05, 0x01, 0xE7, 0x00, 0x00, 0x00, 0x40, 0x80, 0xFE, 0x00, 0xED, 0x00, 0x00, 0x00, 0x40, 0x80, 0xE8, 0x00, 0xE5, 0x00, 0x00, 0x00, 0x40, 0x80, 0xEB, 0x00, 0xED, 0x00, 0x00, 0x00, 0x40, 0x80, 0x16, 0x00, 0xE3, 0x00, 0x00, 0x00, 0x40, 0x80, 0x3A, 0x00, 0xE7, 0x00, 0x00, 0x00, 0x40, 0x80, 0x4A, 0x00, 0xE5, 0x00, 0x00, 0x00, 0x40, 0x80, 0x60, 0x00, 0xE6, 0x00, 0x00, 0x00, 0x40, 0x80, 0x5E, 0x00, 0xED, 0x00, 0x00, 0x00, 0x40, 0x00, 0xD8, 0x00, 0xE7, 0x00, 0x00, 0x00, 0x40, 0x00, 0xE8, 0x00, 0xE2, 0x00, 0x00, 0x00, 0x40, 0x00, 0x09, 0x00, 0xE3, 0x00, 0x00, 0x00, 0x40, 0x00, 0xFA, 0xFF, 0xEA, 0x00, 0x00, 0x00, 0x40, 0x00, 0x0A, 0x00, 0xEB, 0x00, 0x00, 0x00, 0x40, 0x00, 0x2E, 0x00, 0xE9, 0x00, 0x00, 0x00, 0x40, 0x00, 0x4F, 0x00, 0xEA, 0x00, 0x00, 0x00, 0x40, 0x00, 0x2C, 0x00, 0xEE, 0x00, 0x00, 0x00, 0x40, 0x00, 0x1A, 0x00, 0xEB, 0x00, 0x00, 0x00, 0x72, 0x0A, 0x69, 0x00, 0x79, 0x00, 0x32, 0x00, 0x65, 0x0A, 0x5E, 0x00, 0x93, 0x00, 0x00, 0x00, 0x65, 0x8A, 0xDA, 0x00, 0x94, 0x00, 0x00, 0x00, 0x72, 0x8A, 0xCD, 0x00, 0x79, 0x00, 0x32, 0x00, 0x72, 0x8A, 0xDD, 0x00, 0x52, 0x00, 0x00, 0x00, 0x72, 0x0A, 0x5C, 0x00, 0x50, 0x00, 0x00, 0x00, 0x67, 0x0A, 0x5E, 0x00, 0xDF, 0x00, 0x00, 0x00, 0x67, 0x8A, 0xDA, 0x00, 0xE0, 0x00, 0x00, 0x00, 0x66, 0x0A, 0x5E, 0x00, 0xC8, 0x00, 0x00, 0x00, 0x66, 0x8A, 0xDA, 0x00, 0xC9, 0x00, 0x00, 0x00, 0x48, 0x0A, 0x1E, 0x01, 0x54, 0x00, 0x00, 0x00, 0x48, 0x0A, 0x1D, 0x00, 0x59, 0x00, 0x00, 0x00, 0x48, 0x0A, 0x1E, 0x01, 0xDF, 0x00, 0x00, 0x00, 0x48, 0x0A, 0x1C, 0x00, 0xE0, 0x00, 0x00, 0x00, 0x66, 0x8A, 0x5F, 0x01, 0xBF, 0x00, 0x00, 0x00, 0x67, 0x8A, 0x5F, 0x01, 0xDE, 0x00, 0x00, 0x00, 0x65, 0x8A, 0x5F, 0x01, 0x89, 0x00, 0x00, 0x00, 0x40, 0x00, 0xF0, 0x01, 0x1F, 0x01, 0x00, 0x00, 0x3F, 0x00, 0x14, 0x02, 0x11, 0x01, 0x00, 0x00, 0x15, 0x80, 0x3A, 0x02, 0x10, 0x01, 0x00, 0x00, 0x1A, 0x80, 0xCF, 0x01, 0x10, 0x01, 0x00, 0x00, 0x9D, 0x0A, 0x3E, 0x02, 0x44, 0x01, 0x00, 0x00, 0x15, 0x80, 0x3A, 0x02, 0xE7, 0x00, 0x00, 0x00, 0x1A, 0x80, 0xA1, 0x02, 0xC2, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x40, 0x02, 0x11, 0x01, 0x00, 0x00, 0x40, 0x80, 0x39, 0x02, 0x0E, 0x01, 0x00, 0x00, 0x40, 0x00, 0x47, 0x02, 0x17, 0x01, 0x00, 0x00, 0x9D, 0x0A, 0xE0, 0x01, 0xD3, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x1C, 0x02, 0xDE, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x2B, 0x02, 0xD5, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x85, 0x02, 0xD7, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x74, 0x02, 0xEA, 0x00, 0x00, 0x00, 0x99, 0x0A, 0x71, 0x01, 0x56, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x02, 0x00, 0x01, 0x16, 0x00, 0x2F, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x9A, 0x13, 0x32, 0x02, 0x21, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xD9, 0x02, 0x30, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x9A, 0x13, 0x9B, 0x00, 0xE5, 0x00, 0x02, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}