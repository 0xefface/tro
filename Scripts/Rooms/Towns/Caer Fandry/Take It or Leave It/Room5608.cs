using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5608 : Room
{
public Room5608()
: base(5608, "Take It or Leave It")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x1F, 0xD4, 0x09, 0x96, 0x00, 0x10, 0x00, 0x00, 0x00, 0x35, 0x0A, 0xD1, 0xFF, 0xA9, 0x00, 0x00, 0x00, 0x37, 0x8A, 0xD2, 0xFF, 0xCE, 0x00, 0x96, 0x00, 0xDC, 0x09, 0x2F, 0x00, 0xC0, 0x00, 0x96, 0x00, 0xDD, 0x09, 0xCF, 0x00, 0x20, 0x00, 0x00, 0x00, 0x39, 0x0A, 0xE5, 0x00, 0x34, 0x00, 0x00, 0x00, 0xDD, 0x09, 0x9C, 0x01, 0x20, 0x00, 0x00, 0x00, 0x39, 0x0A, 0x90, 0x01, 0x2E, 0x00, 0x00, 0x00, 0xDF, 0x09, 0x35, 0x01, 0x35, 0x00, 0x32, 0x00, 0x3A, 0x0A, 0x34, 0x01, 0x5D, 0x00, 0x32, 0x00, 0x1C, 0x0A, 0x0F, 0x01, 0xA4, 0x00, 0x00, 0x00, 0xC1, 0x08, 0xAA, 0x00, 0xC7, 0x00, 0x00, 0x00, 0x25, 0x0A, 0x1F, 0x01, 0x88, 0x00, 0x00, 0x00, 0xC1, 0x08, 0xE1, 0x01, 0xCA, 0x00, 0x00, 0x00, 0x9C, 0x0A, 0x0A, 0x02, 0x49, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0x5A, 0x02, 0x18, 0x00, 0x00, 0x00, 0x9C, 0x8A, 0x05, 0x02, 0x5C, 0x00, 0x00, 0x00, 0x99, 0x0A, 0xB2, 0x01, 0xC0, 0x00, 0x50, 0x00, 0x9B, 0x0A, 0xA5, 0x01, 0xBF, 0x00, 0x00, 0x00, 0x9A, 0x0A, 0xBC, 0x01, 0xC0, 0x00, 0x1E, 0x00, 0x9A, 0x8A, 0xC2, 0x00, 0xC5, 0x00, 0x1E, 0x00, 0x9B, 0x8A, 0xF2, 0x00, 0xC3, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xF2, 0x00, 0xC7, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x9D, 0x01, 0xCC, 0x00, 0x00, 0x00, 0x31, 0x00, 0xDE, 0x01, 0x71, 0x00, 0x00, 0x00, 0x17, 0x00, 0x30, 0x02, 0x03, 0x00, 0x00, 0x00, 0xC4, 0x08, 0x17, 0x00, 0xE5, 0x00, 0x38, 0x00, 0x38, 0x08, 0x1A, 0x00, 0xE4, 0x00, 0x00, 0x00, 0x10, 0x80, 0xBD, 0xFF, 0x0E, 0x01, 0x00, 0x00, 0x10, 0x80, 0x8A, 0x00, 0xDE, 0x00, 0x00, 0x00, 0xE3, 0x1E, 0xD9, 0x01, 0xD2, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0xC9, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xE8, 0x15, 0x67, 0x00, 0xCD, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}