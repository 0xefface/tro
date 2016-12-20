using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core;
using RealmOffline.Packets;

namespace Scripts.Commands
{
    [RequiredPrivledge(PrivLevel.Player)]
    public class Unbusy : Command
    {
        public override char CommandPrefix
        {
            get { return '/'; }
        }
        public override string CommandName
        {
            get { return "Unbusy"; }
        }
        public override void ReactToPacket()
        {
            byte[] reply = Packet.RoomChatMessage(this.Player, "You are already unbusy!", 43, "Info");
            this.Player.Socket.Send(ref reply);
        }
    }
}
