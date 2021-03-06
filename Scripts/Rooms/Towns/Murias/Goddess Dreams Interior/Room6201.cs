using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6201 : Room
{
public Room6201()
: base(6201, "Goddess Dreams Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x1E, 0x46, 0x08, 0x05, 0x01, 0x81, 0x01, 0x00, 0x00, 0x37, 0x08, 0x41, 0x01, 0x21, 0x01, 0x00, 0x00, 0x35, 0x08, 0x6F, 0x00, 0xB4, 0x00, 0xE2, 0xFF, 0xE4, 0x07, 0xAA, 0x00, 0x1C, 0x00, 0x00, 0x00, 0xEC, 0x07, 0xF3, 0x00, 0x06, 0x00, 0x00, 0x00, 0xED, 0x07, 0x58, 0x01, 0x31, 0x00, 0x00, 0x00, 0xEC, 0x07, 0xA5, 0x01, 0x08, 0x00, 0x00, 0x00, 0xD8, 0x07, 0xE4, 0x01, 0x28, 0x00, 0x00, 0x00, 0x01, 0x08, 0x7E, 0x01, 0x98, 0x00, 0x00, 0x00, 0x58, 0x88, 0xBE, 0x02, 0x7A, 0x01, 0x00, 0x00, 0x01, 0x08, 0xBB, 0x00, 0x9F, 0x00, 0x00, 0x00, 0x40, 0x08, 0x48, 0x01, 0x3B, 0x00, 0x00, 0x00, 0x4D, 0x08, 0x4C, 0x01, 0x7F, 0x00, 0x5A, 0x00, 0x5F, 0x88, 0xCF, 0x01, 0x8C, 0x01, 0x00, 0x00, 0x64, 0x88, 0xAC, 0x02, 0x9F, 0x01, 0x00, 0x00, 0x65, 0x88, 0xAC, 0x02, 0x82, 0x01, 0x00, 0x00, 0x69, 0x88, 0xB0, 0x02, 0xC3, 0x00, 0x5A, 0x00, 0x64, 0x08, 0x2B, 0x00, 0xC9, 0x00, 0x28, 0x00, 0x72, 0x08, 0x4A, 0x01, 0x69, 0x00, 0x00, 0x00, 0x71, 0x08, 0x8C, 0x00, 0x75, 0x00, 0x00, 0x00, 0x73, 0x08, 0x1A, 0x01, 0x6C, 0x00, 0x00, 0x00, 0x73, 0x08, 0x7A, 0x01, 0x6D, 0x00, 0x00, 0x00, 0xF2, 0x09, 0xE5, 0x00, 0x94, 0x00, 0x11, 0x00, 0xF2, 0x09, 0xA8, 0x01, 0x8D, 0x00, 0x11, 0x00, 0x51, 0x08, 0x4F, 0x01, 0xC8, 0x00, 0x3C, 0x00, 0x4D, 0x88, 0x4A, 0x01, 0xC7, 0x00, 0x23, 0x00, 0x3D, 0x08, 0x4A, 0x01, 0xC6, 0x00, 0x00, 0x00, 0x4D, 0x08, 0x4C, 0x01, 0xC7, 0x00, 0x03, 0x00, 0xFB, 0x07, 0xC1, 0x00, 0x91, 0x00, 0x00, 0x00, 0xFB, 0x07, 0x83, 0x01, 0x88, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0x39, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x39, 0x18, 0x2E, 0x02, 0xD7, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x00, 0x01, 0x17, 0x0B, 0x32, 0x4F, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x01, 0x0C, 0x00, 0x58, 0x6F, 0x6C, 0x69, 0x6E, 0x61, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0xD0, 0x08, 0x00, 0x00, 0xD0, 0x08, 0x00, 0x00, 0x01, 0x39, 0x18, 0x3D, 0x01, 0x06, 0x01, 0x02, 0x00, 0x06, 0x00, 0x01, 0x69, 0x04, 0x33, 0x4F, 0x01, 0x00, 0x35, 0x00, 0x01, 0x07, 0x00, 0x44, 0x6F, 0x75, 0x62, 0x6C, 0x65, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xF8, 0x04, 0x34, 0x4F, 0x01, 0x00, 0x45, 0x00, 0x01, 0x04, 0x00, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0x35, 0x4F, 0x01, 0x00, 0x44, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAC, 0x04, 0x36, 0x4F, 0x01, 0x00, 0x35, 0x00, 0x01, 0x09, 0x00, 0x4C, 0x6F, 0x77, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8D, 0x04, 0x37, 0x4F, 0x01, 0x00, 0x3F, 0x00, 0x01, 0x0A, 0x00, 0x4C, 0x6F, 0x6E, 0x67, 0x20, 0x53, 0x6B, 0x69, 0x72, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x38, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x01, 0x05, 0x0A, 0x05, 0x05, 0x06, 0x03, 0x0B, 0x0A, 0x01, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x74 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}
