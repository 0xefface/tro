using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Packets;
using RealmOffline.Accounts;
using RealmOffline.Base;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using RealmOffline.Core.Items;
using RealmOffline.Core.Items.Base;
using RealmOffline.Core.Mobiles;

namespace RealmOffline.Core.Rooms
{
    // Serialize me
    [Serializable()]
    public abstract class Room: IRoom, ISerializable, IDisposable
    {
        public Room()
        {
        }
        public Room(SerializationInfo info, StreamingContext ctxt)
        {
            //EmpId = (int)info.GetValue("EmployeeId", typeof(int));
            //EmpName = (String)info.GetValue("EmployeeName", typeof(string));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
         //   info.AddValue("EmployeeId", EmpId);
           // info.AddValue("EmployeeName", EmpName);
        }
        #region HardCoded Backgrounds
        public enum RoomBackground : ushort
        {
            GrassyBlueSky = 3000,
            PatchyGrassyBlueSky0 = 3001,
            PatchyGrassyBlueSky1 = 3009,
            DesertBrightBlueSky = 3030,
            BeachLeft = 3031,
            BeachTop = 3032,
            GloomyDesert = 3033,
            GloomyBeachLeft = 3034,
            GloomyBeachTop = 3035,
            BrightSnowyGrass = 3050,
            BrightSnowyPatchyGrass = 3051,
            SnowyDesert = 3052,
            DarkCave = 3071,
            LongGrassySunnyDay = 3201,
            PavedRoom0 = 3300,
            DesertBreezeRight = 3404,
            DesertBreezeLeft = 3405,
            EvilDesertBreezeLeft = 3406,
            EvilDesertBreezeRight = 3407,
            EvilDesertStill0 = 3408,
            EvilDesertStill1 = 3409,
            PlainDirt = 3500,
            EvilPlainDirt = 3501,
            PavedRoom1 = 4000,
            InnerTent = 4001,
            Swamp = 6500
        }
        #endregion
        #region Blocked Exits
        public enum BlockedExits : byte
        {
            All = 0x00,
            DownLeftRight = 0x01,
            UpLeftRight = 0x02,
            LeftRight = 0x03,
            UpDownLeft = 0x04,
            DownLeft = 0x05,
            UpLeft = 0x06,
            Left = 0x07,
            UpDownRight = 0x08,
            DownRight = 0x09,
            UpRight = 0x0A,
            Right = 0x0B,
            UpDown = 0x0C,
            Down = 0x0D,
            Up = 0x0E,
            None = 0x0F
        }
        #endregion
        #region RoomExits
        public enum RoomExit : byte
        {
            None = 0x00,
            North = 0x01,
            South = 0x02,
            East = 0x04,
            West = 0x08
        }
        #endregion
        #region RoomTools
        /// <summary>
        /// Returns the room background converted into a ushort
        /// </summary>
        /// <param name="background"></param>
        /// <returns></returns>
        public ushort ToUshort(RoomBackground background)
        {
            return (ushort)background;
        }
        /// <summary>
        /// Returns a roombackground converted into 2 bytes
        /// </summary>
        /// <param name="background"></param>
        /// <returns></returns>
        public byte[] ToBytes(RoomBackground background)
        {
            return BitConverter.GetBytes(ToUshort(background));
        }
        #endregion
        public List<RoomDecoration> Decorations { get; set; }
        public List<Mobile> Npcs { get; private set; }
        public List<Character> Players { get; set; }
        public List<BaseGameItem> Items { get; private set; }
        public uint RoomID { get; set; }
        public RoomBackground Background { get; set; }
        public bool IsCastingEnabled { get; set; }
        public BlockedExits BlockedRoomExits { get; set; }
        public string RoomName { get; set; }
        public bool AllowCasting { get; set; }
        public List<uint> RoomsIDsInUse { get; set; }
        public bool SaveUpdatesToMySql { get; set; }
         
        public Room(uint roomID, string roomName)
            : this(roomID, RoomBackground.GrassyBlueSky, roomName, BlockedExits.None) { }

