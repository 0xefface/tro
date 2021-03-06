using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room8010 : Room
{
public Room8010()
: base(8010, "Blood Forge Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x18, 0xE9, 0x07, 0xB4, 0x00, 0x21, 0x00, 0x00, 0x00, 0xDD, 0x07, 0x18, 0x01, 0x17, 0x00, 0x00, 0x00, 0xE9, 0x07, 0x7D, 0x01, 0x11, 0x00, 0x00, 0x00, 0xAD, 0x88, 0xC0, 0xFF, 0xEF, 0x00, 0x00, 0x00, 0xDD, 0x07, 0x4F, 0x00, 0x27, 0x00, 0x00, 0x00, 0xDE, 0x07, 0x21, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x35, 0x08, 0x7A, 0x00, 0x19, 0x01, 0x00, 0x00, 0xEA, 0x07, 0xEB, 0x01, 0x1A, 0x00, 0x00, 0x00, 0x3D, 0x08, 0xC1, 0x01, 0xB7, 0x00, 0x00, 0x00, 0x47, 0x88, 0xBE, 0x01, 0xB8, 0x00, 0x21, 0x00, 0x47, 0x08, 0xC5, 0x01, 0xB8, 0x00, 0x02, 0x00, 0x5B, 0x08, 0x35, 0x00, 0x1A, 0x01, 0x2D, 0x00, 0x45, 0x08, 0x0B, 0x01, 0x5B, 0x00, 0x00, 0x00, 0xD1, 0x07, 0x6A, 0x02, 0x16, 0x00, 0x00, 0x00, 0xE9, 0x07, 0x03, 0x02, 0x10, 0x00, 0x00, 0x00, 0x3A, 0x08, 0xB1, 0x00, 0xCE, 0x00, 0x00, 0x00, 0x76, 0x08, 0x69, 0x01, 0x46, 0x00, 0x00, 0x00, 0x76, 0x08, 0x17, 0x02, 0x46, 0x00, 0x00, 0x00, 0x39, 0x08, 0x60, 0x02, 0xC8, 0x00, 0x00, 0x00, 0x5A, 0x88, 0x58, 0x02, 0xC9, 0x00, 0x37, 0x00, 0x22, 0x08, 0xB3, 0x00, 0x7E, 0x00, 0x00, 0x00, 0x22, 0x08, 0xC3, 0x01, 0x6A, 0x00, 0x00, 0x00, 0x22, 0x0A, 0x9E, 0x00, 0x80, 0x00, 0x05, 0x00, 0x22, 0x0A, 0xAE, 0x01, 0x6D, 0x00, 0x05, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0x22, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x4A, 0x1F, 0x19, 0x01, 0xBB, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x00, 0x01, 0x17, 0x0B, 0x23, 0x4A, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x01, 0x0D, 0x00, 0x4D, 0x6F, 0x72, 0x67, 0x61, 0x6E, 0x61, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x60, 0x09, 0x00, 0x00, 0x60, 0x09, 0x00, 0x00, 0x01, 0x4A, 0x1F, 0x50, 0x00, 0x18, 0x01, 0x00, 0x00, 0x08, 0x00, 0x01, 0x73, 0x04, 0x24, 0x4A, 0x01, 0x00, 0x36, 0x00, 0x01, 0x0A, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x56, 0x65, 0x73, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x96, 0x04, 0x25, 0x4A, 0x01, 0x00, 0x63, 0x00, 0x01, 0x0E, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x4C, 0x65, 0x67, 0x67, 0x69, 0x6E, 0x67, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xFB, 0x04, 0x26, 0x4A, 0x01, 0x00, 0x62, 0x00, 0x01, 0x0A, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAB, 0x04, 0x27, 0x4A, 0x01, 0x00, 0x36, 0x00, 0x01, 0x0A, 0x00, 0x48, 0x69, 0x67, 0x68, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x2B, 0x4A, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x01, 0x06, 0x0B, 0x07, 0x06, 0x05, 0x00, 0x03, 0x07, 0x00, 0x03, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x05 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}
