using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp;
using RealmOffline.Base;
using RealmOffline.Packets;

namespace RealmOffline.Core
{
    public abstract class Command : IComparable<Command>
    {
        public abstract char CommandPrefix { get; }
        public abstract string CommandName { get; }
        public byte[] CommandPacket { get; set; }
        public string[] CommandArgs { get; set; }
        public Account Player { get; private set; }
        public bool IsValidCommand
        {
            get { return this.Player != null && this.CommandPacket != null; }
        }
        public bool SetCommandInfo(Account acctRequestingCommand, byte[] commandPacket)
        {

            string command = Encoding.ASCII.GetString(commandPacket).CleanEncodedString();
            this.CommandArgs = command.Split(' ');
            this.Player = acctRequestingCommand;
            this.CommandPacket = commandPacket;
            return this.IsValidCommand;
        }
        /// <summary>
        /// Command packets can have emotes inserted inside them
        /// mostly with /g room and groups and tells
        /// 80 81 82 83 84 85 86 87 88 89 8A
        /// by the time we get this packet, our command args are set
        /// if we need to access the packet afterwards, for say alt-#
        /// chat emotes, we can, but thats the only time we need the byte structure
        /// </summary>
        /// <param name="client">the client requesting the command</param>
        /// <param name="commandPacket">the trimmed packet to react too</param>
        public virtual void ReactToPacket()
        {
           
        }

        public void ReplyToChatTab(string message)
        {
            byte[] reply = Packet.ChatPacket(1, 1, message, this.CommandName);
            this.Player.Socket.Send(ref reply);
        }
        private string CleanCommandText(string text)
        {
            byte[] cmdText = Encoding.ASCII.GetBytes(text);

            while (cmdText[cmdText.Length - 1] == 0)
            {
                byte[] newArray = new byte[cmdText.Length - 1];
                Array.Copy(cmdText, 0, newArray, 0, newArray.Length);
                cmdText = newArray;
            }
            return Encoding.ASCII.GetString(cmdText);
        }
        public int CompareTo(Command command)
        {
            if (this.CommandName == command.CommandName) { return 1; }
            else return 0;
        }
    }
}
