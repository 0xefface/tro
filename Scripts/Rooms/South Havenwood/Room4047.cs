using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room4047 : Room
{
public Room4047()
: base(4047, "South Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
byte[] roomDecItems = { 0x1F, 0xB6, 0x8A, 0x6C, 0x00, 0x6D, 0x00, 0x00, 0x00, 0xA5, 0x00, 0x00, 0x02, 0x71, 0x00, 0x00, 0x00, 0xAF, 0x00, 0x35, 0x01, 0x67, 0x00, 0x00, 0x00, 0xC6, 0x04, 0x32, 0x02, 0xF8, 0x00, 0x00, 0x00, 0x9A, 0x80, 0xFA, 0x01, 0x79, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x29, 0x00, 0x77, 0x00, 0x00, 0x00, 0x70, 0x00, 0x79, 0x00, 0xFB, 0x00, 0x00, 0x00, 0x70, 0x00, 0x9B, 0x00, 0xFE, 0x00, 0x00, 0x00, 0x70, 0x00, 0x6D, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x87, 0x0B, 0x54, 0x00, 0x90, 0x00, 0x00, 0x00, 0x88, 0x0B, 0x8A, 0x00, 0xFD, 0x00, 0x00, 0x00, 0x31, 0x00, 0x29, 0x02, 0xF0, 0x00, 0x00, 0x00, 0x30, 0x00, 0x49, 0x02, 0xEE, 0x00, 0x00, 0x00, 0x70, 0x00, 0x45, 0x00, 0x8F, 0x00, 0x00, 0x00, 0x70, 0x00, 0x5D, 0x00, 0x93, 0x00, 0x00, 0x00, 0x6F, 0x00, 0x33, 0x02, 0xF1, 0x00, 0x00, 0x00, 0x05, 0x00, 0xE0, 0x01, 0x79, 0x00, 0x00, 0x00, 0x05, 0x00, 0xF6, 0x01, 0x7A, 0x00, 0x00, 0x00, 0x05, 0x00, 0x0A, 0x02, 0x7A, 0x00, 0x00, 0x00, 0x05, 0x00, 0x37, 0x00, 0x77, 0x00, 0x00, 0x00, 0x05, 0x00, 0x1F, 0x00, 0x78, 0x00, 0x00, 0x00, 0x05, 0x00, 0x0A, 0x00, 0x77, 0x00, 0x00, 0x00, 0xEA, 0x00, 0x1B, 0x01, 0x68, 0x00, 0x00, 0x00, 0xE8, 0x00, 0x14, 0x01, 0x6E, 0x00, 0x00, 0x00, 0xE8, 0x00, 0x13, 0x01, 0x81, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x13, 0x01, 0x99, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x1E, 0x01, 0xC2, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x23, 0x01, 0xEA, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x37, 0x01, 0xE5, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x21, 0x01, 0xAF, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x15, 0x01, 0x86, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
base.ApplyRoomLayout();
}
}
}
