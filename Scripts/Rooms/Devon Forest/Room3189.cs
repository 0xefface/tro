using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room3189 : Room
{
public Room3189()
: base(3189, "Devon Forest")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
byte[] roomDecItems = { 0x3F, 0xB1, 0x00, 0x1C, 0x01, 0x67, 0x00, 0x00, 0x00, 0xB1, 0x00, 0x9A, 0x01, 0x67, 0x00, 0x00, 0x00, 0xB1, 0x00, 0x4A, 0x02, 0x69, 0x00, 0x00, 0x00, 0xB1, 0x00, 0x5B, 0x00, 0x66, 0x00, 0x00, 0x00, 0xB1, 0x00, 0xD8, 0xFF, 0x68, 0x00, 0x00, 0x00, 0xB6, 0x0A, 0x64, 0x00, 0x74, 0x00, 0x00, 0x00, 0xA5, 0x00, 0xA5, 0x02, 0x80, 0x00, 0x00, 0x00, 0x2D, 0x00, 0xC0, 0x01, 0xD4, 0x00, 0x00, 0x00, 0x72, 0x00, 0xAF, 0x01, 0xD7, 0x00, 0x00, 0x00, 0x72, 0x80, 0x50, 0x01, 0x0D, 0x01, 0x00, 0x00, 0x72, 0x00, 0xE9, 0x00, 0xB3, 0x00, 0x00, 0x00, 0xB7, 0x00, 0x43, 0x01, 0x04, 0x01, 0x00, 0x00, 0x70, 0x00, 0xA7, 0x01, 0xCF, 0x00, 0x00, 0x00, 0x2D, 0x00, 0xBC, 0x00, 0x01, 0x01, 0x00, 0x00, 0x87, 0x0B, 0x66, 0x01, 0x08, 0x01, 0x00, 0x00, 0x88, 0x0B, 0xF0, 0x00, 0xB5, 0x00, 0x00, 0x00, 0x30, 0x00, 0x97, 0x01, 0xCD, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x32, 0x00, 0x80, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x62, 0x00, 0x88, 0x00, 0x00, 0x00, 0x9A, 0x80, 0x45, 0x00, 0x8A, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x7B, 0x01, 0x71, 0x00, 0x00, 0x00, 0x9A, 0x00, 0xEA, 0x01, 0x71, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x2C, 0x02, 0x89, 0x00, 0x00, 0x00, 0x9A, 0x80, 0x6D, 0x02, 0x93, 0x00, 0x00, 0x00, 0x70, 0x00, 0xA6, 0x00, 0x02, 0x01, 0x00, 0x00, 0x70, 0x00, 0xE2, 0x00, 0xB6, 0x00, 0x00, 0x00, 0x70, 0x00, 0xDB, 0x01, 0xD3, 0x00, 0x00, 0x00, 0x07, 0x00, 0x48, 0x02, 0x95, 0x00, 0x00, 0x00, 0x07, 0x00, 0x60, 0x02, 0x95, 0x00, 0x00, 0x00, 0x07, 0x00, 0x76, 0x02, 0x96, 0x00, 0x00, 0x00, 0x07, 0x00, 0x4A, 0x02, 0x90, 0x00, 0x00, 0x00, 0x07, 0x00, 0x64, 0x02, 0x8F, 0x00, 0x00, 0x00, 0x07, 0x00, 0x78, 0x02, 0x8F, 0x00, 0x00, 0x00, 0x05, 0x00, 0x5B, 0x01, 0x71, 0x00, 0x00, 0x00, 0x05, 0x00, 0x0E, 0x02, 0x88, 0x00, 0x00, 0x00, 0x05, 0x00, 0x22, 0x02, 0x88, 0x00, 0x00, 0x00, 0x05, 0x00, 0x39, 0x02, 0x88, 0x00, 0x00, 0x00, 0x05, 0x00, 0x80, 0x00, 0x88, 0x00, 0x00, 0x00, 0x05, 0x00, 0x6B, 0x00, 0x88, 0x00, 0x00, 0x00, 0x05, 0x00, 0x53, 0x00, 0x88, 0x00, 0x00, 0x00, 0x05, 0x00, 0x14, 0x00, 0x7F, 0x00, 0x00, 0x00, 0xCE, 0x00, 0x1B, 0x01, 0x7E, 0x00, 0x00, 0x00, 0xEC, 0x80, 0x39, 0x01, 0x69, 0x00, 0x00, 0x00, 0xDD, 0x00, 0x4C, 0x01, 0xB6, 0x00, 0x00, 0x00, 0xF7, 0x80, 0x61, 0x01, 0xDA, 0x00, 0x00, 0x00, 0xD3, 0x00, 0x2A, 0x02, 0xED, 0x00, 0x00, 0x00, 0xE5, 0x1E, 0x39, 0x01, 0x6D, 0x00, 0x00, 0x00, 0xE5, 0x1E, 0x29, 0x01, 0x84, 0x00, 0x00, 0x00, 0xE5, 0x1E, 0x36, 0x01, 0xC0, 0x00, 0x00, 0x00, 0xE5, 0x1E, 0x4F, 0x01, 0xE5, 0x00, 0x00, 0x00, 0xE2, 0x00, 0xBF, 0x01, 0xDA, 0x00, 0x00, 0x00, 0xE1, 0x00, 0xB8, 0x01, 0x0E, 0x01, 0x00, 0x00, 0xE1, 0x80, 0xEA, 0x01, 0x0D, 0x01, 0x00, 0x00, 0xDC, 0x00, 0x24, 0x02, 0x1A, 0x01, 0x00, 0x00, 0xE1, 0x80, 0x79, 0x02, 0x1A, 0x01, 0x00, 0x00, 0xE1, 0x80, 0x67, 0x02, 0x0C, 0x01, 0x00, 0x00, 0xE1, 0x00, 0x96, 0x01, 0x0A, 0x01, 0x00, 0x00, 0xE5, 0x1E, 0x0C, 0x02, 0x21, 0x01, 0x00, 0x00, 0xE5, 0x1E, 0x3C, 0x02, 0x22, 0x01, 0x00, 0x00, 0xE5, 0x1E, 0x70, 0x02, 0x11, 0x01, 0x00, 0x00, 0xE5, 0x1E, 0x12, 0x02, 0x43, 0x01, 0x00, 0x00, 0xE5, 0x1E, 0x4A, 0x02, 0x43, 0x01, 0x00, 0x00, 0xE4, 0x1E, 0x3B, 0x01, 0x76, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
base.ApplyRoomLayout();
}
}
}
