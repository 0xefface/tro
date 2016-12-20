using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Packets;
using RealmOffline.Core;
using RealmOffline.Base;
using RealmOffline;

namespace Scripts.Scripts.Commands
{
    [RequiredPrivledge(PrivLevel.GameMaster)] // Anything priv level at this value or lower can use this comand
    public class Connections : Command
    {
        public override char CommandPrefix
        {
            get { return '/'; }
        }
        public override string CommandName
        {
            get { return "Connections"; }
        }
        public override void ReactToPacket()
        {
            // packet has all our data, but for now the CommandArgs are trimmed
            // and already matched up to this command, so we continue from here
            // I wanna send this via custom reply packets
            StringBuilder b = new StringBuilder();
            b.AppendLine("Used to test connections to server:");
            b.AppendLine("/connections list [Lists all active connections by index.]");
            b.AppendLine("/connections remove 1 [Would forceably remove and disconnect the client in slot 1.]");
            b.AppendLine("/connections validate 1 [Would run tests designed to make sure the client is still connected, and would display the output the tests found.]");

            if (this.CommandArgs.Length != 1)
            {
                switch (this.CommandArgs[1].Trim().ToLower())
                {
                    case "list":
                        {
                            b.Clear();
                            b.AppendLine("");
                            for (int i = 0; i < ServerGlobals.LoggedInAccounts.Count; i++)
                            {
                                b.Append(string.Format("Index [{0}] contains Client {1} from account username {2}",
                                    i, ServerGlobals.LoggedInAccounts[i].Socket.TcpSocket.RemoteEndPoint, ServerGlobals.LoggedInAccounts[i].Username));
                            }
                            byte[] reply1 = Packet.ChatPacket(1, 1, b.ToString(), "Connections");
                            this.Player.Socket.Send(ref reply1);
                        }
                        break;
                    case "remove":
                        {
                            // This is a bad command
                            // we need a index
                            if (this.CommandArgs.Length >= 3)
                            {
                                int index = -1;
                                if (int.TryParse(this.CommandArgs[2], out index))
                                {
                                    //  ServerGlobals.ClearAccount(ServerGlobals.LoggedInAccounts[index], true);
                                    // byte[] reply1 = Packet.ChatPacket(1, 1, "Account Removed!", "Connections");
                                    // client.Send(ref reply1);
                                }
                            }
                            else
                            {
                                //byte[] reply1 = Packet.ChatPacket(1, 1, "You need to supply a index to use for remove.", "Connections");
                                // client.Send(ref reply1);
                            }//
                        }
                        break;
                    case "validate":
                        {
                            if (this.CommandArgs.Length >= 3)
                            {
                                int index = -1;
                                if (int.TryParse(this.CommandArgs[2], out index))
                                {
                                    // byte[] val = Packet.ChatPacket(1, 1, "You have been validated!", "Validate");

                                    // if (ServerGlobals.TrySend(ServerGlobals.LoggedInAccounts[index], val))
                                    // {
                                    // byte[] pass = Packet.ChatPacket(18, 1, "Validation Passed!", "Validate");
                                    //  client.Send(ref pass);
                                    // }
                                    // else
                                    //  {
                                    //    byte[] fail = Packet.ChatPacket(1, 1, "Validation failed!", "Validate");
                                    //    client.Send(ref fail);
                                    // }
                                }
                            }

                            else
                            {
                                // byte[] reply1 = Packet.ChatPacket(1, 1, "You need to supply a index to use for remove.", "Connections");
                                // client.Send(ref reply1);
                            }
                        }

                        break;
                    default:
                        {
                        }
                        break;
                }
            }
            else
            {
                byte[] failReply = Packet.RoomChatMessage(Player, b.ToString(), 43, this.CommandName);
                Player.Socket.Send(ref failReply);
            }
        }
    }
}
