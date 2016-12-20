using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Rooms
{
    public class ImportedRooms : ComponentCollection<Room>
    {
        public bool TryGetRoom(uint roomID, out Room foundRoom)
        {
            foundRoom = null;
            foreach (Room room in List)
            {
                if (room.RoomID == roomID)
                    foundRoom = room;
            }
            return foundRoom != null;
        }
    }
}