        public Room(uint roomID, RoomBackground roomBackground, string roomName, 
            BlockedExits blockedExits, bool castingAllowed = true)
        {
            this.RoomID = roomID;
            this.Background = roomBackground;
            this.IsCastingEnabled = castingAllowed;
            this.Decorations = new List<RoomDecoration>();
            this.Npcs = new List<Mobile>();
            this.Items = new List<BaseGameItem>();
            this.Players = new List<Character>();
            this.BlockedRoomExits = blockedExits;
            this.RoomName = roomName;
            this.RoomsIDsInUse = new List<uint>();
            this.AllowCasting = castingAllowed;
            this.ApplyRoomLayout();
        }
        public virtual void ApplyRoomLayout()
        {
        }
        public void AddMobile(Mobile mobile)
        {
            if (!this.Npcs.Contains(mobile))
                this.Npcs.Add(mobile);
        }
        public void AddRoomDecoration(RoomDecoration decoration)
        {
            this.Decorations.Add(decoration);
        }
        public void AddItem(BaseGameItem item)
        {
            this.Items.Add(item);
        }
        public virtual byte[] GetRoomPacket(uint forAccountID)
        {
            PacketWriter writer = new PacketWriter(0x21);
            writer.WriteUInt32(forAccountID);
            writer.WriteInt32(0x00);
            writer.WriteByte(0x01);
            writer.WriteString(this.RoomName);
            writer.WriteBytes(new byte[] { 0x00, 0x17 }); // still dunno
            writer.WriteUInt32(this.RoomID);
            writer.WriteUShort((ushort)this.Background);
            writer.WriteByte(0);
            writer.WriteByte((byte)this.BlockedRoomExits);
            writer.WriteByte(0x00);
            int cast = this.AllowCasting ? 0 : 7;
            writer.WriteByte((byte)cast); // casting no = 7, yes = 0
            // How many decorations
            writer.WriteByte((byte)this.Decorations.Count);
            //writer.WriteUShort((ushort)this.Decorations.Count);
            foreach (RoomDecoration dec in this.Decorations)
                writer.WriteBytes(dec.Serialize());
            // How many items in room ?
            writer.WriteUShort((ushort)(this.Items.Count));
            Console.WriteLine("Loading {0} items.", this.Items.Count);
            foreach (BaseGameItem item in this.Items)
            {
                ItemType type = BaseItem.GetItemType(item.GraphicID);
                if (type == ItemType.Container)
                {
                    Container c = Container.CastFromBaseGameItem(item);
                    writer.WriteBytes(c.Serialize());
                }
                else if (item is Door)
                {
                    Door d = item as Door;
                    writer.WriteBytes(d.Serialize());
                }
                else
                {
                    Item i = Item.CastFromBaseItem(item);
                    writer.WriteBytes(i.Serialize());
                }
            }


            // Now all mobs, players, and npc's
            // Ok so we dont want to list us here or it adds a extra slot to room for npc / player but has no data afterwards
            // so if we are the only player we do not want to list us, we only want to list all other players
            ushort totalMobiles = (ushort)(this.Players.Count-1 + this.Npcs.Count); // -1 for not you
            writer.WriteUShort(totalMobiles); // everyone but you.
                                              // npcs first

            Console.WriteLine("{0} Players.", this.Players.Count-1);
            foreach (Character c in this.Players)
            {
                Account a = ServerGlobals.GetAccountFromCharacter(c);
                if (a.AccountId != forAccountID) writer.WriteBytes(c.AddToRoom()); // dont add yourself twice
            }
            Console.WriteLine("Loading {0} npcs and {1} players.", this.Npcs.Count, this.Players.Count-1);

            foreach (Mobile m in this.Npcs)
            {
                MobileType type = MobileType.None;
                string name = BaseMobile.MobNameFromID((short)m.GraphicID, out type);

                if (m is NPC)
                {
                    NPC n = m as NPC;
                    NPCFace f = n.Face;
                    if (n != null)
                    {
                        writer.WriteBytes(n.AppearInRoom());
                        if (!string.IsNullOrEmpty(n.Name)) name = n.Name;

                        Console.WriteLine("Added Npc {0} to room {1} at LocX:{2} LocY:{3} Facing:{4}.", name, this.RoomID, m.Location.X, m.Location.Y, m.Location.Facing);
                    }
                }
                if (m is Mob)
                {
                    Mob n = m as Mob;
                   // NPCFace f = n.Face;
                    if (n != null)
                    {
                        writer.WriteBytes(n.Serialize());
                        if (!string.IsNullOrEmpty(n.Name)) name = n.Name;
                        Console.WriteLine("Added Mob {0} to room {1} at LocX:{2} LocY:{3} Facing:{4}.", name, this.RoomID, m.Location.X, m.Location.Y, m.Location.Facing);
                    }
                }
            }
            writer.WriteBytes(new byte[7]);
            byte[] room = writer.ToArray();
            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "loadroom.txt");
            File.WriteAllText(fileLocation, BitConverter.ToString(room));
            return room;
        }
        /*
         * So we now need a way to set the next room number to walk to when exiting
         * from one of this rooms sides.
         * When the client walks ot one of these exit's, we want to give them
         * the next room, so we need a way to get the room number from a exit
         * 
         */
        public virtual uint GetNextRoomByExit(RoomExit exit)
        {
            return 150000004;
        }
        public RoomExit GetRoomExitByValue(byte value)
        {
            RoomExit exit = RoomExit.None;
            foreach (RoomExit re in Enum.GetValues(typeof(RoomExit)))
            {
                if ((byte)re == value) { exit = re; }
            }
            return exit;
        }
        public void AddEntity(IEntity entity, Account sender)
        {
            if (entity is Mobile)
            {
                Mobile m = entity as Mobile;
                this.Npcs.Add(m);
                this.RoomsIDsInUse.Add(m.GameID);
            }
            else if (entity is BaseGameItem)
            {
                // the room needs to hold it's id
                BaseGameItem i = entity as BaseGameItem;

                if (!this.Items.Contains(i)) this.Items.Add(i);
                sender.IDsInUse.Remove(i.GameID);
                this.RoomsIDsInUse.Add(i.GameID);
                Console.WriteLine("({0}) items in room {1}.", this.Items.Count, this.RoomID);

            }
            else if (entity is Character)
            {
                // Make sure we add them to room here, then if it is a character
                // that we add them to everyoneelse and not them, dont want 2 
                // of you on the screen
                Character c = entity as Character;
                
                for (int i = 0; i < this.Players.Count; i++)
                {
                        // If it isnt you, then send a packet to add you to room
                        Account a = ServerGlobals.GetAccountFromCharacter(this.Players[i]);
                        //if (c != a.CurrentCharacter)
                       // {
                            byte[] reply = Packet.CreateCharacterRoomPacket(a, c);
                            a.Socket.Send(ref reply);
                       // }
                    
                }
                if (!this.Players.Contains(c)) this.Players.Add(c);
            }
            else
            {
                // We do not know what to do.
                // Log
                Console.WriteLine("Unknown Entity was added to room {0}", this.RoomID);
            }
        }
        #region Remove Entity
        public void RemoveEntity(IEntity entity, Account sender)
        {
            if (entity is Mobile)
            {
                Mobile m = entity as Mobile;
                // dunno yet
                this.Npcs.Remove(m);
                this.RoomsIDsInUse.Remove(m.GameID);
            }
            else if (entity is BaseGameItem)
            {
                BaseGameItem item = entity as BaseGameItem;
                this.Items.Remove(item);
                sender.IDsInUse.Add(item.GameID);
                this.RoomsIDsInUse.Remove(item.GameID);
                sender.CurrentCharacter.AddInventoryItem(item);
                /*
                for (int i = 0; i < this.Players.Count; i++)
                {
                    Account a = ServerGlobals.GetAccountFromCharacter(this.Players[i]);
                    if (a != null)
                    {
                        PacketWriter w = new PacketWriter(0x2D);
                        w.WriteUInt32(a.AccountId);
                        w.WriteInt32(0);
                        w.WriteUInt32(this.RoomID); // Room to remove from

                        w.WriteUInt32(item.CurrentGameID); // obj to remove

                        w.WriteBytes(new byte[] { 0x00, 0x15, 0x00, 0x69 });
                        byte[] rem = w.ToArray();
                        a.Socket.Send(ref rem);
                    }
                }
                 */
                Console.WriteLine("({0}) items in room {1}.", this.Items.Count, this.RoomID);
            }
            else if (entity is Character)
            {
                Character c = entity as Character;
                this.Players.Remove(c);
                for (int i = 0; i < this.Players.Count; i++)
                {
                    Account a = ServerGlobals.GetAccountFromCharacter(this.Players[i]);
                    if (a != null && a != sender) // do not send remove packet to remove yourself
                    {
                        PacketWriter w = new PacketWriter(0x2D);
                        w.WriteUInt32(a.AccountId);
                        w.WriteInt32(0);
                        w.WriteUInt32(this.RoomID); // Room to remove from

                        w.WriteUInt32(c.GameID); // obj to remove

                        w.WriteBytes(new byte[] { 0x00, 0x15, 0x00, 0x69 });
                        byte[] rem = w.ToArray();
                        a.Socket.Send(ref rem);
                    }
                }
            }
            else
            {
                // We do not know what to do.
                // Log
                Console.WriteLine("Attempted to remove Unknown Entity from room {0}", this.RoomID);
            }
        }
        #endregion
        public void MoveEntity(IEntity entity, Account sender, byte[] movePacket = null)
        {
            if (entity is Mobile)
            {
                Mobile m = entity as Mobile;
                // make the mobile create its own move packet
            }
            else if (entity is Item)
            {
                // Items dont walk
            }
            else if (entity is Character)
            {

                // Make sure we add them to room here, then if it is a character
                // that we add them to everyoneelse and not them, dont want 2 
                // of you on the screen
                Character c = entity as Character;

                for (int i = 0; i < this.Players.Count; i++)
                {
                    if (this.Players[i] != c)
                    {
                        Account a = ServerGlobals.GetAccountFromCharacter(this.Players[i]);
                        // Send it
                        PacketWriter w = new PacketWriter(0x2A);
                        w.WriteUInt32(a.AccountId);
                        w.WriteUInt32(0);
                        w.WriteUInt32(c.GameID);
                        w.WriteUInt32(this.RoomID);
                        w.WriteBytes(movePacket);
                        byte[] reply = w.ToArray();
                       // Console.WriteLine("Sent {0} to {1}", 
                        //    BitConverter.ToString(movePacket), a.CurrentCharacter.Name);
                        a.Socket.Send(ref reply);
                    }
                }
            }
            else
            {
                // We do not know what to do.
                // Log
                Console.WriteLine("Attempted to force Unknown Entity to move in room {0}", this.RoomID);
            }
        }
        public int PlayerCount
        {
            get { return this.Players.Count; }
        }
        public Character GetCharacterInRoom(uint gameID)
        {
            Character c = null;
            for (int i = 0; i < this.Players.Count; i++)
            {
                if (this.Players[i].GameID == gameID)
                {
                    c = this.Players[i];
                    break;
                }
            }
            return c;
        }
        public Entity GetNpcInRoom(uint id)
        {
            Entity found = null;
            foreach (Entity n in this.Npcs)
            {
                if (n.GameID == id)
                {
                    found = n;
                }
            }

            return found;
        }
        //Sends packet containg all data except acct is and 0 spacer
        public void SendColorUpdate(Account sender, uint item, byte color)
        {
            foreach (Character c in this.Players)
            {
                Account a = ServerGlobals.GetAccountFromCharacter(c);
                if (a != null)
                {
                    PacketWriter w = new PacketWriter(0x2A);
                    w.WriteUInt32(a.AccountId);
                    w.WriteUInt32(0);
                    w.WriteUInt32(a.CurrentCharacter.GameID);
                    w.WriteUInt32(this.RoomID);
                    w.WriteByte(0x41);
                    w.WriteUInt32(a.CurrentCharacter.GameID);
                    // the item
                    w.WriteUInt32(item);
                    w.WriteByte(color);// (8546); // the color ?
                    w.WriteByte(0x21);
                    w.WriteByte(0xFF);
                    byte[] dye = w.ToArray();
                    a.Socket.Send(ref dye);
                }
            }
        }
        public void SendPacket(byte[] pak, bool addCharID = true)
        {
            // 4 len 0x00 0x00 0x00 0x00

            // 4 packid 0x00 0x00 0x00 0x00 
            // 4 acct id 0x00 0x00 0x00 0x00
            // 4 0's 0x00, 0x00, 0x00, 0x00
            // the char id to send too 0x00, 0x00, 0x00, 0x00
            foreach (Character c in this.Players)
            {
                Account a = ServerGlobals.GetAccountFromCharacter(c);
                if (c != null)
                {
                    //Console.WriteLine("Sending to {0}", c.Name);
                    byte[] acctid = BitConverter.GetBytes(a.AccountId);
                    byte[] curchar = BitConverter.GetBytes(c.GameID);
                    Array.Copy(acctid, 0, pak, 8, acctid.Length);
                    if(addCharID) Array.Copy(curchar, 0, pak, 16, curchar.Length);
                    a.Socket.Send(ref pak);
                }
            }
        }
        public void DropItemInRoom(Account acct, uint itemID)
        {
            foreach (Character c in this.Players)
            {
                Account a = ServerGlobals.GetAccountFromCharacter(c);
                PacketWriter writer = new PacketWriter(42);
                writer.WriteUInt32(a.AccountId);
                writer.WriteUInt32(0);
                writer.WriteUInt32(a.CurrentCharacter.GameID);
                writer.WriteUInt32(this.RoomID);
                writer.WriteByte(0x06);
                writer.WriteUInt32(a.CurrentCharacter.GameID);
                writer.WriteUInt32(itemID);
                writer.WriteBytes(new byte[] { 0x21, 0xFF, 0x00 });
                byte[] r = writer.ToArray();
                a.Socket.Send(ref r);
            }
        }
        /// <summary>
        /// For NPC Movement
        /// </summary>
        /// <param name="pak"></param>
        public void SendMovePacket(byte[] pak)
        {
            foreach (Character c in this.Players)
            {
                Account a = ServerGlobals.GetAccountFromCharacter(c);
                if (c != null)
                {
                    byte[] acctid = BitConverter.GetBytes(a.AccountId);
                    Array.Copy(acctid, 0, pak, 8, acctid.Length);
                    a.Socket.Send(ref pak);

                    Packet.WritePacketToFile(pak, "SendMovePacket.txt");
                }
            }
        }
        #region Equip Item
        public void EquipItemInRoom(Account sender, uint itemID)
        {
            // Get the item
            BaseGameItem item = sender.CurrentCharacter.GetInventoryItem(itemID);//Managers.MySqlManager.GetItem(sender.CurrentCharacter.SqlCharId, itemID);
            // now we pull from and equip the items from memory

            if (item != null)
            {
               // bool un = Managers.MySqlManager.EquipItem(sender.CurrentCharacter.SqlCharId, item.CurrentGameID);
               // if (!un) Console.WriteLine("Failed to equip");
               // else
               // {
                    item.Equipped = false; // dont forget to equip it !!
                    for (int i = 0; i < this.Players.Count; i++)
                    {
                        if (sender.CurrentCharacter != this.Players[i])
                        {
                            Account a = ServerGlobals.GetAccountFromCharacter(this.Players[i]);
                            // Need to send the to everyone in room
                            PacketWriter toRoom = new PacketWriter(0x2A);
                            toRoom.WriteUInt32(a.AccountId);
                            toRoom.WriteInt32(0);
                            toRoom.WriteUInt32(sender.CurrentCharacter.GameID);
                            toRoom.WriteUInt32(this.RoomID);
                            toRoom.WriteByte(0x3F);

                            PacketWriter it = new PacketWriter();
                            it.WriteBytes(item.Serialize());
                            it.WriteByte(0xFF);
                            byte[] justitem = it.GetRawPacket();
                            toRoom.WriteShort((short)justitem.Length);
                            toRoom.WriteUInt32(sender.CurrentCharacter.GameID);
                            toRoom.WriteBytes(justitem);
                           // toRoom.WriteUShort(0x00);
                            //toRoom.WriteByte(0x00);
                            byte[] p42 = toRoom.ToArray();

                            // Try to actually equip it via sql
                            a.Socket.Send(ref p42);

                            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Equiproom1.txt");
                            File.WriteAllText(fileLocation, BitConverter.ToString(p42));

                            PacketWriter toRoom2 = new PacketWriter(0x2A);
                            toRoom2.WriteUInt32(a.AccountId);
                            toRoom2.WriteInt32(0);
                            toRoom2.WriteUInt32(sender.CurrentCharacter.GameID);
                            toRoom2.WriteUInt32(this.RoomID);
                            toRoom2.WriteByte(0x07);
                            toRoom2.WriteUInt32(sender.CurrentCharacter.GameID);
                            toRoom2.WriteUInt32(itemID);
                            toRoom2.WriteByte(0x2F);
                            toRoom2.WriteUInt32(sender.CurrentCharacter.GameID);
                            toRoom2.WriteUInt32(sender.CurrentCharacter.GameID);

                            // These are item stats  ? figure them out
                            //w42.WriteBytes(new byte[] { 0x2D, 0x00, 0x00, 0x00, 0x21, 0xFF });
                            // sets max hp, use the chars current if no change
                            toRoom2.WriteUInt32((uint)sender.CurrentCharacter.TotalHP);

                            toRoom2.WriteBytes(new byte[] { 0x21, 0xFF });
                            //w42.WriteBytes(new byte[] { 0x00, 0x12 }); // not sure
                            //w42.WriteBytes(new byte[] { 0xA1, 0xF3 });
                            toRoom2.WriteBytes(new byte[4]);
                            byte[] proom2 = toRoom2.ToArray();
                            a.Socket.Send(ref proom2);
                            item.Equipped = false;
                            string fileLocation2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Equiproom2.txt");
                            File.WriteAllText(fileLocation2, BitConverter.ToString(p42));
                        }
                    }
                //}
            }
            else Console.WriteLine("Item was null.");
        }
        #endregion
        #region UnequipItem (Works)
        public void UnequipItemInRoom(Account sender, uint itemID)
        {
            // Get the item
            BaseGameItem item = sender.CurrentCharacter.GetInventoryItem(itemID);//Managers.MySqlManager.GetItem(sender.CurrentCharacter.SqlCharId, itemID);
            if (item != null)
            {
                for (int i = 0; i < this.Players.Count; i++)
                {
                    Account a = ServerGlobals.GetAccountFromCharacter(this.Players[i]);
                    // Need to send the to everyone in room
                    PacketWriter w42 = new PacketWriter(0x2A);
                    w42.WriteUInt32(a.AccountId);
                    w42.WriteInt32(0);
                    w42.WriteUInt32(sender.CurrentCharacter.GameID);
                    w42.WriteUInt32(this.RoomID);
                    w42.WriteByte(0x08);
                    w42.WriteUInt32(sender.CurrentCharacter.GameID);
                    w42.WriteUInt32(item.GameID);
                    w42.WriteByte(0x2F);
                    w42.WriteUInt32(sender.CurrentCharacter.GameID);
                    w42.WriteUInt32(sender.CurrentCharacter.GameID);

                    // These are item stats  ? figure them out
                    //w42.WriteBytes(new byte[] { 0x2D, 0x00, 0x00, 0x00, 0x21, 0xFF });
                    // sets max hp, use the chars current if no change
                    w42.WriteUInt32((uint)sender.CurrentCharacter.TotalHP);

                    w42.WriteBytes(new byte[] { 0x21, 0xFF });
                    w42.WriteBytes(new byte[] { 0x00, 0x00 }); // not sure
                   // w42.WriteBytes(new byte[] { 0x00, 0x6A });
                   //w42.WriteBytes(new byte[4]);
                    byte[] p42 = w42.ToArray();
                    a.Socket.Send(ref p42);
                    item.Equipped = false;
                }
              //  bool un = Managers.MySqlManager.EquipItem(sender.CurrentCharacter.SqlCharId, item.CurrentGameID, true);
               // if (!un) Console.WriteLine("Failed to unequip");
            }
            else Console.WriteLine("Item was null.");
        }
        #endregion
        #region Serialization
        public byte[] Serialize()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, this);
            stream.Close();
            return stream.ToArray();
        }
        public Room Deserialize(byte[] room)
        {
            MemoryStream stream = new MemoryStream(room);
            BinaryFormatter bformatter = new BinaryFormatter();
            return bformatter.Deserialize(stream) as Room;
        }
        #endregion
        public virtual void Dispose()
        {
            // return our id to pool
            ServerGlobals.RemoveID(this.RoomID);
            foreach (BaseGameItem i in this.Items)
            {
                ServerGlobals.RemoveID(i.GameID);
            }
            // any npcs ?
            foreach (Entity e in this.Npcs)
            {
                ServerGlobals.RemoveID(e.GameID);
            }
            // remove us from importedrooms
            ScriptResolver.ImportedRooms.Remove(this);
            //clean us up
        }
        public Entity GetEntityInRoom(uint gameID)
        {
            Entity result = null;
            foreach (Entity e in this.Players)
            {
                if (e.GameID == gameID)
                {
                    result = e;
                    break;
                }
            }
            foreach (Entity e in this.Npcs)
            {
                if (e.GameID == gameID)
                {
                    result = e;
                    break;
                }
            }
            foreach (Entity e in this.Items)
            {
                if (e.GameID == gameID)
                {
                    result = e;
                    break;
                }
            }
            // What if the item is in the inventory of one of our players ?
            foreach (Character c in this.Players)
            {
                foreach (BaseGameItem i in c.Inventory)
                {
                    if (i.GameID == gameID)
                    {
                        result = i;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
