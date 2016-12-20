using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6311 : Room
{
public Room6311()
: base(6311, "Bristle's Bane Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x15, 0x3B, 0x08, 0x52, 0x00, 0xC1, 0x00, 0x00, 0x00, 0x3C, 0x08, 0x4D, 0x02, 0xBF, 0x00, 0x00, 0x00, 0xD1, 0x07, 0x57, 0x02, 0x26, 0x00, 0x00, 0x00, 0xDD, 0x07, 0x5E, 0x01, 0x14, 0x00, 0x00, 0x00, 0xDD, 0x07, 0x9E, 0x00, 0x13, 0x00, 0x00, 0x00, 0xD2, 0x07, 0x0E, 0x02, 0x27, 0x00, 0x00, 0x00, 0xD1, 0x07, 0xFE, 0x00, 0x14, 0x00, 0x00, 0x00, 0xDE, 0x07, 0x4A, 0x00, 0x2E, 0x00, 0x00, 0x00, 0x74, 0x08, 0x74, 0x00, 0x59, 0x00, 0x00, 0x00, 0x74, 0x08, 0x0B, 0x00, 0x6B, 0x00, 0x00, 0x00, 0xDE, 0x07, 0xFE, 0xFF, 0x3B, 0x00, 0x00, 0x00, 0x35, 0x08, 0x57, 0x01, 0xCC, 0x01, 0x00, 0x00, 0x5E, 0x08, 0xB9, 0x00, 0xA6, 0x01, 0x00, 0x00, 0x5E, 0x88, 0xFF, 0x01, 0xA9, 0x01, 0x00, 0x00, 0x5F, 0x08, 0x26, 0x00, 0xC2, 0x00, 0x11, 0x00, 0x36, 0x08, 0x87, 0x01, 0x1B, 0x01, 0x00, 0x00, 0x5F, 0x88, 0x7D, 0x02, 0xC0, 0x00, 0xF1, 0xFF, 0x75, 0x08, 0x5D, 0x02, 0x68, 0x00, 0x00, 0x00, 0xAD, 0x08, 0xC4, 0x01, 0xAC, 0x00, 0x00, 0x00, 0x26, 0x08, 0x22, 0x00, 0x95, 0x00, 0x00, 0x00, 0x20, 0x0A, 0x2F, 0x00, 0x7B, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x02, 0x00, 0x01, 0xE3, 0x02, 0x90, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA7, 0x18, 0xF1, 0x01, 0xBC, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xDB, 0x02, 0x98, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA7, 0x18, 0xFB, 0x00, 0xB9, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x17, 0x0B, 0x91, 0x4E, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x00, 0x0A, 0x00, 0x53, 0x76, 0x65, 0x6E, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x78, 0x09, 0x00, 0x00, 0x78, 0x09, 0x00, 0x00, 0x01, 0xA7, 0x18, 0xA1, 0x01, 0x11, 0x01, 0x01, 0x00, 0x06, 0x00, 0x01, 0x8A, 0x04, 0x92, 0x4E, 0x01, 0x00, 0x35, 0x00, 0x01, 0x04, 0x00, 0x48, 0x6F, 0x73, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x6A, 0x04, 0x93, 0x4E, 0x01, 0x00, 0x3F, 0x00, 0x01, 0x07, 0x00, 0x44, 0x6F, 0x75, 0x62, 0x6C, 0x65, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xF8, 0x04, 0x94, 0x4E, 0x01, 0x00, 0x3F, 0x00, 0x01, 0x04, 0x00, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0x95, 0x4E, 0x01, 0x00, 0x35, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAC, 0x04, 0x96, 0x4E, 0x01, 0x00, 0x63, 0x00, 0x01, 0x09, 0x00, 0x4C, 0x6F, 0x77, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x97, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x07, 0x0B, 0x07, 0x04, 0x0B, 0x00, 0x02, 0x04, 0x02, 0x04, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}