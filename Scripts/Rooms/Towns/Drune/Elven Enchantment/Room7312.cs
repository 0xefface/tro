using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room7312 : Room
{
public Room7312()
: base(7312, "Elven Enchantment")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x21, 0xCF, 0x09, 0x13, 0x01, 0x32, 0x00, 0x00, 0x00, 0x68, 0x0A, 0xEC, 0x00, 0x4D, 0x00, 0xC1, 0xFF, 0x69, 0x0A, 0x41, 0x01, 0x9A, 0x00, 0x00, 0x00, 0xDC, 0x09, 0x9C, 0x01, 0x4E, 0x00, 0x00, 0x00, 0x56, 0x0A, 0x4C, 0x01, 0x99, 0x00, 0x00, 0x00, 0x6C, 0x0A, 0xED, 0x00, 0x94, 0x00, 0x00, 0x00, 0x6E, 0x0A, 0x0C, 0x01, 0x9A, 0x00, 0x00, 0x00, 0x46, 0x0A, 0x51, 0x01, 0x55, 0x00, 0x00, 0x00, 0x2B, 0x8A, 0x5F, 0x01, 0x59, 0x00, 0x13, 0x00, 0x29, 0x0A, 0xC7, 0x01, 0xAF, 0x00, 0x00, 0x00, 0x29, 0x0A, 0xEA, 0x00, 0x0E, 0x00, 0x84, 0xFF, 0xCD, 0x09, 0xB0, 0x00, 0x94, 0x00, 0x00, 0x00, 0xCD, 0x09, 0x95, 0x01, 0xBC, 0x00, 0x00, 0x00, 0xCE, 0x09, 0xD9, 0x00, 0xE4, 0x00, 0x00, 0x00, 0xCE, 0x09, 0x30, 0x01, 0xF2, 0x00, 0x00, 0x00, 0x45, 0x0A, 0xF9, 0x00, 0x9C, 0x00, 0x00, 0x00, 0xD4, 0x09, 0x79, 0x02, 0x3D, 0x00, 0x00, 0x00, 0x44, 0x0A, 0x4C, 0x01, 0xAC, 0x00, 0x00, 0x00, 0x42, 0x0A, 0x3F, 0x01, 0xAB, 0x00, 0x00, 0x00, 0x2A, 0x0A, 0xE1, 0x01, 0x38, 0x00, 0x00, 0x00, 0x8A, 0x0B, 0xA3, 0x00, 0xEA, 0x00, 0x00, 0x00, 0xB1, 0x0A, 0x10, 0x02, 0xCC, 0x00, 0x00, 0x00, 0x9A, 0x0A, 0x9C, 0x00, 0xD5, 0x00, 0x00, 0x00, 0x99, 0x0A, 0xC7, 0x01, 0xFC, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0x05, 0x02, 0xFC, 0x00, 0x00, 0x00, 0x8A, 0x0A, 0x09, 0x01, 0x6C, 0x00, 0x00, 0x00, 0x17, 0x00, 0x2D, 0x00, 0x92, 0x00, 0x00, 0x00, 0x17, 0x80, 0x4B, 0x00, 0xB3, 0x00, 0x00, 0x00, 0xB8, 0x00, 0x31, 0x00, 0xB3, 0x00, 0x00, 0x00, 0xB8, 0x80, 0x3A, 0x00, 0xA8, 0x00, 0x00, 0x00, 0xBD, 0x0A, 0x5F, 0x00, 0x06, 0x00, 0xB0, 0xFF, 0xE3, 0x09, 0xB5, 0x00, 0x02, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDC, 0x02, 0x69, 0x49, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x90, 0x1C, 0x51, 0x02, 0xFA, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
