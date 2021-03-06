using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5300 : Room
{
public Room5300()
: base(5300, "Monmouth Necessaries")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x34, 0xDD, 0x09, 0x80, 0x00, 0x49, 0x00, 0x00, 0x00, 0xDE, 0x09, 0xC8, 0x00, 0x4F, 0x00, 0x00, 0x00, 0xDD, 0x09, 0x88, 0x01, 0x48, 0x00, 0x00, 0x00, 0xDE, 0x09, 0x45, 0x01, 0x4E, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xE5, 0xFF, 0xEE, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xBC, 0x01, 0xFC, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x2E, 0x00, 0xF8, 0x00, 0x00, 0x00, 0x3C, 0x00, 0xC4, 0x01, 0xF1, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0x70, 0x00, 0x30, 0x01, 0x00, 0x00, 0x8B, 0x8B, 0x1E, 0x00, 0x3A, 0x01, 0x00, 0x00, 0x47, 0x0A, 0x93, 0x00, 0x5B, 0x00, 0x00, 0x00, 0x49, 0x0A, 0x10, 0x01, 0x5B, 0x00, 0x00, 0x00, 0x4A, 0x0A, 0x89, 0x01, 0x5A, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x21, 0x00, 0xE7, 0x00, 0x00, 0x00, 0x33, 0x0A, 0x8D, 0x00, 0x60, 0x00, 0x00, 0x00, 0x33, 0x0A, 0x0E, 0x01, 0x5C, 0x00, 0x00, 0x00, 0x33, 0x0A, 0x83, 0x01, 0x5C, 0x00, 0x00, 0x00, 0x89, 0x0B, 0xDB, 0xFF, 0xD8, 0x00, 0x00, 0x00, 0xEF, 0x09, 0x87, 0x01, 0xC0, 0x00, 0x00, 0x00, 0xF2, 0x09, 0x88, 0x01, 0xC6, 0x00, 0x0C, 0x00, 0xF2, 0x09, 0x88, 0x00, 0xC6, 0x00, 0x0D, 0x00, 0xEF, 0x09, 0x86, 0x00, 0xC0, 0x00, 0x00, 0x00, 0xC1, 0x08, 0x63, 0x01, 0xF6, 0x00, 0x00, 0x00, 0x2E, 0x00, 0xB5, 0x00, 0xE5, 0x00, 0x00, 0x00, 0x2E, 0x80, 0x56, 0x01, 0xE3, 0x00, 0x00, 0x00, 0x2E, 0x00, 0xC4, 0x01, 0xE6, 0x00, 0x00, 0x00, 0x32, 0x00, 0x4F, 0x00, 0xF2, 0x00, 0x00, 0x00, 0xE5, 0x1E, 0xB9, 0x00, 0xF8, 0x00, 0x00, 0x00, 0x3C, 0x80, 0xF3, 0x01, 0xA3, 0x00, 0x00, 0x00, 0xE5, 0x1E, 0x63, 0x01, 0xF8, 0x00, 0x00, 0x00, 0xC4, 0x08, 0xB0, 0x00, 0xF5, 0x00, 0x00, 0x00, 0x98, 0x8A, 0x0B, 0x00, 0xEB, 0x00, 0x00, 0x00, 0x98, 0x8A, 0x09, 0x00, 0xAC, 0x00, 0x00, 0x00, 0x98, 0x8A, 0x0F, 0x00, 0x5E, 0x00, 0x00, 0x00, 0xBA, 0x8A, 0x24, 0x02, 0x41, 0x00, 0xAE, 0xFF, 0xD1, 0x09, 0xE3, 0x01, 0x01, 0x00, 0x00, 0x00, 0x51, 0x0A, 0x06, 0x02, 0x48, 0x00, 0x00, 0x00, 0x52, 0x0A, 0x06, 0x02, 0x2D, 0x00, 0x9E, 0xFF, 0x52, 0x0A, 0xC0, 0x01, 0x38, 0x00, 0x9E, 0xFF, 0x51, 0x0A, 0xC0, 0x01, 0x49, 0x00, 0x00, 0x00, 0x5B, 0x0A, 0xD2, 0x01, 0x34, 0x00, 0x00, 0x00, 0x5E, 0x0A, 0xDA, 0x01, 0x18, 0x00, 0xA5, 0xFF, 0x19, 0x80, 0xFC, 0x01, 0x9B, 0x00, 0x00, 0x00, 0x6F, 0x00, 0xF3, 0x01, 0xA4, 0x00, 0x00, 0x00, 0x1A, 0x00, 0x73, 0x02, 0x02, 0x00, 0xE2, 0xFF, 0x19, 0x80, 0x43, 0x02, 0x44, 0x00, 0x00, 0x00, 0x15, 0x00, 0x73, 0x02, 0x04, 0x00, 0x00, 0x00, 0xB0, 0x0A, 0x11, 0x02, 0x28, 0x00, 0x00, 0x00, 0x15, 0x00, 0x2E, 0x00, 0x03, 0x00, 0x00, 0x00, 0xBA, 0x8A, 0x94, 0x00, 0x3A, 0x00, 0xAD, 0xFF, 0x14, 0x00, 0xF3, 0x00, 0xE1, 0x00, 0x00, 0x00, 0x14, 0x80, 0x13, 0x01, 0xE3, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0x5E, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xB4, 0x14, 0x05, 0x01, 0xEE, 0x00, 0x02, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
