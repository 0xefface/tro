using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5023 : Room
{
public Room5023()
: base(5023, "Meditation Garden")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x3B, 0x15, 0x00, 0x4C, 0x00, 0x21, 0x00, 0x00, 0x00, 0x15, 0x80, 0x2C, 0x02, 0x23, 0x00, 0x00, 0x00, 0x15, 0x00, 0x88, 0x02, 0xF9, 0x00, 0x00, 0x00, 0x15, 0x80, 0xEB, 0xFF, 0xFB, 0x00, 0x00, 0x00, 0x17, 0x80, 0x93, 0x01, 0xBF, 0x00, 0x00, 0x00, 0x15, 0x00, 0xAF, 0x01, 0xBD, 0x00, 0x00, 0x00, 0x15, 0x80, 0xA7, 0x01, 0xA7, 0x00, 0x00, 0x00, 0x15, 0x80, 0xC6, 0x00, 0xBF, 0x00, 0x00, 0x00, 0x16, 0x80, 0xDE, 0x00, 0x68, 0x00, 0x00, 0x00, 0x15, 0x80, 0xEB, 0x00, 0x9F, 0x00, 0x00, 0x00, 0x15, 0x00, 0xCB, 0x00, 0xA4, 0x00, 0x00, 0x00, 0x17, 0x00, 0xFC, 0x00, 0xC0, 0x00, 0x00, 0x00, 0x16, 0x00, 0x99, 0x01, 0xA3, 0x00, 0x00, 0x00, 0x15, 0x80, 0x28, 0x01, 0x71, 0x00, 0x00, 0x00, 0x15, 0x00, 0xD2, 0x00, 0x83, 0x00, 0x00, 0x00, 0x15, 0x00, 0xC3, 0x01, 0x8A, 0x00, 0x00, 0x00, 0x16, 0x00, 0x4A, 0x01, 0x5F, 0x00, 0x00, 0x00, 0x15, 0x00, 0xB3, 0x01, 0x76, 0x00, 0x00, 0x00, 0x97, 0x0A, 0x8F, 0x01, 0x8E, 0x00, 0x00, 0x00, 0x97, 0x8A, 0xE8, 0x00, 0x8D, 0x00, 0x00, 0x00, 0x97, 0x0A, 0x91, 0x01, 0xDC, 0x00, 0x00, 0x00, 0x97, 0x0A, 0xD9, 0x01, 0xB8, 0x00, 0x00, 0x00, 0x97, 0x8A, 0x95, 0x00, 0xB7, 0x00, 0x00, 0x00, 0x97, 0x8A, 0xE1, 0x00, 0xDE, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x3E, 0x01, 0xB4, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x24, 0x01, 0xB2, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x59, 0x01, 0xB0, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x36, 0x01, 0x9A, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x64, 0x01, 0xA1, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x1E, 0x01, 0x9F, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x0D, 0x01, 0xA8, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x69, 0x01, 0xAC, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x50, 0x01, 0x9F, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0xCB, 0x01, 0xE3, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x93, 0x00, 0xBD, 0x00, 0x00, 0x00, 0x8C, 0x8B, 0x31, 0x01, 0x70, 0x00, 0x00, 0x00, 0x8C, 0x8B, 0xD7, 0x01, 0xC0, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x3E, 0x01, 0xF0, 0x00, 0x00, 0x00, 0x8B, 0x8B, 0x9E, 0x00, 0xE4, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0x16, 0x01, 0x77, 0x00, 0x00, 0x00, 0x8B, 0x8B, 0x51, 0x01, 0x78, 0x00, 0x00, 0x00, 0x0F, 0x80, 0x57, 0x02, 0x3B, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x2E, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x2B, 0x00, 0xE3, 0x00, 0x87, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x8F, 0x01, 0x89, 0x00, 0x00, 0x00, 0x2B, 0x00, 0x90, 0x00, 0xB2, 0x00, 0x00, 0x00, 0x2B, 0x00, 0xDF, 0x01, 0xB8, 0x00, 0x00, 0x00, 0x16, 0x00, 0x5D, 0x00, 0x19, 0x01, 0x00, 0x00, 0x16, 0x80, 0x1E, 0x00, 0x08, 0x01, 0x00, 0x00, 0x16, 0x80, 0x18, 0x02, 0x1C, 0x01, 0x00, 0x00, 0x16, 0x00, 0x6C, 0x02, 0x0D, 0x01, 0x00, 0x00, 0x3F, 0x00, 0x2E, 0x00, 0x40, 0x00, 0x00, 0x00, 0x97, 0x0A, 0x29, 0x00, 0x32, 0x01, 0x00, 0x00, 0x97, 0x8A, 0x5A, 0x02, 0x36, 0x01, 0x00, 0x00, 0x8C, 0x8B, 0x26, 0x00, 0x38, 0x01, 0x00, 0x00, 0x8C, 0x0B, 0x59, 0x02, 0x39, 0x01, 0x00, 0x00, 0x3F, 0x00, 0x64, 0x02, 0x3C, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x15, 0x01, 0xAF, 0x00, 0x00, 0x00, 0x31, 0x00, 0x0F, 0x00, 0x69, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x04, 0x00, 0x01, 0x16, 0x00, 0x68, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x9F, 0x13, 0x3C, 0x01, 0xAC, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB7, 0x07, 0x69, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x9F, 0x13, 0xAA, 0x00, 0xEC, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB7, 0x07, 0x6A, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x9F, 0x13, 0xD7, 0x01, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB7, 0x07, 0x6B, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x9F, 0x13, 0x34, 0x01, 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD1, 0xA0, 0x8C };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
