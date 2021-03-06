using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5055 : Room
{
public Room5055()
: base(5055, "East Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x17, 0xD9, 0x09, 0x24, 0x00, 0x6B, 0x00, 0x00, 0x00, 0xD9, 0x09, 0x71, 0x00, 0x60, 0x00, 0x00, 0x00, 0xDA, 0x09, 0x5D, 0x00, 0x6D, 0x00, 0x00, 0x00, 0x37, 0x8A, 0xF5, 0x01, 0xCA, 0x00, 0x96, 0x00, 0xD4, 0x09, 0xCA, 0x02, 0x06, 0x00, 0x00, 0x00, 0x35, 0x0A, 0x17, 0x02, 0x8D, 0x00, 0x00, 0x00, 0xDC, 0x09, 0x46, 0x02, 0x90, 0x00, 0x64, 0x00, 0xCF, 0x09, 0xBE, 0x01, 0xA5, 0x00, 0x96, 0x00, 0xCD, 0x09, 0xE7, 0x01, 0x85, 0x00, 0x00, 0x00, 0xCD, 0x09, 0x9C, 0x01, 0x7A, 0x00, 0x00, 0x00, 0x35, 0x0A, 0xDA, 0x01, 0x85, 0x00, 0x00, 0x00, 0xCE, 0x09, 0x7D, 0x01, 0xBD, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x81, 0x00, 0xB3, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xC7, 0x00, 0xA5, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xD9, 0x00, 0x94, 0x00, 0x00, 0x00, 0x9E, 0x0A, 0x9E, 0x00, 0x9D, 0x00, 0x00, 0x00, 0xBD, 0x0A, 0xAA, 0xFF, 0x6A, 0x00, 0x00, 0x00, 0x8A, 0x0B, 0x4A, 0x02, 0xD9, 0x00, 0x00, 0x00, 0x2F, 0x8A, 0x24, 0x00, 0x79, 0x00, 0x00, 0x00, 0x30, 0x8A, 0xE7, 0xFF, 0x85, 0x00, 0x00, 0x00, 0x89, 0x0B, 0x6D, 0x01, 0x58, 0x00, 0x00, 0x00, 0xBC, 0x0A, 0x2E, 0x01, 0x6B, 0x00, 0x00, 0x00, 0x03, 0x00, 0x49, 0x00, 0xAA, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
