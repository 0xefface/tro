using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room2909 : Room
{
public Room2909()
: base(2909, "The Badlands")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.DesertBreezeLeft;
byte[] roomDecItems = { 0x2C, 0x79, 0x80, 0x86, 0x02, 0x21, 0x01, 0x00, 0x00, 0xF0, 0x05, 0xCA, 0x00, 0x0C, 0x01, 0x00, 0x00, 0xF0, 0x05, 0xC7, 0x00, 0xA6, 0x00, 0x00, 0x00, 0xF0, 0x05, 0x52, 0x00, 0x25, 0x01, 0x00, 0x00, 0xF1, 0x05, 0x31, 0x00, 0x12, 0x01, 0x00, 0x00, 0x36, 0x06, 0x15, 0x01, 0xA2, 0x00, 0x00, 0x00, 0x37, 0x06, 0x3D, 0x01, 0xA5, 0x00, 0x00, 0x00, 0x3A, 0x06, 0xA0, 0x00, 0x9E, 0x00, 0x00, 0x00, 0x3A, 0x06, 0x26, 0x00, 0x81, 0x00, 0x00, 0x00, 0x3A, 0x06, 0x4F, 0x00, 0x70, 0x00, 0x00, 0x00, 0x3A, 0x06, 0x35, 0x00, 0x60, 0x00, 0x00, 0x00, 0x3A, 0x06, 0x35, 0x00, 0x90, 0x00, 0x00, 0x00, 0x3B, 0x06, 0x23, 0x00, 0xC0, 0x00, 0x00, 0x00, 0x3B, 0x06, 0x97, 0x00, 0xC7, 0x00, 0x00, 0x00, 0x3B, 0x06, 0xBE, 0x00, 0xE2, 0x00, 0x00, 0x00, 0x3B, 0x06, 0xF8, 0x00, 0xC9, 0x00, 0x00, 0x00, 0x3B, 0x06, 0x42, 0x01, 0xE2, 0x00, 0x00, 0x00, 0x3B, 0x06, 0x25, 0x00, 0xD8, 0x00, 0x00, 0x00, 0x3B, 0x06, 0x46, 0x00, 0xDA, 0x00, 0x00, 0x00, 0x16, 0x80, 0x7E, 0x02, 0x92, 0x00, 0x00, 0x00, 0xB4, 0x00, 0x81, 0x00, 0x0E, 0x01, 0x00, 0x00, 0xB4, 0x00, 0xB9, 0x00, 0x22, 0x01, 0x00, 0x00, 0xB4, 0x00, 0x33, 0x01, 0x03, 0x01, 0x00, 0x00, 0xB4, 0x00, 0x47, 0x01, 0x1D, 0x01, 0x00, 0x00, 0xB4, 0x80, 0x14, 0x01, 0xF5, 0x00, 0x00, 0x00, 0xB4, 0x00, 0x32, 0x00, 0x1F, 0x01, 0x00, 0x00, 0xB4, 0x00, 0x01, 0x01, 0x09, 0x01, 0x00, 0x00, 0x3B, 0x06, 0x1A, 0x00, 0xB2, 0x00, 0x00, 0x00, 0x18, 0x00, 0x8C, 0x02, 0xFD, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x73, 0x02, 0x26, 0x01, 0x00, 0x00, 0x33, 0x00, 0xAF, 0x00, 0xA4, 0x00, 0x00, 0x00, 0x5D, 0x00, 0x4E, 0x01, 0x67, 0x00, 0x00, 0x00, 0x8C, 0x8B, 0x1D, 0x02, 0xF4, 0x00, 0x00, 0x00, 0xD3, 0xE2, 0xF4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x33, 0x00, 0x75, 0x00, 0x22, 0x01, 0x00, 0x00, 0x33, 0x00, 0x09, 0x00, 0xF0, 0x00, 0x00, 0x00, 0x33, 0x00, 0x3B, 0x01, 0xDB, 0x00, 0x00, 0x00, 0x3B, 0x06, 0x25, 0x00, 0xF1, 0x00, 0x00, 0x00, 0x15, 0x00, 0x70, 0x02, 0xE9, 0x00, 0x00, 0x00, 0x15, 0x00, 0x76, 0x02, 0x63, 0x00, 0x00, 0x00, 0x15, 0x80, 0x4D, 0x02, 0xA2, 0x00, 0x00, 0x00, 0x15, 0x80, 0x77, 0x02, 0xB7, 0x00, 0x00, 0x00, 0x18, 0x00, 0xB9, 0x02, 0xBE, 0x00, 0x00, 0x00, 0x16, 0x00, 0x93, 0x02, 0x76, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
base.ApplyRoomLayout();
}
}
}
