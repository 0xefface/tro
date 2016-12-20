using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room8001 : Room
{
public Room8001()
: base(8001, "Grand Gear Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x12, 0xD5, 0x07, 0xFE, 0x01, 0x07, 0x00, 0x00, 0x00, 0xED, 0x07, 0x28, 0x01, 0x2C, 0x00, 0x00, 0x00, 0xEC, 0x07, 0x9E, 0x01, 0x01, 0x00, 0x00, 0x00, 0xD6, 0x07, 0x5A, 0x02, 0x41, 0x00, 0x00, 0x00, 0xEC, 0x07, 0xBC, 0x00, 0x02, 0x00, 0x00, 0x00, 0xE1, 0x07, 0x52, 0x00, 0x06, 0x00, 0x00, 0x00, 0xE2, 0x07, 0x00, 0x00, 0x39, 0x00, 0x00, 0x00, 0xAD, 0x88, 0x40, 0x00, 0xC0, 0x00, 0x00, 0x00, 0x22, 0x09, 0x15, 0x00, 0x67, 0x00, 0x32, 0x00, 0x22, 0x09, 0xB6, 0xFF, 0x75, 0x00, 0x32, 0x00, 0x70, 0x08, 0xE8, 0x00, 0xFA, 0x00, 0x46, 0x00, 0x40, 0x08, 0xCC, 0x00, 0x6E, 0x00, 0x00, 0x00, 0x4F, 0x08, 0xCE, 0x00, 0x8D, 0x00, 0x32, 0x00, 0x37, 0x08, 0xE4, 0x00, 0xF4, 0x00, 0x00, 0x00, 0x26, 0x0A, 0x52, 0x00, 0x57, 0x01, 0x00, 0x00, 0x28, 0x0A, 0x0B, 0x02, 0x37, 0x01, 0x00, 0x00, 0x22, 0x08, 0x8D, 0x01, 0x80, 0x00, 0x00, 0x00, 0x22, 0x0A, 0x79, 0x01, 0xAF, 0x00, 0x32, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x06, 0x00, 0x01, 0xDB, 0x02, 0xB7, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x41, 0x1F, 0x2C, 0x02, 0xD1, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE3, 0x02, 0xB8, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x41, 0x1F, 0x11, 0x00, 0xD0, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE1, 0x02, 0xC0, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x41, 0x1F, 0x8F, 0x01, 0x27, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE1, 0x02, 0xC1, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x41, 0x1F, 0xDF, 0x01, 0x15, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE1, 0x02, 0xC2, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x41, 0x1F, 0x32, 0x02, 0x18, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE1, 0x02, 0xC3, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x41, 0x1F, 0xC9, 0x01, 0xD0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x1F, 0x0B, 0xB9, 0x4A, 0x01, 0x00, 0x00, 0xFF };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x00, 0x0A, 0x00, 0x53, 0x68, 0x65, 0x61, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x01, 0x41, 0x1F, 0x51, 0x01, 0xED, 0x00, 0x02, 0x00, 0x06, 0x00, 0x01, 0xF7, 0x04, 0xBA, 0x4A, 0x01, 0x00, 0x49, 0x00, 0x01, 0x04, 0x00, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x69, 0x04, 0xBB, 0x4A, 0x01, 0x00, 0x58, 0x00, 0x01, 0x07, 0x00, 0x44, 0x6F, 0x75, 0x62, 0x6C, 0x65, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8A, 0x04, 0xBC, 0x4A, 0x01, 0x00, 0x58, 0x00, 0x01, 0x04, 0x00, 0x48, 0x6F, 0x73, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0xBD, 0x4A, 0x01, 0x00, 0x49, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAA, 0x04, 0xBE, 0x4A, 0x01, 0x00, 0x49, 0x00, 0x01, 0x0A, 0x00, 0x48, 0x69, 0x67, 0x68, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0xBF, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x0A, 0x05, 0x03, 0x10, 0x02, 0x02, 0x0D, 0x02, 0x04, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x31, 0x31, 0x2C };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}