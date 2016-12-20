using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6900 : Room
{
public Room6900()
: base(6900, "The Pig and Kettle Lobby")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x15, 0x20, 0x0A, 0x30, 0x00, 0xA0, 0x00, 0x06, 0x00, 0xEC, 0x07, 0xF4, 0x01, 0x0A, 0x00, 0x00, 0x00, 0xEC, 0x07, 0xB0, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x4F, 0x08, 0x1F, 0x01, 0x80, 0x00, 0x96, 0x00, 0xED, 0x07, 0xE7, 0x00, 0x33, 0x00, 0x00, 0x00, 0xD5, 0x07, 0x55, 0x02, 0x73, 0x00, 0x64, 0x00, 0xEC, 0x07, 0x4F, 0x01, 0x09, 0x00, 0x00, 0x00, 0x37, 0x08, 0xBC, 0x00, 0xEB, 0x00, 0x00, 0x00, 0x40, 0x08, 0xA2, 0x01, 0x0C, 0x01, 0xAA, 0x00, 0x50, 0x08, 0xA7, 0x01, 0x29, 0x01, 0xDC, 0x00, 0xE1, 0x07, 0x47, 0x00, 0x0E, 0x00, 0x00, 0x00, 0xC1, 0x08, 0x05, 0x02, 0xBC, 0x00, 0xEC, 0xFF, 0xED, 0x07, 0xB7, 0x01, 0x34, 0x00, 0x00, 0x00, 0xE2, 0x07, 0x03, 0x00, 0x3F, 0x00, 0x00, 0x00, 0x74, 0x08, 0x10, 0x00, 0x8C, 0x00, 0x14, 0x00, 0x28, 0x0A, 0xBE, 0x01, 0x31, 0x01, 0x00, 0x00, 0x45, 0x08, 0xA9, 0x01, 0x56, 0x00, 0x00, 0x00, 0x76, 0x08, 0x43, 0x01, 0x68, 0x00, 0x00, 0x00, 0x22, 0x0A, 0xB2, 0x00, 0x99, 0x00, 0x06, 0x00, 0x20, 0x08, 0x2F, 0x00, 0x9F, 0x00, 0x00, 0x00, 0x22, 0x08, 0xC7, 0x00, 0x96, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x09, 0x00, 0x01, 0xE0, 0x02, 0x85, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF4, 0x1A, 0x41, 0x01, 0x23, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x86, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF4, 0x1A, 0x5D, 0x01, 0x1A, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x87, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF4, 0x1A, 0x2E, 0x02, 0x28, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x88, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF4, 0x1A, 0x14, 0x02, 0x19, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x89, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF4, 0x1A, 0xA3, 0x01, 0x18, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x8A, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF4, 0x1A, 0x7B, 0x01, 0x18, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x8B, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF4, 0x1A, 0xC7, 0x01, 0x18, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x8C, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF4, 0x1A, 0xEF, 0x01, 0x18, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xDC, 0x02, 0x93, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xF4, 0x1A, 0x4C, 0x02, 0xD0, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x28, 0x0B, 0x8D, 0x48, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x00, 0x01, 0x0D, 0x00, 0x46, 0x61, 0x6C, 0x64, 0x6F, 0x72, 0x61, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x30, 0x09, 0x00, 0x00, 0x30, 0x09, 0x00, 0x00, 0x01, 0xF4, 0x1A, 0xC4, 0x00, 0xE4, 0x00, 0x02, 0x00, 0x05, 0x00, 0x01, 0xFB, 0x04, 0x8E, 0x48, 0x01, 0x00, 0x35, 0x00, 0x01, 0x0A, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x73, 0x04, 0x8F, 0x48, 0x01, 0x00, 0x35, 0x00, 0x01, 0x0A, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x56, 0x65, 0x73, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8B, 0x04, 0x90, 0x48, 0x01, 0x00, 0x4E, 0x00, 0x01, 0x04, 0x00, 0x48, 0x6F, 0x73, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAA, 0x04, 0x91, 0x48, 0x01, 0x00, 0x49, 0x00, 0x01, 0x0A, 0x00, 0x48, 0x69, 0x67, 0x68, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x92, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x01, 0x08, 0x08, 0x01, 0x03, 0x02, 0x02, 0x0C, 0xFF, 0x01, 0x05, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}
