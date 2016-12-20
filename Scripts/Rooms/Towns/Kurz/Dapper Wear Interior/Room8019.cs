using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room8019 : Room
{
public Room8019()
: base(8019, "Dapper Wear Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x1C, 0xEC, 0x07, 0x5A, 0x01, 0x3C, 0x00, 0x00, 0x00, 0xD5, 0x07, 0xBA, 0x01, 0x42, 0x00, 0x00, 0x00, 0xD6, 0x07, 0x4E, 0x02, 0x86, 0x00, 0x00, 0x00, 0xD6, 0x07, 0xF6, 0x01, 0x78, 0x00, 0x00, 0x00, 0xED, 0x07, 0xEC, 0x00, 0x67, 0x00, 0x00, 0x00, 0xED, 0x07, 0x82, 0x00, 0x68, 0x00, 0x00, 0x00, 0xED, 0x07, 0x28, 0x00, 0x68, 0x00, 0x00, 0x00, 0x46, 0x08, 0x3A, 0x01, 0xE6, 0x00, 0x32, 0x00, 0x40, 0x08, 0x3A, 0x01, 0xC8, 0x00, 0x00, 0x00, 0x40, 0x08, 0xC0, 0x00, 0xAA, 0x00, 0x00, 0x00, 0x40, 0x08, 0x38, 0x01, 0x72, 0x00, 0x00, 0x00, 0x40, 0x08, 0x57, 0x00, 0xCF, 0x00, 0x00, 0x00, 0x40, 0x08, 0x55, 0x00, 0x86, 0x00, 0x00, 0x00, 0x40, 0x08, 0x54, 0x00, 0x75, 0x00, 0x32, 0x00, 0x40, 0x08, 0xC4, 0x00, 0x8E, 0x00, 0x32, 0x00, 0x46, 0x08, 0x58, 0x00, 0xA4, 0x00, 0x32, 0x00, 0x46, 0x88, 0xC7, 0x00, 0xC8, 0x00, 0x32, 0x00, 0x46, 0x08, 0x53, 0x00, 0x95, 0x00, 0x64, 0x00, 0x46, 0x88, 0x51, 0x00, 0xEB, 0x00, 0x32, 0x00, 0x46, 0x08, 0x3C, 0x01, 0x92, 0x00, 0x32, 0x00, 0x46, 0x88, 0xCA, 0x00, 0xAD, 0x00, 0x64, 0x00, 0x38, 0x08, 0x46, 0x00, 0x3E, 0x01, 0x00, 0x00, 0xFA, 0x07, 0xA8, 0x01, 0xDD, 0x00, 0x00, 0x00, 0xFA, 0x07, 0xA6, 0x01, 0x8E, 0x00, 0x32, 0x00, 0xFA, 0x07, 0x14, 0x02, 0x9C, 0x00, 0x32, 0x00, 0xFD, 0x09, 0xDD, 0x01, 0xE6, 0x00, 0x14, 0x00, 0xFD, 0x09, 0xDB, 0x01, 0xB5, 0x00, 0x64, 0x00, 0xFD, 0x09, 0x48, 0x02, 0xC4, 0x00, 0x64, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x04, 0x00, 0x01, 0xDB, 0x02, 0x0C, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x53, 0x1F, 0x28, 0x02, 0x16, 0x01, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x14, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x53, 0x1F, 0x8F, 0x01, 0x08, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x15, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x53, 0x1F, 0xD7, 0x01, 0x19, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x16, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x53, 0x1F, 0x60, 0x02, 0x35, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x18, 0x0B, 0x0D, 0x4B };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x00, 0x0A, 0x00, 0x42, 0x6F, 0x69, 0x6D, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x48, 0x09, 0x00, 0x00, 0x48, 0x09, 0x00, 0x00, 0x01, 0x53, 0x1F, 0x19, 0x00, 0x2E, 0x01, 0x00, 0x00, 0x06, 0x00, 0x01, 0xF7, 0x04, 0x0E, 0x4B, 0x01, 0x00, 0x35, 0x00, 0x01, 0x04, 0x00, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x69, 0x04, 0x0F, 0x4B, 0x01, 0x00, 0x49, 0x00, 0x01, 0x07, 0x00, 0x44, 0x6F, 0x75, 0x62, 0x6C, 0x65, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8A, 0x04, 0x10, 0x4B, 0x01, 0x00, 0x62, 0x00, 0x01, 0x04, 0x00, 0x48, 0x6F, 0x73, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0x11, 0x4B, 0x01, 0x00, 0x49, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAA, 0x04, 0x12, 0x4B, 0x01, 0x00, 0x49, 0x00, 0x01, 0x0A, 0x00, 0x48, 0x69, 0x67, 0x68, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x13, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x0A, 0x05, 0x03, 0x10, 0x02, 0x02, 0x0D, 0x02, 0x04, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}