using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room10047 : Room
{
public Room10047()
: base(10047, "Killing Fields")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
byte[] roomDecItems = { 0x27, 0x2C, 0x00, 0xA8, 0x01, 0xDE, 0x00, 0x00, 0x00, 0xA8, 0x80, 0x36, 0x02, 0x8B, 0x00, 0x00, 0x00, 0xB0, 0x80, 0x4D, 0x02, 0x6B, 0x00, 0x00, 0x00, 0xB4, 0x00, 0x53, 0x00, 0xF9, 0x00, 0x00, 0x00, 0xB4, 0x80, 0x47, 0x01, 0xCE, 0x00, 0x00, 0x00, 0xB6, 0x00, 0xC4, 0x01, 0x09, 0x01, 0x00, 0x00, 0xBA, 0x00, 0x5F, 0x00, 0x0C, 0x01, 0x00, 0x00, 0x87, 0x0B, 0x53, 0x02, 0xCE, 0x00, 0x00, 0x00, 0x25, 0x04, 0x60, 0x02, 0x43, 0x01, 0x00, 0x00, 0xC6, 0x04, 0x05, 0x00, 0x69, 0x00, 0x00, 0x00, 0x99, 0x00, 0x09, 0x00, 0x75, 0x00, 0x00, 0x00, 0x31, 0x00, 0x80, 0x02, 0x43, 0x01, 0x00, 0x00, 0x3D, 0x80, 0x61, 0x02, 0xF5, 0x00, 0x00, 0x00, 0x31, 0x80, 0x54, 0x02, 0xE0, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x4E, 0x02, 0x04, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x18, 0x00, 0x75, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x25, 0x00, 0x6E, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x3A, 0x00, 0x08, 0x01, 0x00, 0x00, 0xE0, 0x00, 0x0C, 0x02, 0x72, 0x00, 0x00, 0x00, 0xE0, 0x00, 0x0E, 0x02, 0xC4, 0x00, 0x00, 0x00, 0xE0, 0x80, 0x7C, 0x00, 0x46, 0x01, 0x00, 0x00, 0xE0, 0x80, 0x9A, 0x01, 0x6F, 0x00, 0x00, 0x00, 0xC6, 0x04, 0xB0, 0x00, 0xC1, 0x00, 0x00, 0x00, 0xC6, 0x04, 0xC6, 0x01, 0x7C, 0x00, 0x00, 0x00, 0xC6, 0x04, 0x0C, 0x00, 0x71, 0x00, 0x00, 0x00, 0xDE, 0x80, 0x2F, 0x00, 0x75, 0x00, 0x00, 0x00, 0xC6, 0x04, 0x0B, 0x00, 0x7A, 0x00, 0x00, 0x00, 0xC6, 0x04, 0x11, 0x02, 0x7C, 0x00, 0x00, 0x00, 0xC6, 0x04, 0x28, 0x02, 0x48, 0x01, 0x00, 0x00, 0xC6, 0x04, 0x22, 0x00, 0x6A, 0x00, 0x00, 0x00, 0xB1, 0x00, 0x7D, 0xFF, 0x6A, 0x00, 0x00, 0x00, 0xBA, 0x00, 0x1B, 0x00, 0x78, 0x00, 0x00, 0x00, 0xBA, 0x00, 0x82, 0x01, 0x14, 0x01, 0x00, 0x00, 0x5E, 0x00, 0x4E, 0x01, 0x68, 0x00, 0x00, 0x00, 0x56, 0x04, 0x76, 0x01, 0x6B, 0x00, 0x00, 0x00, 0x6A, 0x00, 0xE6, 0xFF, 0xFE, 0x00, 0x00, 0x00, 0xB9, 0x00, 0x74, 0x01, 0x6C, 0x00, 0x00, 0x00, 0xB9, 0x00, 0x90, 0x01, 0x6E, 0x00, 0x00, 0x00, 0xDF, 0x80, 0x40, 0x00, 0x6A, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
base.ApplyRoomLayout();
}
}
}
