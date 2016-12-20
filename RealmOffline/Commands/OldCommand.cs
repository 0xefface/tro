using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Base;
using RealmOffline.Managers;
using System.IO;
using System.Reflection;
using System.Threading;
using RealmOffline.Packets;
using RealmOffline.Core.Rooms;
using RealmOffline.Core;
using RealmOffline.Accounts;
using RealmOffline.Core.Mobiles;
using RealmOffline.Core.Items;
using RealmOffline.Core.Items.Base;

namespace RealmOffline.Commands
{
    public class OldCommand
    {
        public string[] CommandArgs { get; private set; }
        /// <summary>
        /// The remainder of the command minus CommandArgs[0]
        /// </summary>
        private string CommandData { get; set; }
        public Account Player { get; private set; }
        public byte[] FullMessagepacket { get; private set; }
        private MemoryStream Stream { get; set; }
        private BinaryReader Reader { get; set; }

        /*
        public Command(Account player , string commandText)
        {
            commandText = CleanCommandText(commandText);
            this.CommandArgs = commandText.Split(' ');
            this.Player = player;
        }
         */
        public OldCommand(Account player, byte[] messagePacket)
        {
            // Set ur command text

            byte[] trimmedMessage = new byte[messagePacket.Length - 8];
            Array.Copy(messagePacket, 8, trimmedMessage, 0, trimmedMessage.Length);
            this.Stream = new MemoryStream(trimmedMessage);
            this.Reader = new BinaryReader(this.Stream);
            string command = Encoding.ASCII.GetString(trimmedMessage);
            command = CleanCommandText(command);
            this.CommandArgs = command.Split(' ');
            
            for (int i = 1; i < this.CommandArgs.Length; i++)
                this.CommandData += this.CommandArgs[i]+" ";
            this.CommandData = this.CommandData;

            this.FullMessagepacket = trimmedMessage;
            this.Player = player;
        }
        public void ReactToCommand()
        {
            switch (this.CommandArgs[0])
            {
                case "/cmds":
                        {
                            // Gonna build a huge listy thingy
                            StringBuilder cmds = new StringBuilder();
                            cmds.AppendLine("Any, or all of these commands may crash you, your friends, or your enemies, they may also cause anger and ruptured bodily organs, use at your own risk!!");
                            cmds.AppendLine("\nCostume:");
                            cmds.AppendLine("Type /costume yourname 2300");
                            cmds.AppendLine("Then relog and boom your a troll, ask your friends for a list of costumes.");
                            cmds.AppendLine("typing /costume 0 will reset you to your original peppy self.");
                            // add moar latur
                            cmds.AppendLine("\nTeleport:");
                            cmds.AppendLine("Type /tp list and look in channel chat for a list of rooms you can goto !");
                            cmds.AppendLine("then type /tp room# to go there !");
                            cmds.AppendLine("\nSpells");
                            cmds.AppendLine("Typing /spells will give you all the known spells in game.");
                            cmds.AppendLine("You must relog to see them.");
                            // Ok lets build the packet
                            byte[] msg = Packet.TopicPopup(Player, "Current Testing Commands!!", cmds.ToString());
                            Player.Socket.Send(ref msg);
                        }
                        break;
                case "/p":
                    {
                        if (CommandArgs.Length >= 2)
                        {
                            int pckid = 0;
                            if (int.TryParse(CommandArgs[1], out pckid))
                            {
                                PacketWriter w = new PacketWriter(0x19);
                                w.WriteUInt32(Player.AccountId);
                                w.WriteUInt32(0x00);
                                w.WriteInt32(pckid);
                                w.WriteUInt32(0x00);
                                w.WriteString("Test");
                                byte[] t = w.ToArray();
                                Player.Socket.Send(ref t);
                                Console.WriteLine("Sent {0}.", pckid);
                            }
                        }
                    }
                    break;
                case "/npc":
                    {
                        List<BaseGameItem> defaultInventory = new List<BaseGameItem>();
                        Item i1 = new Item();
                        i1.GameID = ServerGlobals.GetNextAvailableID();
                        i1.Equipped = true;
                        i1.Color = 99;
                        i1.GraphicID = 1155;
                        defaultInventory.Add(i1);
                        i1 = new Item();
                        i1.GameID = ServerGlobals.GetNextAvailableID();
                        i1.Equipped = true;
                        i1.Color = 99;
                        i1.GraphicID = 1191;
                        defaultInventory.Add(i1);
                        // we want a graphic id
                        if (CommandArgs.Length < 2)
                        {
                            byte[] reply = Packet.ChatPacket(1, 1,
                              "You must supply a graphic id to summon.", "Mob");
                            Player.Socket.Send(ref reply);
                        }
                        else
                        {
                            short mobid = 0;
                            if (short.TryParse(CommandArgs[1], out mobid))
                            {
                                MobileType type = MobileType.None;
                                string name = BaseMobile.MobNameFromID(mobid, out type);
                              //  if (type != MobileType.Humaniod
                               //     || name == "ERROR_NO_DATA")
                               // {
                               //     byte[] breply = Packet.ChatPacket(1, 1,
                               //     string.Format("No known NPC id:{0}.", mobid), "Npc");
                               //     Player.Socket.Send(ref breply);
                                //    return;
                               // }
                                uint mid = ServerGlobals.GetNextAvailableID();
                                Player.CurrentCharacter.IDsInUse.Add(mid);
                                PacketWriter add = new PacketWriter(0x2A);
                                //  PacketWriter mob = new PacketWriter();
                                add.WriteUInt32(Player.AccountId);
                                add.WriteUInt32(0);
                                add.WriteInt32(-1);
                                add.WriteUInt32(Player.CurrentCharacter.Location.CurrentRoom.RoomID);

                                //add.WriteBytes(new byte[]{0x40, 0x2F, 0x00});
                                add.WriteByte(0x40);

                                NPC m = new NPC();
                                m.GraphicID = (ushort)mobid;
                                m.GameID = mid;
                                m.Girth = 100;
                                m.Height = 100;
                                m.CurrentHitPoints = 1201230;
                                m.MaxHitPoints = 1201230;

                                RoomLocation r = new RoomLocation(Player.CurrentCharacter.Location.CurrentRoom.RoomID, Player.CurrentCharacter.Location.X,
                                    Player.CurrentCharacter.Location.Y, Player.CurrentCharacter.Location.Facing);
                                //m.Location = Player.CurrentCharacter.Location;
                                m.Location = r;
                                m.Gender = 1;
                                m.RaceHead = 1;
                                m.ChinPart = 0;
                                m.EarPart = 0;
                                m.EyeBrowPart = 0;
                                m.EyeColor = 2;
                                m.EyePart = 0;
                                m.FacialHairPart = 0;
                                m.HairColor = 2;
                                m.HairPart = 0;
                                m.HeadPart = 0;
                                m.MouthPart = 0;
                                m.NosePart = 0;
                                //m.RaceHead = 1;
                                m.SkinColor = 2;
                                m.Inventory = defaultInventory;
                                m.CreateFace();
                                //m.MobBrain = new Brain(m);
                                //  m.Location.CurrentRoom = Player.CurrentCharacter.Location.CurrentRoom;
                                Player.CurrentCharacter.Location.CurrentRoom.AddEntity(m, Player);
                                byte[] mob = Packet.WrappedMob(m);
                                add.WriteBytes(mob);
                                byte[] try1 = add.ToArray();
                                Player.CurrentCharacter.Location.CurrentRoom.SendMovePacket(try1);
                               // string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly()
                                  //  .Location), "npc1.txt");
                              //  File.WriteAllText(fileLocation, BitConverter.ToString(try1));
                                byte[] reply = Packet.ChatPacket(1, 1,
                                string.Format("Created {0} NPC {1} with a GameID of:({2}).",
                                type, name, mid), "Npc");
                                Player.Socket.Send(ref reply);
                            }
                            else
                            {
                                if (CommandArgs[1].ToLower() == "build")
                                {
                                    string replyString = "Haha Example: /npc build graphicid# height% girth% race# gender# chin# hair# brow# eyes# nose# ear# mouth# beard# skincolor# haircolor# eyecolor#";

                                    // ya we got lots of sections
                                    if (CommandArgs.Length == 18)
                                    {
                                        short npcID = 0;

                                        byte hi, gi, ra, ge, ch, ha, br, ey, no, ea, mo, be, sc, hc, ec;

                                        // First check the id
                                        if (short.TryParse(CommandArgs[2], out npcID))
                                        {
                                            MobileType type = MobileType.None;
                                            string name = BaseMobile.MobNameFromID(npcID, out type);
                                            if (type != MobileType.Humaniod
                                                || name == "ERROR_NO_DATA")
                                            {
                                                byte[] breply = Packet.ChatPacket(1, 1,
                                                string.Format("No known NPC id:{0}.", npcID), "Npc");
                                                Player.Socket.Send(ref breply);
                                                return;
                                            }
                                            // Good mob, continue
                                            NPC npc = new NPC();
                                            npc.GraphicID = (ushort)npcID;
                                            npc.GameID = ServerGlobals.GetNextAvailableID();
                                            //npc.Location = Player.CurrentCharacter.Location;
                                            npc.Location = new RoomLocation(Player.CurrentCharacter.Location.CurrentRoom.RoomID, Player.CurrentCharacter.Location.X,
                                            Player.CurrentCharacter.Location.Y, Player.CurrentCharacter.Location.Facing);
                                            
                                            npc.CurrentHitPoints = 8675;
                                            npc.MaxHitPoints = 8675;
                                            // all at once
                                            if (byte.TryParse(CommandArgs[3], out hi) && byte.TryParse(CommandArgs[4], out gi)
                                                && byte.TryParse(CommandArgs[5], out ra) && byte.TryParse(CommandArgs[6], out ge) && byte.TryParse(CommandArgs[7], out ch)
                                                && byte.TryParse(CommandArgs[8], out ha) && byte.TryParse(CommandArgs[9], out br) && byte.TryParse(CommandArgs[10], out ey)
                                                && byte.TryParse(CommandArgs[11], out no) && byte.TryParse(CommandArgs[12], out ea) && byte.TryParse(CommandArgs[13], out mo)
                                                && byte.TryParse(CommandArgs[14], out be) && byte.TryParse(CommandArgs[15], out sc) && byte.TryParse(CommandArgs[16], out hc)
                                                && byte.TryParse(CommandArgs[17], out ec))
                                            {
                                                npc.Height = hi;
                                                npc.Girth = gi;
                                                npc.BuildHead(ra, ge, ch, ha, br, ey, no, ea, mo, br, sc, hc, ec);
                                                npc.Inventory = defaultInventory;
                                                Player.CurrentCharacter.Location.CurrentRoom.AddEntity(npc, Player);
                                                byte[] try2 = Packet.WrappedNPC(npc, Player.CurrentCharacter.Location);
                                               
                                                Player.CurrentCharacter.Location.CurrentRoom.SendPacket(try2, false);//.SendMovePacket(try2);
                                                string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly()
                                    .Location), "npc2.txt");
                                                File.WriteAllText(fileLocation, BitConverter.ToString(try2));
                                                ///
                                                replyString = string.Format("You got MobID {0} Height {1}% Girth {2}% Race {3} Gender {4} Chin {5} Hair {6} EyeBrow {7} Eyes {8} Nose {9} Ear {10} Mouth {11} Beard {12} SkinColor {13} HairColor {14} EyeColor {15}.",
                                                    npcID, hi, gi, ra, ge, ch, ha, br, ey, no, ea, mo, be, sc, hc, ec);
                                            }

                                        }
                                        Console.WriteLine("Ya thats enough.");
                                    }


                                    byte[] reply = Packet.ChatPacket(1, 1,
                                    string.Format(replyString, CommandArgs[1]), "Npc");
                                    Player.Socket.Send(ref reply);
                                }
                                else
                                {
                                    byte[] reply = Packet.ChatPacket(1, 1,
                                    string.Format("Unable to parse Graphic ID {0}.", CommandArgs[1]), "Npc");
                                    Player.Socket.Send(ref reply);
                                }
                            }
                        }
                    }
                    break;
                case "/string":
                    {
                        if (CommandArgs.Length >= 2)
                        {
                            uint cmd = 0;
                            if (uint.TryParse(CommandArgs[1], out cmd))
                            {
                                PacketWriter w1A = new PacketWriter(0x1A);
                                w1A.WriteUInt32(Player.AccountId);
                                w1A.WriteUInt32(0x00);
                                w1A.WriteUInt32(0x87);
                                w1A.WriteUInt32(cmd);
                                byte[] p1A = w1A.ToArray();
                                Player.Socket.Send(ref p1A);
                                byte[] reply = Packet.ChatPacket(1, 1, string.Format("Sent packet for {0}", cmd), "Door");
                                Player.Socket.Send(ref reply);
                            }
                        }
                    }
                    break;
                case "/door":
                    {
                        // door unlock id room#
                        // door lock id room
                        // door move id room newx newy
                        // door key (add/remove)
                        
                        Door door = null;
                        byte[] reply = null;
                        string replyString = "Invalid Option!";
                        Room room = null;

                        // Many subcommands
                        if (CommandArgs.Length >= 2)
                        {
                            switch (CommandArgs[1].ToLower())
                            {
                                case "unlock":
                                    {
                                        if (CommandArgs.Length >= 4)
                                        {
                                            uint doorID = 0;
                                            uint roomNum = 0;
                                            if (uint.TryParse(CommandArgs[2], out doorID))
                                            {
                                                if (uint.TryParse(CommandArgs[3], out roomNum))
                                                {
                                                    room = ScriptResolver.GetRoom(roomNum);
                                                    if (room != null)
                                                    {
                                                        // find the door
                                                        foreach (BaseGameItem b in room.Items)
                                                        {
                                                            if (b.GameID == doorID && b is Door)
                                                            {
                                                                door = b as Door;
                                                                door.UnlockDoor();
                                                                replyString = string.Format("Door {0} unlocked.",doorID);
                                                            }
                                                        }
                                                    }
                                                    else replyString = string.Format("Unable to locate Room #{0}.", roomNum);
                                                }
                                                else replyString = string.Format("Invalid Room {0}.", CommandArgs[3]);
                                            }
                                            else replyString = string.Format("Invalid DoorID {0}.", CommandArgs[2]);

                                        }
                                        else replyString = "Unlock requires a doorid followed by a roomnumber. EX: /door unlock 2017 5043";
                                        reply = Packet.ChatPacket(1, 1, replyString, "Door");
                                        Player.Socket.Send(ref reply);
                                    }
                                    break;
                                case "lock":
                                        {
                                        if (CommandArgs.Length >= 4)
                                        {
                                            uint doorID = 0;
                                            uint roomNum = 0;
                                            if (uint.TryParse(CommandArgs[2], out doorID))
                                            {
                                                if (uint.TryParse(CommandArgs[3], out roomNum))
                                                {
                                                    room = ScriptResolver.GetRoom(roomNum);
                                                    if (room != null)
                                                    {
                                                        // find the door
                                                        foreach (BaseGameItem b in room.Items)
                                                        {
                                                            if (b.GameID == doorID && b is Door)
                                                            {
                                                                door = b as Door;
                                                                door.LockDoor();
                                                                replyString = string.Format("Door {0} locked.",doorID);
                                                            }
                                                        }
                                                    }
                                                    else replyString = string.Format("Unable to locate Room #{0}.", roomNum);
                                                }
                                                else replyString = string.Format("Invalid Room {0}.", CommandArgs[3]);
                                            }
                                            else replyString = string.Format("Invalid DoorID {0}.", CommandArgs[2]);

                                        }
                                        else replyString = "Lock requires a doorid followed by a roomnumber. EX: /door unlock 2017 5043";
                                    }
                                    break;
                            }
                        }
                        reply = Packet.ChatPacket(1, 1, replyString, "Door");
                        Player.Socket.Send(ref reply);
                    }
                    break;
                case "/clearroom":
                    {
                        string reply = "Invalid.";
                        byte[] p = null;
                        if (CommandArgs.Length >= 2)
                        {
                            uint id = 0;
                            if (uint.TryParse(CommandArgs[1], out id))
                            {
                                try
                                {
                                    ScriptResolver.GetRoom(id).Items.Clear();
                                    reply = string.Format("Room {0} Successfully cleared of items.", id);
                                }
                                catch { reply = string.Format("Unable to clear room {0} of items.", id); }
                            }
                            else reply = string.Format("Unable to parse {0}", CommandArgs[1]);
                        }
                        else reply = "Please supply a room id.";

                        p = Packet.ChatPacket(1, 1, reply, "ClearRoom");
                        Player.Socket.Send(ref p);
                    }
                    break;
                case "/additem":
                    {
                        string reply = "Invalid.";
                        byte[] p = null;
                        if (CommandArgs.Length >= 2)
                        {
                            ushort id = 0;
                            if (ushort.TryParse(CommandArgs[1], out id))
                            {

                                Door i = new Door();
                                i.GraphicID = id;
                                i.AssignToRoom(Player.CurrentCharacter.Location);
                                i.GameID = ServerGlobals.GetNextAvailableID();
                                i.IsContainer = false;
                                i.IsInventoryItem = false; // open and close for a door
                                Player.CurrentCharacter.Location.CurrentRoom.AddItem(i);
                                reply = string.Format("Item {0} added to room {1}, please leave the room and return.",
                                id, Player.CurrentCharacter.Location.CurrentRoom.RoomID);
                            }
                            else reply = string.Format("Unable to parse {0}", CommandArgs[1]);
                        }
                        else reply = "Please supply a graphic id.";
                        
                        p = Packet.ChatPacket(1, 1, reply, "AddToRoom");
                        Player.Socket.Send(ref p);
                    }
                    break;
                case "/level":
                    {
                        PacketWriter w = new PacketWriter(0x2A);
                        w.WriteUInt32(Player.AccountId);
                        w.WriteUInt32(0x00);

                        w.WriteUInt32(Player.CurrentCharacter.GameID);
                        w.WriteUInt32(Player.CurrentCharacter.Location.CurrentRoom.RoomID);
                        w.WriteByte(0x17);
                        //1E heals you for below amt
                        w.WriteUInt32(Player.CurrentCharacter.GameID);
                        w.WriteBytes(new byte[] { 0xA0, 0x86, 0x01, 0x00, 0x18 });
                        w.WriteByte(0x21);
                        w.WriteByte(0xFF);
                        byte[] p25 = w.ToArray();
                        Player.Socket.Send(ref p25);
                    }
                    break;
                case "/regen":
                    {
                        if (CommandArgs.Length >= 2)
                        {
                            byte a = 0x00;
                            if (byte.TryParse(CommandArgs[1], out a))
                            {
                                byte[] amount = RealmPacketIO.GetByteArrayFromFileInBaseDir("regen.txt");
                                Console.WriteLine("{0} bytes in amount.", amount.Length);
                                PacketWriter w = new PacketWriter(0x2A);
                                w.WriteUInt32(Player.AccountId);
                                w.WriteUInt32(0x00);
                                w.WriteUInt32(Player.CurrentCharacter.GameID);
                                w.WriteUInt32(Player.CurrentCharacter.Location.CurrentRoom.RoomID);
                                //w.WriteByte(0x1E); // the whatsever to munk with ?
                                w.WriteByte(a);
                                w.WriteUInt32(Player.CurrentCharacter.GameID);
                                w.WriteBytes(amount);
                                w.WriteByte(0x00);
                                w.WriteByte(0xFF);
                                byte[] p42 = w.ToArray();
                                Player.Socket.Send(ref p42);
                            }
                        }
                    }
                    break;
                case "/save":
                    {
                        Console.WriteLine("In Save");
                        // what to save ?
                        if (CommandArgs.Length >= 2)
                        {
                            switch (CommandArgs[1].ToLower())
                            {
                                case "stats":
                                    {
                                        Console.WriteLine("Stats");
                                        bool save = MySqlManager.SaveCharStats(Player.CurrentCharacter);
                                        Console.WriteLine(save);
                                        byte[] reply = Packet.ChatPacket(1, 1,
                                        string.Format("Saved stats for {0} {1}.", Player.CurrentCharacter.Name, save), "ServerMessage");
                                        Player.Socket.Send(ref reply);
                                    }
                                    break;
                            }
                        }
                    }
                    break;
                case "/q":
                    {
                        PacketWriter w42A = new PacketWriter(0x2A);
                        w42A.WriteUInt32(Player.AccountId);
                        w42A.WriteUInt32(0x00);
                        // Works, gives a wrapped item
                        w42A.WriteUInt32(Player.CurrentCharacter.GameID);
                        w42A.WriteUInt32(Player.CurrentCharacter.Location.CurrentRoom.RoomID);
                        w42A.WriteBytes(new byte[]{0x3F, 
                        0x16, 0x00});
                        w42A.WriteUInt32(Player.CurrentCharacter.GameID);
                        w42A.WriteBytes(new byte[] { 0x01, 0x0E, 0x01});
                        w42A.WriteUInt32(ServerGlobals.GetNextAvailableID());
                        //0x0F, 0xAD, 0x04, 0x00, 
                        w42A.WriteBytes(new byte[]{ 0x00, 0x00, 0x00, 0x20, 0xFF, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF });
                        byte[] p42A = w42A.ToArray();
                        Player.Socket.Send(ref p42A);
                    }
                    break;
                case "/sm":
                    {
                        var replyString = string.Empty;
                        if (CommandArgs.Length >= 3) // must have a 1 word topic and 1 word mesage at least
                        {
                            var a = CommandData.Select(c => c).Where(c=> c == ':').ToArray();
                            if (a.Length > 1)
                            {
                                replyString = "Only 1 : seperates topic from message.";
                                return;
                            }
                            string topic = CommandData.Split(':').First();
                            string msg = CommandData.Split(':').Last();
                            foreach (Account act in ServerGlobals.LoggedInAccounts)
                            {
                                byte[] p = Packet.TopicPopup(act, topic, string.Format("{0} - {1}", msg, Player.CurrentCharacter.Name));
                                act.Socket.Send(ref p);
                            }
                            replyString = string.Format("Creating Message (Topic:{0}) (Message:{1})", topic, msg);
                        }
                        byte[] reply = Packet.ChatPacket(1, 1,
                          replyString, "ServerMessage");
                        Player.Socket.Send(ref reply);
                    }
                    break;
                case "/snow":
                    {
                        uint gameID = 0;
                        PacketWriter w = new PacketWriter(0x2A);
                                w.WriteUInt32(Player.AccountId);
                                w.WriteUInt32(0x00);
                        byte[] snow = Packet.WrapWeather(Player.CurrentCharacter.Location.CurrentRoom.RoomID, 288, out gameID);
                        w.WriteUInt32(gameID);
                        w.WriteUInt32(Player.CurrentCharacter.Location.CurrentRoom.RoomID);
                        w.WriteBytes(snow);


                        w.WriteByte(0x00);
                        w.WriteByte(0xFF);
                        byte[] p = w.ToArray();
                        Player.CurrentCharacter.Location.CurrentRoom.SendPacket(p, false);
                    }
                    break;
                case "/stopsnow":
                    {
                        int room = (int)Player.CurrentCharacter.Location.CurrentRoom.RoomID;
                        PacketWriter w = new PacketWriter(0x2D);
                        w.WriteUInt32(Player.AccountId);
                        w.WriteInt32(0);
                        w.WriteInt32(room); // Room to remove from

                        w.WriteUInt32(200001); // obj to remove

                        w.WriteBytes(new byte[] { 0x00, 0x15, 0x00, 0x69 });
                        byte[] rem = w.ToArray();
                        Player.CurrentCharacter.Location.CurrentRoom.SendPacket(rem, false);
                    }
                    break;
                case "/ani":
                    {
                        string replyString = "None.";
                        byte[] reply = new byte[0];
                        if (CommandArgs.Length >= 2)
                        {
                            short gid = 0;
                            if (short.TryParse(CommandArgs[1], out gid))
                            {
                                Console.WriteLine("We got {0}", gid);
                                PacketWriter w = new PacketWriter(0x2A);
                                w.WriteUInt32(Player.AccountId);
                                w.WriteUInt32(0x00);
                                uint id = 0;
                                byte[] cloud = Packet.WrapCloud(Player, gid, out id);
                                w.WriteUInt32(id); // id of mob below

                                w.WriteUInt32(Player.CurrentCharacter.Location.CurrentRoom.RoomID);
                                w.WriteBytes(cloud);
                                w.WriteByte(0x00);
                                w.WriteByte(0xFF);
                                byte[] p = w.ToArray();
                                Player.CurrentCharacter.Location.CurrentRoom.SendPacket(p);
                                replyString = string.Format("Animation {0} summoned with GameID {1}.", gid, id);
                              
                            }
                            else replyString = string.Format("{0} is not a valid numeral.", CommandArgs[1]);
                        }
                        else replyString = "/ani # (EX: /ani 3)";

                        reply = Packet.ChatPacket(1, 1,
                          replyString, "Animation");
                        Player.Socket.Send(ref reply);

                    }
                    break;
                case "/gold":
                    {
                        if (CommandArgs.Length >= 2)
                        {
                            int amt = 0;

                            if (int.TryParse(CommandArgs[1], out amt))
                            {
                                // just givng to self atm
                                Item i = new Item();
                                i.GraphicID = 0x02;
                                i.GameID = ServerGlobals.GetNextAvailableID();
                                i.Color = 43;
                                i.IsIdentified = true;
                                i.Value = 123456;
                                i.IsGoldOrMana = true;
                                i.Location = Player.CurrentCharacter.Location;
                                Console.WriteLine("Trying to give {0} gold to {1}.", amt, Player.CurrentCharacter.Name);
                                byte[] p = RealmPacketIO.GiveInventoryItem(Player, i);
                                Player.Socket.Send(ref p);
                            }
                        }
                    }
                    break;
                #region Costume
                case "/costume":
                    {
                        string reply = "was";
                        
                        if (CommandArgs.Length >= 3)
                        {
                            // we need who to give the costume, we want name
                            string player = CommandArgs[1];
                            short costume = 0;
                            uint sqlid = 0;
                            bool found = MySqlManager.TryFindCharacter(player, out sqlid);
                            Character c = MySqlManager.GetCharacter(sqlid);
                            Console.WriteLine("Command args length = {0} sql id found {1}", CommandArgs.Length, sqlid);
                            if (found && c != null)
                            {
                                if (short.TryParse(CommandArgs[2], out costume))
                                {
                                    Console.WriteLine("We Parse Costume to {0}", costume);
                                    
                                        
                                            if (costume == 0)
                                            {
                                                c.ResetCharacterGraphic();
                                                reply = string.Format("Sucessfully reset player {0} to normal.", player);
                                            }
                                            else
                                            {
                                                c.SwitchCharacterToMob(costume);
                                                reply = string.Format("Sucessfully granted costume {0} to {1}.", costume, player);
                                            }
                                        
                                    
                                }
                                else reply = string.Format("Invalid costume # {0}.", CommandArgs[2]);
                            }
                            else reply = string.Format("Player {0} not found.", player);
                        }
                        else reply = "/costume playername costume id  (EX: /costume Barry 2436).";
                        if (reply != string.Empty)
                        {
                            byte[] r = Packet.ChatPacket(1, 1,
                            reply, "Costume");
                            Player.Socket.Send(ref r);
                        }
                    }
                    break;
                #endregion
                case "/spellgive":
                    {
                        if (CommandArgs.Length >= 2)
                        {
                            byte spell = 0;
                            if (byte.TryParse(CommandArgs[1], out spell))
                            {
                                Console.WriteLine("Trying to give spell {0}", spell);
                                PacketWriter w42 = new PacketWriter(0x2A);
                                w42.WriteUInt32(Player.AccountId);
                                w42.WriteUInt32(0x00);
                                w42.WriteUInt32(Player.CurrentCharacter.GameID);
                                w42.WriteUInt32(Player.CurrentCharacter.Location.CurrentRoom.RoomID);
                                //w42.WriteByte(0x32);
                                w42.WriteUInt32(Player.CurrentCharacter.GameID);
                                //w42.WriteUInt32(0x00);
                                w42.WriteShort(spell);
                                w42.WriteByte(0xFF);
                                w42.WriteByte(0xFF);
                                w42.WriteByte(0x21);
                                w42.WriteByte(0xFF);
                                byte[] p42 = w42.ToArray();
                                Player.Socket.Send(ref p42);
                            }

                        }
                    }
                    break;
                #region dye
                case "/dye":
                    {
                        if (CommandArgs.Length >= 3)
                        {
                            uint item = 0;
                            short color = 0;
                            if (uint.TryParse(CommandArgs[1], out item))
                            {
                                if (short.TryParse(CommandArgs[2], out color))
                                {
                                    Player.CurrentCharacter.Location.CurrentRoom.SendColorUpdate(Player,
                                        item, (byte)color);
                                    Item found = null;//MySqlManager.GetItem(item);

                                    foreach (Character c in Player.CurrentCharacter.Location.CurrentRoom.Players)
                                    {
                                        foreach (Item i in c.Inventory)
                                        {
                                            if (i.GameID == item)
                                            {
                                                found = i;
                                                break;
                                            }
                                        }
                                    }

                                    if (found != null)
                                    {
                                        found.Color = (ushort)color;
                                        bool update = MySqlManager.UpdateItem(found);
                                        if (!update)
                                        {
                                            byte[] replyPacket = Packet.ChatPacket(1, 1,
                                             string.Format("Error Updating item {0}", item), "Dye");
                                            Player.Socket.Send(ref replyPacket);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                #endregion
                #region Spell
                case "/spell":
                    {
                        string replystring = string.Empty;
                        uint cid = Player.CurrentCharacter.GameID;
                        uint room = Player.CurrentCharacter.Location.CurrentRoom.RoomID;

                        if (CommandArgs.Length >= 2)
                        {
                            short id = 0;
                            if (short.TryParse(CommandArgs[1], out id))
                            {
                                if (id < 258 || id == 287 || id == 288 || id == 289
                            || id == 293) return;
                                PacketWriter w25 = new PacketWriter(0x19);
                                w25.WriteUInt32(Player.AccountId);
                                w25.WriteUInt32(0);
                                w25.WriteUInt32(0x50);
                                w25.WriteBytes(new byte[] { 0xD3, 0x3B, 0x09, 0x08 });
                                byte[] reply = w25.ToArray();


                                PacketWriter w = new PacketWriter(0x2A);
                                w.WriteUInt32(Player.AccountId);
                                w.WriteUInt32(0x00);
                                w.WriteUInt32(cid);
                                w.WriteUInt32(room);
                                w.WriteBytes(new byte[] { 0x21, 0xFF, 0x00, 0x00 });
                                byte[] pw = w.ToArray();
                               Player.Socket.Send(ref pw);


                                PacketWriter w2B = new PacketWriter(0x2A);
                                w2B.WriteUInt32(Player.AccountId);
                                w2B.WriteUInt32(0x00);
                                w2B.WriteUInt32(cid);
                                w2B.WriteUInt32(room);
                                w2B.WriteByte(0x1D);
                                w2B.WriteUInt32(cid);
                                w2B.WriteByte(0x2C);
                                w2B.WriteUInt32(cid);
                               // if (caster != target)
                                   // w2B.WriteString(string.Format("{0} says 'SpellName', pointing at the {1}.", cli.GameAccount.CurrentCharacter.Name, target));
                                //else 
                                w2B.WriteString(string.Format("{0} mumbles 'SpellName', under {1} breath.", Player.CurrentCharacter.Name, Player.CurrentCharacter.Gender == 0 ? "his" : "her"));
                                w2B.WriteByte(0x25); // end spell text
                                w2B.WriteUInt32(cid);
                                w2B.WriteInt32(-1); // how much the spell costs
                                w2B.WriteByte(0x27);
                                w2B.WriteUInt32(cid);
                                w2B.WriteShort(id);
                                //w2B.WriteBytes(new byte[] { 0x4B, 0x01 }); // the spell id
                                w2B.WriteUInt32(cid);
                                w2B.WriteByte(0x0E);
                                w2B.WriteUInt32(cid);
                                w2B.WriteBytes(new byte[] { 0x27, 0x00, 0x01, 0x2C });
                                w2B.WriteUInt32(cid);
                                w2B.WriteString("The spell does all sorts of stuff to you or an item here.");
                                w2B.WriteByte(0x1F); // end spell info
                                w2B.WriteUInt32(cid);
                                w2B.WriteByte(0xFF);
                                byte[] p2B = w2B.ToArray();
                                //Player.Socket.Send(ref p2B);
                                Player.CurrentCharacter.Location.CurrentRoom.SendPacket(p2B);


                                // Now next packet to gimme my icon back
                                PacketWriter w2C = new PacketWriter(0x2A);
                                w2C.WriteUInt32(Player.AccountId);
                                w2C.WriteUInt32(0x00);
                                w2C.WriteUInt32(cid);
                                w2C.WriteUInt32(room);
                                w2C.WriteBytes(new byte[] { 0x21, 0xFF });
                                byte[] p2C = w2C.ToArray();
                                Player.Socket.Send(ref p2C);
                            }
                            else replystring = string.Format("Unable to parse spell id {0}", id);
                        }
                        else replystring = "You must supply a spell id.";
                    }
                    break;
                #endregion
                #region Zerk Helm
                case "/back":
                    {
                        if (CommandArgs.Length <= 2)
                        {
                            short ef = 0;
                            if (short.TryParse(CommandArgs[1], out ef))
                            {
                                // removes str/dex too
                                uint acctid = Player.AccountId;
                                uint myid = Player.CurrentCharacter.GameID;
                                uint myroom = Player.CurrentCharacter.Location.CurrentRoom.RoomID;
                                PacketWriter w = new PacketWriter(0x2A); //42
                                w.WriteUInt32(acctid);
                                w.WriteUInt32(0x00);
                                w.WriteUInt32(myid);
                                w.WriteUInt32(myroom);
                                w.WriteByte(0x08); // go up to here
                                w.WriteUInt32(myid);
                                // the id responsible ?
                                w.WriteUInt32(myid); // might be problem
                                // set to me for now
                                w.WriteByte(0x0F);

                                // The charid the spells are being removed from
                                // follwed by the spell text to display, or the spell id itsself ?
                                // as many as are needed i guess.

                                //string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly()
                                 //   .Location), "spelldesc.txt");

                                w.WriteUInt32(myid);
                                w.WriteShort(ef);
                                w.WriteShort(3840);
                              //  byte[] s = RealmPacketIO.GetByteArrayFromFileInBaseDir(fileLocation);
                               // w.WriteBytes(s);
                                // w.WriteBytes(new byte[] { 0x38, 0x00, 0x00, 0x0F }); // you feel less agressive 0x0F removes, 0x0E gives.
                                // w.WriteUInt32(myid);
                                // w.WriteBytes(new byte[] { 0x05, 0x02, 0x00, 0x0F });
                                // w.WriteUInt32(myid); // good to here
                                // w.WriteBytes(new byte[] { 0x21, 0x00, 0x00, 0x0F });
                                // w.WriteUInt32(myid);
                                // w.WriteBytes(new byte[] { 0x46, 0x00, 0x00, 0x0F });
                                // w.WriteUInt32(myid);
                                // w.WriteBytes(new byte[] { 0x61, 0x00, 0x00, 0x0F });
                                // w.WriteUInt32(myid);
                                // w.WriteBytes(new byte[] { 0x3B, 0x00, 0x06, 0x2F });
                                w.WriteUInt32(myid);//me
                                w.WriteUInt32(myid);//me
                                w.WriteInt32(Player.CurrentCharacter.TotalHP);
                                w.WriteBytes(new byte[] { 0x21, 0xFF });
                                // Do not think we need these
                                //w.WriteBytes(new byte[] { 0x00, 0x00, 0xDE, 0x07 });
                                byte[] p = w.ToArray();
                                Player.CurrentCharacter.Location.CurrentRoom.SendPacket(p);
                                //Player.Socket.Send(ref p);
                            }
                        }
                        
                    }
                    break;
                case "/app":
                    {
                        if (CommandArgs.Length <= 2)
                        {
                            short ef = 0;
                            if (short.TryParse(CommandArgs[1], out ef))
                            {
                                Console.WriteLine("Trying to apply spell effect {0}", ef);
                                uint acctid = Player.AccountId;
                                uint myid = Player.CurrentCharacter.GameID;
                                uint myroom = Player.CurrentCharacter.Location.CurrentRoom.RoomID;
                                PacketWriter w = new PacketWriter(0x2A); //42
                                w.WriteUInt32(acctid);
                                w.WriteUInt32(0x00);
                                w.WriteUInt32(myid);
                                w.WriteUInt32(myroom);
                                w.WriteByte(0x07); // go up to here
                                w.WriteUInt32(myid);
                                // the id responsible ?
                                w.WriteUInt32(myid); // might be problem
                                // set to me for now
                                w.WriteByte(0x0E);
                              //  w.WriteUInt32(myid);
                               // w.WriteBytes(new byte[] { 0x38, 0x00, 0x00, 0x0E });
                               // w.WriteUInt32(myid);
                               // w.WriteBytes(new byte[] { 0x05, 0x02, 0x00, 0x0E });
                               // w.WriteUInt32(myid); // good to here
                               // w.WriteBytes(new byte[] { 0x21, 0x00, 0x00, 0x0E });
                                //w.WriteUInt32(myid);
                               // w.WriteBytes(new byte[] { 0x46, 0x00, 0x00, 0x0E });
                               // w.WriteUInt32(myid);
                               // w.WriteBytes(new byte[] { 0x61, 0x00, 0x00, 0x0E });
                                w.WriteUInt32(myid);
                               // w.WriteBytes(new byte[] { 0x27, 0x00, 0x06, 0x0E });
                                w.WriteShort(ef);
                                w.WriteByte(0x06);
                                w.WriteByte(0x0E);
                                w.WriteUInt32(myid);//me
                                w.WriteUInt32(myid);//me
                                w.WriteInt32(Player.CurrentCharacter.TotalHP);
                                w.WriteBytes(new byte[] { 0x21, 0xFF });
                                /* this all works
                                w.WriteShort(ef);
                                w.WriteShort(3584);
                                
                                w.WriteUInt32(myid);// good to here
                                w.WriteBytes(new byte[] { 0x3B, 0x00, 0x06, 0x2F });
                                w.WriteUInt32(myid);//me
                                w.WriteUInt32(myid);//me
                                w.WriteInt32(Player.CurrentCharacter.TotalHP);
                                w.WriteBytes(new byte[] { 0x21, 0xFF });
                                 * 
                                 */
                                // Do not think we need these
                                //w.WriteBytes(new byte[] { 0x00, 0x00, 0xDE, 0x07 });
                                byte[] p = w.ToArray();
                                Player.CurrentCharacter.Location.CurrentRoom.SendPacket(p);
                                //Player.Socket.Send(ref p);
                            }
                        }
                    }
                    break;
                #endregion
                #region Whats New
                case "/wn":
                    {
                        #region Help Info
                        string adduse = "/wn add [color] [message] EX: /wn add 6 Welcome to the first day of Realm !!!";
                        string remuse = "/wn remove # EX: /wn remove 5";
                        string upuse = "/wn update # [color] [message] EX: /wn update 5 32 Welcome to the first day of Realm !!!";
                        string finduse = "/wn find [author] EX: /wn find dan\n"+
                            "/wn find # EX: /wn find 5";
                        string clearuse = "/wn clear [Warning !!! this will empty the whats new list!!].";
                        byte[] replyPacket = null;
                        string replyString = "Try /wn help.";
                        #endregion
                        /*
                         * Whats new, number of commands here to maniuplate the database
                         * add -> adds a new message
                         * find -> finds a message
                         * clear -> clears the list
                         * remove # -> removes message #
                         * update # -> updates message
                         * help -> it helps.
                         */
                        if (CommandArgs.Length >= 2)
                        {
                            switch (CommandArgs[1].ToLower())
                            {
                                    // add done
                                #region Add
                                case "add": // 1 // color is 2 message is 3 and on
                                    {
                                        if (CommandArgs.Length < 4) { replyString = "You Must supply a color and a message."; break; }
                                        int color = 0;
                                        if (!int.TryParse(CommandArgs[2], out color)) { replyString = string.Format("{0} is not a valid color.", CommandArgs[2]); break; }
                                        if (CommandArgs.Length >= 4)
                                        {
                                            string message = CommandData.Substring((7 + color.ToString().Length) + 1).Trim();
                                            WhatsNewMessage m = new WhatsNewMessage();
                                            m.ID = 0;
                                            m.Color = color;
                                            m.Message = message;
                                            m.TimeStamp = DateTime.Now.ToString();
                                            m.Author = Player.CurrentCharacter.Name;
                                            bool create = MySqlManager.SaveWhatsNew(m);

                                            if (create)
                                            {
                                                replyString = string.Format("Creating Whats New Message {0} with color {1} by Author {2} at datetime {3}.",
                                                    message, color, Player.CurrentCharacter.Name, DateTime.Now);
                                            }
                                            else replyString = "Failed to create whats new message!";
                                            break;
                                        }
                                        else replyString = "Empty Message Supplied."; break;
                                    }
                                #endregion
                                    // Find done
                                #region Find
                                case "find":
                                    {
                                        // arg 2 is a number or author or timestamp date search portion
                                        if (CommandArgs.Length >= 3)
                                        {
                                            int recordnum = 0;
                                            if (int.TryParse(CommandArgs[2], out recordnum))
                                            {
                                                // we wanna find by the record number
                                               WhatsNewMessage found = MySqlManager.GetWhatsNew(recordnum);
                                               if (found != null)
                                                   replyString = string.Format("Found Record ID {0} by Author {1} Time Stamp {2}", found.ID, found.Author, found.Message);
                                               else replyString = string.Format("Message {0} not found.", recordnum);
                                                   
                                            }
                                            else
                                            {
                                                // could be author or timestamp portion
                                                List<WhatsNewMessage> found = MySqlManager.GetWhatsNew(CommandArgs[2]);
                                                if (found.Count == 0) replyString = "No Records found.";
                                                else replyString = "";

                                                foreach (WhatsNewMessage m in found) 
                                                    replyString += string.Format("Found Record ID {0} by Author {1} Time Stamp {2}.\n", m.ID, m.Author, m.Message);
                                               
                                            }

                                        }
                                        else replyString = finduse;
                                    }
                                    break;
                                #endregion
                                #region Clear
                                case "clear":
                                    replyString = "Not Implmented.";
                                    break;
                                #endregion
                                    // rem done
                                #region Remove
                                case "remove":
                                    // arg 2 is a number or author or timestamp date search portion
                                    if (CommandArgs.Length >= 3)
                                    {
                                        int recordnum = 0;
                                        if (int.TryParse(CommandArgs[2], out recordnum))
                                        {
                                            // we wanna find by the record number
                                            replyString = string.Format("Searching for record by id of {0}", recordnum);
                                            bool del = MySqlManager.DeleteWhatsNewRecord(recordnum);
                                            if (del) replyString = string.Format("Deleted What's New record id {0}", recordnum);
                                            else replyString = string.Format("Record {0} not found.", recordnum);

                                        }
                                        else
                                        {
                                            // could be author or timestamp portion
                                            replyString = string.Format("Invalid record {0}", CommandArgs[1]);

                                        }

                                    }
                                    else replyString = remuse;
                                    break;
                                #endregion
                                #region Update
                                case "update":
                                    {
                                        // /update (1), # (2) color (3) message (4 (5)and on)
                                        if (CommandArgs.Length < 5) { replyString = "You Must supply a record id to update and a color and a message."; break; }
                                        int record = 0;
                                        int color = 0;
                                        if (!int.TryParse(CommandArgs[2], out record)) { replyString = string.Format("{0} is not a valid record id.", CommandArgs[2]); break; }
                                        if (!int.TryParse(CommandArgs[3], out color)) { replyString = string.Format("{0} is not a valid color.", CommandArgs[3]); break; }
                                        if (CommandArgs.Length >= 5)
                                        {
                                            string message = CommandData.Substring((11 + color.ToString().Length) + (record.ToString().Length +1)).Trim();
                                            WhatsNewMessage wn = MySqlManager.GetWhatsNew(record);

                                            if (wn != null)
                                            {
                                                wn.Color = color;
                                                wn.Message = message;
                                                wn.TimeStamp = DateTime.Now.ToString();
                                                wn.Author = Player.CurrentCharacter.Name;

                                                bool update = MySqlManager.UpdateWhatsNew(wn);
                                                if (update)
                                                {
                                                    replyString = string.Format("Updated Whats New Message {0} ID: {1} with color {2} by Author {3} at datetime {4}.",
                                                        message, record, color, Player.CurrentCharacter.Name, wn.TimeStamp);
                                                }
                                                else replyString = string.Format("Unable to update whats new message id {0}", record);
                                            }
                                            else replyString = string.Format("Record {0} not found.", record);
                                            break;
                                        }
                                        else replyString = "Empty Message Supplied."; break;
                                    }
                                #endregion
                                    // help done
                                #region Help
                                case "help":
                                    {
                                        if (CommandArgs.Length >= 3)
                                        {
                                            switch (CommandArgs[2].ToLower())
                                            {
                                                case "add":
                                                    replyString = adduse;
                                                    break;
                                                case "clear":
                                                    replyString = clearuse;
                                                    break;
                                                case "find":
                                                    replyString = finduse;
                                                    break;
                                                case "remove":
                                                    replyString = remuse;
                                                    break;
                                                case "update":
                                                    replyString = upuse;
                                                    break;
                                                default:
                                                    replyString = string.Format("Unknown help topic {0}.", CommandArgs[2]);
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            replyString = string.Format("[add] [find] [remove] [update], try /wn help follwed by one of those topics.");
                                        }
                                    }
                                    break;
                                #endregion
                            }
                        }
                        else
                        {
                            replyString = "Try /wn help.";
                        }


                        replyPacket = Packet.ChatPacket(1, 1,
                                             replyString, "WhatsNew");
                        Player.Socket.Send(ref replyPacket);
                    }
                    break;
                #endregion
                case "/chat":
                    {
                        // we want a channel to try
                        //if (CommandArgs.Length >= 2)
                       // {
                         //   int channel = -1;
                         //   if (int.TryParse(CommandArgs[1], out channel))
                          //  {
                        for (int i = 0; i < 1000; i++)
                        {
                            PacketWriter w = new PacketWriter(0x26);
                            w.WriteUInt32(Player.AccountId);
                            w.WriteInt32(0);
                            string topic = string.Format("|c{0}|Info>|c103|Chat Test on:{0}", i);
                            w.WriteBytes(Encoding.ASCII.GetBytes(topic));
                            w.WriteBytes(new byte[] { 0x0A, 0x00 });
                            byte[] top = w.ToArray();
                            Player.Socket.Send(ref top);
                        }
                          //  }
                       // }
                       // else
                      //  {
                        //    byte[] reply = Packet.ChatPacket(1, 1,
                          //    string.Format("Unable to parse {0} into a channel number.", CommandArgs[1]), "Chat Test");
                          //  Player.Socket.Send(ref reply);
                        //}
                    }
                    break;
                case "/createroom":
                    {
                        // we want a graphic id
                        if (CommandArgs.Length < 2)
                        {
                            byte[] reply = Packet.ChatPacket(1, 1,
                              "You must supply a roomid id to create.", "CreateRoom");
                            Player.Socket.Send(ref reply);
                        }
                        else
                        {
                            uint roomNum = 0;
                            if (uint.TryParse(CommandArgs[1], out roomNum))
                            {
                                bool roomTaken = false;
                                for (int i = 0; i < ScriptResolver.ImportedRooms.Count; i++)
                                {
                                    if (ScriptResolver.ImportedRooms[i].RoomID == roomNum) roomTaken = true;
                                }

                                if (roomTaken)
                                {
                                    byte[] reply = Packet.ChatPacket(1, 1,
                              string.Format("Room {0} is in use.", roomNum), "CreateRoom");
                                    Player.Socket.Send(ref reply);
                                }
                                else
                                {
                                    RoomProxy prop = new RoomProxy(roomNum, "New Room");
                                    ScriptResolver.ImportedRooms.Add(prop);
                                    byte[] reply = Packet.ChatPacket(1, 1,
                                    string.Format("Room {0} has been created and should now be availible.", roomNum), 
                                    "CreateRoom");
                                    Player.Socket.Send(ref reply);
                                }
                            }
                        }
                    }
                    break;
                case "/newnpc":
                    {
                        // we want a graphic id
                        if (CommandArgs.Length < 2)
                        {
                            byte[] reply = Packet.ChatPacket(1, 1,
                              "You must supply a graphic id to summon.", "Mob");
                            Player.Socket.Send(ref reply);
                        }
                        else
                        {
                            short mobid = 0;
                            if (short.TryParse(CommandArgs[1], out mobid))
                            {
                                MobileType type = MobileType.None;
                                string name = BaseMobile.MobNameFromID(mobid, out type);

                                uint mid = ServerGlobals.GetNextAvailableID();
                                Player.CurrentCharacter.IDsInUse.Add(mid);
                                PacketWriter add = new PacketWriter(0x2A);
                                add.WriteUInt32(Player.AccountId);
                                add.WriteUInt32(0);
                                add.WriteInt32(-1);
                                add.WriteUInt32(Player.CurrentCharacter.Location.CurrentRoom.RoomID);

                                add.WriteByte(0x40);

                                NPC m = new NPC();
                                m.GraphicID = (ushort)mobid;
                                m.GameID = mid;
                                m.Girth = 100;
                                m.Height = 100;
                                m.CurrentHitPoints = 12560;
                                m.MaxHitPoints = 13000;
                                m.Location = new RoomLocation(Player.CurrentCharacter.Location.CurrentRoom.RoomID,
                                    Player.CurrentCharacter.Location.X, Player.CurrentCharacter.Location.Y, Player.CurrentCharacter.Location.Facing);
                                m.BuildHead(1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                               

                                byte[] mob = Packet.WrappedMob(m);
                                add.WriteBytes(mob);
                                byte[] try1 = add.ToArray();
                                Player.CurrentCharacter.Location.CurrentRoom.SendMovePacket(try1);

                                // add mob to room
                                Player.CurrentCharacter.Location.CurrentRoom.AddEntity(m, Player);
                                byte[] reply = Packet.ChatPacket(1, 1,
                                string.Format("Created NPC {0} with a GameID of:({1}).",name, mid), "TNewNPC");
                                Player.Socket.Send(ref reply);
                            }
                            else
                            {
                                byte[] reply = Packet.ChatPacket(1, 1,
                                string.Format("Unable to parse Graphic ID {0}.", CommandArgs[1]), "Mob");
                                Player.Socket.Send(ref reply);
                            }
                        }
                    }
                    break;
                case "/mob":
                    {
                        // we want a graphic id
                        if (CommandArgs.Length < 2)
                        {
                            byte[] reply = Packet.ChatPacket(1, 1, 
                              "You must supply a graphic id to summon.", "Mob");
                            Player.Socket.Send(ref reply);
                        }
                        else
                        {
                            short mobid = 0;
                            if(short.TryParse(CommandArgs[1], out mobid))
                            {
                                MobileType type = MobileType.None;
                                string name = BaseMobile.MobNameFromID(mobid, out type);
                                if (type == MobileType.None
                                    || name == "ERROR_NO_DATA")
                                {
                                    byte[] breply = Packet.ChatPacket(1, 1,
                                    string.Format("No known monster id:{0}.", mobid), "TMob");
                                    Player.Socket.Send(ref breply);
                                    return;
                                }
                                uint mid = ServerGlobals.GetNextAvailableID();
                                Player.CurrentCharacter.IDsInUse.Add(mid);
                                PacketWriter add = new PacketWriter(0x2A);
                                add.WriteUInt32(Player.AccountId);
                                add.WriteUInt32(0);
                                add.WriteInt32(-1);
                                add.WriteUInt32(Player.CurrentCharacter.Location.CurrentRoom.RoomID);
                                
                                add.WriteByte(0x40);
                                
                                Mob m = new Mob();
                                m.GraphicID = (ushort)mobid;
                                m.GameID = mid;
                                m.Girth = 100;
                                m.Height = 100;
                                m.CurrentHitPoints = 12560;
                                m.MaxHitPoints = 13000;
                                m.Location = new RoomLocation(Player.CurrentCharacter.Location.CurrentRoom.RoomID,
                                    Player.CurrentCharacter.Location.X, Player.CurrentCharacter.Location.Y, Player.CurrentCharacter.Location.Facing);
                                m.MobBrain = new Brain(m);

                                byte[] mob = Packet.WrappedMob(m);
                                add.WriteBytes(mob);
                                byte[] try1 = add.ToArray();
                                Player.CurrentCharacter.Location.CurrentRoom.SendMovePacket(try1);

                              // add mob to room
                                Player.CurrentCharacter.Location.CurrentRoom.AddEntity(m, Player);
                                byte[] reply = Packet.ChatPacket(1, 1,
                                string.Format("Created {0} Monster {1} with a GameID of:({2}).",
                                type, name, mid), "TMob");
                                Player.Socket.Send(ref reply);
                            }
                            else
                            {
                                byte[] reply = Packet.ChatPacket(1, 1,
                                string.Format("Unable to parse Graphic ID {0}.", CommandArgs[1]), "Mob");
                                Player.Socket.Send(ref reply);
                            }
                        }
                    }
                    break;
                case "/members":
                    {
                        byte[] reply = Packet.ChatPacket(1, 1, string.Format("{0} Players in Room {1}", 
                            Player.CurrentCharacter.Location.CurrentRoom.PlayerCount,
                            Player.CurrentCharacter.Location.CurrentRoom.RoomID), "Members");
                        Player.Socket.Send(ref reply);
                    }
                    break;
                #region /tell
                case "/tell":
                case "/t":
                    {
                        // who do we want ?
                        string to = string.Empty;
                        byte[] msg = RealmPacketIO.ParseChatMessage(this.FullMessagepacket, out to);
                        string from = Player.CurrentCharacter.Name;
                        
                        Account toPlayer = null;
                        foreach (Account a in ServerGlobals.LoggedInAccounts)
                        {
                            if (to.ToLower() == a.CurrentCharacter.Name.ToLower() &&
                                a.CurrentCharacter != Player.CurrentCharacter)
                            {
                                toPlayer = a; break;
                            }
                        }
                        if (toPlayer != null)
                        {
                            PacketWriter tell = new PacketWriter(0x26);
                            // what acct we sending it too ?
                            tell.WriteUInt32(Player.AccountId);
                            tell.WriteUInt32(0x00);
                            string chat = string.Format("-tr{0}  ", toPlayer.CurrentCharacter.Name); // 2 spaces this puts to as the name
                            tell.WriteBytes(Encoding.ASCII.GetBytes(chat));
                            tell.WriteBytes(msg);
                            tell.WriteShort(0x0A);
                            byte[] reply = tell.ToArray();
                            // now send to that acct
                            Player.Socket.Send(ref reply);
                            

                        
                            PacketWriter tellto = new PacketWriter(0x26);
                            // what acct we sending it too ?
                            tellto.WriteUInt32(toPlayer.AccountId);
                            tellto.WriteUInt32(0x00);
                            string chatto = string.Format("-tp{0}  ", Player.CurrentCharacter.Name);
                            tellto.WriteString(chatto, false);
                            tellto.WriteBytes(msg);
                            tellto.WriteShort(0x0A);
                            byte[] replyto = tellto.ToArray();
                         
                            // now send to that acct
                           toPlayer.Socket.Send(ref replyto);
                           // break;
                        }
                    }
                    break;
                #endregion
                #region /spells
                case "/spells":
                    {
                        List<string> allSpells = MySqlManager.GetSpellNames();

                        foreach (string spell in allSpells)
                        {
                            try
                            {
                                if (spell != "CharID")
                                {
                                    bool give = MySqlManager.GiveSpell(Player.CurrentCharacter.SqlCharId, spell);
                                   // Console.WriteLine("Spell {0} Given {1}.", spell, give);
                                }
                            }
                            catch (Exception ex) { Console.WriteLine("{0} : {1}", ex.Message, ex.StackTrace); }
                        }
                        byte[] reply = Packet.ChatPacket(1, 1,"All Spells Granted!", "Spells");
                        Player.Socket.Send(ref reply);
                    }
                    break;
                #endregion
                #region /loc
                case "/loc":
                    {
                        string s = string.Empty;
                        if (Player.CurrentCharacter.Location != null)
                        {
                            s = string.Format("Current Location of Player {0} is X:{1} Y:{2} Facing {3} in room {4}",
                                Player.CurrentCharacter.Name, Player.CurrentCharacter.Location.X, Player.CurrentCharacter.Location.Y,
                                Player.CurrentCharacter.Location.Facing, Player.CurrentCharacter.Location.RoomNumber);
                            Console.WriteLine("Value for Room is {0}", Player.CurrentCharacter.Location.RoomNumber);
                        }
                        else s = "No Location in memory.";
                        byte[] reply = Packet.ChatPacket(1, 1, s, "Loc");
                        Player.Socket.Send(ref reply);
                    }
                    break;
                #endregion
                #region /join
                case "/join":
                    {
                        if (CommandArgs.Length == 2)
                        {
                            // What channel ?
                            int channel = -1;
                            if(int.TryParse(CommandArgs[1], out channel))
                            {
                                // try to find the channel
                                Channel c = null;
                                foreach (Channel chan in ScriptResolver.ImportedChannels)
                                {
                                    if (chan.ChannelNumber == CommandArgs[1])
                                        c = chan;
                                    
                                }
                                if (c != null)
                                {
                                    // If player is already in a channel, make sure to leave it

                                    Player.CurrentChannel.SendJoinPacket(Player);
                                    
                                }
                                else
                                {
                                    byte[] reply = Packet.ChatPacket(1, 1,
                                        string.Format("Failed to locate channel #{0}.", CommandArgs[1]), "Join");
                                    Player.Socket.Send(ref reply);
                                }
                            }
                        }
                    }
                    break;
                #endregion
                case "/list":
                    {
                        byte[] reply = Packet.ListChannels(Player);
                        Player.Socket.Send(ref reply);
                    }
                    break;
                #region /unbusy
                case "/unbusy":
                    {
                        PacketWriter w = new PacketWriter(0x26);
                        w.WriteUInt32(Player.AccountId);
                        w.WriteUInt32(0);
                        w.WriteString("|c43|Info> You are already not busy.", false);
                        w.WriteByte(0x00);
                        w.WriteByte(0xC3);
                        w.WriteByte(0xF1);
                        byte[] busy = w.ToArray();
                        Player.Socket.Send(ref busy);
                    }
                    break;
                #endregion
                case "/say":
                    {
                        //string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "say.txt");
                        //byte[] fake0 = RealmOffline.Packets.RealmPacketIO.GetByteArrayFromFile(fileLocation);
                       // 
                        if (CommandArgs.Length == 2)
                        {
                            // its a color
                            int color = -1;
                            if(int.TryParse(CommandArgs[1], out color))
                            {
                                byte[] say = ChanTest(color);
                                Player.Socket.Send(ref say);
                            }
                        }
                        else
                        {
                            int tries = 50;
                            for (int i = 0; i < tries; i++)
                            {
                                byte[] chan = ChanTest(107);
                                 Thread.Sleep(100);
                                Player.Socket.Send(ref chan);
                            }
                        }
                    }
                    break;
                case "/online":
                    {
                        int currentPlayers = ServerGlobals.LoggedInAccounts.Count;
                        byte[] reply = Packet.ChatPacket(32, 56,
                            string.Format("Currently {0} players are in the world.", currentPlayers),
                            "Info");
                        Player.Socket.Send(ref reply);
                    }
                    break;
                case "/g":
                    {
                        Console.WriteLine("We got a gossip request");
                        if (Player.CurrentChannel != null)
                        {
                            byte[] fixedMessagePacket = CleanGossipText(this.FullMessagepacket);
                            
                            Console.WriteLine("Tried to send message to channel {0}", Player.CurrentChannel.ChannelNumber);
                            Player.CurrentChannel.SendMessage(Player, fixedMessagePacket);
                        }
                    }
                    break;
                case "/msg":
                    {
                        string msg = CommandData.Substring(5);
                        if (msg != string.Empty)
                        {
                            // 41 in length is as long as the msg can be
                            byte[] m = Packet.ServerMessageBottom(Player, msg);
                            Player.Socket.Send(ref m);
                        }
                    }
                    break;
                case "/i":
                        {
                            Console.WriteLine("Slash I Requested.");
                            byte[] t = Packet.NPCDialog(Player);
                            Player.Socket.Send(ref t);

                        }
                    break;
                case "/rem":
                    {
                        byte[] reply = new byte[0];

                        if (CommandArgs.Length != 2)
                        {
                            reply = Packet.ChatPacket(1, 1, "You must enter a id to remove.", "Remove");
                        }
                        else
                        {
                            uint obj = 0;
                            if (uint.TryParse(CommandArgs[1], out obj))
                            {
                                int room = (int)Player.CurrentCharacter.Location.CurrentRoom.RoomID;
                                PacketWriter w = new PacketWriter(0x2D);
                                w.WriteUInt32(Player.AccountId);
                                w.WriteInt32(0);
                                w.WriteInt32(room); // Room to remove from

                                w.WriteUInt32(obj); // obj to remove

                                w.WriteBytes(new byte[] { 0x00, 0x15, 0x00, 0x69 });
                                byte[] rem = w.ToArray();
                                Entity e = Player.CurrentCharacter.Location.CurrentRoom.GetEntityInRoom(obj);
                                Player.CurrentCharacter.Location.CurrentRoom.SendPacket(rem);//.Socket.Send(ref rem);
                                Player.CurrentCharacter.Location.CurrentRoom.RemoveEntity(e, Player);
                                reply = Packet.ChatPacket(1, 1, "Command Complete.", "Remove");
                            }
                            else { reply = Packet.ChatPacket(1, 1, "Unable to parse that id.", "Remove"); } // error
                            Player.Socket.Send(ref reply);
                        }
                    }
                    break;
                case "/troom":
                    {
                        // my testroom
                        string fileLocation = Path.Combine(
                            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "roomtest.txt");
                        PacketWriter w = new PacketWriter();
                        w.WriteUInt32(Player.AccountId);
                        w.WriteInt32(0);
                        byte[] testPacket = RealmPacketIO.GetByteArrayFromFile(fileLocation);
                        w.WriteBytes(testPacket);
                        byte[] reply = w.ToArray();
                        Player.Socket.Send(ref reply);
                    }
                    break;
                    case "/npcface":
                    {
                        if (this.CommandArgs.Length == 3)
                        {
                            string sid = this.CommandArgs[1].ToString();
                            string face = this.CommandArgs[2].ToString();

                            int id = 0;

                            if (int.TryParse(sid, out id))
                            {
                                string answer = string.Format("Facing NPC {0} {1}.", id, face);

                                byte[] reply = Packet.ChatPacket(1, 1, answer, "NPCMove");
                                Player.Socket.Send(ref reply);


                               

                                
                                if (face.ToLower() == "n" || face.ToLower() == "s" || face.ToLower() == "w" || face.ToLower() == "e")
                                {
                                    Entity n = Player.CurrentCharacter.Location.CurrentRoom.GetNpcInRoom((uint)id);

                                    byte[] f = RealmPacketIO.FaceEntity(n, face);
                                    Player.CurrentCharacter.Location.CurrentRoom.SendMovePacket(f);
                                    /*
                                    if (n is NPC)
                                    {
                                        NPC npc = n as NPC;
                                        byte[] move = RealmPacketIO.FaceEntity(Player, n, Player.CurrentCharacter.Location.CurrentRoom,
                                            npc.Location.X, npc.Location.Y, face);
                                        Player.CurrentCharacter.Location.CurrentRoom.SendMovePacket(move);
                                    }
                                    if (n is Mob)
                                    {
                                        Mob mob = n as Mob;
                                        byte[] move = RealmPacketIO.FaceEntity(Player, n, Player.CurrentCharacter.Location.CurrentRoom,
                                            mob.Location.X, mob.Location.Y, face);
                                        Player.CurrentCharacter.Location.CurrentRoom.SendMovePacket(move);
                                    }
                                    */
                                }
                                
                            }
                        }
                    }
                    break;
                    case "/move":
                    {
                        // want npc id and x y
                        if (this.CommandArgs.Length == 4)
                        {
                            string sid = this.CommandArgs[1].ToString();
                            string sx = this.CommandArgs[2].ToString();
                            string sy = this.CommandArgs[3].ToString();

                            int id = 0;
                            int xx = 0;
                            int yy = 0;

                            if (int.TryParse(sid, out id) && int.TryParse(sx, out xx) && int.TryParse(sy, out yy))
                            {
                                string answer = string.Format("Wanting to move npc {0} to X:{1} Y:{2}.", sid, xx, yy);

                                byte[] reply = Packet.ChatPacket(1, 1, answer, "NPCMove");
                                Player.Socket.Send(ref reply);
                                Entity n = Player.CurrentCharacter.Location.CurrentRoom.GetNpcInRoom((uint)id);

                               // if (n is NPC)
                              //  {
                                    byte[] move = RealmPacketIO.MoveEntityTo(Player, n, Player.CurrentCharacter.Location.CurrentRoom, (short)xx, (short)yy);

                                    Player.CurrentCharacter.Location.CurrentRoom.SendMovePacket(move);
                               // }
                                //Player.Socket.Send(ref move);
                            }


                        }
                    }
                    break;
                case "/sp":
                    {
                        // argue one has to be a filename
                        if (this.CommandArgs.Length == 2)
                        {
                            string file = this.CommandArgs[1].ToString();
                            if (!file.EndsWith(".txt")) { file = file + ".txt"; }
                            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), file);
                            byte[] testPacket = RealmPacketIO.GetByteArrayFromFile(fileLocation);
                            if (testPacket.Length > 0)
                            {
                                // Try to send it
                                Player.Socket.Send(ref testPacket);
                                byte[] reply = Packet.ChatPacket(1, 1, string.Format("Sent {0} bytes", testPacket.Length), "Test");
                                Player.Socket.Send(ref reply);
                            }
                            else
                            {
                                byte[] reply = Packet.ChatPacket(1, 1, "Unable to convert to byte array", "Test");
                                Player.Socket.Send(ref reply);
                            }
                        }
                        else
                        {
                            byte[] reply = Packet.ChatPacket(1, 1, "You need to supply a filename, we assume its *.txt", "SendPacket");
                            Player.Socket.Send(ref reply);
                        }
                    }
                    break;
                case "/myid":
                    {
                        byte[] reply = Packet.ChatPacket(1, 1, string.Format("Account ID({0}) CharID({1}) InventoryID({2}).", 
                            Player.AccountId, Player.CurrentCharacter.GameID, Player.CurrentCharacter.InventoryId), "ID");
                        Player.Socket.Send(ref reply);

                    }
                    break;
                case "/id":
                    {
                        if(this.CommandArgs.Length == 2)
                        {
                            ushort newId = 0;
                            if (ushort.TryParse(this.CommandArgs[1], out newId))
                            {
                                Player.CurrentCharacter.GameID = newId;
                                byte[] reply = Packet.ChatPacket(1, 1, string.Format("Your new id is {0}", Player.CurrentCharacter.GameID), "IDChange");
                                Player.Socket.Send(ref reply);
                            }
                        }
                    }
                    break;
                #region /item
                case "/item":
                    {
                        // Check for this command we need 3 arguments for now
                        // [0] = /item 
                        // [1] = ushort acctotgiveto<- no
                        // [2] = a ushort the inventory slot to try to give it too <- no
                        // [3] = The item
                        // [4] == optional color
                        byte[] failReply = Packet.ChatPacket(1, 1, "Command Usage: /item (uint)ID (ushort)color (string)name (name is optional.", "Item");
                        Console.WriteLine("Args Length {0}", this.CommandArgs.Length);

                        ushort id = 0;
                        ushort color = 0;
                        string name = string.Empty;

                        byte[] pack = null;

                        if (this.CommandArgs.Length < 2)
                        {
                            // Tell client he fubared
                            Player.Socket.Send(ref failReply);
                        }
                        else
                        {
                            if (ushort.TryParse(this.CommandArgs[1], out id))
                            {
                                if (this.CommandArgs.Length >= 3)
                                {
                                    bool c = ushort.TryParse(this.CommandArgs[2], out color);
                                }

                                ItemType type = BaseItem.GetItemType(id);
                                if (type != ItemType.None)
                                {
                                    // Switch here to format
                                    pack = Packet.ChatPacket(1, 1, string.Format("You asked for itemtype {0}.", type), "Item");
                                    uint itemid = 0;
                                    switch (type)
                                    {
                                        case ItemType.Container:
                                            {
                                                Container c = new Container();
                                                c.GraphicID = id;
                                                c.Color = color;
                                                c.Equipped = false;
                                                c.Serialize(out itemid);
                                                
                                                PacketWriter w42A = new PacketWriter(0x2A);
                                                w42A.WriteUInt32(Player.AccountId);
                                                w42A.WriteUInt32(0x00);
                                                // Works, gives a wrapped item
                                                w42A.WriteUInt32(Player.CurrentCharacter.GameID);
                                                w42A.WriteUInt32(Player.CurrentCharacter.Location.CurrentRoom.RoomID);
                                                w42A.WriteByte(0x3F);
                                                w42A.WriteBytes(Packet.WrappedItem(Player, c));
                                                byte[] p42A = w42A.ToArray();
                                                Player.Socket.Send(ref p42A);
                                                Player.CurrentCharacter.AddInventoryItem(c);
                                            }
                                            break;
                                    }
                                }
                                else pack = Packet.ChatPacket(1, 1, string.Format("Invalid item {0}.", id), "Item");
                            }
                            else pack = Packet.ChatPacket(1, 1, string.Format("Unable to create item {0}.", this.CommandArgs[1]), "Item");

                         /*   
                            bool p = ushort.TryParse(this.CommandArgs[1], out id);
                            if (CommandArgs.Length == 3)
                                ushort.TryParse(this.CommandArgs[2], out color);
                            //if (color == 0) color = 0x63;
                            if (CommandArgs.Length >= 4) name = string.Join(" ", CommandArgs.Skip(3));


                            if (p)
                            {
                                if (id > 153)
                                {
                                    Item i = new Item();
                                    i.CurrentGameID = ServerGlobals.GetNextAvailableID();
                                    i.GraphicID = id;
                                    i.Color = color;
                                    if (!string.IsNullOrEmpty(name)) i.Name = name;
                                    Console.WriteLine("We want Name: {0}", name);
                                    // set next inventory slot
                                    //Item[] all = Managers.MySqlManager.LoadItems(Player.CurrentCharacter.SqlCharId);
                                   // Console.WriteLine("{0} Item for Char {1}", all.Length, Player.CurrentCharacter.SqlCharId);
        
                                    Console.WriteLine("Giving item {0}", i.CurrentGameID);
                                    pack = RealmPacketIO.GiveInventoryItem(Player, i);
                                    byte[] g =Packet.ChatPacket(1, 1, string.Format("Command Complete ID = {0}.", i.CurrentGameID), "Item");
                                    Player.Socket.Send(ref g);
                                    Console.WriteLine("Made it past give");
                                    Player.CurrentCharacter.AddInventoryItem(i);
                                }
                                else pack = Packet.ChatPacket(1, 1, "Items begin at 154 (Mana) please choose a itemid higher than 154.", "Item");
                          
                            }
                            else
                            {
                                pack = Packet.ChatPacket(1, 1, "Unable to create item.", "Item");
                            }
                          */
                            Player.Socket.Send(ref pack);
                        }
                    }
                    break;
                #endregion
                case "/connections":
                    {
                        StringBuilder b = new StringBuilder();
                        b.AppendLine("Used to test connections to server:");
                        b.AppendLine("/connections list [Lists all active connections by index.]");
                        b.AppendLine("/connections remove 1 [Would forceably remove and disconnect the client in slot 1.]");
                        b.AppendLine("/connections validate 1 [Would run tests designed to make sure the client is still connected, and would display the output the tests found.]");
                        /*
                         * [0] /connections
                         * [1]- what to do, list, or remove, validate
                         * [2] it lists by index, so if this command is here its the index to check
                         */
                        Console.WriteLine("Total of {0} args", this.CommandArgs.Length);
                        // do we have a arg after /connections ?
                        if (this.CommandArgs.Length > 1)
                        {
                            // We have another command to parse
                            switch (this.CommandArgs[1].ToLower())
                            {
                                case "list":
                                    {
                                        b.Clear();
                                        b.AppendLine("");
                                        for (int i = 0; i < ServerGlobals.LoggedInAccounts.Count; i++)
                                        {
                                            b.AppendLine(string.Format("Index [{0}] contains Client {1} from account username {2}",
                                                i, ServerGlobals.LoggedInAccounts[i].Socket.TcpSocket.RemoteEndPoint, ServerGlobals.LoggedInAccounts[i].Username));
                                        }
                                        byte[] reply1 = Packet.ChatPacket(1, 1, b.ToString(), "Connections");
                                        Player.Socket.Send(ref reply1);
                                    }
                                    break;
                                case "remove":
                                    {
                                        // This is a bad command
                                        // we need a index
                                        if (this.CommandArgs.Length >= 3)
                                        {
                                            int index = -1;
                                            if(int.TryParse(this.CommandArgs[2], out index))
                                            {
                                                ServerGlobals.ClearAccount(ServerGlobals.LoggedInAccounts[index], true);
                                                byte[] reply1 = Packet.ChatPacket(1, 1, "Account Removed!", "Connections");
                                                Player.Socket.Send(ref reply1);
                                            }
                                        }
                                        else
                                        {
                                            byte[] reply1 = Packet.ChatPacket(1, 1, "You need to supply a index to use for remove.", "Connections");
                                            Player.Socket.Send(ref reply1);
                                        }
                                    }
                                    break;
                                case "validate":
                                    {
                                        if (this.CommandArgs.Length >= 3)
                                        {
                                            int index = -1;
                                            if (int.TryParse(this.CommandArgs[2], out index))
                                            {
                                                byte[] val = Packet.ChatPacket(1, 1, "You have been validated!", "Validate");

                                                if (ServerGlobals.TrySend(ServerGlobals.LoggedInAccounts[index], val))
                                                {
                                                    byte[] pass = Packet.ChatPacket(18, 1, "Validation Passed!", "Validate");
                                                    Player.Socket.Send(ref pass);
                                                }
                                                else
                                                {
                                                    byte[] fail = Packet.ChatPacket(1, 1, "Validation failed!", "Validate");
                                                    Player.Socket.Send(ref fail);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            byte[] reply1 = Packet.ChatPacket(1, 1, "You need to supply a index to use for remove.", "Connections");
                                            Player.Socket.Send(ref reply1);
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
                                byte[] commandStructure = Packet.ChatPacket(1, 1, b.ToString(), "Connections");
                                Player.Socket.Send(ref commandStructure);
                            
                        }
                    }
                    break;
                case "/room":
                    {
                        byte[] roomReply = Packet.ChatPacket(1, 1, 
                            string.Format("You are in room {0}", Player.CurrentCharacter.Location.CurrentRoom.RoomID), "Room");
                        Player.Socket.Send(ref roomReply);
                    }
                    break;
                case "/tp":
                    {
                        string errorMessage = "No Errors.";
                        byte[] errorReply = null;
                        // we want a room number
                        if (this.CommandArgs.Length != 2)
                        {
                            errorMessage = "Current commands {/tp list}- Lists all rooms, {/tp 4606}- teleports you to room 4606, if it exists.";
                            errorReply = Packet.ChatPacket(1, 1, errorMessage, "Teleport");
                            Player.Socket.Send(ref errorReply);
                        }
                        else
                        {
                            if (this.CommandArgs[1].ToLower() == "list")
                            {
                                // try to build this crazy packet
                                StringBuilder l = new StringBuilder();
                                l.AppendLine("Current Rooms. ");
                                for (int i = 0; i < ScriptResolver.ImportedRooms.Count; i++)
                                {
                                    if (i == ScriptResolver.ImportedRooms.Count - 1)
                                        l.Append(string.Format("{0}.", ScriptResolver.ImportedRooms[i].RoomID));
                                    else
                                        l.Append(string.Format("{0}-", ScriptResolver.ImportedRooms[i].RoomID));
                                }
                                byte[] roomList = Packet.ChatPacket(1, 1, l.ToString(), "RoomList");
                                Player.Socket.Send(ref roomList);
                            }
                            else // if second arg is not list, then we only accept a room number
                            {
                                uint roomNum = 0;
                                if (uint.TryParse(this.CommandArgs[1], out roomNum))
                                {
                                    Room r = null;
                                    // do we have the room ?
                                    foreach (Room room in ScriptResolver.ImportedRooms)
                                    {
                                        if (room.RoomID == roomNum)
                                            r = room;
                                    }
                                    if (r == null)
                                    {
                                        errorReply = Packet.ChatPacket(1, 1, "Invalid room number requested.", "Teleport");
                                        Player.Socket.Send(ref errorReply);
                                    }
                                    else if (roomNum == Player.CurrentCharacter.Location.CurrentRoom.RoomID)
                                    {
                                        errorReply = Packet.ChatPacket(1, 1, "You are already in that room..", "Teleport");
                                        Player.Socket.Send(ref errorReply);
                                    }
                                    else
                                    {
                                        // Lets send a teleport request
                                        Room troom = ScriptResolver.GetRoom(roomNum);
                                        byte[] goodReply = Packet.TeleportRequest(Player, troom);
                                        Player.Socket.Send(ref goodReply);
                                    }
                                }
                                else
                                {
                                    errorReply = Packet.ChatPacket(1, 1, "Invalid room number requested.", "Teleport");
                                    Player.Socket.Send(ref errorReply);
                                }
                            }
                        }
                    }
                    break;
            }
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
        private byte[] CleanGossipText(byte[] cmdText)
        {
            while (cmdText[cmdText.Length - 1] == 0)
            {
                byte[] newArray = new byte[cmdText.Length - 1];
                Array.Copy(cmdText, 0, newArray, 0, newArray.Length);
                cmdText = newArray;
            }
            // Now take off /g
            byte[] reply = new byte[cmdText.Length - 2];
            Array.Copy(cmdText, 2, reply, 0, reply.Length);
            return reply;
        }
      
        public byte[] ChanTest(int color)
        {
            List<byte> test = new List<byte>();
            // No len and no crc add both
            byte[] begin ={
0x26, 0x00, 0x00, 0x00, 
0x91, 0x63, 
0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 

0x7C, 0x63, 

0x35, 0x36, 0x7C, 0x4E, 0x65, 0x77, 0x62, 0x69, 0x65, 0x73, 0x3E, 0x7C, 0x63};
            test.AddRange(begin);
            byte[] tcolor = Encoding.ASCII.GetBytes(color.ToString());
            test.AddRange(tcolor);
//0x31, 0x30, 0x30, 
            string info = string.Format("{0}: Welcome to My Emu Bitches !! (In Color [{1}])", 
                Player.CurrentCharacter.Name, color);
            byte[] binfo = Encoding.ASCII.GetBytes(info);
            byte rem = 0x7C;
            test.Add(rem);
            test.AddRange(binfo);
byte[] end = {0x0A, 0x00, 0x14, 0x75, 0x03};
test.AddRange(end);
            byte[] payload = test.ToArray();
            test.Clear();
            test.AddRange(BitConverter.GetBytes(payload.Length));
            test.AddRange(payload);
            test.AddRange(new byte[] { 0x00, 0x00, 0x00, 0x00 });
            return test.ToArray();
        }
    }
}
