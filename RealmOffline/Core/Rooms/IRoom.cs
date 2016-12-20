using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Items.Base;

namespace RealmOffline.Core.Rooms
{
    public interface IRoom
    {
        uint RoomID { get; set; }
        void AddMobile(Mobile mobile);
        void AddRoomDecoration(RoomDecoration decoration);
        void AddItem(BaseGameItem item);
        byte[] GetRoomPacket(uint forAccountID);
    }
}
