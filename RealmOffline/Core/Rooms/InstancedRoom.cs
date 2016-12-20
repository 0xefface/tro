using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Items.Base;

namespace RealmOffline.Core.Rooms
{
    public class InstancedRoom : Room
    {
        public InstancedRoom(uint roomId, RoomBackground backGround, string roomName, BlockedExits blocked, bool castingAllowed = true)
            : base(roomId, backGround, roomName, blocked, castingAllowed)
        {
        }
        public void AddRoomDecorations(List<RoomDecoration> decs)
        {
            this.Decorations = decs;
        }
        public void AddDoor(ushort graphicID, ushort atLocX, ushort atLocY, ushort atFace,
            uint doorExit, ushort exitX, ushort exitY)
        {
            Door d = new Door();
            d.ExitRoom = doorExit;
            d.Location = new RoomLocation(this.RoomID, atLocX, atLocY, atFace);
            d.Location.CurrentRoom = this;
            d.ExitWalkToX = exitX;
            d.ExitWalkToY = exitY;
            d.GraphicID = graphicID;
            d.GameID = ServerGlobals.GetNextAvailableID();
            this.RoomsIDsInUse.Add(d.GameID);
            d.IsOpen = false; // default closed
            this.Items.Add(d);
        }
        public void AddChest()
        {
            // room chests
            // loot chests
        }
    }
}
