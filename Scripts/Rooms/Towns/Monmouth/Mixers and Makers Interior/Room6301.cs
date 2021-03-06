using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6301 : Room
{
public Room6301()
: base(6301, "Mixers and Makers Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x22, 0x3B, 0x08, 0x53, 0x00, 0xA9, 0x00, 0x00, 0x00, 0x3C, 0x08, 0xE1, 0x00, 0xA1, 0x00, 0x00, 0x00, 0xD1, 0x07, 0x52, 0x02, 0x23, 0x00, 0x00, 0x00, 0xDD, 0x07, 0xF1, 0x01, 0x24, 0x00, 0x00, 0x00, 0xD1, 0x07, 0x90, 0x01, 0x1B, 0x00, 0xF6, 0xFF, 0xDD, 0x07, 0x7E, 0x00, 0x09, 0x00, 0x00, 0x00, 0xD2, 0x07, 0x39, 0x01, 0x25, 0x00, 0x00, 0x00, 0xD1, 0x07, 0xDE, 0x00, 0x0A, 0x00, 0x00, 0x00, 0xDE, 0x07, 0x21, 0x00, 0x23, 0x00, 0x00, 0x00, 0x63, 0x08, 0xDE, 0xFF, 0x99, 0x01, 0x00, 0x00, 0x63, 0x88, 0x71, 0x02, 0x92, 0x01, 0x00, 0x00, 0x64, 0x08, 0x25, 0x00, 0xAA, 0x00, 0xF2, 0xFF, 0x65, 0x88, 0x16, 0x01, 0xA2, 0x00, 0x0B, 0x00, 0x65, 0x08, 0xDA, 0xFF, 0x65, 0x01, 0x00, 0x00, 0x69, 0x08, 0xE0, 0xFF, 0x46, 0x01, 0x00, 0x00, 0x74, 0x08, 0x8C, 0x00, 0x4E, 0x00, 0x00, 0x00, 0x74, 0x08, 0x13, 0x00, 0x62, 0x00, 0x00, 0x00, 0x20, 0x08, 0x39, 0x00, 0x6E, 0x00, 0x00, 0x00, 0x21, 0x08, 0xF5, 0x00, 0x6C, 0x00, 0x00, 0x00, 0x21, 0x08, 0x3D, 0x01, 0x78, 0x00, 0x00, 0x00, 0x21, 0x08, 0x88, 0x01, 0x83, 0x00, 0x00, 0x00, 0x64, 0x88, 0x13, 0x01, 0xA2, 0x00, 0xF3, 0xFF, 0x69, 0x08, 0xB2, 0x00, 0x0E, 0x01, 0x28, 0x00, 0x27, 0x0A, 0xB3, 0x00, 0x0D, 0x01, 0x00, 0x00, 0x75, 0x08, 0xA5, 0x01, 0x6E, 0x00, 0x00, 0x00, 0x3C, 0x08, 0x5E, 0x01, 0xB5, 0x00, 0x00, 0x00, 0x65, 0x88, 0x91, 0x01, 0xB6, 0x00, 0xF1, 0xFF, 0x35, 0x08, 0xD2, 0x01, 0xE0, 0x00, 0x00, 0x00, 0x20, 0x0A, 0x3B, 0x00, 0x6E, 0x00, 0x06, 0x00, 0x21, 0x0A, 0xD0, 0x00, 0x6C, 0x00, 0x06, 0x00, 0x21, 0x0A, 0x19, 0x01, 0x79, 0x00, 0x06, 0x00, 0x21, 0x0A, 0x63, 0x01, 0x83, 0x00, 0x06, 0x00, 0x5F, 0x08, 0x25, 0x00, 0xB8, 0x00, 0x1E, 0x00, 0x5E, 0x88, 0x99, 0x01, 0xBD, 0x00, 0x32, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x04, 0x00, 0x01, 0xE0, 0x02, 0x73, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x9D, 0x18, 0x91, 0x00, 0xFA, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE1, 0x02, 0x74, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x9D, 0x18, 0xB1, 0x00, 0xBE, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x75, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x9D, 0x18, 0xDD, 0x00, 0xFF, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xDB, 0x02, 0x7A, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x9D, 0x18, 0x53, 0x02, 0xC7, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x17, 0x0B, 0x76, 0x4E };

this.AddRoomItemsByteBlock(roomItems);
byte[] npcs = { 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x00, 0x0A, 0x00, 0x57, 0x69, 0x6C, 0x6C, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x90, 0x09, 0x00, 0x00, 0x90, 0x09, 0x00, 0x00, 0x01, 0x9D, 0x18, 0xB3, 0x01, 0xCF, 0x00, 0x02, 0x00, 0x03, 0x00, 0x01, 0x6D, 0x04, 0x77, 0x4E, 0x01, 0x00, 0x62, 0x00, 0x01, 0x04, 0x00, 0x52, 0x6F, 0x62, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAA, 0x04, 0x78, 0x4E, 0x01, 0x00, 0x3A, 0x00, 0x01, 0x0A, 0x00, 0x48, 0x69, 0x67, 0x68, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x04, 0x00, 0x79, 0x4E, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x0E, 0x01, 0x08, 0x02, 0x08, 0x05, 0x01, 0x04, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFB, 0x00 };

this.AddNpcsByteBlock(npcs);
base.ApplyRoomLayout();
}
}
}
