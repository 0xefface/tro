using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room8101 : Room
{
public Room8101()
: base(8101, "Marvelous Armory Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x1B, 0xDD, 0x07, 0x18, 0x01, 0x17, 0x00, 0x00, 0x00, 0xE9, 0x07, 0x7D, 0x01, 0x0F, 0x00, 0x00, 0x00, 0xAD, 0x08, 0x44, 0x02, 0xAB, 0x00, 0x00, 0x00, 0xDD, 0x07, 0x59, 0x00, 0x17, 0x00, 0x00, 0x00, 0xDE, 0x07, 0x0F, 0x00, 0x61, 0x00, 0x32, 0x00, 0xEA, 0x07, 0xEE, 0x01, 0x18, 0x00, 0x00, 0x00, 0x3D, 0x08, 0xAB, 0x01, 0xB3, 0x00, 0x00, 0x00, 0x47, 0x88, 0xAB, 0x01, 0xB4, 0x00, 0x02, 0x00, 0xF0, 0x09, 0x2D, 0x00, 0x9A, 0x00, 0x11, 0x00, 0x47, 0x08, 0xB2, 0x01, 0xB4, 0x00, 0x1F, 0x00, 0x74, 0x08, 0x74, 0x00, 0x59, 0x00, 0x00, 0x00, 0x74, 0x08, 0x0A, 0x00, 0x63, 0x00, 0xF1, 0xFF, 0x3D, 0x08, 0x15, 0x02, 0x18, 0x01, 0x00, 0x00, 0x3D, 0x08, 0x34, 0x00, 0x0D, 0x01, 0x00, 0x00, 0xF0, 0x09, 0x06, 0x01, 0x92, 0x00, 0x11, 0x00, 0x47, 0x88, 0x12, 0x02, 0x19, 0x01, 0x02, 0x00, 0x47, 0x08, 0x41, 0x00, 0x0E, 0x01, 0x02, 0x00, 0x49, 0x08, 0x1C, 0x02, 0x19, 0x01, 0x22, 0x00, 0x49, 0x08, 0x3B, 0x00, 0x0E, 0x01, 0x22, 0x00, 0x37, 0x08, 0x30, 0x01, 0xEB, 0x00, 0x00, 0x00, 0xF9, 0x07, 0xFB, 0x00, 0x90, 0x00, 0x00, 0x00, 0x76, 0x08, 0x75, 0x01, 0x44, 0x00, 0x00, 0x00, 0x76, 0x08, 0xEA, 0x01, 0x43, 0x00, 0x00, 0x00, 0xD1, 0x07, 0xB9, 0x00, 0x17, 0x00, 0x00, 0x00, 0xF9, 0x07, 0x21, 0x00, 0x98, 0x00, 0x00, 0x00, 0xFF, 0x07, 0x1D, 0x00, 0xA5, 0x00, 0x00, 0x00, 0xFF, 0x07, 0xF6, 0x00, 0x9D, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x02, 0x00, 0x01, 0xD9, 0x02, 0x9E, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA5, 0x1F, 0xB5, 0x00, 0xBB, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE3, 0x02, 0x9F, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA5, 0x1F, 0x71, 0x02, 0xBC, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01 };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x17, 0x0B, 0xA0, 0x51, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x6E, 0x6E, 0x01, 0x00, 0x00, 0x0C, 0x00, 0x4C, 0x6F, 0x70, 0x69, 0x65, 0x72, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x01, 0xA5, 0x1F, 0x30, 0x01, 0xDB, 0x00, 0x00, 0x00, 0x09, 0x00, 0x01, 0x73, 0x04, 0xA1, 0x51, 0x01, 0x00, 0x63, 0x00, 0x01, 0x0A, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x56, 0x65, 0x73, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8A, 0x04, 0xA2, 0x51, 0x01, 0x00, 0x63, 0x00, 0x01, 0x04, 0x00, 0x48, 0x6F, 0x73, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xFB, 0x04, 0xA3, 0x51, 0x01, 0x00, 0x63, 0x00, 0x01, 0x0A, 0x00, 0x43, 0x68, 0x61, 0x69, 0x6E, 0x20, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0xA4, 0x51, 0x01, 0x00, 0x62, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAA, 0x04, 0xA5, 0x51, 0x01, 0x00, 0x62, 0x00, 0x01, 0x0A, 0x00, 0x48, 0x69, 0x67, 0x68, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0xA9, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x02, 0x00, 0x06, 0x03, 0x01, 0x02, 0x02, 0x03, 0x07, 0x03, 0x01, 0x06, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}