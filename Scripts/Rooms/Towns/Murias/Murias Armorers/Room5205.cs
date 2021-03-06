using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5205 : Room
{
public Room5205()
: base(5205, "Murias Armorers")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x33, 0xC5, 0x09, 0x05, 0x00, 0x1C, 0x00, 0x00, 0x00, 0xC5, 0x09, 0x46, 0x00, 0x27, 0x00, 0x00, 0x00, 0xC6, 0x09, 0x2D, 0x00, 0x32, 0x00, 0x00, 0x00, 0x20, 0x0A, 0x9A, 0x00, 0x93, 0x00, 0x00, 0x00, 0x21, 0x0A, 0x2D, 0x00, 0x94, 0x00, 0x00, 0x00, 0xD8, 0x09, 0xD1, 0x00, 0x14, 0x00, 0x00, 0x00, 0x20, 0x0A, 0xA9, 0x01, 0x89, 0x00, 0x00, 0x00, 0x97, 0x8A, 0x89, 0x01, 0xBE, 0x00, 0x00, 0x00, 0x03, 0x00, 0xFF, 0x01, 0xB7, 0x00, 0x00, 0x00, 0x9E, 0x0A, 0x02, 0x00, 0xC7, 0x00, 0xEC, 0xFF, 0x9D, 0x0A, 0x15, 0x00, 0xE2, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x66, 0x00, 0xDD, 0x00, 0x00, 0x00, 0x88, 0x0A, 0x47, 0x01, 0x68, 0x00, 0x00, 0x00, 0x2A, 0x8A, 0xDA, 0x00, 0x34, 0x00, 0x00, 0x00, 0xC7, 0x09, 0x56, 0x01, 0x02, 0x00, 0x00, 0x00, 0x1B, 0x0A, 0x38, 0x00, 0xA7, 0x00, 0x00, 0x00, 0xD1, 0x09, 0xBE, 0x01, 0x1B, 0x00, 0x00, 0x00, 0x2A, 0x8A, 0x80, 0x00, 0x42, 0x00, 0x00, 0x00, 0x2A, 0x8A, 0x94, 0x01, 0x30, 0x00, 0x00, 0x00, 0x2D, 0x00, 0xF4, 0x01, 0xBF, 0x00, 0x00, 0x00, 0x1A, 0x0A, 0xB3, 0x00, 0xA5, 0x00, 0x00, 0x00, 0x1A, 0x0A, 0xC2, 0x01, 0x9B, 0x00, 0x00, 0x00, 0x18, 0x80, 0x78, 0x02, 0x14, 0x00, 0xD8, 0xFF, 0x10, 0x80, 0x61, 0x01, 0xDF, 0x00, 0x00, 0x00, 0x16, 0x80, 0x18, 0x02, 0x17, 0x01, 0x00, 0x00, 0x16, 0x80, 0x65, 0x00, 0xC1, 0x00, 0x00, 0x00, 0x16, 0x80, 0x0C, 0x00, 0xC8, 0x00, 0x00, 0x00, 0x18, 0x00, 0x28, 0x02, 0x15, 0x00, 0x00, 0x00, 0xDC, 0x1E, 0x49, 0x00, 0xE6, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xD4, 0x01, 0xC7, 0x00, 0x00, 0x00, 0x10, 0x00, 0xB9, 0x01, 0xDE, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x10, 0x00, 0xC5, 0x00, 0xF6, 0xFF, 0x14, 0x00, 0xF4, 0x00, 0xB8, 0x00, 0x00, 0x00, 0x14, 0x80, 0x21, 0x01, 0xB4, 0x00, 0x00, 0x00, 0x14, 0x80, 0xD7, 0x00, 0xE7, 0x00, 0xBD, 0xFF, 0x16, 0x80, 0x1A, 0x00, 0x06, 0x01, 0x00, 0x00, 0x16, 0x80, 0x48, 0x00, 0x20, 0x01, 0x00, 0x00, 0x14, 0x00, 0xBB, 0x01, 0xB4, 0x00, 0x00, 0x00, 0x16, 0x00, 0x62, 0x02, 0x06, 0x01, 0x00, 0x00, 0x99, 0x0A, 0x85, 0x00, 0x5E, 0x00, 0x00, 0x00, 0x99, 0x8A, 0x79, 0x01, 0x54, 0x00, 0x00, 0x00, 0x97, 0x0A, 0x6D, 0x00, 0xDA, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x93, 0x00, 0xD4, 0x00, 0x00, 0x00, 0x2A, 0x0A, 0x25, 0x00, 0x34, 0x00, 0x00, 0x00, 0x2A, 0x0A, 0x68, 0x00, 0x42, 0x00, 0x00, 0x00, 0x2A, 0x0A, 0x80, 0x01, 0x30, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x80, 0x01, 0xCB, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x4B, 0x01, 0xBC, 0x00, 0x00, 0x00, 0x18, 0x80, 0x86, 0x02, 0x46, 0x00, 0xD8, 0xFF, 0xE9, 0x80, 0x4F, 0x02, 0x53, 0x00, 0x00, 0x00, 0xE9, 0x80, 0x5C, 0x02, 0x17, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0xE9, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x55, 0x14, 0xF8, 0x00, 0xBE, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
