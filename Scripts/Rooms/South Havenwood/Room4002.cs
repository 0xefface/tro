using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room4002 : Room
{
public Room4002()
: base(4002, "South Havenwood")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
byte[] roomDecItems = { 0x0F, 0x87, 0x0B, 0xDE, 0x00, 0xC3, 0x00, 0x00, 0x00, 0xB7, 0x00, 0xB6, 0x01, 0x42, 0x01, 0x00, 0x00, 0x70, 0x00, 0xDD, 0x00, 0xC5, 0x00, 0x00, 0x00, 0xE8, 0x09, 0xC3, 0x01, 0x69, 0x00, 0x00, 0x00, 0xE8, 0x09, 0x88, 0x00, 0x69, 0x00, 0x00, 0x00, 0xE8, 0x09, 0x09, 0x02, 0x68, 0x00, 0x00, 0x00, 0x87, 0x8B, 0xBC, 0x01, 0x42, 0x01, 0x00, 0x00, 0x98, 0x00, 0x50, 0x02, 0x72, 0x00, 0x00, 0x00, 0x98, 0x80, 0x29, 0x00, 0x75, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x77, 0x00, 0x72, 0x00, 0x00, 0x00, 0xE7, 0x00, 0xBD, 0x01, 0xCC, 0x00, 0x00, 0x00, 0xE7, 0x80, 0x08, 0x01, 0xCD, 0x00, 0x00, 0x00, 0xE7, 0x80, 0x52, 0x00, 0xCE, 0x00, 0x00, 0x00, 0xE7, 0x80, 0x5A, 0x02, 0xCB, 0x00, 0x00, 0x00, 0xC3, 0x80, 0x5C, 0x02, 0x31, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
base.ApplyRoomLayout();
}
}
}