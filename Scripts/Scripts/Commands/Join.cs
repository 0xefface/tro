using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core;
using RealmOffline.Packets;

namespace Scripts.Scripts.Commands
{
    [RequiredPrivledge(PrivLevel.Player)]
    public class Join : Command
    {
        public override char CommandPrefix
        {
            get { return '/'; }
        }
        public override string CommandName
        {
            get { return "Join"; }
        }
        public override void ReactToPacket()
        {
            /*
            string requestedChannel = CommandArgs[1];

            // Joining first channel
            if (Player.CurrentChannel == null)
            {
                foreach (Channel c in ScriptResolver.ImportedChannels)
                {
                    if (c.ChannelNumber == requestedChannel)
                    {
                        Player.CurrentChannel = c;
                        Player.CurrentChannel.AddMember(Player);
                        byte[] join = c.SendJoinPacket(Player);
                        byte[] topic = c.SendTopicPacket(Player);
                        Player.Socket.Send(ref join);
                        Player.Socket.Send(ref topic);
                        break;
                    }
                }
            }

            // We are changing channels, only if we are not already on the channel
            if (Player.CurrentChannel.ChannelNumber != requestedChannel)
            {
                foreach (Channel c in ScriptResolver.ImportedChannels)
                {
                    if (c.ChannelNumber == requestedChannel)
                    {
                        byte[] leave = Player.CurrentChannel.SendLeavePacket(Player);
                        Player.CurrentChannel.RemoveMember(Player);
                        Player.CurrentChannel = c;
                        Player.CurrentChannel.AddMember(Player);
                        byte[] join = c.SendJoinPacket(Player);
                        byte[] topic = c.SendTopicPacket(Player);
                        Player.Socket.Send(ref leave);
                        System.Threading.Thread.Sleep(10);
                        Player.Socket.Send(ref join);
                        Player.Socket.Send(ref topic);
                        break;
                    }
                }
            }
            Packet.JoinChannel(4, Player);
             */
        }
    }
}
