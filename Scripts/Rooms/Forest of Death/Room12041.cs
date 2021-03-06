using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room12041 : Room
{
public Room12041()
: base(12041, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
byte[] roomDecItems = { 0x38, 0xB7, 0x0A, 0x5A, 0x00, 0x7C, 0x00, 0x00, 0x00, 0xB7, 0x0A, 0x2B, 0x02, 0x8B, 0x00, 0x00, 0x00, 0xA8, 0x00, 0x49, 0x01, 0x8B, 0x00, 0x00, 0x00, 0x9A, 0x00, 0xF8, 0x01, 0x8B, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x6A, 0x02, 0x90, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x62, 0x00, 0x8A, 0x00, 0x00, 0x00, 0x99, 0x00, 0x3D, 0x02, 0x96, 0x00, 0x00, 0x00, 0x99, 0x00, 0xB3, 0x00, 0x8A, 0x00, 0x00, 0x00, 0x9A, 0x80, 0x37, 0x01, 0x8D, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x81, 0x01, 0x8F, 0x00, 0x00, 0x00, 0x9C, 0x00, 0xBE, 0x01, 0x91, 0x00, 0x00, 0x00, 0x9C, 0x00, 0xE1, 0x00, 0x8B, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x1C, 0x00, 0x7D, 0x00, 0x00, 0x00, 0x30, 0x00, 0x5C, 0x01, 0x03, 0x01, 0x00, 0x00, 0x31, 0x00, 0x9B, 0x01, 0x02, 0x01, 0x00, 0x00, 0x88, 0x8B, 0x07, 0x01, 0x3F, 0x01, 0x00, 0x00, 0x73, 0x00, 0x0C, 0x02, 0xF7, 0x00, 0x00, 0x00, 0x72, 0x00, 0x78, 0x00, 0x0E, 0x01, 0x00, 0x00, 0x31, 0x80, 0xCB, 0x00, 0xDF, 0x00, 0x00, 0x00, 0x88, 0x0B, 0xDB, 0x01, 0xED, 0x00, 0x00, 0x00, 0xCC, 0x00, 0x4F, 0x00, 0xFF, 0x00, 0x14, 0x00, 0x2D, 0x00, 0x23, 0x00, 0x03, 0x01, 0x00, 0x00, 0x5D, 0x00, 0x4E, 0x01, 0x68, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x32, 0x00, 0x11, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x1E, 0x00, 0x00, 0x01, 0x00, 0x00, 0x3E, 0x00, 0xD3, 0x00, 0xD7, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xDE, 0x00, 0xE7, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xBC, 0x00, 0xDD, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x5D, 0x01, 0x07, 0x01, 0x00, 0x00, 0xDF, 0x80, 0xB1, 0x01, 0x10, 0x01, 0x00, 0x00, 0xDF, 0x80, 0x5C, 0x01, 0x04, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x92, 0x01, 0x00, 0x01, 0x00, 0x00, 0xC7, 0x04, 0xB3, 0x01, 0xFA, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xD8, 0x01, 0xEB, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x23, 0x01, 0x4D, 0x01, 0x00, 0x00, 0xDF, 0x80, 0x06, 0x01, 0x45, 0x01, 0x00, 0x00, 0x3E, 0x00, 0x63, 0x01, 0xF2, 0x00, 0x00, 0x00, 0x3E, 0x00, 0xAF, 0x01, 0xF7, 0x00, 0x00, 0x00, 0x3E, 0x00, 0x11, 0x00, 0xFA, 0x00, 0x00, 0x00, 0x05, 0x00, 0x80, 0x00, 0x89, 0x00, 0x00, 0x00, 0x05, 0x00, 0x6C, 0x00, 0x89, 0x00, 0x00, 0x00, 0x05, 0x00, 0x56, 0x00, 0x8B, 0x00, 0x00, 0x00, 0x05, 0x00, 0xAD, 0x00, 0x89, 0x00, 0x00, 0x00, 0x05, 0x00, 0xE3, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x05, 0x00, 0xFA, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x05, 0x00, 0x21, 0x01, 0x8E, 0x00, 0x00, 0x00, 0x05, 0x00, 0x39, 0x01, 0x8D, 0x00, 0x00, 0x00, 0x05, 0x00, 0x7E, 0x01, 0x90, 0x00, 0x00, 0x00, 0x05, 0x00, 0xB0, 0x01, 0x91, 0x00, 0x00, 0x00, 0x05, 0x00, 0xC7, 0x01, 0x91, 0x00, 0x00, 0x00, 0x05, 0x00, 0xF5, 0x01, 0x8B, 0x00, 0x00, 0x00, 0x05, 0x00, 0x0D, 0x02, 0x8B, 0x00, 0x00, 0x00, 0x05, 0x00, 0x36, 0x02, 0x96, 0x00, 0x00, 0x00, 0x05, 0x00, 0x4E, 0x02, 0x96, 0x00, 0x00, 0x00, 0x05, 0x00, 0x65, 0x02, 0x8F, 0x00, 0x00, 0x00, 0x05, 0x00, 0x78, 0x02, 0x8F, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
base.ApplyRoomLayout();
}
}
}
