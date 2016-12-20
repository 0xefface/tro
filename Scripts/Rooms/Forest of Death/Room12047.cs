using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room12047 : Room
{
public Room12047()
: base(12047, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
byte[] roomDecItems = { 0x52, 0xB7, 0x0A, 0xE0, 0xFF, 0x7C, 0x00, 0x00, 0x00, 0xB7, 0x0A, 0x36, 0x02, 0x87, 0x00, 0x00, 0x00, 0xA8, 0x00, 0x13, 0x02, 0x89, 0x00, 0x00, 0x00, 0x9A, 0x00, 0xD4, 0x01, 0x8C, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x74, 0x02, 0x90, 0x00, 0x00, 0x00, 0x9A, 0x00, 0xA9, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x99, 0x00, 0x4A, 0x02, 0x91, 0x00, 0x00, 0x00, 0x99, 0x00, 0xF2, 0x00, 0x8E, 0x00, 0x00, 0x00, 0x9A, 0x80, 0x86, 0x01, 0x8C, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x33, 0x00, 0x8E, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x2E, 0x01, 0x8F, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x1A, 0x02, 0x8C, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x66, 0x00, 0x89, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x1C, 0x00, 0x89, 0x00, 0x00, 0x00, 0x73, 0x00, 0x68, 0x02, 0x3F, 0x01, 0x00, 0x00, 0x72, 0x00, 0x08, 0x01, 0x29, 0x01, 0x00, 0x00, 0x87, 0x0B, 0x5D, 0x02, 0x41, 0x01, 0x00, 0x00, 0x88, 0x0B, 0xA3, 0x01, 0xFB, 0x00, 0x00, 0x00, 0x30, 0x00, 0x4E, 0x01, 0xF8, 0x00, 0x00, 0x00, 0x31, 0x00, 0xDE, 0x01, 0xEE, 0x00, 0x00, 0x00, 0x88, 0x0B, 0x1F, 0x00, 0x01, 0x01, 0x00, 0x00, 0xB6, 0x0A, 0x5B, 0x01, 0x64, 0x00, 0x00, 0x00, 0xB7, 0x0A, 0xAB, 0x00, 0x85, 0x00, 0x00, 0x00, 0x73, 0x00, 0x6A, 0x01, 0x46, 0x01, 0xEC, 0xFF, 0x73, 0x00, 0x59, 0x00, 0x0B, 0x01, 0x00, 0x00, 0x88, 0x8B, 0x78, 0x00, 0xDB, 0x00, 0x00, 0x00, 0x5D, 0x00, 0x4E, 0x01, 0x67, 0x00, 0x00, 0x00, 0x7D, 0x00, 0xEC, 0x00, 0x46, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x85, 0x00, 0xE6, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x6E, 0x00, 0xDC, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x35, 0x00, 0x0C, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x1E, 0x00, 0x00, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x5F, 0x01, 0x0A, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x48, 0x01, 0xF6, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xAC, 0x01, 0x0D, 0x01, 0x00, 0x00, 0xC7, 0x04, 0xA1, 0x01, 0xF9, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xF1, 0x01, 0xF7, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xDB, 0x01, 0xED, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x6A, 0x02, 0x49, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x36, 0x02, 0x44, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x08, 0x01, 0x48, 0x01, 0x00, 0x00, 0xC7, 0x04, 0xEE, 0x00, 0x3C, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x5F, 0x01, 0x4D, 0x01, 0x00, 0x00, 0xC7, 0x04, 0xB3, 0x00, 0x4A, 0x01, 0x00, 0x00, 0x73, 0x00, 0x9D, 0x00, 0xEE, 0x00, 0x00, 0x00, 0x73, 0x00, 0x14, 0x02, 0xF6, 0x00, 0x00, 0x00, 0x73, 0x00, 0xD5, 0x01, 0x09, 0x01, 0x00, 0x00, 0x72, 0x00, 0xBB, 0x00, 0x35, 0x01, 0x00, 0x00, 0x72, 0x00, 0x73, 0x00, 0x43, 0x01, 0x00, 0x00, 0x72, 0x00, 0x47, 0x02, 0x32, 0x01, 0x00, 0x00, 0x72, 0x00, 0x0C, 0x02, 0x3F, 0x01, 0x00, 0x00, 0xCB, 0x00, 0xE2, 0x00, 0x48, 0x01, 0x14, 0x00, 0xCB, 0x80, 0xFC, 0x00, 0x3A, 0x01, 0x14, 0x00, 0x73, 0x00, 0xAB, 0x01, 0x47, 0x01, 0x00, 0x00, 0x3E, 0x00, 0x6C, 0x01, 0xF0, 0x00, 0x00, 0x00, 0x3E, 0x00, 0x86, 0x00, 0x40, 0x01, 0x00, 0x00, 0x3E, 0x00, 0xD8, 0x00, 0x2E, 0x01, 0x00, 0x00, 0x3E, 0x00, 0x98, 0x01, 0x3D, 0x01, 0x00, 0x00, 0x3E, 0x00, 0x3A, 0x01, 0x30, 0x01, 0x00, 0x00, 0x3E, 0x00, 0x7F, 0x00, 0xDB, 0x00, 0x00, 0x00, 0x64, 0x00, 0x1D, 0x00, 0x57, 0x01, 0x00, 0x00, 0x64, 0x00, 0x4C, 0x02, 0x5C, 0x01, 0x00, 0x00, 0x64, 0x80, 0xAE, 0x01, 0x84, 0x01, 0x00, 0x00, 0x64, 0x00, 0xF6, 0x00, 0x80, 0x01, 0x00, 0x00, 0xB9, 0x00, 0x88, 0x01, 0xA6, 0x00, 0x00, 0x00, 0x05, 0x00, 0x3F, 0x00, 0x8D, 0x00, 0x00, 0x00, 0x05, 0x00, 0x28, 0x00, 0x8D, 0x00, 0x00, 0x00, 0x05, 0x00, 0x08, 0x00, 0x8A, 0x00, 0x00, 0x00, 0x05, 0x00, 0x58, 0x00, 0x88, 0x00, 0x00, 0x00, 0x05, 0x00, 0x95, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x05, 0x00, 0xAD, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x05, 0x00, 0xFA, 0x00, 0x8E, 0x00, 0x00, 0x00, 0x05, 0x00, 0x1B, 0x01, 0x8E, 0x00, 0x00, 0x00, 0x05, 0x00, 0x30, 0x01, 0x8D, 0x00, 0x00, 0x00, 0x05, 0x00, 0x77, 0x01, 0x8C, 0x00, 0x00, 0x00, 0x05, 0x00, 0x8D, 0x01, 0x8D, 0x00, 0x00, 0x00, 0x05, 0x00, 0xBB, 0x01, 0x8C, 0x00, 0x00, 0x00, 0x05, 0x00, 0xFB, 0x01, 0x8B, 0x00, 0x00, 0x00, 0x05, 0x00, 0x12, 0x02, 0x8B, 0x00, 0x00, 0x00, 0x05, 0x00, 0x2A, 0x02, 0x8A, 0x00, 0x00, 0x00, 0x05, 0x00, 0x47, 0x02, 0x90, 0x00, 0x00, 0x00, 0x05, 0x00, 0x72, 0x02, 0x8E, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
base.ApplyRoomLayout();
}
}
}
