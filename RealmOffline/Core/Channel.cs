using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Base;
using RealmOffline.Packets;
using RealmOffline.Logs;
using System.IO;
using RealmOffline.Core;
using RealmOffline.Channels;

namespace RealmOffline.Core
{
    public abstract class Channel : IComparable<Channel>, ISerializable<Channel>
    {
        private static readonly RLog logger = new RLog(Path.Combine(ServerGlobals.BaseDirectory, @"Logs\ChannelErrors.log"));

        private string channelNumber;
        public string ChannelNumber
        {
            get { return this.channelNumber; }
            set { this.channelNumber = value; }
        }
        public bool IsPublic { get; set; }
        public string Moderator { get; set; }
        private List<Account> ChannelMembers { get; set; }
        // Does not have to have these to be a channel
        public virtual string ChannelTitle { get; private set; }
        public virtual string Topic { get; private set; }
        public virtual string Password { get; private set; }
        private Random r = new Random();
        /// <summary>
        /// Default constructor, just sets some basic defaults
        /// </summary>
        public Channel()
        {
            ChannelTitle = "";
            Topic = "";
            ChannelMembers = new List<Account>();
        }
        public Channel(string title, string topic)
        {
            this.SetTitle(title);
            this.SetTopic(topic);
            ChannelMembers = new List<Account>();
        }
        public static Channel FromCode(string ownerName, string channelNumber, string title, string topic, string password)
        {
            ChannelProxy proxy = new ChannelProxy();
            proxy.SetChannelInfo(channelNumber, title, topic, password, ownerName);
            return proxy;
        }
        public void SetChannelInfo(string channelnumber, string title, string topic, string password, string moderator = "The Realm Emu Team")
        {
            if (this.ChannelMembers == null) this.ChannelMembers = new List<Account>();
            this.ChannelNumber = channelnumber;
            this.ChannelTitle = title;
            this.Topic = topic;
            this.Password = password;
            this.IsPublic = string.IsNullOrEmpty(password);
            this.Moderator = moderator;
        }
        public int CurrentUsers
        {
            get { return this.ChannelMembers.Count; }
        }
        public void AddMember(Account acct)
        {
            if (!this.ChannelMembers.Contains(acct)) { this.ChannelMembers.Add(acct); }
        }
        public void RemoveMember(Account acct)
        {
            if (this.ChannelMembers.Contains(acct)) { this.ChannelMembers.Remove(acct); }
        }
        public void SetTitle(string title)
        {
            this.ChannelTitle = title;
        }
        public void SetTopic(string topic)
        {
            this.Topic = topic;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }
        public string SetChannelNumber
        {
            get { return this.ChannelNumber; }
            set { this.ChannelNumber = value; }
        }
        public void SendMessage(Account account, string message, ushort color = 103)
        {
            SendMessage(account, Encoding.ASCII.GetBytes(message), color);
        }
        public void SendMessage(Account account, byte[] message, ushort color = 103)
        {
            Console.WriteLine("Sending");
            ChannelColor[] blues = { ChannelColor.Blue_Gray, ChannelColor.Blue_GrayA,
                                   ChannelColor.Blue_Light};

            ChannelColor sender = ChannelColor.Blue_Gray;
            // Depending on admin level, of player, or if they are the chan moderator
            // color will change
            // Color should also change slightly each time a message is displayed like on live.
            switch (Managers.MySqlManager.GetPLevel(account.SqlId))
            {
                case 4: // Guide
                    sender = ChannelColor.Green_Dark;
                    break;
                case 3: // Event Host
                    sender = ChannelColor.Magenta;
                    break;
                case 2: // Moderator
                    sender = ChannelColor.Peach;
                    break;
                case 1: // Game Staff 
                    sender = ChannelColor.Orange_Dark;
                    break;
                case 0: // Implementor
                    sender = ChannelColor.Tan_Dark;
                    break;
                default: // Set 5 default player
                    {
                        int c = r.Next(blues.Length -1);
                        sender = blues[c];
                    }
                    break;
            }
            Console.WriteLine("Still sending");
            PacketWriter msg = new PacketWriter(0x26);
            msg.WriteUInt32(account.AccountId);
            msg.WriteUInt32(0);
            string s = string.Format("|c56|{0}>|c{1}|{2}: ", this.ChannelTitle, (int)sender, account.CurrentCharacter.Name);
            msg.WriteString(s, false);
            msg.WriteBytes(message);
            msg.WriteShort(0x0A);
            byte[] msgPck = msg.ToArray();

            Console.WriteLine("Chanel Members {0}", this.ChannelMembers.Count);
            foreach (Account a in this.ChannelMembers)
            {
                //if (account != a)
               // {
                Console.WriteLine(a.CurrentCharacter.Name);
                    a.Socket.Send(ref msgPck);
               // }
            }
        }
        #region Serialize
        public byte[] Serialize()
        {
            // everything is encoded text
            PacketWriter writer = new PacketWriter();
            writer.WriteBytes(this.ChannelNumber.ToString().ToLengthPrefixedString());
            // channel Name
            writer.WriteBytes(this.ChannelTitle.ToLengthPrefixedString());
            // public ? yes or no
            writer.WriteBytes(string.Format("{0}", this.IsPublic ? "Yes":"No").ToLengthPrefixedString());
            // Who is the moderator ?
            writer.WriteBytes(this.Moderator.ToLengthPrefixedString());
            writer.WriteBytes(this.ChannelMembers.Count.ToString().ToLengthPrefixedString());
            return writer.ToArray();
        }
        public Channel DeSerialize(byte[] ob)
        {
            Channel result = null;
            PacketReader reader = new PacketReader(ob);
            try
            {
                ushort channelNumberLength = reader.ReadUInt16();
                int chanNum = -1;
                if (int.TryParse(reader.ReadString(channelNumberLength), out chanNum))
                {
                    result = new ChannelProxy();
                    result.ChannelNumber = chanNum.ToString();
                    ushort channelTitleLength = reader.ReadUInt16();
                    string channelTitle = reader.ReadString(channelTitleLength);
                    result.ChannelTitle = ChannelTitle;
                    ushort publicStateLength = reader.ReadUInt16();
                    string isPublic = reader.ReadString(publicStateLength);
                    if (isPublic.ToLower() == "yes") { result.IsPublic = true; }
                    else result.IsPublic = false;
                    ushort channelModeratorLength = reader.ReadUInt16();
                    string channelModerator = reader.ReadString(channelModeratorLength);
                    result.Moderator = channelModerator;
                    // How many players on the channel ?
                    ushort playersOnChannelLength = reader.ReadUInt16();
                    string playersOnChannel = reader.ReadString(playersOnChannelLength);
                    // Somehow i need to get these accounts
                }
            }
            catch (Exception e) { logger.WriteException(e); }
            return result;
        }
        #endregion
        public int CompareTo(Channel channel)
        {
            if (this.ChannelNumber == channel.ChannelNumber) { return 1; }
            else return 0;
        }
        public void SendLeavePacket(Account acct)
        {
            PacketWriter w = new PacketWriter(0x26);
            w.WriteUInt32(acct.AccountId);
            w.WriteInt32(0);
            string leave = string.Format("|c43|Info> You have left channel {0} ({1}).", this.ChannelNumber, this.ChannelTitle);
            w.WriteBytes(Encoding.ASCII.GetBytes(leave));
            w.WriteBytes(new byte[] { 0x0A, 0x00 });
            this.ChannelMembers.Remove(acct);
            byte[] l= w.ToArray();
            acct.Socket.Send(ref l);
        }
        public void SendJoinPacket(Account acct, string password = "")
        {
            if (!string.IsNullOrEmpty(password))
            {
                Console.WriteLine("We sent password of {0}", password);
            }
            PacketWriter w = new PacketWriter(0x26);
            w.WriteUInt32(acct.AccountId);
            w.WriteInt32(0);
            if (!string.IsNullOrEmpty(this.Password) 
                && acct.CurrentCharacter.Name != this.Moderator 
                && this.Password != password) // password not sent
            {
                Console.WriteLine("We need a password.");
                w.WriteBytes(new byte[] { 0x7C, 0x63, 0x34, 0x33, 0x7C, 0x49, 0x6E, 0x66, 0x6F, 0x3E, 0x20, 0x41, 0x20, 0x70, 0x61, 0x73, 0x73, 0x77, 0x6F, 0x72, 0x64, 0x20, 0x69, 0x73, 0x20, 0x72, 0x65, 0x71, 0x75, 0x69, 0x72, 0x65, 0x64, 0x20, 0x74, 0x6F, 0x20, 0x6A, 0x6F, 0x69, 0x6E, 0x20, 0x74, 0x68, 0x61, 0x74, 0x20, 0x63, 0x68, 0x61, 0x6E, 0x6E, 0x65, 0x6C, 0x2E, 0x0A, 0x00, 0x2E, 0x20, 0x20 });
                w.WriteBytes(new byte[] { 0x0A, 0x00 });
                byte[] pass = w.ToArray();

                acct.Socket.Send(ref pass);
            }
            else
            {
                if (acct.CurrentChannel != null)
                    acct.CurrentChannel.SendLeavePacket(acct);
                acct.CurrentChannel = this;

                string join = string.Format("|c43|Info> You have joined channel {0} ({1}).",
                this.ChannelNumber, this.ChannelTitle);
                w.WriteBytes(Encoding.ASCII.GetBytes(join));
                w.WriteBytes(new byte[] { 0x0A, 0x00 });
                if (!this.ChannelMembers.Contains(acct)) this.ChannelMembers.Add(acct);
                byte[] pck = w.ToArray();

                acct.Socket.Send(ref pck);
                // send topic
                SendTopicPacket(acct);
            }

        }
        public void SendTopicPacket(Account acct)
        {
            PacketWriter w = new PacketWriter(0x26);
            w.WriteUInt32(acct.AccountId);
            w.WriteInt32(0);
            string topic = string.Format("|c43|Info> Topic: {0}", this.Topic);
            w.WriteBytes(Encoding.ASCII.GetBytes(topic));
            w.WriteBytes(new byte[] { 0x0A, 0x00 });
            byte[] top = w.ToArray();
            acct.Socket.Send(ref top);
        }
    }
}
public class ChannelProxy : Channel
{
    public ChannelProxy()
    {
        this.SetTitle("");
        this.SetTopic("");
    }
}
