using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5012 : Room
{
public Room5012()
: base(5012, "Troll Spit Tavern")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x24, 0xC8, 0x09, 0x36, 0x02, 0x04, 0x00, 0x00, 0x00, 0xDD, 0x09, 0xF5, 0x01, 0x1C, 0x00, 0x00, 0x00, 0x03, 0x00, 0x7A, 0x02, 0xC7, 0x00, 0x00, 0x00, 0xDF, 0x09, 0x9C, 0x01, 0xA2, 0x00, 0x96, 0x00, 0xD4, 0x09, 0x02, 0x01, 0x12, 0x00, 0x00, 0x00, 0x35, 0x0A, 0x4B, 0x00, 0xA2, 0x00, 0x14, 0x00, 0x35, 0x8A, 0xC3, 0x02, 0x41, 0x01, 0xC8, 0x00, 0xCD, 0x09, 0x20, 0x00, 0x91, 0x00, 0x00, 0x00, 0x39, 0x0A, 0x49, 0x01, 0xAB, 0x00, 0x96, 0x00, 0x39, 0x0A, 0xF2, 0x01, 0xAC, 0x00, 0x96, 0x00, 0x3A, 0x0A, 0x9E, 0x01, 0xF4, 0x00, 0xC8, 0x00, 0x3D, 0x0A, 0x82, 0x03, 0xA2, 0x00, 0x00, 0x00, 0x42, 0x0A, 0xC3, 0xFF, 0x9C, 0x00, 0x14, 0x00, 0x48, 0x0A, 0x46, 0x01, 0x27, 0x00, 0x00, 0x00, 0x48, 0x0A, 0xF0, 0x01, 0x27, 0x00, 0x00, 0x00, 0x4B, 0x0A, 0x9E, 0x01, 0x36, 0x01, 0xFA, 0x00, 0xDD, 0x09, 0x3D, 0x01, 0x1B, 0x00, 0x00, 0x00, 0x03, 0x00, 0xD6, 0x01, 0xC8, 0x00, 0x00, 0x00, 0x8B, 0x0A, 0x08, 0x01, 0x81, 0x00, 0x19, 0x00, 0x94, 0x0A, 0xFD, 0x00, 0x71, 0x00, 0x32, 0x00, 0xB6, 0x0A, 0x79, 0xFF, 0x0E, 0x00, 0x9D, 0xFF, 0x9D, 0x0A, 0x38, 0x00, 0xE9, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x04, 0x02, 0xC8, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x2E, 0x01, 0xCE, 0x00, 0x00, 0x00, 0x9B, 0x0A, 0x35, 0x02, 0xB4, 0x00, 0x00, 0x00, 0x9A, 0x0A, 0x4C, 0x02, 0xB4, 0x00, 0x00, 0x00, 0x9A, 0x8A, 0x2F, 0x00, 0xD0, 0x00, 0x00, 0x00, 0x9B, 0x0A, 0x40, 0x00, 0xCD, 0x00, 0x00, 0x00, 0xEF, 0x09, 0x9A, 0x01, 0xA8, 0x00, 0x00, 0x00, 0x8B, 0x8B, 0x3D, 0x02, 0xBB, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x24, 0x00, 0x18, 0x00, 0xD8, 0xFF, 0x03, 0x00, 0x0A, 0x00, 0xDB, 0x00, 0x00, 0x00, 0x03, 0x00, 0x69, 0x00, 0xDE, 0x00, 0x00, 0x00, 0xEF, 0x09, 0x3B, 0x01, 0x73, 0x00, 0xCE, 0xFF, 0xEF, 0x09, 0xFC, 0x01, 0xA3, 0x00, 0x00, 0x00, 0xE8, 0x09, 0x1C, 0x00, 0x1F, 0x00, 0xD8, 0xFF };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0xE2, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x94, 0x13, 0xD4, 0x00, 0xD0, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}