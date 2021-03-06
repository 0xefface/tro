using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5085 : Room
{
public Room5085()
: base(5085, "East Leinster")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.Down;
byte[] roomDecItems = { 0x4B, 0x17, 0x80, 0xC2, 0x00, 0x01, 0x00, 0x00, 0x00, 0x15, 0x00, 0xE7, 0x00, 0xC6, 0x00, 0x00, 0x00, 0x17, 0x00, 0x4C, 0x00, 0xD1, 0x00, 0x00, 0x00, 0x16, 0x00, 0x5C, 0x02, 0xD0, 0x00, 0x00, 0x00, 0x16, 0x00, 0x1C, 0x02, 0x17, 0x01, 0x00, 0x00, 0x16, 0x80, 0x51, 0x00, 0x15, 0x01, 0x00, 0x00, 0x17, 0x80, 0xD8, 0x01, 0xC7, 0x00, 0x00, 0x00, 0x15, 0x00, 0xBC, 0x01, 0xF3, 0x00, 0x00, 0x00, 0x15, 0x80, 0x91, 0x00, 0xEE, 0x00, 0x00, 0x00, 0x15, 0x80, 0x4C, 0x01, 0xC8, 0x00, 0x00, 0x00, 0x16, 0x80, 0x07, 0x00, 0xC8, 0x00, 0x00, 0x00, 0x15, 0x80, 0x57, 0x00, 0xB8, 0x00, 0x00, 0x00, 0x2C, 0x00, 0xC3, 0x01, 0x11, 0x01, 0x00, 0x00, 0x16, 0x80, 0x07, 0x00, 0x2F, 0x00, 0x00, 0x00, 0x15, 0x00, 0x02, 0x02, 0xB3, 0x00, 0x00, 0x00, 0xE7, 0x89, 0x52, 0x01, 0xD1, 0x01, 0x00, 0x00, 0x15, 0x80, 0x4A, 0x02, 0x28, 0x00, 0x00, 0x00, 0x17, 0x00, 0xF6, 0x00, 0xA8, 0x00, 0x00, 0x00, 0x15, 0x00, 0x8A, 0x01, 0xAA, 0x00, 0x00, 0x00, 0x17, 0x00, 0xE2, 0x01, 0x14, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x52, 0x00, 0x39, 0x01, 0x00, 0x00, 0x15, 0x00, 0x52, 0x00, 0x04, 0x00, 0x00, 0x00, 0x15, 0x80, 0x25, 0x02, 0x01, 0x00, 0x00, 0x00, 0x16, 0x00, 0x5E, 0x00, 0x16, 0x00, 0x00, 0x00, 0x88, 0x0B, 0x16, 0x00, 0x2D, 0x01, 0x00, 0x00, 0x88, 0x0B, 0x66, 0x02, 0x33, 0x01, 0x00, 0x00, 0xE7, 0x89, 0x15, 0x00, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x89, 0xB1, 0x00, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x89, 0x63, 0x00, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x89, 0xF6, 0x01, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x09, 0x6F, 0x01, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x09, 0xCF, 0x00, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x09, 0x13, 0x02, 0xD1, 0x01, 0x00, 0x00, 0x2B, 0x00, 0x01, 0x01, 0x31, 0x01, 0x00, 0x00, 0xE7, 0x89, 0x04, 0x01, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x09, 0x1F, 0x01, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x09, 0xBF, 0x01, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x89, 0xA3, 0x01, 0xD1, 0x01, 0x00, 0x00, 0x2B, 0x00, 0xB5, 0x00, 0x08, 0x01, 0x00, 0x00, 0x2B, 0x00, 0x6A, 0x00, 0x06, 0x01, 0x00, 0x00, 0x2B, 0x00, 0x7C, 0x01, 0xF2, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0x66, 0x02, 0x0C, 0x00, 0x00, 0x00, 0x40, 0x00, 0x02, 0x00, 0x29, 0x01, 0x00, 0x00, 0x40, 0x00, 0xE2, 0x00, 0xC6, 0x00, 0x00, 0x00, 0x40, 0x80, 0xD3, 0x01, 0x19, 0x01, 0x00, 0x00, 0x40, 0x00, 0xFD, 0xFF, 0x23, 0x00, 0x00, 0x00, 0x40, 0x00, 0x84, 0x00, 0x30, 0x00, 0x00, 0x00, 0x40, 0x80, 0x2D, 0x02, 0x29, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x31, 0x00, 0x42, 0x00, 0x00, 0x00, 0x15, 0x00, 0x32, 0x01, 0xDC, 0x00, 0x00, 0x00, 0x16, 0x00, 0x40, 0x01, 0xFC, 0x00, 0x00, 0x00, 0x16, 0x00, 0x67, 0x00, 0xFA, 0x00, 0x00, 0x00, 0x16, 0x00, 0x55, 0x02, 0xFE, 0x00, 0x00, 0x00, 0x15, 0x80, 0x2E, 0x02, 0xEA, 0x00, 0x00, 0x00, 0x15, 0x00, 0xFD, 0x00, 0x1B, 0x01, 0x00, 0x00, 0x16, 0x00, 0x93, 0x01, 0x1A, 0x01, 0x00, 0x00, 0x2B, 0x00, 0x7E, 0x00, 0x26, 0x01, 0x00, 0x00, 0xE7, 0x89, 0x48, 0x02, 0xD1, 0x01, 0x00, 0x00, 0x2B, 0x00, 0x36, 0x02, 0x32, 0x01, 0x00, 0x00, 0x2B, 0x00, 0xF9, 0x01, 0x35, 0x01, 0x00, 0x00, 0x2B, 0x00, 0xA2, 0x01, 0x3B, 0x01, 0x00, 0x00, 0xE7, 0x09, 0x65, 0x02, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x09, 0x80, 0x00, 0xD1, 0x01, 0x00, 0x00, 0xE7, 0x09, 0x2F, 0x00, 0xD1, 0x01, 0x00, 0x00, 0x2B, 0x00, 0x1D, 0x02, 0x06, 0x01, 0x00, 0x00, 0x88, 0x0B, 0xDB, 0x00, 0x23, 0x01, 0x00, 0x00, 0x2B, 0x00, 0x6A, 0x02, 0x49, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x44, 0x02, 0x31, 0x00, 0x00, 0x00, 0x8B, 0x8B, 0x12, 0x00, 0x13, 0x00, 0x00, 0x00, 0xDE, 0x1E, 0x50, 0x00, 0x2A, 0x00, 0x00, 0x00, 0xDE, 0x1E, 0x58, 0x02, 0x2A, 0x00, 0x00, 0x00, 0x2D, 0x00, 0x44, 0x01, 0x1D, 0x01, 0x00, 0x00, 0xDE, 0x1E, 0x87, 0x00, 0x48, 0x01, 0x00, 0x00, 0xDE, 0x1E, 0xA2, 0x01, 0x48, 0x01, 0x00, 0x00, 0xE3, 0x1E, 0x4F, 0x02, 0x40, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
