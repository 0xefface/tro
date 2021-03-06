using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6208 : Room
{
public Room6208()
: base(6208, "Dog's Breath Inn Lobby")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x16, 0xD8, 0x07, 0xD0, 0x01, 0x0F, 0x00, 0x00, 0x00, 0xE0, 0x07, 0x91, 0x00, 0x05, 0x00, 0x23, 0x00, 0xEC, 0x07, 0xC9, 0x00, 0x05, 0x00, 0x14, 0x00, 0xEC, 0x07, 0x91, 0x01, 0x03, 0x00, 0x14, 0x00, 0xED, 0x07, 0x20, 0x01, 0x2F, 0x00, 0x14, 0x00, 0xFA, 0x07, 0x26, 0x02, 0x9B, 0x00, 0x00, 0x00, 0x76, 0x08, 0x2F, 0x01, 0x5B, 0x00, 0x00, 0x00, 0xFB, 0x07, 0x52, 0x01, 0x7F, 0x00, 0x00, 0x00, 0xFB, 0x07, 0xC8, 0x00, 0x7E, 0x00, 0x00, 0x00, 0xFB, 0x09, 0x74, 0x01, 0x80, 0x00, 0x11, 0x00, 0x74, 0x08, 0x60, 0x00, 0x5C, 0x00, 0x00, 0x00, 0x35, 0x08, 0x9E, 0x00, 0x18, 0x01, 0x00, 0x00, 0x37, 0x08, 0x0C, 0x01, 0x1A, 0x01, 0x00, 0x00, 0x3D, 0x08, 0x31, 0x01, 0xA3, 0x00, 0xEC, 0xFF, 0x4F, 0x08, 0x47, 0x01, 0xA9, 0x00, 0xF6, 0xFF, 0xFA, 0x09, 0x5A, 0x02, 0xA2, 0x00, 0x11, 0x00, 0xFB, 0x09, 0xEA, 0x00, 0x7F, 0x00, 0x11, 0x00, 0x4D, 0x08, 0x34, 0x01, 0xA8, 0x00, 0x14, 0x00, 0x4F, 0x08, 0x1D, 0x01, 0xA8, 0x00, 0xF6, 0xFF, 0xC1, 0x08, 0xA9, 0x00, 0xB6, 0x00, 0x00, 0x00, 0xC4, 0x08, 0x73, 0x00, 0xC0, 0x00, 0x00, 0x00, 0x26, 0x0A, 0x57, 0x02, 0x3C, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x06, 0x00, 0x01, 0xD9, 0x02, 0x3A, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x40, 0x18, 0xEC, 0x01, 0xB5, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x3B, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x40, 0x18, 0x61, 0x00, 0x08, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x45, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x40, 0x18, 0xDC, 0x01, 0x33, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x46, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x40, 0x18, 0xFC, 0x01, 0x22, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x47, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x40, 0x18, 0x44, 0x02, 0x1D, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x48, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x40, 0x18, 0x78, 0x02, 0x1D, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x1F, 0x0B, 0x3C, 0x4F, 0x01, 0x00, 0x00, 0xFF };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x00, 0x0C, 0x08, 0x6E, 0x6E, 0x01, 0x00, 0x00, 0x09, 0x00, 0x42, 0x6F, 0x62, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x60, 0x09, 0x00, 0x00, 0x60, 0x09, 0x00, 0x00, 0x01, 0x40, 0x18, 0x72, 0x00, 0x14, 0x01, 0x00, 0x00, 0x08, 0x00, 0x01, 0xF7, 0x04, 0x3D, 0x4F, 0x01, 0x00, 0x58, 0x00, 0x01, 0x04, 0x00, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8A, 0x04, 0x3E, 0x4F, 0x01, 0x00, 0x58, 0x00, 0x01, 0x04, 0x00, 0x48, 0x6F, 0x73, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x69, 0x04, 0x3F, 0x4F, 0x01, 0x00, 0x53, 0x00, 0x01, 0x07, 0x00, 0x44, 0x6F, 0x75, 0x62, 0x6C, 0x65, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAE, 0x04, 0x40, 0x4F, 0x01, 0x00, 0x49, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0x41, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x44, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x02, 0x00, 0x02, 0x07, 0x04, 0x06, 0x06, 0x04, 0x07, 0x07, 0x01, 0x04, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}
