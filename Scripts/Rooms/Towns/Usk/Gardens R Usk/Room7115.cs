using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room7115 : Room
{
public Room7115()
: base(7115, "Gardens R Usk")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.SnowyDesert;
this.BlockedRoomExits = BlockedExits.UpRight;
byte[] roomDecItems = { 0x29, 0xDD, 0x09, 0xFB, 0x00, 0x49, 0x00, 0x00, 0x00, 0xC7, 0x8A, 0x6D, 0x02, 0xB9, 0x00, 0x00, 0x00, 0xDD, 0x09, 0x35, 0x02, 0x47, 0x00, 0x00, 0x00, 0xDE, 0x09, 0x45, 0x01, 0x4E, 0x00, 0x00, 0x00, 0xDE, 0x09, 0xC2, 0x01, 0x4E, 0x00, 0x00, 0x00, 0x0B, 0x18, 0xF3, 0x00, 0xF3, 0x00, 0x00, 0x00, 0x0B, 0x18, 0x67, 0x00, 0xFB, 0x00, 0x00, 0x00, 0x84, 0x17, 0x64, 0x02, 0x41, 0x01, 0x00, 0x00, 0x76, 0x97, 0xD5, 0x00, 0xCE, 0x00, 0x00, 0x00, 0x14, 0x98, 0x1F, 0x02, 0xF6, 0x00, 0x00, 0x00, 0x47, 0x0A, 0x12, 0x01, 0x56, 0x00, 0x00, 0x00, 0x49, 0x0A, 0x67, 0x01, 0x57, 0x00, 0x00, 0x00, 0x4A, 0x0A, 0x26, 0x02, 0x57, 0x00, 0x00, 0x00, 0x49, 0x0A, 0xBF, 0x01, 0x57, 0x00, 0x00, 0x00, 0xFE, 0x17, 0x12, 0x01, 0x5E, 0x00, 0x00, 0x00, 0xFE, 0x17, 0xEA, 0x01, 0x5C, 0x00, 0x00, 0x00, 0xFE, 0x17, 0x98, 0x01, 0x5D, 0x00, 0x00, 0x00, 0xFE, 0x17, 0x2D, 0x02, 0x5B, 0x00, 0x00, 0x00, 0xEF, 0x09, 0x2B, 0x01, 0xBC, 0x00, 0x00, 0x00, 0xF2, 0x09, 0x2B, 0x01, 0xC0, 0x00, 0x0C, 0x00, 0xF2, 0x09, 0x1E, 0x02, 0xC3, 0x00, 0x0D, 0x00, 0xEF, 0x09, 0x1D, 0x02, 0xBA, 0x00, 0x00, 0x00, 0x82, 0x17, 0x09, 0x00, 0xBF, 0x00, 0x00, 0x00, 0x7F, 0x17, 0xF2, 0x00, 0xE6, 0x00, 0x00, 0x00, 0x99, 0x17, 0x6D, 0x00, 0xFC, 0x00, 0x00, 0x00, 0x7F, 0x17, 0x7C, 0x02, 0xF0, 0x00, 0x00, 0x00, 0x83, 0x17, 0xBF, 0x00, 0xE5, 0x00, 0x00, 0x00, 0x7E, 0x17, 0x76, 0x02, 0xF2, 0x00, 0x00, 0x00, 0x84, 0x97, 0x65, 0x02, 0xF2, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0xC6, 0x00, 0x8D, 0x00, 0x00, 0x00, 0x90, 0x17, 0xF5, 0xFF, 0x9B, 0x00, 0x00, 0x00, 0xC9, 0x8A, 0x6C, 0x02, 0x8A, 0x00, 0x00, 0x00, 0x07, 0x98, 0x07, 0x00, 0x92, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0xC5, 0x00, 0xC2, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0xC6, 0x00, 0xDF, 0x00, 0xF6, 0xFF, 0x0B, 0x98, 0x24, 0x00, 0xAC, 0x00, 0x00, 0x00, 0x99, 0x97, 0x5F, 0x00, 0x04, 0x01, 0x00, 0x00, 0xCA, 0x8A, 0x6D, 0x02, 0xE7, 0x00, 0x00, 0x00, 0x74, 0x17, 0x4F, 0x02, 0xE1, 0x00, 0x00, 0x00, 0x98, 0x17, 0x58, 0x00, 0xD8, 0x00, 0x00, 0x00, 0x98, 0x97, 0x51, 0x00, 0xDD, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0x5B, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xCB, 0x1B, 0xB3, 0x01, 0xED, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
