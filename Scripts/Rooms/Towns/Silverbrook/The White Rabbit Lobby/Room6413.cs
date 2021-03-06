using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6413 : Room
{
public Room6413()
: base(6413, "The White Rabbit Lobby")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x1F, 0x74, 0x08, 0x5E, 0x00, 0x94, 0x00, 0x32, 0x00, 0xEC, 0x07, 0x43, 0x01, 0x5E, 0x00, 0x64, 0x00, 0xEC, 0x07, 0xAF, 0x00, 0x73, 0x00, 0x64, 0x00, 0x4F, 0x08, 0x1F, 0x01, 0x80, 0x00, 0x96, 0x00, 0xED, 0x07, 0xEB, 0x00, 0xCB, 0x00, 0x96, 0x00, 0xD5, 0x07, 0x1A, 0x02, 0x72, 0x00, 0x64, 0x00, 0xD6, 0x07, 0xBA, 0x01, 0x5D, 0x00, 0x32, 0x00, 0x37, 0x08, 0xEC, 0x00, 0xD7, 0x00, 0xEC, 0xFF, 0x40, 0x08, 0xBD, 0x00, 0xFC, 0x00, 0xAA, 0x00, 0x50, 0x08, 0xB9, 0x00, 0x1B, 0x01, 0xDC, 0x00, 0x27, 0x08, 0x95, 0x02, 0xBC, 0x00, 0x00, 0x00, 0xE1, 0x07, 0x45, 0x00, 0x03, 0x00, 0x00, 0x00, 0x76, 0x08, 0x22, 0x01, 0x1F, 0x01, 0xC8, 0x00, 0xAD, 0x08, 0xA2, 0x01, 0xB6, 0x00, 0x00, 0x00, 0xC1, 0x08, 0x50, 0x01, 0xBC, 0x00, 0x00, 0x00, 0x24, 0x0A, 0x5A, 0x02, 0xB7, 0x00, 0x14, 0x00, 0x26, 0x08, 0x05, 0x00, 0xB2, 0x00, 0x00, 0x00, 0x39, 0x08, 0x88, 0x00, 0xB9, 0x00, 0xD8, 0xFF, 0xD6, 0x07, 0x8E, 0x01, 0x50, 0x00, 0x32, 0x00, 0xE2, 0x07, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x27, 0x0A, 0xFF, 0x01, 0x1E, 0x01, 0x00, 0x00, 0x62, 0x88, 0x93, 0x00, 0xD5, 0x00, 0x28, 0x00, 0x61, 0x88, 0xA2, 0x00, 0xCC, 0x00, 0x23, 0x00, 0xD6, 0x07, 0x70, 0x02, 0x79, 0x00, 0x32, 0x00, 0x27, 0x0A, 0x9B, 0x00, 0x28, 0x01, 0x00, 0x00, 0x23, 0x0A, 0x12, 0x00, 0x98, 0x00, 0x00, 0x00, 0x10, 0x00, 0xA8, 0x00, 0xFA, 0x00, 0x00, 0x00, 0xE0, 0x9E, 0x57, 0x00, 0xF0, 0x00, 0x00, 0x00, 0xE3, 0x1E, 0xAA, 0x00, 0xEE, 0x00, 0x00, 0x00, 0xE3, 0x1E, 0x16, 0x01, 0xEE, 0x00, 0x00, 0x00, 0xE0, 0x1E, 0x16, 0x01, 0xF7, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x0A, 0x00, 0x01, 0xE0, 0x02, 0x19, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x0D, 0x19, 0xC5, 0x01, 0x0C, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x1A, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x0D, 0x19, 0x38, 0x02, 0x0C, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x1B, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x0D, 0x19, 0x12, 0x02, 0x04, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x1C, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x0D, 0x19, 0xEA, 0x01, 0x04, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xD9, 0x02, 0x1D, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x0D, 0x19, 0x1D, 0x02, 0xD0, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x24, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x0D, 0x19, 0x3F, 0x00, 0x2B, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x25, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x0D, 0x19, 0xF6, 0x00, 0x2E, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x26, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x0D, 0x19, 0x7F, 0x00, 0x11, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x27, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x0D, 0x19, 0xB9, 0x00, 0x10, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE3, 0x02, 0x28, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x0D, 0x19, 0xCF, 0x01, 0xC7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x28, 0x0B, 0x1E, 0x50, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x0C, 0x00, 0x55, 0x6C, 0x72, 0x69, 0x63, 0x68, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0xD0, 0x08, 0x00, 0x00, 0xD0, 0x08, 0x00, 0x00, 0x01, 0x0D, 0x19, 0xE5, 0x00, 0xD4, 0x00, 0x02, 0x00, 0x05, 0x00, 0x01, 0x6C, 0x04, 0x1F, 0x50, 0x01, 0x00, 0x4E, 0x00, 0x01, 0x05, 0x00, 0x54, 0x75, 0x6E, 0x69, 0x63, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8A, 0x04, 0x20, 0x50, 0x01, 0x00, 0x53, 0x00, 0x01, 0x04, 0x00, 0x48, 0x6F, 0x73, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAA, 0x04, 0x21, 0x50, 0x01, 0x00, 0x49, 0x00, 0x01, 0x0A, 0x00, 0x48, 0x69, 0x67, 0x68, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0x22, 0x50, 0x01, 0x00, 0x49, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x23, 0x50, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x03, 0x00, 0x01, 0x09, 0x00, 0x06, 0x00, 0x01, 0x02, 0xFF, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}
