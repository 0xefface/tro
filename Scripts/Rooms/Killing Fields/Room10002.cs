using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room10002 : Room
{
public Room10002()
: base(10002, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
byte[] roomDecItems = { 0x32, 0xB7, 0x0A, 0x38, 0x02, 0x83, 0x00, 0x00, 0x00, 0xA8, 0x00, 0x43, 0x00, 0x84, 0x00, 0x00, 0x00, 0x7F, 0x00, 0x18, 0x00, 0x2B, 0x01, 0x00, 0x00, 0x3C, 0x00, 0x1A, 0x00, 0x46, 0x01, 0x00, 0x00, 0xA5, 0x00, 0x75, 0x00, 0x6C, 0x00, 0x00, 0x00, 0xA5, 0x80, 0x62, 0x02, 0x71, 0x00, 0x00, 0x00, 0xB6, 0x0A, 0x50, 0x01, 0x6E, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x40, 0x02, 0x83, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x99, 0x01, 0x71, 0x00, 0x00, 0x00, 0x99, 0x00, 0x74, 0x02, 0x87, 0x00, 0x00, 0x00, 0x98, 0x00, 0xD1, 0x00, 0x70, 0x00, 0x00, 0x00, 0xAF, 0x00, 0x35, 0x01, 0x65, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x5B, 0x00, 0x71, 0x00, 0x00, 0x00, 0x9C, 0x80, 0xC6, 0x01, 0x71, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xFD, 0x00, 0x77, 0x00, 0x00, 0x00, 0xDF, 0x80, 0x55, 0x02, 0x86, 0x00, 0x00, 0x00, 0xDF, 0x80, 0x66, 0x00, 0x48, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x09, 0x00, 0x14, 0x01, 0x00, 0x00, 0xE0, 0x00, 0x58, 0x00, 0x7B, 0x00, 0x00, 0x00, 0xE0, 0x00, 0x38, 0x02, 0x7D, 0x00, 0x00, 0x00, 0xE0, 0x00, 0xAE, 0x01, 0x74, 0x00, 0x00, 0x00, 0xC6, 0x04, 0xE9, 0x00, 0x7C, 0x00, 0x00, 0x00, 0xC6, 0x04, 0x37, 0x02, 0x85, 0x00, 0x00, 0x00, 0xC6, 0x04, 0x48, 0x00, 0x81, 0x00, 0x00, 0x00, 0xDE, 0x80, 0x4A, 0x02, 0x0F, 0x01, 0x00, 0x00, 0xDE, 0x80, 0x80, 0x02, 0x8F, 0x00, 0x00, 0x00, 0xC6, 0x04, 0xD8, 0x01, 0x16, 0x01, 0x00, 0x00, 0xB1, 0x00, 0x07, 0x01, 0x55, 0x00, 0x00, 0x00, 0xB1, 0x80, 0x50, 0x02, 0x4A, 0x00, 0x00, 0x00, 0xB1, 0x00, 0x6A, 0x00, 0x4A, 0x00, 0x00, 0x00, 0xB1, 0x00, 0xE3, 0xFF, 0x47, 0x00, 0x00, 0x00, 0xB4, 0x80, 0x50, 0x00, 0x7C, 0x00, 0x00, 0x00, 0xB4, 0x00, 0x56, 0x02, 0x86, 0x00, 0x00, 0x00, 0xB6, 0x00, 0xA7, 0x01, 0x16, 0x01, 0x00, 0x00, 0xB6, 0x80, 0xED, 0x00, 0x7C, 0x00, 0x00, 0x00, 0xBA, 0x00, 0x66, 0x02, 0x21, 0x01, 0x00, 0x00, 0xBA, 0x00, 0x32, 0x00, 0xDC, 0x00, 0x00, 0x00, 0x5E, 0x00, 0x4F, 0x01, 0x63, 0x00, 0x00, 0x00, 0x56, 0x04, 0xBA, 0x00, 0x7F, 0x00, 0x00, 0x00, 0xBA, 0x00, 0x27, 0x01, 0x13, 0x01, 0x00, 0x00, 0x2D, 0x00, 0x7F, 0x02, 0x40, 0x01, 0x00, 0x00, 0x01, 0x00, 0x05, 0x02, 0x7F, 0x00, 0x00, 0x00, 0x01, 0x00, 0x11, 0x02, 0x7F, 0x00, 0x00, 0x00, 0x01, 0x00, 0x1D, 0x02, 0x7F, 0x00, 0x00, 0x00, 0x01, 0x00, 0x29, 0x02, 0x7F, 0x00, 0x00, 0x00, 0x01, 0x00, 0x35, 0x02, 0x7F, 0x00, 0x00, 0x00, 0x01, 0x00, 0x41, 0x02, 0x7F, 0x00, 0x00, 0x00, 0x01, 0x00, 0x4D, 0x02, 0x7F, 0x00, 0x00, 0x00, 0x01, 0x00, 0x58, 0x02, 0x7F, 0x00, 0x00, 0x00, 0x01, 0x00, 0x66, 0x02, 0x7F, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
base.ApplyRoomLayout();
}
}
}
