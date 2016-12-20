using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5611 : Room
{
public Room5611()
: base(5611, "Pedantic Pilfery")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x1C, 0xC5, 0x09, 0xB0, 0x00, 0x11, 0x00, 0x00, 0x00, 0xC5, 0x09, 0x08, 0x01, 0x21, 0x00, 0x00, 0x00, 0xC6, 0x09, 0xF1, 0x00, 0x2B, 0x00, 0x00, 0x00, 0xD8, 0x09, 0x92, 0x01, 0x12, 0x00, 0x00, 0x00, 0xC8, 0x09, 0xF7, 0x01, 0x22, 0x00, 0x28, 0x00, 0xFA, 0x09, 0xC1, 0x00, 0x80, 0x00, 0x00, 0x00, 0x98, 0x0A, 0xAF, 0x00, 0x9E, 0x00, 0xE2, 0xFF, 0x98, 0x8A, 0xF2, 0x00, 0xCC, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x07, 0x01, 0xDA, 0x00, 0x00, 0x00, 0x03, 0x00, 0x7B, 0x00, 0xAE, 0x00, 0x00, 0x00, 0x03, 0x00, 0x55, 0x01, 0xC8, 0x00, 0x00, 0x00, 0x03, 0x00, 0x79, 0x00, 0x9A, 0x00, 0x00, 0x00, 0x03, 0x00, 0x40, 0x01, 0xCA, 0x00, 0x00, 0x00, 0x03, 0x00, 0xE1, 0x00, 0xB3, 0x00, 0x00, 0x00, 0xB1, 0x0A, 0x24, 0x02, 0x6E, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xB6, 0x00, 0xD0, 0x00, 0x00, 0x00, 0xF9, 0x09, 0x5A, 0x01, 0x96, 0x00, 0x00, 0x00, 0xF4, 0x09, 0x19, 0x01, 0x97, 0x00, 0x00, 0x00, 0xF4, 0x09, 0xC1, 0x00, 0x86, 0x00, 0x00, 0x00, 0xF3, 0x09, 0x49, 0x01, 0xB1, 0x00, 0x00, 0x00, 0xFA, 0x09, 0x1A, 0x01, 0x92, 0x00, 0x00, 0x00, 0xAD, 0x0A, 0x38, 0x01, 0xCA, 0x00, 0x00, 0x00, 0x35, 0x8A, 0xBF, 0x02, 0x94, 0x00, 0x00, 0x00, 0x14, 0x00, 0xCE, 0x01, 0xB4, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x85, 0x00, 0xC1, 0x00, 0x00, 0x00, 0x36, 0x0A, 0x4C, 0x01, 0x30, 0x00, 0x00, 0x00, 0x36, 0x0A, 0xEC, 0x00, 0x32, 0x00, 0x0F, 0x00, 0x15, 0x80, 0x2A, 0x02, 0x10, 0x00, 0x6A, 0xFF };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0xDB, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xEB, 0x15, 0xBB, 0x01, 0xC2, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}