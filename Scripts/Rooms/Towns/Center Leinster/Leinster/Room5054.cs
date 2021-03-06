using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5054 : Room
{
public Room5054()
: base(5054, "Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x1B, 0xC5, 0x09, 0x53, 0x02, 0x47, 0x00, 0x00, 0x00, 0x43, 0x0A, 0x23, 0x02, 0x3E, 0x00, 0x00, 0x00, 0x2A, 0x0A, 0x8B, 0x02, 0x41, 0x00, 0x00, 0x00, 0x15, 0x00, 0xC3, 0x00, 0x31, 0x00, 0x00, 0x00, 0x17, 0x00, 0x04, 0x02, 0x04, 0x00, 0x00, 0x00, 0x16, 0x00, 0x68, 0x00, 0x05, 0x00, 0x00, 0x00, 0x14, 0x00, 0x42, 0x02, 0xE3, 0x00, 0x00, 0x00, 0x16, 0x80, 0xF9, 0xFF, 0x20, 0x00, 0x00, 0x00, 0x16, 0x80, 0x42, 0x00, 0x2E, 0x00, 0x00, 0x00, 0x15, 0x00, 0x3C, 0x00, 0x4E, 0x00, 0x00, 0x00, 0x16, 0x80, 0x4B, 0x00, 0x67, 0x00, 0x00, 0x00, 0x16, 0x80, 0xF3, 0xFF, 0x73, 0x00, 0x00, 0x00, 0x17, 0x80, 0x97, 0x00, 0x3D, 0x00, 0x00, 0x00, 0x15, 0x80, 0xB2, 0x00, 0x0E, 0x00, 0x00, 0x00, 0x15, 0x80, 0x27, 0x02, 0x2F, 0x00, 0x00, 0x00, 0xB9, 0x0A, 0x15, 0x02, 0x2D, 0x00, 0x00, 0x00, 0xC1, 0x08, 0x3B, 0x02, 0xF4, 0x00, 0x00, 0x00, 0x79, 0x00, 0x22, 0x02, 0xEB, 0x00, 0x00, 0x00, 0x71, 0x00, 0x0E, 0x02, 0xE4, 0x00, 0x00, 0x00, 0x70, 0x00, 0x2C, 0x02, 0xEC, 0x00, 0x00, 0x00, 0x0E, 0x00, 0x81, 0x02, 0x06, 0x01, 0x00, 0x00, 0x16, 0x00, 0x55, 0x00, 0x19, 0x01, 0x00, 0x00, 0x2D, 0x00, 0x25, 0x00, 0x64, 0x00, 0x00, 0x00, 0x2D, 0x80, 0x69, 0x00, 0x49, 0x00, 0x00, 0x00, 0x70, 0x00, 0x3C, 0x00, 0x65, 0x00, 0x00, 0x00, 0x70, 0x00, 0x71, 0x00, 0x4A, 0x00, 0x00, 0x00, 0x98, 0x0A, 0x18, 0x00, 0x5E, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
