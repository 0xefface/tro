using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room8100 : Room
{
public Room8100()
: base(8100, "The Chapel Interior")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PavedRoom1;
this.BlockedRoomExits = BlockedExits.All;
byte[] roomDecItems = { 0x1A, 0xD4, 0x07, 0x37, 0x02, 0x05, 0x00, 0x37, 0x00, 0xEA, 0x07, 0x26, 0x01, 0x04, 0x00, 0x00, 0x00, 0xEA, 0x07, 0xA4, 0x01, 0x04, 0x00, 0x00, 0x00, 0xEA, 0x07, 0xAC, 0x00, 0x03, 0x00, 0x00, 0x00, 0xE9, 0x07, 0xFD, 0x01, 0x02, 0x00, 0x07, 0x00, 0xE9, 0x07, 0x94, 0x00, 0x02, 0x00, 0x08, 0x00, 0xE0, 0x07, 0x5E, 0x00, 0x04, 0x00, 0x37, 0x00, 0xFB, 0x07, 0x9C, 0x00, 0x7E, 0x00, 0x00, 0x00, 0xFB, 0x07, 0x20, 0x01, 0x81, 0x00, 0x00, 0x00, 0xFB, 0x07, 0xA7, 0x01, 0x7B, 0x00, 0x00, 0x00, 0xFA, 0x07, 0x3D, 0x02, 0x7E, 0x00, 0x00, 0x00, 0x01, 0x08, 0x1A, 0x01, 0x8C, 0x00, 0x00, 0x00, 0x00, 0x08, 0x3B, 0x02, 0x8F, 0x00, 0x00, 0x00, 0x37, 0x08, 0x45, 0x01, 0x27, 0x01, 0x00, 0x00, 0x01, 0x08, 0x97, 0x00, 0x8A, 0x00, 0x00, 0x00, 0x73, 0x08, 0x83, 0x00, 0x4A, 0x00, 0x00, 0x00, 0x01, 0x08, 0xA0, 0x01, 0x8A, 0x00, 0x00, 0x00, 0xFE, 0x09, 0xC8, 0x01, 0x83, 0x00, 0x14, 0x00, 0xFE, 0x09, 0x42, 0x01, 0x84, 0x00, 0x14, 0x00, 0xFE, 0x09, 0xC0, 0x00, 0x84, 0x00, 0x14, 0x00, 0xFD, 0x09, 0x71, 0x02, 0x88, 0x00, 0x14, 0x00, 0x73, 0x08, 0x12, 0x01, 0x3E, 0x00, 0x00, 0x00, 0x73, 0x08, 0x78, 0x01, 0x3D, 0x00, 0x00, 0x00, 0x73, 0x08, 0x0D, 0x02, 0x50, 0x00, 0x00, 0x00, 0x73, 0x08, 0x97, 0x01, 0x5E, 0x00, 0x00, 0x00, 0x73, 0x08, 0xF1, 0x00, 0x5E, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x10, 0x00, 0x01, 0xE0, 0x02, 0x8E, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0xB6, 0x00, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x8F, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x7F, 0x00, 0xA3, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x90, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x95, 0x00, 0xD4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x91, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0xED, 0x00, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x92, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x24, 0x01, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x93, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x5A, 0x01, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x94, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x0C, 0x02, 0xA5, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x95, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x8F, 0x01, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x96, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0xC0, 0x01, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x97, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0xEF, 0x01, 0xCD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x98, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x38, 0x02, 0xE3, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x99, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x64, 0x02, 0xF6, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x9A, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x10, 0x02, 0xD4, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x9B, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x3F, 0x00, 0xF7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0x9C, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x6A, 0x00, 0xE4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xDB, 0x02, 0x9D, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xA4, 0x1F, 0x2A, 0x00, 0xA4, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xCF, 0x10, 0x01, 0x59, 0x94, 0xC5, 0x32 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
