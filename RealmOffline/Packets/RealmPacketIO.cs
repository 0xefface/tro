using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp.Base;
using RealmOffline.Managers;
using RealmOffline.Tcp;
using System.IO;
using System.Globalization;
using System.Reflection;
using RealmOffline.Base;
using RealmOffline.Accounts;
using RealmOffline.Commands;
using RealmOffline.Logs;
using RealmOffline.Core;
using RealmOffline.Core.Rooms;
using RealmOffline.Core.Items.Base;
using RealmOffline.Core.Mobiles;

namespace RealmOffline.Packets
  {
  public class RealmPacketIO
    {
    private static RLog log = new RLog(Path.Combine(ServerGlobals.BaseDirectory, @"PacketErrors\Error.log"));

    public static bool CustomRoomLoad = false;
    public static string CustomRoomFile = string.Empty;
    public static bool CustomProgramRoomLoad = false;
    public static int CustomProgramRoomNumber = 0;
    public static bool NewWay = true;

    static List<ServerObject> s = null;

    #region Handle
    public static void Handle(ClientBase cli, string cmd)
      {

      XMLManager xml = new XMLManager();

      s = xml.GetGameServers();

      // "updates 3 522"
      // "gamelist"
      string[] cmdArray = cmd.Split(' ');
      switch (cmdArray[0].ToLower())
        {
        case "updates":
            {
            Console.WriteLine("Client version {0}.{1}", cmdArray[1], cmdArray[2]);

            PacketWriter writer = new PacketWriter();
            writer.WriteInt32(25);
            writer.WriteInt32(0);
            writer.WriteInt32(0);
            writer.WriteInt32(100);
            writer.WriteInt32(0);

            foreach (KeyValuePair<string, string> p in xml.GetPatch())
              {
              // Patch IP
              writer.WriteString(p.Key);
              // Patch port
              writer.WriteString(p.Value);
              }
            //writer.WriteString("65.183.173.2");
            // Patch port
            //writer.WriteString("6005");
            writer.WriteShort(0);
            writer.WriteByte(112);
            writer.WriteString("93");
            writer.WriteByte(12);

            byte[] reply = writer.ToArray();

            cli.Send(ref reply);
            }
          break;
        case "gamelist":
            {
            foreach (ServerObject sv in s)
              {
              // Give me time to get a update
              sv.GetServerData();
              System.Threading.Thread.Sleep(100);
              }
            PacketWriter writer = new PacketWriter();
            writer.WriteInt32(25);
            writer.WriteInt32(0);
            writer.WriteInt32(0);
            writer.WriteInt32(100);
            writer.WriteInt32(0);

            //writer.WriteByte(4);    // Number of servers
            writer.WriteByte((byte)s.Count);    // Number of servers
            foreach (ServerObject ob in s)
              {
              writer.WriteString(ob.Name);
              // Server Status
              //if (ServerGlobals.ServerRunning)
              //{
              writer.WriteString(ob.Up);
              //loggedInPlayers = ServerGlobals.LoggedInAccounts.Count;
              // }
              //else writer.WriteString("down");

              writer.WriteString(ob.LoggedOnPlayerCount);
              // IP
              writer.WriteString(ob.Address);
              // Port
              writer.WriteString(ob.Port.ToString());
              }
            writer.WriteInt32(0);
            writer.WriteInt32(0);

            byte[] reply = writer.ToArray();
            cli.Send(ref reply);
            }
          break;
        default:
          Console.WriteLine("RouterClient:: Unknown command ({0})", cmd);
          break;
        }
      }
    #endregion
    #region Updates
    public static void ParseUpdatesRequest(Client cli, byte[] pak, int pid)
      {
      switch (pid)
        {
        case 6:
            {

            // World server says hello to a connected client
            /*
            // This is most likly where the encryption takes place
            PacketReader reader = new PacketReader(pak); */
            byte[] hello = new byte[]
            {
                            0x18, 0x00, 0x00, 0x00, // 18 first byte in hex, is 24 in dec, length of this packet
                            0x19, 0x00, 0x00, 0x00, // Header ? is 7 // hex 19 = 25 the op code ?

                            0x00, 0x00, 0x00, 0x00, // Starts the actual hello packet
                            0x00, 0x00, 0x00, 0x00,
                            0x06, 0x00, 0x00, 0x00,
                            0x0a, 0x02, 0x00, 0x00,
                            0x00, 0x85, 0x5e, 0xf2,
                            0x02, 0x60, 0x00, 0x05
            };
            Console.WriteLine(BitConverter.ToString(pak));
            cli.Send(ref hello);
            }
          break;
        case 100:
            {
            PacketReader reader = new PacketReader(pak);
            reader.ReadInt32(); // pkt length
            reader.ReadInt32(); // pkt id
            ushort cmd_len = reader.ReadUInt16();
            string cmd = reader.ReadString(cmd_len);
            reader.ReadByte();
            reader.ReadInt32();
            reader.Close();
            Handle(cli, cmd);
            // Console.WriteLine(BitConverter.ToString(pak));
            }
          break;
        default:
          Console.WriteLine("PatchServer: Unknown message ({0})", pid);
          Console.WriteLine(BitConverter.ToString(pak));
          break;
        }
      }
    #endregion
    public static void ParseWorldPackets(WorldClient cli, byte[] pak, int pid)
      {
      MemoryStream stream = new MemoryStream(pak);
      BinaryReader reader = new BinaryReader(stream);
      for (int t = 0; t < pak.Length; t++)
        {
        Console.Write(pak[t].ToString("X2"));
        }
      Console.WriteLine("");
      switch (pid)
        {
        // Need to sha the password and secret word,
        // soo all we can do is check its the same
        // cant tell what it is.
        #region 0x0E User Authenicate 
        case 0x0E:
            {
            //Console.WriteLine("Start 0x0E");
            // get it 
            PacketReader r = new PacketReader(pak);
            r.ReadBytes(8);
            string uName = r.ReadString16().Trim();
            string uPpass = r.ReadString16().Trim();
            r.Close();

            //ushort userNamLen = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            //byte[] usernameBytes = reader.ReadBytes(userNamLen);
            //ushort passLen = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            //byte[] pass = reader.ReadBytes(passLen);
            //reader.Close();

            bool valid = false;
            //string uName = user;
            //string uPpass = pass;

            // Good reply 
            // Send packet 98 (We got your login Packet reply)
            PacketWriter recv = new PacketWriter(0x62);
            recv.WriteInt32(0);
            recv.WriteInt32(0);
            recv.WriteInt32(0); // Changing number on live no clue why
            byte[] recieved = recv.ToArray();
            cli.Send(ref recieved);

            // Send packet 14

            byte[] good = null;
            byte[] bad = Packet.BadLogon("Incorrect Username or password.");



            // Ok we are valid, are we logged on already ?
            uint uid = MySqlManager.GetUserID(uName);

            valid = MySqlManager.CheckLogin(uName, uPpass);
            if (!ServerGlobals.IsAccountInUse(uid))
              {
              if (valid)
                {
                // get and set the account id

                if (uid > 0)
                  {
                  uint sid = ServerGlobals.GetNextAvailableID();
                  cli.SetGameAccount(new Account(cli, sid, uid));
                  if (cli.GameAccount != null)
                    {
                    cli.GameAccount.Username = uName;
                    // Logon
                    ServerGlobals.LoggedInAccounts.QueueItem(cli.GameAccount);
                    good = Packet.GoodLogon(cli.GameAccount);
                    cli.Send(ref good);
                    }
                  else
                    cli.Send(ref bad);
                  }
                }
              else
                {
                if (ServerGlobals.AutoAccountCreation && !string.IsNullOrEmpty(uName))
                  {
                  string error = string.Empty;
                  if (MySqlManager.CreateUserAccount(uName, uPpass, "AutoCreate", "Autocreate", 5, out error))
                    {
                    uid = MySqlManager.GetUserID(uName);
                    if (uid > 0)
                      {
                      uint sid = ServerGlobals.GetNextAvailableID();
                      byte[] acctID = BitConverter.GetBytes(sid);
                      cli.SetGameAccount(new Account(cli, sid, uid));
                      if (cli.GameAccount != null)
                        {
                        cli.GameAccount.Username = uName;
                        // Logon
                        ServerGlobals.LoggedInAccounts.QueueItem(cli.GameAccount);
                        good = Packet.GoodLogon(cli.GameAccount);
                        cli.Send(ref good);
                        }
                      else
                        cli.Send(ref bad);
                      }
                    else
                      cli.Send(ref bad);
                    }
                  else
                    cli.Send(ref bad);
                  }
                else
                  cli.Send(ref bad);
                }
              }
            else
              {
              // Account is in use
              byte[] invalid = Packet.BadLogon("This account is currently logged on, if you have logged off this account, please check back shortly.");
              cli.Send(ref invalid);
              }

            // Console.WriteLine("Sent 0x0E");
            }
          break;
        #endregion
        #region 0x0F
        case 0x0F: // no clue why the client sends this packet, we do not need to reply to it
                   //Console.WriteLine("Sent 0x0F");
          break;
        #endregion
        #region  0x10
        case 0x10:
            {
            //  Console.WriteLine("Start 0x10");
            PacketWriter w = new PacketWriter(25);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteInt32(0);
            w.WriteInt32(0x15);
            w.WriteBytes(new byte[] { 0x21, 0xE5, 0x30, 0x40 });
            byte[] reply = w.ToArray();
            cli.Send(ref reply);
            //  Console.WriteLine("Sent 0x10");
            }
          break;
        #endregion
        #region 0x11 Ping/Pong
        case 0x11:
            {
            //Console.WriteLine("Start 0x11");
            PacketWriter w = new PacketWriter(25);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteInt32(0);
            w.WriteShort(0x11);
            w.WriteBytes(new byte[] { 0x8C, 0x72, 0x11, 0x08 });
            byte[] reply = w.ToArray();
            cli.Send(ref reply);
            // Console.WriteLine("Sent 0x11");
            }
          break;
        #endregion
        #region 0x12 Dreaded Packet 18 Load Chars File
        case 0x12:
            {
            //     Console.WriteLine("Start 0x12");
            // This packet gives back loaded chars server packet id is 18
            // If we have chars we send packet 18 formatted with chars, if not
            // we send a blank one
            // Seems to be in chunks of 21 bytes the 21st byte is FF i assume to mark the ending
            // of the array

            if (ServerGlobals.LoadFromSql)
              {

              cli.GameAccount.Characters = MySqlManager.LoadCharactersFromAccount(cli.GameAccount.SqlId);


              // Always list chars alphabetically
              cli.GameAccount.Characters = cli.GameAccount.Characters.OrderBy(c => c.Name).ToList<Character>();
              // Set the chars into our slots


              CharacterPacket cp = new CharacterPacket(cli.GameAccount, cli.GameAccount.Characters.ToArray());

              byte[] reply = cp.Packet0x12(cli.GameAccount);//cp.GetPacket(cli.GameAccount.AccountId);
              cli.Send(ref reply);
              //  Console.WriteLine("The packet is {0} we think its {1}", reply.LongLength -8, BitConverter.ToUInt32(reply, 0));
              }
            else
              {
              Console.WriteLine("Loading packet 18 from CharDataFile.txt");
              // Reads the charfile from CharDataFile.txt
              string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "CharDataFile.txt");
              byte[] fake0 = GetByteArrayFromFile(fileLocation);
              cli.Send(ref fake0);
              }
            //Console.WriteLine("Sent 0x12");
            }
          break;
        #endregion
        #region 0x15 I do not know but works
        case 0x15:
            {
            //     Console.WriteLine("Start 0x15");
            PacketWriter w = new PacketWriter(0x15);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteUInt32(0);
            w.WriteUInt32(0x15);
            w.WriteBytes(new byte[] { 0x21, 0xE5, 0x30, 0x40 });
            byte[] r = w.ToArray();
            cli.Send(ref r);
            //  Console.WriteLine("Sent 0x15");
            }
          break;
        #endregion
        #region 0x16 I dunno but works
        case 0x16:
            {
            // When client clicks quit the correct way, this packet is sent.
            // which client cant recieve, because it has quit.
            //Console.WriteLine("Packet 22 (0x16) from client not answered {0}", BitConverter.ToString(pak)); 
            //  Console.WriteLine("Sent 0x16");
            }
          break;
        #endregion
        #region 0x17 I dunno but works.
        case 0x17:
            {
            //    Console.WriteLine("Start 0x17");
            PacketWriter w = new PacketWriter(0x17);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteUInt32(0);
            w.WriteUInt32(0x17);
            w.WriteUInt32(0);
            byte[] r = w.ToArray();
            cli.Send(ref r);
            //  Console.WriteLine("Sent 0x17");
            }
          break;
        #endregion
        #region 0x20  (Sends next room Information) This needs fixed so bad
        case 0x20:
            {
            //  Console.WriteLine("Opcode 0x20");

            /// AHHHHHHH this is why, it asks for a room here
            reader.ReadBytes(8);
            // what room do we want ?
            uint room1 = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            ushort dunno = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            uint room2 = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            reader.Close();

            // Here we go
            byte[] sendNewRoom = null;

            foreach (Room r in ScriptResolver.ImportedRooms)
              {
              if (room1 == r.RoomID)
                {
                // Console.WriteLine("Room {0} Found.", room1);
                // If location is null, we just logged on


                if (cli.GameAccount.CurrentCharacter.Location == null)
                  cli.GameAccount.CurrentCharacter.Location = new RoomLocation(r.RoomID, 150, 150, 2);
                r.AddEntity(cli.GameAccount.CurrentCharacter, cli.GameAccount);
                cli.GameAccount.CurrentCharacter.Location.CurrentRoom = r;

                sendNewRoom = r.GetRoomPacket(cli.GameAccount.AccountId);
                }
              }

            // just in case the room doesnt exist, we send them to a default room
            // this will be thier home eventually
            if (sendNewRoom == null)
              {
              Room rfault = ScriptResolver.ImportedRooms[0];
              // If location is null, we just logged on

              if (cli.GameAccount.CurrentCharacter.Location == null)
                cli.GameAccount.CurrentCharacter.Location = new RoomLocation(rfault.RoomID, 150, 150, 2);
              rfault.AddEntity(cli.GameAccount.CurrentCharacter, cli.GameAccount);
              cli.GameAccount.CurrentCharacter.Location.CurrentRoom = rfault;

              sendNewRoom = ScriptResolver.ImportedRooms[0].GetRoomPacket(cli.GameAccount.AccountId);
              }

            /// This all needs moved, we only send this on connect.

            // Now send uptime n shit
            byte[] connected = ServerMessageType2(ServerGlobals.GetCurrentNumberOfPlayers);
            cli.Send(ref connected);
            //  Console.WriteLine("Sent con");
            // How long has server been up ?
            byte[] uptime = ServerMessageType2(ServerGlobals.GetCurrentUpTime);
            cli.Send(ref uptime);
            if (sendNewRoom == null) Console.WriteLine("New room is null");
            //Room Last
            cli.Send(ref sendNewRoom);
            Console.WriteLine("Sent up");

            }
          break;
        #endregion
        #region 0x25 Chat Console Packet
        case 0x25:
            {
            // Console.WriteLine("Start 37 : {0}", BitConverter.ToString(pak));
            // 0x80-8A are the emotes
            // This is the chat packet, it handles all chat as far as i can see
            //Console.WriteLine("Chat Packet {0}", Tools.NiceHexOutput(pak));
            //byte[] reply;


            // Other wise, lets read this 
            reader.ReadBytes(4); //Pck Length
            reader.ReadBytes(4); // Id
            int remaining = (int)(reader.BaseStream.Length - reader.BaseStream.Position + 5);
            try
              {
              List<byte> clean = new List<byte>();
              byte[] cb = reader.ReadBytes(remaining);
              foreach (byte b in cb)
                {
                if (b != 0x00) clean.Add(b);
                }
              string command = Encoding.ASCII.GetString(clean.ToArray());
              string[] cmd = command.Split(' ');
              // Good channel code, works fine
              // Need to rewrite this section
              // for custom commands.

              if (command.StartsWith("|c")) // room chat
                {
                // Room Chat
                // What room did we say this in ?
                uint room = cli.GameAccount.CurrentCharacter.Location.RoomNumber;
                List<Account> playersInRoom = ServerGlobals.GetAccountsInRoom(room);
                //      Console.WriteLine("Total accounts in this room {0}", playersInRoom.Count);

                for (int i = 0; i < playersInRoom.Count; i++)
                  {
                  byte[] chat = chat = Packet.RoomChatPacket(cli.GameAccount,
                      playersInRoom[i].AccountId, clean.ToArray());
                  bool sent = ServerGlobals.TrySend(playersInRoom[i], chat);
                  if (!sent) Console.WriteLine("Failed to send room chat to account {0}", playersInRoom[i].AccountId);
                  }
                }
              else if (command.StartsWith("/join"))
                {
                if (cmd.Length >= 2)
                  {
                  // What channel ?
                  int channel = -1;
                  if (int.TryParse(cmd[1], out channel))
                    {
                    // try to find the channel
                    Channel c = null;
                    foreach (Channel chan in ScriptResolver.ImportedChannels)
                      {
                      if (chan.ChannelNumber == cmd[1])
                        c = chan;

                      }
                    if (c != null)
                      {
                      // If player is already in a channel, make sure to leave it

                      if (cmd.Length == 3)
                        {
                        c.SendJoinPacket(cli.GameAccount, cmd[2]);
                        }
                      else
                        c.SendJoinPacket(cli.GameAccount);
                      //   Console.WriteLine("Tried to join channel {0}", cmd[1]);
                      }
                    else
                      {
                      // Force join 4
                      foreach (Channel c4 in ScriptResolver.ImportedChannels)
                        {
                        if (c4.ChannelNumber == "4")
                          c4.SendJoinPacket(cli.GameAccount);
                        }
                      //   Console.WriteLine("Channel {0} not found.", cmd[1]);
                      //byte[] reply = Packet.ChatPacket(1, 1,
                      //   string.Format("Failed to locate channel #{0}.", cmd[1]), "Join");
                      //  cli.Send(ref reply);
                      }
                    }
                  else Console.WriteLine("We got a bad cmd parse.");
                  }
                }
              else if (command.StartsWith("/open"))
                {
                //  Console.WriteLine("Wants to open group.");
                PacketWriter w = new PacketWriter(0x26);
                w.WriteUInt32(cli.GameAccount.AccountId);
                w.WriteInt32(0);
                w.WriteBytes(new byte[] { 0x2D, 0x33, 0x4F }); // maybe group id ?
                string grp = "|c43|You are now accepting new group members.";
                w.WriteBytes(Encoding.ASCII.GetBytes(grp));
                w.WriteBytes(new byte[] { 0x0A, 0x00, 0x9D, 0x00 });
                byte[] reply = w.ToArray();
                cli.Send(ref reply);

                }
              else if (command.StartsWith("/close"))
                {
                //   Console.WriteLine("Wants to close group.");
                PacketWriter w = new PacketWriter(0x26);
                w.WriteUInt32(cli.GameAccount.AccountId);
                w.WriteInt32(0);
                w.WriteBytes(new byte[] { 0x2D, 0x33, 0x43 }); // maybe group id ?
                string grp = "|c43|You are no longer accepting new group members.";
                w.WriteBytes(Encoding.ASCII.GetBytes(grp));
                w.WriteBytes(new byte[] { 0x0A, 0x00 });
                byte[] reply = w.ToArray();
                cli.Send(ref reply);

                }
              else if (command.StartsWith("/gms"))
                {
                // Do not know this packet, never any gms on.
                PacketWriter w = new PacketWriter(0x3D);
                w.WriteUInt32(cli.GameAccount.AccountId);
                w.WriteInt32(0);
                w.WriteShort(5);
                w.WriteByte(0x00);
                w.WriteByte(0x00);

                byte[] reply = w.ToArray();
                cli.Send(ref reply);
                //    Console.WriteLine("Wants a gm list");
                }
              else if (command.StartsWith("/addfriend"))
                {
                PacketWriter w = new PacketWriter(0x26);
                w.WriteUInt32(cli.GameAccount.AccountId);
                w.WriteInt32(0);
                //w.WriteBytes(new byte[] { 0x2D, 0x66, 0x2B}); // Online
                w.WriteBytes(new byte[] { 0x2D, 0x66, 0x20 }); // Offline
                w.WriteBytes(Encoding.ASCII.GetBytes(cmd[1]));
                w.WriteShort(0);
                w.WriteByte(0xFF);
                byte[] reply = w.ToArray();
                cli.Send(ref reply);
                //      Console.WriteLine("I wanna add friend {0}", cmd[1]);
                }
              else if (command.StartsWith("/delfriend"))
                {
                PacketWriter w = new PacketWriter(0x26);
                w.WriteUInt32(cli.GameAccount.AccountId);
                w.WriteInt32(0);
                w.WriteBytes(new byte[] { 0x2D, 0x66, 0x72 });
                w.WriteBytes(Encoding.ASCII.GetBytes(cmd[1]));
                w.WriteBytes(new byte[] { 0x00, 0x40, 0x01, 0xEE });
                byte[] reply = w.ToArray();
                cli.Send(ref reply);
                //    Console.WriteLine("I wanna del friend {0}", cmd[1]);
                }
              else if (command.StartsWith("/ignore"))
                {
                PacketWriter w = new PacketWriter(0x26);
                w.WriteUInt32(cli.GameAccount.AccountId);
                w.WriteInt32(0);
                w.WriteBytes(new byte[] { 0x2D, 0x65, 0x20 }); //0x2B Online
                w.WriteBytes(Encoding.ASCII.GetBytes(cmd[1]));
                w.WriteBytes(new byte[] { 0x00, 0x00, 0x01, 0x48 });
                byte[] reply = w.ToArray();
                cli.Send(ref reply);
                //    Console.WriteLine("I wanna ignore {0}", cmd[1]);
                }
              else if (command.StartsWith("/listen"))
                {
                PacketWriter w = new PacketWriter(0x26);
                w.WriteUInt32(cli.GameAccount.AccountId);
                w.WriteInt32(0);
                w.WriteBytes(new byte[] { 0x2D, 0x65, 0x72 });
                w.WriteBytes(Encoding.ASCII.GetBytes(cmd[1]));
                w.WriteBytes(new byte[] { 0x00, 0x40, 0x01, 0xEE });
                byte[] reply = w.ToArray();
                cli.Send(ref reply);
                //     Console.WriteLine("I wanna unignore {0}", cmd[1]);
                }
              else if (command.StartsWith("/pignore"))
                {
                }
              else if (command.StartsWith("/report"))
                {
                }
              else if (command.StartsWith("/"))
                {
                OldCommand playerCommand = new OldCommand(cli.GameAccount, pak);//new Command(cli.GameAccount, command);
                playerCommand.ReactToCommand();
                }

              }
            catch { }
            //  Console.WriteLine("Sent 37");
            }
          break;
        #endregion
        #region 0x29 Location Validation
        case 0x29:
            {
            //Console.WriteLine("Start 41");
            int len = BitConverter.ToInt32(reader.ReadBytes(4), 0);
            reader.ReadBytes(4);
            uint ID = reader.ReadUInt32();
            uint room = reader.ReadUInt32();

            //  Console.WriteLine("Char id {0} from room {1}", ID, room);
            // -12
            byte[] rem = reader.ReadBytes(len - 12);
            byte[] outBuffer = Tools.ReadUntil0xFF(rem);
            //log.LogMessage(string.Format("Payload {0}", BitConverter.ToString(outBuffer)), MessageType.Information);
            reader.Close();
            /*
             * This packet is just a reply saying ok we got the data from you mr client
             * So we want this data, of where we think we are.
             */
            uint roomNumber = 0;
            int packId = -1;
            //ushort facing = 0;
            // ushort x = 0;
            // ushort y = 0;
            //  ushort charID = 0;

            byte[] payload = null;

            try
              {
              payload = Tools.ReadPacket41UntilFF(pak, out packId, out roomNumber);
              }
            catch (Exception ex) { log.WriteException(ex); }

            if (payload == null) { } // error out
            if (payload.Length == 0) { } // error out.
                                         // If the room isnt loaded, we cant set it
            bool roomExists = false;
            foreach (Room r in ScriptResolver.ImportedRooms)
              {
              if (r.RoomID == roomNumber)
                {
                roomExists = true; break;
                }
              }

            if (roomExists)
              {
              if (cli.GameAccount.CurrentCharacter != null)
                {
                if (cli.GameAccount.CurrentCharacter.Location == null)
                  {
                  cli.GameAccount.CurrentCharacter.Location = new RoomLocation(pak);
                  }
                else
                  {
                  cli.GameAccount.CurrentCharacter.Location.Repopulate(pak);
                  cli.GameAccount.CurrentCharacter.Location.CurrentRoom.MoveEntity(cli.GameAccount.CurrentCharacter,
                      cli.GameAccount, rem);
                  }
                }
              PacketWriter w = new PacketWriter(0x19);
              w.WriteUInt32(cli.GameAccount.AccountId);
              w.WriteInt32(0);
              w.WriteInt32(0x29);
              w.WriteBytes(new byte[] { 0x7C, 0x4E, 0x0A, 0x08 });

              byte[] reply = w.ToArray();

              cli.Send(ref reply);
              }
            else Console.WriteLine("Logging in for first time");
            // log.LogMessage(string.Format("Packet 41 answered. {0}", BitConverter.ToString(pak)), MessageType.Error);
            //Console.WriteLine("Sent 41");
            }
          break;
        #endregion
        #region 0x30 Char Creation (Begin) 1 of 3 packets
        case 0x30:
            {
            Tools.SetColor(ConsoleColor.Yellow);
            Console.WriteLine("Creation Packet  48: {0}", BitConverter.ToString(pak));
            Tools.ResetColor();
            reader.ReadBytes(4); // pck len
            reader.ReadBytes(4); // Id
                                 // Ok need to make a new char here
                                 // Lets begin to create our new char
            cli.GameAccount.InCharacterCreationProcess = true;
            cli.GameAccount.CurrentCharacter = new Character();
            //var cBuilder = cli.GameAccount.CurrentCharacter;
            //  string fileLocation1 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "CharCreate0x3010f3Client.txt");
            //  File.WriteAllText(fileLocation1, BitConverter.ToString(pak));


            ushort uNameLen = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            string uName = Encoding.ASCII.GetString(reader.ReadBytes(uNameLen));

            if (!MySqlManager.IsNameTaken(uName))
              {
              uint sqlId = 0;

              ushort uTtitleLen = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
              string uTitle = Encoding.ASCII.GetString(reader.ReadBytes(uTtitleLen));

              cli.GameAccount.CurrentCharacter.AddCharData(uName, uTitle, reader.ReadByte(),
                  reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), reader.ReadByte(),
                  reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), reader.ReadByte(),
                  reader.ReadByte(), reader.ReadByte());
              reader.Close();

              switch (cli.GameAccount.CurrentCharacter.Class)
                {
                case 0x00: // adv
                    {
                    cli.GameAccount.CurrentCharacter.CurrentHP = 45;
                    cli.GameAccount.CurrentCharacter.TotalHP = 45;
                    Console.WriteLine("Adv");
                    }
                  break;
                case 0x01://warrior
                    {
                    cli.GameAccount.CurrentCharacter.CurrentHP = 60;
                    cli.GameAccount.CurrentCharacter.TotalHP = 60;
                    Console.WriteLine("War");
                    }
                  break;
                case 0x02: //wiz
                    {
                    cli.GameAccount.CurrentCharacter.CurrentHP = 15;
                    cli.GameAccount.CurrentCharacter.TotalHP = 15;
                    Console.WriteLine("Wiz");
                    }
                  break;
                case 0x03: //thief
                    {
                    cli.GameAccount.CurrentCharacter.CurrentHP = 25;
                    cli.GameAccount.CurrentCharacter.TotalHP = 25;
                    Console.WriteLine("Thief");
                    }
                  break;
                default:
                  Console.WriteLine("Unknown Class {0}.", cli.GameAccount.CurrentCharacter.Class);
                  break;
                }
              cli.GameAccount.CurrentCharacter.Gold = 10000;
              cli.GameAccount.CurrentCharacter.Mana = 10000;
              cli.GameAccount.CurrentCharacter.Level = 1;
              cli.GameAccount.CurrentCharacter.BuildPoints = 5;
              bool created = MySqlManager.CreateNewCharacter(cli.GameAccount.CurrentCharacter, cli.GameAccount.SqlId, out sqlId);


              //    Console.WriteLine("Created new char {0} {1}", uName, created);
              //  cBuilder.SqlCharId = sqlId;
              // The character is finished up to this point
              // we have 2 more sections to add next is 59
              //  Character c = MySqlManager.GetCharacter(sqlId);
              //  if (c == null) Console.WriteLine("cant get new char");
              //cli.GameAccount.CurrentCharacter = c;
              byte[] reply = cli.GameAccount.CurrentCharacter.CreateNewChar48(cli.GameAccount.AccountId);//cli.GameAccount.GenerateCreateCharPacket();
              string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MyPacket25(NewChar).txt");
              File.WriteAllText(fileLocation, BitConverter.ToString(reply));
              Console.WriteLine("Sent Char Create 1");
              cli.Send(ref reply);
              }
            else
              {
              byte[] no = { 0x14, 0x00, 0x00, 0x00, 0x1A, 0x00, 0x00, 0x00, 0x23, 0x0A, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x00, 0x00, 0x00, 0x11, 0x27, 0x00, 0x00, 0x83, 0xCF, 0x49, 0xC4 };
              cli.Send(ref no);
              }

            }
          break;
        #endregion
        #region 0x31 49 Erase Toon
        case 0x31:
            {
            //   Console.WriteLine("Start 49");
            //  Console.WriteLine("Erase Packet : {0}", BitConverter.ToString(pak));
            // This deletes chars, when you delete a char in front of another char
            // the chars in the slots to the right move up one to the left.

            // 49 is erase a toon packet
            reader.ReadBytes(4); // packet len
            reader.ReadBytes(4); // pckid 49

            uint charID = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            reader.Close();
            //Character toRemove = acct.GetCharFromGameID(BitConverter.ToUInt16(charID, 0));
            if (cli.GameAccount.RemoveCharByGameID(charID))
              {
              // We need to check and move the chars up a slot if one is null
              }



            byte[] reply = Packet.ReplyWith25(cli.GameAccount.AccountId, 49,
                new byte[] { 0x4F, 0x29, 0x0A, 0x08 });
            cli.Send(ref reply);
            //   Console.WriteLine("Sent 49");
            }
          break;
        #endregion
        #region 0x34 52 Moves from one screen to next
        case 0x34:
            {
            Character c = cli.GameAccount.CurrentCharacter;
            reader.ReadBytes(4);
            reader.ReadBytes(4);
            ushort exitNum = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            reader.Close();

            // this is the exit we leaving by
            RealmOffline.Core.Rooms.Room.RoomExit e = cli.GameAccount.CurrentCharacter.Location.CurrentRoom.GetRoomExitByValue((byte)exitNum);
            uint newRoomNum = cli.GameAccount.CurrentCharacter.Location.CurrentRoom.GetNextRoomByExit(e);
            Room foundRoom = null;
            bool found = ScriptResolver.ImportedRooms.TryGetRoom(newRoomNum, out foundRoom);
            if (!found) found = ScriptResolver.ImportedRooms.TryGetRoom(5043, out foundRoom);

            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RemoveEntity(cli.GameAccount.CurrentCharacter, cli.GameAccount);
            foundRoom.AddEntity(cli.GameAccount.CurrentCharacter, cli.GameAccount);
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom = foundRoom;
            byte[] room = foundRoom.GetRoomPacket(cli.GameAccount.AccountId);
            cli.Send(ref room);
            /*
             * Denies entry to room, turns you back
            PacketWriter w25 = new PacketWriter(0x1A);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0x34); // the packet we are replying too, client must send it
            w25.WriteBytes(new byte[] { 0x00, 0x00, 0x00, 0x00 }); // thr reply above in hex.
            byte[] pno = w25.ToArray();
            cli.Send(ref pno);
             */
            }
          break;
        #endregion
        #region 0x37 Look At 55
        case 0x37:
            {
            //  Console.WriteLine("Start 55");

            reader.ReadBytes(4);// len
            reader.ReadBytes(4);// id
            uint charId = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            reader.Close();
            // Console.WriteLine("Look at {0}", charId);
            Entity e = null;
            if (cli.GameAccount.CurrentCharacter != null)
              {
              if (cli.GameAccount.CurrentCharacter.Location != null)
                {
                if (cli.GameAccount.CurrentCharacter.Location.CurrentRoom != null)
                  {
                  e = cli.GameAccount.CurrentCharacter.Location.CurrentRoom.GetEntityInRoom(charId);
                  }
                }
              }
            if (e == null)
              {
              // Must be looking at on screen
              e = cli.GameAccount.GetCharFromGameID(charId);
              }
            if (e is Character)
              {
              Character c = e as Character;
              byte[] reply = c.CreateLookAt55(c.GameID);

              cli.Send(ref reply);
              }
            //   Console.WriteLine("Sent 55");
            }
          break;
        #endregion
        #region 0x38 CreateNewChar 56 (Final) 3 of 3
        case 0x38:
            {
            Console.WriteLine("Final Char Create");
            // not sent atm fix me.
            //  Console.WriteLine("Reply from creation 56: {0}", BitConverter.ToString(pak));
            // Final part of create char, we finalize stuff here
            reader.ReadBytes(4); // pck len
            reader.ReadBytes(4); // pack id
            reader.ReadBytes(4);  // Not sure what this is
            ushort bioLen = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            byte[] bTitle = reader.ReadBytes(bioLen);
            reader.Close();
            string fileLocation1 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "CharCreate0x3830f3Client.txt");
            File.WriteAllText(fileLocation1, BitConverter.ToString(pak));

            Character c = cli.GameAccount.CurrentCharacter;
            //  Console.WriteLine("New chars id is {0}", c.CharId);
            if (c == null) { Console.WriteLine("Char should not be null in 56"); }
            c.AddDescription(bTitle);
            // Now we need to generate default skills

            //  Console.WriteLine("Packet 56 from client answered");
            PacketWriter w = new PacketWriter(0x19);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteUInt32(0);
            w.WriteUInt32(0x38);
            //   w.WriteBytes(new byte[] { 0x98, 0xC3, 0x71, 0x0F });
            byte[] reply = w.ToArray();
            //c.CreateNewChar56(cli.GameAccount.AccountId);

            // This brand new char is completed
            // we need to add this in the correct slot in the acounts chars

            // Now we need to make sure mysql is populated correctly
            // assign more vars
            c.Gold = 1000000;//750;
            bool g = MySqlManager.TryUpdateCharValue("Gold", 1000000, c.SqlCharId);
            c.Mana = 1000000;//500;
            bool m = MySqlManager.TryUpdateCharValue("Mana", 1000000, c.SqlCharId);
            c.Level = 1;
            bool l = MySqlManager.TryUpdateCharValue("Level", 1, c.SqlCharId);
            c.CurrentHP = 30;
            bool ch = MySqlManager.TryUpdateCharValue("CurrentHP", 30, c.SqlCharId);
            c.TotalHP = 30;
            bool th = MySqlManager.TryUpdateCharValue("TotalHP", 30, c.SqlCharId);
            c.BuildPoints = 54;
            bool b = MySqlManager.TryUpdateCharValue("BuildPoints", 1, c.SqlCharId);
            cli.Send(ref reply);
            if (cli.GameAccount.AddCharacter(c))
              {
              Console.WriteLine("Good Char add chars now at {0}", cli.GameAccount.NumberOfValidCharacters);
              }
            Console.WriteLine("Sent Char create final");
            }
          break;
        #endregion
        #region 0x39 57 Look at item ?
        case 0x39:
            {
            //   Console.WriteLine("Start 57");
            // Look at item
            //  Console.WriteLine("Packet 57 answered. {0}", BitConverter.ToString(pak));
            //     Console.WriteLine("Packet 57: {0}", BitConverter.ToString(pak));
            reader.ReadBytes(4); // pak length
            reader.ReadBytes(4); // Id 57
            uint slotId = reader.ReadUInt32();
            // what are we doing with it ?
            //byte action = reader.ReadByte();
            reader.Close();
            // Console.WriteLine("We want to look at item or mob id {0}", slotId);

            // Needs to look everywhere, inventory first
            BaseGameItem i = null;// MySqlManager.GetItem(slotId);
            foreach (BaseGameItem item in cli.GameAccount.CurrentCharacter.Inventory)
              {
              if (item.GameID == slotId) i = item;
              }
            // Does i still = null ?
            if (i == null)
              {
              // Then look through the room
              foreach (BaseGameItem item in cli.GameAccount.CurrentCharacter.Location.CurrentRoom.Items)
                {
                if (item.GameID == slotId) i = item;
                }

              }
            if (i != null && i.GameID != 0)
              {
              PacketWriter w = new PacketWriter(0x19);
              w.WriteUInt32(cli.GameAccount.AccountId);
              w.WriteUInt32(0x00);
              w.WriteUInt32(0x39);
              w.WriteUInt32(0);
              string name = i.Name;
              if (name == string.Empty) name = "Default Name.";
              w.WriteString(string.Format(
                  "You see a {0} with a Color of {1}, it {2} equipped.\n" +
                  "It's Graphic id is {3}, SqlID is {4}, The SqlId of it's current owner is {5}.\n" +
                  "The type of the item is {6}, and it's look at is {7}, with a Current Game ID of {8}.",
                  i.Name, i.Color, i.Equipped ? "is" : "is not",
                  i.GraphicID, i.SqlID, i.SqlOwnerID,
                  i.Type, i.LookAt, i.GameID));
              byte[] r = w.ToArray();
              cli.Send(ref r);
              }
            else
              {
              // we might be a player in a costume.
              Character c = cli.GameAccount.CurrentCharacter.Location.CurrentRoom.GetCharacterInRoom(slotId);//MySqlManager.GetCurrentCharacter(slotId);
              if (c != null)
                {
                PacketWriter w = new PacketWriter(0x19);
                w.WriteUInt32(cli.GameAccount.AccountId);
                w.WriteUInt32(0x00);
                w.WriteUInt32(0x39);
                w.WriteUInt32(0);
                string name = c.Name;
                w.WriteString(string.Format(
                    "Player {0} is currently in a costume.", c.Name));
                byte[] r = w.ToArray();
                cli.Send(ref r);
                }
              else if (c == null)
                {
                Mobile nfound = null;
                // Maybe we are a npc ?
                foreach (Mobile m in cli.GameAccount.CurrentCharacter.Location.CurrentRoom.Npcs)
                  {
                  if (m.GameID == slotId)
                    {
                    nfound = m;
                    break;
                    }
                  }
                if (nfound != null)
                  {
                  PacketWriter w = new PacketWriter(0x19);
                  w.WriteUInt32(cli.GameAccount.AccountId);
                  w.WriteUInt32(0x00);
                  w.WriteUInt32(0x39);
                  w.WriteUInt32(0);
                  w.WriteString(string.Format(
                      "You see a NPC {0}, {1} GameID is {2}.", nfound.Name, nfound.Gender == 0 ? "his" : "her", nfound.GameID));
                  byte[] r = w.ToArray();
                  cli.Send(ref r);
                  }
                else Console.WriteLine("No found npc {0}", slotId);
                }
              else
                {
                // Look at a item
                byte[] reply = { 0xB0, 0x00, 0x00, 0x00,
                                         0x19, 0x00, 0x00, 0x00,
                                         0xD4, 0x9E,
                                         0x02, 0x00,
                                         0x00, 0x00, 0x00, 0x00,
                                         0x39, 0x00, 0x00, 0x00,
                                         0x00, 0x00, 0x00, 0x00, 
                                         // Description of the item
                                         0x96, 0x00,
                                         0x59, 0x6F, 0x75, 0x20, 0x73, 0x65, 0x65, 0x20, 0x61, 0x20, 0x53,
                                         0x6B, 0x69, 0x6C, 0x6C, 0x65, 0x64, 0x20, 0x50, 0x6C, 0x61, 0x79,
                                         0x65, 0x72, 0x27, 0x73, 0x20, 0x42, 0x61, 0x6C, 0x64, 0x72, 0x69,
                                         0x63, 0x2E, 0x20, 0x54, 0x68, 0x69, 0x73, 0x20, 0x69, 0x74, 0x65,
                                         0x6D, 0x20, 0x68, 0x61, 0x73, 0x20, 0x61, 0x6E, 0x20, 0x61, 0x72,
                                         0x6D, 0x6F, 0x72, 0x20, 0x72, 0x61, 0x74, 0x69, 0x6E, 0x67, 0x20,
                                         0x6F, 0x66, 0x20, 0x31, 0x30, 0x20, 0x70, 0x65, 0x72, 0x63, 0x65,
                                         0x6E, 0x74, 0x2E, 0x20, 0x20, 0x54, 0x68, 0x69, 0x73, 0x20, 0x69,
                                         0x74, 0x65, 0x6D, 0x20, 0x77, 0x65, 0x69, 0x67, 0x68, 0x73, 0x20,
                                         0x30, 0x2E, 0x35, 0x20, 0x73, 0x74, 0x6F, 0x6E, 0x65, 0x73, 0x2E,
                                         0x20, 0x20, 0x54, 0x68, 0x69, 0x73, 0x20, 0x69, 0x73, 0x20, 0x69,
                                         0x6E, 0x20, 0x65, 0x78, 0x63, 0x65, 0x6C, 0x6C, 0x65, 0x6E, 0x74,
                                         0x20, 0x63, 0x6F, 0x6E, 0x64, 0x69, 0x74, 0x69, 0x6F, 0x6E, 0x20,
                                         0x28, 0x31, 0x30, 0x30, 0x25, 0x29, 0x2E,

                                         0x00, 0x00, 0x02, 0x00,

                                         0x00, 0x00, 0x00, 0x00 };
                // byte 8 and 9 are the items slot id, this needs to change to reply to what slot char is looking at atm
                //  reply[8] = slotId[0];
                //  reply[9] = slotId[1];
                // reply[10] = slotId[2];
                // reply[11] = slotId[3];
                cli.Send(ref reply);
                }
              }
            //  Console.WriteLine("Sent 57");
            }
          break;
        #endregion
        #region 0x3A Look At 58
        case 0x3A:
            {
            //         Console.WriteLine("Sending 58");
            // Send packet 25 its big
            // when we click play, this is the first packet sent. 
            //Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Look At 58: {0}", BitConverter.ToString(pak));
            Console.WriteLine("Total chars {0}.", cli.GameAccount.Characters.Count);
            //Console.ResetColor();
            reader.ReadBytes(4); // len
            reader.ReadBytes(4); // id
            uint charID = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            Character c = null;
            if (cli.GameAccount.CurrentCharacter == null)
              cli.GameAccount.CurrentCharacter = cli.GameAccount.GetCharFromGameID(charID);

            if (cli.GameAccount.CurrentCharacter.Location != null)
              {
              if (cli.GameAccount.CurrentCharacter.Location.CurrentRoom != null)
                {
                Entity e = cli.GameAccount.CurrentCharacter.Location.CurrentRoom.GetEntityInRoom(charID);
                if (e is Character)
                  {
                  c = e as Character;
                  byte[] look = c.CreateLookAt58(cli.GameAccount.AccountId);
                  cli.Send(ref look);
                  }
                }
              else c = cli.GameAccount.CurrentCharacter;
              // send yours
              }
            else
              {
              if (c == null) c = cli.GameAccount.CurrentCharacter;
              byte[] look = c.CreateLookAt58(cli.GameAccount.AccountId);
              cli.Send(ref look);
              }
            /*
            Character c = cli.GameAccount.GetCharFromGameID(charID);
            if (c == null) c = cli.GameAccount.CurrentCharacter;
            Console.WriteLine("We got char id {0} {1}", charID, c!= null ? "True":"False");
            if (ServerGlobals.LoadFromSql)
            {
                byte[] charLookAt = c.CreateLookAt58(cli.GameAccount.AccountId);
                // Ok we have the char, lets build a packet around his info
                cli.Send(ref charLookAt);
            }
            else
            {
                Console.WriteLine("Sending fake look at");
                byte[] fakeLook = GetByteArrayFromFileInBaseDir("lookat.txt");
                cli.Send(ref fakeLook);
            }
            //done
             */
            //     Console.WriteLine("Sent 58");
            }
          break;
        #endregion
        #region 0x3B Char Create Part Data (Middle) 2 of 3
        case 0x3B:
            {
            //Console.WriteLine("Start 59");
            // Console.WriteLine("Packet 59 {0}", BitConverter.ToString(pak));
            // 0x54, 0x65, 0x73, 0x74, 0x6f, 0x72, // Testor
            // Here during a new char creation we get our part data
            Character c = cli.GameAccount.CurrentCharacter;
            if (c == null) { Console.WriteLine("We have a null char, and we shouldnt"); }
            reader.ReadBytes(4); // pck len
            reader.ReadBytes(4); // pack id
            reader.ReadBytes(4); // charid
                                 //reader.ReadByte();
                                 //string fileLocation1 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "CharCreate0x3B20f3Client.txt");
                                 // File.WriteAllText(fileLocation1, BitConverter.ToString(pak));
                                 // Data starts
            c.AddPartData(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), reader.ReadByte(),
                reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), reader.ReadByte(),
                reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
            reader.Close();
            // Update the char mysql info

            PacketWriter writer = new PacketWriter(0x19);
            writer.WriteUInt32(cli.GameAccount.AccountId);
            writer.WriteUInt32(0x00);
            writer.WriteUInt32(0x3B);
            // writer.WriteBytes(new byte[] { 0x98, 0xC3, 0x71, 0x0F });

            byte[] reply = writer.ToArray();
            cli.Send(ref reply);
            Console.WriteLine("Sent Char Create 2");
            string fileLocation1 = Path.Combine(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location), "CharCreate0x3B20f3Server.txt");
            File.WriteAllText(fileLocation1, BitConverter.ToString(reply));
            //done
            }
          break;
        #endregion
        #region 0x45 (Exit Combat cloud)
        case 0x45: // exit combat cloud
            {
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0x45);
            w25.WriteBytes(new byte[] { 0x60, 0x80, 0xE1, 0x1B });
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);

            PacketWriter w42A = new PacketWriter(0x2A);
            w42A.WriteUInt32(cli.GameAccount.AccountId);
            w42A.WriteUInt32(0x00);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42A.WriteByte(0x23);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42A.WriteUShort(150);
            w42A.WriteUShort(150);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42A.WriteByte(0xFF);
            byte[] p42A = w42A.ToArray();
            //cli.Send(ref p42A);
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(p42A, false);
            PacketWriter w42B = new PacketWriter(0x2A);
            w42B.WriteUInt32(cli.GameAccount.AccountId);
            w42B.WriteUInt32(0x00);
            // cloud
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42B.WriteByte(0x3E);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID);
            w42B.WriteBytes(new byte[] { 0xAC, 0x91, 0x00, 0x00 });
            w42B.WriteByte(0xFF);
            byte[] p42B = w42B.ToArray();
            //cli.Send(ref p42B);
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(p42B, false);

            PacketWriter w45 = new PacketWriter(0x45);
            w45.WriteUInt32(cli.GameAccount.AccountId);
            w45.WriteUInt32(0x00);
            w45.WriteBytes(new byte[] { 0x00, 0x0B, 0x02, 0x27 });
            w45.WriteByte(0x01);
            w45.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            byte[] p45 = w45.ToArray();
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(p45, false);

            // Get all the mobs in cloud that died.
            Mobile m = cli.GameAccount.CurrentCharacter.Cloud.Combatants[0];

            PacketWriter w42C = new PacketWriter(0x2D);
            w42C.WriteUInt32(cli.GameAccount.AccountId);
            w42C.WriteUInt32(0x00);
            w42C.WriteInt32((int)cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            // cloud
            w42C.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID);
            w42C.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID);
            w42C.WriteBytes(new byte[] { 0x00, 0xD1, 0x05, 0xFB });
            byte[] p42C = w42C.ToArray();
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(p42C, false);

            // now remove the dead mob(s)
            PacketWriter w42D = new PacketWriter(0x2D);
            w42D.WriteUInt32(cli.GameAccount.AccountId);
            w42D.WriteUInt32(0x00);
            w42D.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42D.WriteUInt32(m.GameID);
            w42D.WriteBytes(new byte[] { 0x00, 0x00, 0x00, 0x56 });
            byte[] p42D = w42D.ToArray();
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(p42D, false);
            // remove mob(s) from room
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RemoveEntity(m, cli.GameAccount);
            // Combat done
            cli.GameAccount.CurrentCharacter.Cloud.Combatants.Clear();
            }
          break;
        #endregion
        #region 0x47 Shopkeeper screen
        case 0x47:
            {
            // Console.WriteLine("Start 0x47");
            byte[] t = Packet.DD(cli.GameAccount);
            cli.Send(ref t);
            // Console.WriteLine("Sent 0x47");
            }
          break;
        #endregion
        #region 0x4A Sell Item(s)
        case 0x4A:
            {
            // Removes the item and gives cash
            reader.ReadBytes(8);
            uint charid = reader.ReadUInt32();
            uint itemid = reader.ReadUInt32();
            reader.Close();
            //    Console.WriteLine("Char {0} wants to sell item {1}", charid, itemid);
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0x4A);
            w25.WriteInt32(750000); // how much gold to give
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);
            }
          break;
        #endregion
        #region 0x4B (Sell single item)
        case 0x4B:
            {
            // Drags item to shopkeeper to sell
            reader.ReadBytes(8);
            uint charid = reader.ReadUInt32();
            uint itemid = reader.ReadUInt32();
            reader.Close();
            //    Console.WriteLine("Char {0} wants to sell item {1}", charid, itemid);
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0x4B);
            w25.WriteInt32(75000); // money item is worth
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);
            }
          break;
        #endregion
        #region 0x4C Drop Gold or Mana
        case 0x4C:
            {
            // drop gold
            //    Console.WriteLine("Pak {0}", BitConverter.ToString(pak));
            reader.ReadBytes(8);
            int amt = reader.ReadInt32();
            byte type = reader.ReadByte();
            reader.Close();
            Console.WriteLine("{0} wants to drop {1} {2}.", cli.GameAccount.CurrentCharacter.Name, amt, type == 0 ? "Gold" : "Mana");

            uint id = ServerGlobals.GetNextAvailableID();

            PacketWriter w42A = new PacketWriter(0x2A);
            w42A.WriteUInt32(cli.GameAccount.AccountId);
            w42A.WriteUInt32(0x00);
            w42A.WriteUInt32(id);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42A.WriteByte(0x3F);
            w42A.WriteShort(0x22);
            w42A.WriteUInt32(0x00);
            w42A.WriteByte(0x01);
            if (type == 0)
              w42A.WriteShort(0x02);
            else
              w42A.WriteShort(0x03);
            w42A.WriteUInt32(id);
            w42A.WriteBytes(new byte[3]);
            w42A.WriteByte(0xFF);
            w42A.WriteByte(0x02);
            w42A.WriteInt32(amt);
            w42A.WriteByte(0x02);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42A.WriteShort(0xFD);
            w42A.WriteShort(0xD4);
            w42A.WriteUInt32(0x00);
            w42A.WriteShort(0x00);
            w42A.WriteShort(0x01);
            w42A.WriteByte(0xFF);
            byte[] pw42A = w42A.ToArray();
            cli.Send(ref pw42A);


            // now 25
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0x4C);
            w25.WriteUInt32(0x00);
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);


            // Now add the actual item to room
            PacketWriter w42B = new PacketWriter(0x2A);
            w42B.WriteUInt32(cli.GameAccount.AccountId);
            w42B.WriteUInt32(0x00);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42B.WriteByte(0x19);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42B.WriteInt32(amt);
            w42B.WriteUInt32(id);
            w42B.WriteByte(0xFF);
            byte[] pw42B = w42B.ToArray();
            cli.Send(ref pw42B);

            // Give icon back
            PacketWriter w42C = new PacketWriter(0x2A);
            w42C.WriteUInt32(cli.GameAccount.AccountId);
            w42C.WriteUInt32(0x00);
            w42C.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42C.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42C.WriteByte(0x21);
            w42C.WriteByte(0xFF);
            byte[] p42C = w42C.ToArray();
            cli.Send(ref p42C);

            }
          break;
        #endregion
        #region 0x4F Pick up gold or Mana
        case 0x4F:
            {
            Console.WriteLine("Pickup gold or mana {0}", BitConverter.ToString(pak));
            reader.ReadBytes(8);
            uint item = reader.ReadUInt32();
            reader.Close();
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0x4F);
            w25.WriteUInt32(0x00);
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);



            PacketWriter w42A = new PacketWriter(0x2A);
            w42A.WriteUInt32(cli.GameAccount.AccountId);
            w42A.WriteInt32(0);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42A.WriteByte(0x1C);
            //w42.WriteUInt32(cli.GameAccount.CurrentCharacter.CharId);
            w42A.WriteUInt32(item);
            // w42.WriteByte(0x21);
            w42A.WriteByte(0xFF);
            byte[] p42A = w42A.ToArray();
            cli.Send(ref p42A);

            // doesnt allow pickup if 42A isnt sent
            PacketWriter w42B = new PacketWriter(0x2A);
            w42B.WriteUInt32(cli.GameAccount.AccountId);
            w42B.WriteUInt32(0x00);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42B.WriteByte(0x21);
            w42B.WriteByte(0xFF);
            byte[] pw42B = w42B.ToArray();
            cli.Send(ref pw42B);

            }
          break;
        #endregion
        #region 0x50 spell casted 80 spells (Working but casts empower only)
        case 0x50:
            {
            // Somewhere we gotta send a location to do this on.
            ///     Console.WriteLine("Start 80");
            // teleport too from town teleporter
            // does he just use a spell ?
            // Spell Cast Packet
            reader.ReadBytes(4); // pck len
            reader.ReadBytes(4); // id
            short spellID = BitConverter.ToInt16(reader.ReadBytes(2), 0);
            uint caster = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            uint target = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            reader.Close();
            // First get the caster, it can be a player or a npc or a mob in the room


            Room r = cli.GameAccount.CurrentCharacter.Location.CurrentRoom;
            Entity _caster = r.GetEntityInRoom(caster);
            Entity _target = r.GetEntityInRoom(target);


            string spellName = string.Empty;
            Enum _spell = SpellConvertor.FromShort(spellID);

            if (_spell is BaseSpell.Elementalism) spellName = ((BaseSpell.Elementalism)_spell).ToString();
            if (_spell is BaseSpell.Mysticsim) spellName = ((BaseSpell.Mysticsim)_spell).ToString();
            if (_spell is BaseSpell.Necromancy) spellName = ((BaseSpell.Necromancy)_spell).ToString();
            if (_spell is BaseSpell.Sorcery) spellName = ((BaseSpell.Sorcery)_spell).ToString();
            if (_spell is BaseSpell.Thaumaturgy) spellName = ((BaseSpell.Thaumaturgy)_spell).ToString();

            if (_spell != null)
              {
              //Console.WriteLine("Casting Spell ID:{0} ({1}) {2} is casting on {3}.",
              // string.Format("0x{0}",spellID.ToString("X2")), spellName, caster, target);
              byte[] tp = Packet.CastSpell(spellID, SpellConvertor.SpellEffect(_spell),
                  _caster, _target);
              }
            else Console.WriteLine("Spell {0} not found.", spellID);
            // First reply is 25 to give cursor back


            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0);
            w25.WriteUInt32(0x50);
            w25.WriteBytes(new byte[] { 0xD3, 0x3B, 0x09, 0x08 });
            byte[] reply = w25.ToArray();
            cli.Send(ref reply);


            PacketWriter w2B = new PacketWriter(0x2A);
            w2B.WriteUInt32(cli.GameAccount.AccountId);
            w2B.WriteUInt32(0x00);
            w2B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w2B.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w2B.WriteByte(0x1D);
            w2B.WriteUInt32(caster);
            w2B.WriteByte(0x2C);
            w2B.WriteUInt32(caster);
            if (caster != target)
              w2B.WriteString(string.Format("{0} says 'SpellName', pointing at the {1}.", cli.GameAccount.CurrentCharacter.Name, target));
            else w2B.WriteString(string.Format("{0} mumbles 'SpellName', under {1} breath.", cli.GameAccount.CurrentCharacter.Name, cli.GameAccount.CurrentCharacter.Gender == 0 ? "his" : "her"));
            w2B.WriteByte(0x25); // end spell text 2A on other example ?
            w2B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w2B.WriteInt32(-1); // how much the spell costs
            w2B.WriteByte(0x27);
            w2B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w2B.WriteShort(SpellConvertor.SpellEffect(_spell));
            //w2B.WriteShort(331); // the spell graphic
            w2B.WriteUInt32(target);
            w2B.WriteByte(0x0E);
            w2B.WriteUInt32(target);
            w2B.WriteBytes(new byte[] { 0x27, 0x00, 0x01, 0x2C }); // still not sure
            w2B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w2B.WriteString("The spell does all sorts of stuff to you or an item here.");

            // so now, what does it do ?

            w2B.WriteByte(0x1F); // end spell info
            w2B.WriteUInt32(caster);
            w2B.WriteByte(0xFF);
            byte[] p2B = w2B.ToArray();
            r.SendPacket(p2B);
            //cli.Send(ref p2B);



            // Now next packet to gimme my icon back
            PacketWriter w2C = new PacketWriter(0x2A);
            w2C.WriteUInt32(cli.GameAccount.AccountId);
            w2C.WriteUInt32(0x00);
            w2C.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w2C.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w2C.WriteBytes(new byte[] { 0x21, 0xFF });
            byte[] p2C = w2C.ToArray();
            cli.Send(ref p2C);

            //Console.WriteLine("Packet 80 (Spell) answered {0}", BitConverter.ToString(pak));
            }
          break;
        #endregion
        #region 0x54 Debugging Information from last crash. (Completed)
        case 0x54:
            {
            Account a = cli.GameAccount;
            DebugInfo i = new DebugInfo(a, pak);

            if (!MySqlManager.SaveDebugInfo(i)) Console.WriteLine("Error Saving Debugging info to Mysql!!");

            PacketWriter w = new PacketWriter(0x19);
            w.WriteInt32(-1);
            w.WriteInt32(0);
            w.WriteInt32(0x54);
            byte[] f = w.ToArray();
            cli.Send(ref f);
            Console.WriteLine(Encoding.ASCII.GetString(pak));
            }
          break;
        #endregion
        #region 0x5C Log into last room (Completed)
        case 0x5C:
            {
            Console.WriteLine(BitConverter.ToString(pak));
            // Console.WriteLine("Start 0x5C");
            /* No need to read this packet, it doesnt contain
             * Any specfic info, just get the charname
             * and find out the last room they logged out
             * and the last locs, then send that.
             */
            // First time a room number is referenced,
            Character c = cli.GameAccount.CurrentCharacter;

            PacketWriter w = new PacketWriter(0x19);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteInt32(0);
            w.WriteInt32(0x5C);
            w.WriteInt32(0);
            // We just logged on, get the last room we were in
            // and the last x,y,facing and send it

            cli.GameAccount.CurrentCharacter.Location = new RoomLocation(5043, 150, 150, 2);
            w.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.RoomNumber); // Send the room
                                                                                 // Set chars room 
            w.WriteUShort(cli.GameAccount.CurrentCharacter.Location.X); // X
            w.WriteUShort(cli.GameAccount.CurrentCharacter.Location.Y); // Y
            w.WriteUShort(cli.GameAccount.CurrentCharacter.Location.Facing); // N/S/W/E 3/2/1/0
            c.Location = new RoomLocation(5043, 150, 150, 2);
            Room r = ScriptResolver.GetRoom(5043);
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom = r;
            w.WriteBytes(new byte[] { 0xC3, 0x28 });
            byte[] room = w.ToArray();
            cli.Send(ref room);
            // Send empty loc packet

            PacketWriter l = new PacketWriter(0x29);
            l.WriteUInt32(cli.GameAccount.AccountId);
            l.WriteUInt32(0x00);
            l.WriteUInt32(0x29);
            l.WriteUInt32(0x01);
            byte[] loc = l.ToArray();
            cli.Send(ref loc);
            }
          break;
        #endregion
        #region 0x5D Change Password
        case 0x5D: // Change Password
            {
            //Console.WriteLine("Change Password {0}", BitConverter.ToString(pak));
            reader.Close();
            PacketReader r = new PacketReader(pak);
            r.ReadBytes(8);
            uint id = r.ReadUInt32();
            string oldp = r.ReadString16();
            string newp = r.ReadString16();
            r.Close();

            bool match = cli.GameAccount.CurrentCharacter.GameID == id;

            Console.WriteLine("Original Password {0} changed to {1}, the charids {2} match.", oldp, newp, match ? "do" : "do not");
            PacketWriter w = new PacketWriter(0x19);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteUInt32(0x00);
            w.WriteUInt32(0x5D);
            w.WriteBytes(new byte[] { 0x7A, 0xDD, 0x08, 0x08 });
            byte[] a = w.ToArray();
            cli.Send(ref a);
            }
          break;
        #endregion
        #region 0x5E Teleport to house request ?
        case 0x5E:
            {
            //     Console.WriteLine("Start 0x5E");
            reader.ReadBytes(8);
            short len = reader.ReadInt16();
            string name = Encoding.ASCII.GetString(reader.ReadBytes(len));
            reader.Close();

            Console.WriteLine("Tele to home ? {0}", name);

            // Well, we need to get the players house here.


            PacketWriter w26A = new PacketWriter(0x1A);
            w26A.WriteUInt32(cli.GameAccount.AccountId);
            w26A.WriteUInt32(0x00);
            w26A.WriteUInt32(0x5E);
            w26A.WriteUInt32(10013);
            byte[] p26A = w26A.ToArray();
            cli.Send(ref p26A);


            PacketWriter w2A = new PacketWriter(0x2A);
            w2A.WriteUInt32(cli.GameAccount.AccountId);
            w2A.WriteUInt32(0x00);
            w2A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            // current room we are in
            w2A.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w2A.WriteByte(0x2A);
            w2A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w2A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w2A.WriteUInt32(5046); // the room to goto
            w2A.WriteByte(0xFF);
            byte[] p2A = w2A.ToArray();
            cli.Send(ref p2A);
            //  Console.WriteLine("Sent 0x5E");
            }
          break;
        #endregion
        #region 0x5F Enter Doors (FIX MEEEE)
        case 0x5F:
            {
            //   Console.WriteLine("Start 95");
            // Use a doorish item
            Console.WriteLine("Dungeon/Door  Enter Item Use: {0}", BitConverter.ToString(pak));
            Character c = cli.GameAccount.CurrentCharacter;
            reader.ReadBytes(8);
            // what item id was used ?
            uint itemID = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            reader.Close();
            // the id of the item, it is up to us to figure out where to go.

            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0x5F);
            w25.WriteUInt32(0x00);
            w25.WriteByte(0x1A);
            w25.WriteByte(0x01);
            // Where they come out in the room
            w25.WriteUShort(cli.GameAccount.CurrentCharacter.Location.X);
            w25.WriteByte(0x03);
            w25.WriteByte(0x15);
            w25.WriteByte(0x01);
            // then they wanna walk to here.
            w25.WriteUShort(cli.GameAccount.CurrentCharacter.Location.Y);
            w25.WriteByte(0x01);
            w25.WriteUInt32(5043); // the room to go

            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);
            Console.WriteLine("Sent 95");
            }
          break;
        #endregion
        #region 0x68 Npc Chat Dialog
        case 0x68:
            {
            //       Console.WriteLine("Start 0x68");
            reader.ReadBytes(8);
            uint npcId = reader.ReadUInt32();
            reader.Close();

            Console.WriteLine("Want NPC ID:{0}'s dialog.", npcId);

            byte[] npc = Packet.NPCDialog(cli.GameAccount);
            cli.Send(ref npc);
            //   Console.WriteLine("Sent 0x68");
            }
          break;
        case 0x69:
            {
            Console.WriteLine("Start 0x69");
            reader.ReadBytes(8);
            int dialogChoice = reader.ReadInt32();
            reader.Close();
            Console.WriteLine("We want option {0}", dialogChoice);

            PacketWriter w = new PacketWriter(0x19);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteInt32(0);
            w.WriteInt32(0x69);
            w.WriteInt32(0);
            w.WriteByte(0x01);
            w.WriteByte(0x05);
            w.WriteString("Not to sure what is going down.");

            w.WriteBytes(new byte[] { 0x00, 0x00, 0x00, 0x42 }); // not allow go on button
                                                                 // 0x00, 0x00, 0x0A, 0x1D allows go on.
            byte[] r = w.ToArray();
            cli.Send(ref r);
            Console.WriteLine("Start 0x69");
            }
          // More to go, go on button and prev page button 106/107
          break;
        #endregion
        #region 0x6E Quest Button
        case 0x6E:
            {
            //  Console.WriteLine("Quest button clicked");

            PacketWriter w = new PacketWriter(25);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteInt32(0);
            w.WriteInt32(0x6E);
            w.WriteInt32(0); // No Quests
            w.WriteInt32(0);

            byte[] reply = w.ToArray();
            cli.Send(ref reply);
            }
          break;
        #region 0x72 Whats New
        case 0x72:
            {
            PacketWriter w = new PacketWriter(0x72);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteInt32(0);
            w.WriteBytes(new byte[] { 0x01, 0x7F, 0x03, 0x0A });

            List<WhatsNewMessage> all = MySqlManager.GetWhatsNew("*");

            StringBuilder b = new StringBuilder();
            if (all.Count == 0)
              {
              b.Append("|c86|Welcome to your new realm emulator server, log in game and type /wn add 5 anymessage to remove this default What's New!.\n");
              }
            else
              {
              foreach (WhatsNewMessage m in all)
                b.Append(string.Format("|c{0}|{1} - written by {2} on {3}.\n", m.Color, m.Message, m.Author, m.TimeStamp));
              }

            w.WriteBytes(Encoding.ASCII.GetBytes(b.ToString()));
            while (w.Length % 4 != 0)
              {
              w.WriteByte(0x00);
              }
            byte[] reply = w.ToArray();
            cli.Send(ref reply);
            }
          break;
        #endregion
        #endregion
        #region 0x70 Combat Round
        case 0x70: //Combat round
            {
            reader.ReadBytes(8);
            byte action = reader.ReadByte();

            Console.WriteLine("Combat round {0} with {1} mobs in combat.",
                BitConverter.ToString(pak), cli.GameAccount.CurrentCharacter.Cloud.Combatants.Count);
            switch (action)
              {
              case 0:
                Console.WriteLine("Wants to move");
                break;
              case 1:
                Console.WriteLine("Attacked");
                break;
              case 2:
                Console.WriteLine("Guarded");
                break;
              case 4:
                Console.WriteLine("Flee");
                break;
              case 5:
                  {
                  short spellID = reader.ReadInt16();
                  uint caster = reader.ReadUInt32();
                  uint target = reader.ReadUInt32();
                  string spellName = string.Empty;
                  Enum _spell = SpellConvertor.FromShort(spellID);

                  if (_spell is BaseSpell.Elementalism) spellName = ((BaseSpell.Elementalism)_spell).ToString();
                  if (_spell is BaseSpell.Mysticsim) spellName = ((BaseSpell.Mysticsim)_spell).ToString();
                  if (_spell is BaseSpell.Necromancy) spellName = ((BaseSpell.Necromancy)_spell).ToString();
                  if (_spell is BaseSpell.Sorcery) spellName = ((BaseSpell.Sorcery)_spell).ToString();
                  if (_spell is BaseSpell.Thaumaturgy) spellName = ((BaseSpell.Thaumaturgy)_spell).ToString();

                  // if the spell is a aoe, loc info follows target (target is same as caster for aoe)
                  byte[] r = Packet.ChatPacket(1, 1, string.Format("Casting Spell {0} while in Combat!", spellName.ToUpper()), "Debug");
                  cli.Send(ref r);
                  }
                break;
              case 7:
                Console.WriteLine("Wants to charge");
                break;
              default:
                Console.WriteLine("Unk Action {0}", action);
                break;
              }
            reader.Close();
            PacketWriter w42 = new PacketWriter(0x2A);
            w42.WriteUInt32(cli.GameAccount.AccountId);
            w42.WriteUInt32(0x00);

            // Start with the cloud id
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID);
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42.WriteByte(0x12);
            // get the mob to move this round
            Mobile m = cli.GameAccount.CurrentCharacter.Cloud.Combatants[0];
            w42.WriteUInt32(m.GameID);
            // w42.WriteBytes(new byte[] { 0x14, 0x06, 0x12 });
            // w42.WriteUInt32(cli.GameAccount.CurrentCharacter.CharId);
            // w42.WriteBytes(new byte[] { 0x04, 0x06, 0x12 });
            //w42.WriteUInt32(m.GameID);
            // w42.WriteBytes(new byte[] { 0x11, 0x06, 0x12 });
            // w42.WriteUInt32(cli.GameAccount.CurrentCharacter.CharId);
            // w42.WriteBytes(new byte[] { 0x07, 0x06, 0x12 });
            // w42.WriteUInt32(m.GameID);
            // w42.WriteBytes(new byte[] { 0x0E, 0x06, 0x12 });
            //  w42.WriteUInt32(cli.GameAccount.CurrentCharacter.CharId);
            // w42.WriteBytes(new byte[] { 0x0A, 0x06, 0x12 });
            // w42.WriteUInt32(m.GameID);
            w42.WriteBytes(new byte[] { 0x07, 0x06, 0x11 });

            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42.WriteUInt32(m.GameID);
            w42.WriteBytes(new byte[] { 0x04, 0x1E });
            w42.WriteUInt32(m.GameID);
            // w42.WriteInt32(-5000); // how much u hit for
            Console.WriteLine("New hit");
            //w42.WriteInt32(0x00);
            int idmg = int.MinValue;
            w42.WriteInt32(idmg); // if we change this.
                                  //w42.WriteBytes(new byte[] { 0xC2, 0xFE, 0xFF, 0xFF});
            w42.WriteByte(0x00);
            w42.WriteByte(0x24);
            w42.WriteUInt32(m.GameID);
            w42.WriteByte(0x06);
            w42.WriteUInt32(m.GameID);
            w42.WriteBytes(new byte[] { 0xAC, 0x91, 0x00, 0x00, 0x2D });
            w42.WriteUInt32(m.GameID);
            string dmg = idmg.ToString();
            w42.WriteString(dmg); // the damage done in text
            w42.WriteByte(0x2C);
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42.WriteString("|c21|You totally |c15|demolish the fuck |c60|out of what you just bitch |c9|smacked, |c82|Man that |c67|totally |c38|freaked |c63|out |c109|out!");
            w42.WriteByte(0x23);
            w42.WriteUInt32(m.GameID);
            w42.WriteBytes(new byte[] { 0x0B, 0x02, 0x27, 0x01 }); // nothing i can see
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42.WriteByte(0x3C);
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID);
            w42.WriteByte(0x35); // crash
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID);
            w42.WriteByte(0x17); // crash
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42.WriteInt32(int.MaxValue); // exp gain or loss
            w42.WriteByte(0xFF);
            byte[] p42 = w42.ToArray();
            cli.Send(ref p42);
            }
          break;
        #endregion
        #region 0x74 Look At 116
        case 0x74:
            {
            //  Console.WriteLine("Start 116");
            reader.ReadBytes(4); // len
            reader.ReadBytes(4); // id
            uint charID = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            //   Console.WriteLine("Want to look at char id {0}: {1}", charID, BitConverter.ToString(pak));

            Entity e = null;
            if (cli.GameAccount.CurrentCharacter != null)
              {
              if (cli.GameAccount.CurrentCharacter.Location != null)
                {
                if (cli.GameAccount.CurrentCharacter.Location.CurrentRoom != null)
                  {
                  e = cli.GameAccount.CurrentCharacter.Location.CurrentRoom.GetEntityInRoom(charID);
                  }
                }
              }
            if (e == null)
              {
              // Must be looking at on screen 
              e = cli.GameAccount.GetCharFromGameID(charID);
              }
            if (e is Character)
              {
              Character c = e as Character;
              byte[] reply = c.CreateLookAt116(c.GameID);

              cli.Send(ref reply);
              }

            //done
            // Console.WriteLine("Sent 116");
            }
          break;
        #endregion
        #region 0x7e Shop sell
        case 0x7E: // shop sell
            {
            }
          break;
        case 0x7F: // 127 shop buy
            {
            Console.WriteLine("Shop buy {0}", BitConverter.ToString(pak));
            }
          break;
        //0x80
        #endregion
        #region 0x80 Shop sell screen
        case 0x80:
            {
            // Sell screen ?
            reader.ReadBytes(8);
            uint shopkeeperid = reader.ReadUInt32();
            reader.Close();
            Console.WriteLine("Using shopkeeper {0}", BitConverter.ToString(pak));

            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);

            w25.WriteInt32(-1);
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);

            }
          break;
        #endregion
        #region 0x81 Create Gossip Channel (Done)
        case 0x81:
            {
            // Creates a channel
            Character c = cli.GameAccount.CurrentCharacter;
            reader.ReadBytes(8);
            ushort newChannelNum = reader.ReadUInt16();
            ushort titleLength = reader.ReadUInt16();

            string title = Encoding.ASCII.GetString(reader.ReadBytes(titleLength)).CleanEncodedString();

            ushort topiclength = reader.ReadUInt16();

            string topic = Encoding.ASCII.GetString(reader.ReadBytes(topiclength)).CleanEncodedString();

            ushort passlength = reader.ReadUInt16();
            string password = Encoding.ASCII.GetString(reader.ReadBytes(passlength)).CleanEncodedString();
            reader.Close();

            // So check to make sure this channel number isnt already in use, 
            // if its not, then make the channel and add it
            var channel = Channel.FromCode(c.Name, newChannelNum.ToString(), title, topic, password);
            // add the player to the chanel

            ScriptResolver.ImportedChannels.AddChannel(channel);
            channel.SendJoinPacket(cli.GameAccount);
            cli.GameAccount.CurrentChannel = channel;
            }
          break;
        #endregion
        #region 0x82 Log In
        case 0x82:
            {
            // Login to game ?
            reader.ReadBytes(4); // len
            reader.ReadBytes(4); // id
            uint charID = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            Character c = cli.GameAccount.GetCharFromGameID(charID);
            if (c == null) Console.WriteLine("Null Char");
            cli.GameAccount.CurrentCharacter = c;
            c.GameMail = new MagicMail(cli.GameAccount);
            if (c.GameMail == null) Console.WriteLine("Null GameMail");

            byte[] reply = c.CreateLogin130(cli.GameAccount.AccountId);
            cli.Send(ref reply);

            // check busy
            PacketWriter busy = new PacketWriter(0x25);
            busy.WriteString("/unbusy");
            byte[] u = busy.ToArray();
            //cli.Send(ref u);

            // Join last gossip chan
            PacketWriter join = new PacketWriter(0x25);
            join.WriteString("/join 4");
            byte[] j = join.ToArray();
            // cli.Send(ref j);


            // Send Magic Mail
            ParseWorldPackets(cli, new byte[12], 0x87);
            //Console.WriteLine("Logging in {0}", BitConverter.ToString(pak));
            // Console.WriteLine("Sent 130");
            }
          break;
        #endregion
        #region 0x87 - 0x88 Magic Mail
        #region 0x87 Refresh Magic Mail
        case 0x87:
            {
            //  Console.WriteLine("Start 0x87");
            PacketWriter w = new PacketWriter(25);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteInt32(0);
            w.WriteInt32(0x87);
            w.WriteInt32(0);
            w.WriteShort(0);
            // get all mail from sql

            if (cli.GameAccount.CurrentCharacter.GameMail == null)
              cli.GameAccount.CurrentCharacter.GameMail = new MagicMail(cli.GameAccount);
            // Refresh mail
            cli.GameAccount.CurrentCharacter.GameMail.RefreshMail();

            if (cli.GameAccount.CurrentCharacter.GameMail.AllMail == null)
              cli.GameAccount.CurrentCharacter.GameMail.AllMail = new List<Mail>();
            // Console.WriteLine("{0} mails for char {1}", cli.GameAccount.CurrentCharacter.GameMail.AllMail.Count, cli.GameAccount.CurrentCharacter.CharId);
            w.WriteShort((short)cli.GameAccount.CurrentCharacter.GameMail.AllMail.Count);

            w.WriteByte(0x01); // start mail data

            if (cli.GameAccount == null) Console.WriteLine("Game acct null.");
            if (cli.GameAccount.CurrentCharacter == null) Console.WriteLine("Char is null");
            if (cli.GameAccount.CurrentCharacter.GameMail == null) Console.WriteLine("Mail Container null");
            if (cli.GameAccount.CurrentCharacter.GameMail.AllMail == null) Console.WriteLine("All mail is null");
            foreach (Mail m in cli.GameAccount.CurrentCharacter.GameMail.AllMail)
              {
              w.WriteInt32(m.MailID);
              w.WriteByte(0x00);
              w.WriteInt32(m.TimeStamp);
              byte[] subject = Encoding.ASCII.GetBytes(m.Subject);
              w.WriteShort((short)subject.Length);
              w.WriteBytes(subject);
              byte[] from = Encoding.ASCII.GetBytes(m.From);
              w.WriteShort((short)from.Length);
              w.WriteBytes(from);
              }

            w.WriteBytes(new byte[] { 0x00, 0x00, 0xFF });
            byte[] reply = w.ToArray();
            cli.Send(ref reply);
            // Console.WriteLine("Sent 0x87");
            }
          break;
        #endregion
        #region 0x8A Create Magic Mail
        case 0x8A:
            {
            //   Console.WriteLine("Start 0x8A");
            // Read the mail
            reader.ReadBytes(4); //len
            reader.ReadBytes(4); // id
            reader.ReadBytes(4); // act id
            reader.ReadByte(); // spacer
            int subLen = reader.ReadInt16();
            string subject = Encoding.ASCII.GetString(reader.ReadBytes(subLen));
            int bodyLen = reader.ReadInt16();
            string body = Encoding.ASCII.GetString(reader.ReadBytes(bodyLen));
            int fromLen = reader.ReadUInt16();
            string to = Encoding.ASCII.GetString(reader.ReadBytes(fromLen));
            reader.Close();

            // Parse to, if it has Name;name;name;name;
            // then try to send to all


            if (cli.GameAccount.CurrentCharacter.GameMail == null)
              cli.GameAccount.CurrentCharacter.GameMail = new MagicMail(cli.GameAccount);
            // Get the player we want to send too
            uint sqlid = 0;
            Mail m = null;
            if (MySqlManager.TryFindCharacter(to, out sqlid))
              {
              // Create the Mail
              m = new Mail();
              m.Body = body;
              m.From = cli.GameAccount.CurrentCharacter.Name;
              m.Subject = subject;
              m.TimeStamp = (int)MagicMail.DateTimeToUnixTimestamp(DateTime.Now);
              m.MailID = cli.GameAccount.CurrentCharacter.GameMail.NextMailID;
              //    Console.WriteLine("Next Mail Id is {0}", m.MailID);
              //Done.
              if (MySqlManager.WriteMail(m, sqlid))
                {
                PacketWriter w = new PacketWriter(0x19);
                w.WriteUInt32(cli.GameAccount.AccountId);
                w.WriteInt32(0);
                w.WriteShort(0x8A);
                w.WriteInt32(0);
                w.WriteInt32(m.MailID); // the mails ID

                byte[] reply = w.ToArray();
                cli.Send(ref reply);
                }
              else
                {
                log.LogMessage(string.Format("Unable to write Magic Mail from {0} to {1}, to the database.", cli.GameAccount.CurrentCharacter.Name, to), MessageType.Error);
                }

              }
            else
              {
              PacketWriter w = new PacketWriter(0x1A);
              w.WriteUInt32(cli.GameAccount.AccountId);
              w.WriteInt32(0);
              w.WriteInt32(0x87);
              w.WriteBytes(new byte[] { 0x14, 0x27 });
              w.WriteShort(0);
              byte[] reply = w.ToArray();

              PacketWriter w1 = new PacketWriter(0x1A);
              w1.WriteUInt32(cli.GameAccount.AccountId);
              w1.WriteInt32(0);
              w1.WriteInt32(0x8A);
              w1.WriteInt32(0);
              byte[] msg = Encoding.ASCII.GetBytes(string.Format("Player {0} not found, unable to send magic mail.", to));
              w1.WriteShort((short)msg.Length);
              w1.WriteBytes(msg);
              w1.WriteShort(0);
              w1.WriteBytes(new byte[] { 0x00, 0xA8 });
              byte[] reply2 = w1.ToArray();

              cli.Send(ref reply);
              cli.Send(ref reply2);
              }
            //Console.WriteLine("Sent 0x8A");
            }
          break;
        #endregion
        #region 0x89 Delete Magic Mail
        case 0x89:
            {
            //    Console.WriteLine("Start 0x89");
            reader.ReadBytes(4);
            reader.ReadBytes(4);
            int id = reader.ReadInt32();
            reader.Close();

            if (MySqlManager.DeleteMail(cli.GameAccount.CurrentCharacter.SqlCharId, id))
              {
              PacketWriter w = new PacketWriter(0x19);
              w.WriteUInt32(cli.GameAccount.AccountId);
              w.WriteInt32(0);
              w.WriteInt32(0x89);
              w.WriteInt32(0);
              w.WriteInt32(id);
              w.WriteBytes(new byte[] { 0x00, 0x12, 0x00, 0x01 });
              byte[] reply = w.ToArray();
              cli.Send(ref reply);
              }
            else
              {
              PacketWriter w = new PacketWriter(0x1A);
              w.WriteUInt32(cli.GameAccount.AccountId);
              w.WriteInt32(0);
              w.WriteInt32(0x87);
              w.WriteBytes(new byte[] { 0x14, 0x27 });
              w.WriteShort(0);
              byte[] reply = w.ToArray();

              PacketWriter w1 = new PacketWriter(0x1A);
              w1.WriteUInt32(cli.GameAccount.AccountId);
              w1.WriteInt32(0);
              w1.WriteInt32(0x8A);
              w1.WriteInt32(0);
              byte[] msg = Encoding.ASCII.GetBytes(string.Format("Unable to delete email {0}, please refresh and try again.", id));
              w1.WriteShort((short)msg.Length);
              w1.WriteBytes(msg);
              w1.WriteShort(0);
              w1.WriteBytes(new byte[] { 0x00, 0xA8 });
              byte[] reply2 = w1.ToArray();

              cli.Send(ref reply);
              cli.Send(ref reply2);
              }
            //    Console.WriteLine("Sent 0x89");
            }
          break;
        #endregion
        #region 0x88 Read Magic Mail
        case 0x88:
            {
            //      Console.WriteLine("Start 0x88");
            reader.ReadBytes(8);
            int id = reader.ReadInt32();
            reader.Close();


            Mail mm = MySqlManager.ReadMail(cli.GameAccount, id);

            if (mm != null)
              {
              PacketWriter w = new PacketWriter(0x19);
              w.WriteUInt32(cli.GameAccount.AccountId);
              w.WriteInt32(0);
              w.WriteInt32(0x88);
              w.WriteInt32(0);
              byte[] body = Encoding.ASCII.GetBytes(mm.Body);
              w.WriteShort((short)body.Length);
              w.WriteBytes(body);
              w.WriteByte(0x01);
              w.WriteByte(0x01);
              byte[] from = Encoding.ASCII.GetBytes(mm.From);
              w.WriteShort((short)from.Length);
              w.WriteBytes(from);
              w.WriteByte(0x00);
              w.WriteBytes(new byte[] { 0x00, 0x10, 0x89, 0x05 });
              byte[] reply = w.ToArray();
              cli.Send(ref reply);
              }
            else
              {
              PacketWriter w = new PacketWriter(0x1A);
              w.WriteUInt32(cli.GameAccount.AccountId);
              w.WriteInt32(0);
              w.WriteInt32(0x87);
              w.WriteBytes(new byte[] { 0x14, 0x27 });
              w.WriteShort(0);
              byte[] reply = w.ToArray();

              PacketWriter w1 = new PacketWriter(0x1A);
              w1.WriteUInt32(cli.GameAccount.AccountId);
              w1.WriteInt32(0);
              w1.WriteInt32(0x8A);
              w1.WriteInt32(0);
              byte[] msg = Encoding.ASCII.GetBytes(string.Format("Unable to read email {0}, please refresh and try again.", id));
              w1.WriteShort((short)msg.Length);
              w1.WriteBytes(msg);
              w1.WriteShort(0);
              w1.WriteBytes(new byte[] { 0x00, 0xA8 });
              byte[] reply2 = w1.ToArray();

              cli.Send(ref reply);
              cli.Send(ref reply2);
              }
            //    Console.WriteLine("Sent 0x88");
            }
          break;
        #endregion
        #endregion
        #region 0x91 Spell effect
        case 0x91: // 145 (Spell effect ?)
            {
            //Console.WriteLine("0x91 {0}", BitConverter.ToString(pak));
            PacketWriter w = new PacketWriter(0x2A);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteUInt32(0x00);
            w.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w.WriteBytes(new byte[] { 0x21, 0xFF, 0x00, 0x00 });
            byte[] pw = w.ToArray();
            cli.Send(ref pw);
            }
          break;
        #endregion
        #region 0x96 Put item into inventory
        case 0x96: // Put item into inventory
            {
            Console.WriteLine("Packet 150 Pickup Item: {0}", BitConverter.ToString(pak));
            Character c = cli.GameAccount.CurrentCharacter;
            reader.ReadBytes(8);
            uint itemNum = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            reader.Close();
            // So it can be in room, or in a backpack
            BaseGameItem i = null;
            foreach (BaseGameItem item in cli.GameAccount.CurrentCharacter.Location.CurrentRoom.Items)
              {
              if (item.GameID == itemNum) i = item;
              }
            // ok check our inventory if still null
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteInt32(0);
            w25.WriteInt32(0x96); // replying to pack 96 pickup
            w25.WriteInt32(0);
            byte[] p25 = w25.ToArray();

            if (i == null)
              {
              foreach (BaseGameItem item in cli.GameAccount.CurrentCharacter.Inventory)
                {
                if (item.GameID == itemNum) i = item;
                }

              }
            if (i == null)
              {
              Console.WriteLine("Cant find item {0}", itemNum);
              cli.Send(ref p25);
              return;
              }


            cli.Send(ref p25);

            // Cannot pick it up until i know exactly how it is formatted
            PacketWriter w42 = new PacketWriter(0x2A);
            w42.WriteUInt32(cli.GameAccount.AccountId);
            w42.WriteInt32(0);
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42.WriteByte(0x05);
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42.WriteUInt32(itemNum);
            w42.WriteByte(0x21);
            w42.WriteByte(0xFF);
            byte[] qr = w42.ToArray();
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(qr, false);
            // try to remove it from room if able
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RemoveEntity(i, cli.GameAccount);
            // add it to current inventory list
            cli.GameAccount.CurrentCharacter.AddInventoryItem(i);
            i.RemoveFromRoom();

            //TODO: Should we save the item now ?
            // if not rollbacks will occur if client crashes or handles.

            bool save = MySqlManager.SaveItem(cli.GameAccount.CurrentCharacter.SqlCharId, i);
            //cli.Send(ref qr);
            Console.WriteLine("Sent 150");
            }
          break;
        #endregion
        #region 0x97 Drop item
        case 151:
            {
            Console.WriteLine("Packet 151 Drop Item: {0}", BitConverter.ToString(pak));
            reader.ReadBytes(8);
            Character c = cli.GameAccount.CurrentCharacter;

            uint itemNum = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            reader.Close();



            // This all needs redone.



            //cli.GameAccount.CurrentCharacter.Location.CurrentRoom.DropItemInRoom(cli.GameAccount, itemNum);//SendPacket(reply42);

            BaseGameItem item = cli.GameAccount.CurrentCharacter.GetInventoryItem(itemNum);
            cli.GameAccount.CurrentCharacter.RemoveInventoryItem(item);
            // add it to room, this may crash loading now.
            Console.WriteLine("Trying to add item to room via addentity");
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.AddEntity(item, cli.GameAccount);


            // Get item from inventory
            // Now the packet 42 that does the dropping
            // item wrap
            PacketWriter w42A = new PacketWriter(0x2A);
            w42A.WriteUInt32(cli.GameAccount.AccountId);
            w42A.WriteUInt32(0x00);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42A.WriteByte(0x3F);
            w42A.WriteBytes(Packet.WrappedItem(cli.GameAccount, item));
            byte[] drop = w42A.ToArray();
            //cli.Send(ref drop);

            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(drop);
            // Asign item to rom
            item.AssignToRoom(cli.GameAccount.CurrentCharacter.Location);

            string fileLocation = Path.Combine(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location), "dropitem.txt");
            File.WriteAllText(fileLocation, BitConverter.ToString(drop));

            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteInt32(0x00);
            w25.WriteInt32(0x97);
            w25.WriteBytes(new byte[] { 0x65, 0x25, 0x05, 0x08 });
            byte[] reply25 = w25.ToArray();
            cli.Send(ref reply25);

            // Remove it from inventory
            //  bool rem = MySqlManager.DeleteItem(item.SqlID);


            PacketWriter w42B = new PacketWriter(0x2A);
            w42B.WriteUInt32(cli.GameAccount.AccountId);
            w42B.WriteUInt32(0x00);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42B.WriteByte(0x06);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42B.WriteUInt32(item.GameID);
            w42B.WriteByte(0x21);
            w42B.WriteByte(0xFF);
            byte[] p42B = w42B.ToArray();
            //cli.Send(ref p42B);
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(p42B);
            //cli.GameAccount.CurrentCharacter.Location.CurrentRoom.DropItemInRoom(cli.GameAccount, item.CurrentGameID);

            //  if (!rem) log.LogMessage(
            //    string.Format("Unable to remove item {0} from char {1}", itemNum, cli.GameAccount.SqlId), MessageType.Error);
            Console.WriteLine("Sent 151");

            }
          break;
        #endregion
        #region 0x98 Put item in container
        case 0x98: // put item in container
            {
            Console.WriteLine("Put item in container {0}", BitConverter.ToString(pak));
            reader.ReadBytes(8);
            uint container = reader.ReadUInt32();
            uint item = reader.ReadUInt32();
            reader.Close();
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0x98);
            w25.WriteBytes(new byte[] { 0x65, 0x25, 0x05, 0x08 });
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);

            PacketWriter w42A = new PacketWriter(0x2A);
            w42A.WriteUInt32(cli.GameAccount.AccountId);
            w42A.WriteUInt32(0x00);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42A.WriteByte(0x09);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            // item thats going in
            w42A.WriteUInt32(item);
            // into this container
            w42A.WriteUInt32(container);
            w42A.WriteByte(0x21);
            w42A.WriteByte(0xFF);
            byte[] p42A = w42A.ToArray();
            cli.Send(ref p42A);
            }
          break;
        #endregion
        #region 0x99 Equip Item
        case 0x99:
            {
            // This equips a item
            //      Console.WriteLine("Packet 153 Equip Item: {0}", BitConverter.ToString(pak));
            reader.ReadBytes(4); // len
            reader.ReadBytes(4); //id
                                 // byte[] bslotId = reader.ReadBytes(4);
            uint slotId = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            Character c = cli.GameAccount.CurrentCharacter;
            // send 25
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0);
            w25.WriteUInt32(0x99);
            w25.WriteBytes(new byte[] { 0x65, 0x25, 0x05, 0x08 });
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);

            BaseGameItem b = cli.GameAccount.CurrentCharacter.GetInventoryItem(slotId);

            byte[] r = Packet.ChatPacket(1, 1,
                  string.Format("You equiped {0}", b.EquipableSlot), "Equip");
            cli.Send(ref r);

            if (!cli.GameAccount.CurrentCharacter.IsMob)
              {

              // You have a different packet than room for this
              PacketWriter w42 = new PacketWriter(0x2A);
              w42.WriteUInt32(cli.GameAccount.AccountId);
              w42.WriteInt32(0);
              w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
              w42.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
              w42.WriteByte(0x07);
              w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
              w42.WriteUInt32(slotId);
              w42.WriteByte(0x2F);
              w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
              w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);

              // These are item stats  ? figure them out
              //w42.WriteBytes(new byte[] { 0x2D, 0x00, 0x00, 0x00, 0x21, 0xFF });
              // sets max hp, use the chars current if no change
              w42.WriteUInt32((uint)cli.GameAccount.CurrentCharacter.TotalHP);

              w42.WriteBytes(new byte[] { 0x21, 0xFF });
              //w42.WriteBytes(new byte[] { 0x00, 0x12 }); // not sure
              //w42.WriteBytes(new byte[] { 0xA1, 0xF3 });
              w42.WriteBytes(new byte[4]);
              byte[] p42 = w42.ToArray();
              cli.Send(ref p42);
              // Now send to room
              cli.GameAccount.CurrentCharacter.Location.CurrentRoom.EquipItemInRoom(cli.GameAccount, slotId);
              }
            else
              {
              byte[] reply = Packet.ChatPacket(1, 1, "You have no need for weapons or armor in that form.", "Info");
              cli.Send(ref reply);
              PacketWriter w42 = new PacketWriter(0x2A);
              w42.WriteUInt32(cli.GameAccount.AccountId);
              w42.WriteInt32(0);
              w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
              w42.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
              w42.WriteByte(0x08);
              w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
              w42.WriteUInt32(slotId);
              w42.WriteByte(0x2F);
              w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
              w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);

              // These are item stats  ? figure them out
              //w42.WriteBytes(new byte[] { 0x2D, 0x00, 0x00, 0x00, 0x21, 0xFF });
              // sets max hp, use the chars current if no change
              w42.WriteUInt32((uint)cli.GameAccount.CurrentCharacter.TotalHP);

              w42.WriteBytes(new byte[] { 0x21, 0xFF });
              //w42.WriteBytes(new byte[] { 0x00, 0x12 }); // not sure
              //w42.WriteBytes(new byte[] { 0xA1, 0xF3 });
              w42.WriteBytes(new byte[4]);
              byte[] p42 = w42.ToArray();
              cli.Send(ref p42);
              }
            }
          break;
        #endregion
        #region 0x9A Unequip Item (Works for all players)
        case 0x9A:
            {
            // Unequip a item
            //      Console.WriteLine("Packet 154 Unequip Item: {0}", BitConverter.ToString(pak));
            reader.ReadBytes(4); // len
            reader.ReadBytes(4); //id
            byte[] bslotId = reader.ReadBytes(4);
            uint slotId = BitConverter.ToUInt32(bslotId, 0);
            Character c = cli.GameAccount.CurrentCharacter;
            // Starts with packet 25
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0);
            w25.WriteUInt32(0x9A);
            w25.WriteBytes(new byte[] { 0x65, 0x25, 0x05, 0x08 });
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);
            BaseGameItem b = cli.GameAccount.CurrentCharacter.GetInventoryItem(slotId);



            byte[] reply = Packet.ChatPacket(1, 1,
                  string.Format("You Unequiped {0}", b.EquipableSlot), "Unequip");
            cli.Send(ref reply);
            //Item i = Managers.MySqlManager.GetItem(cli.GameAccount.CurrentCharacter.SqlCharId, slotId);

            // if (i == null) Console.WriteLine("Fuck bad item grab, wanted {0} for charid {1}.", slotId, cli.GameAccount.CurrentCharacter.SqlCharId);
            cli.GameAccount.CurrentCharacter.Location
                .CurrentRoom.UnequipItemInRoom(cli.GameAccount, slotId);//Packet.UnequipItem(cli.GameAccount, i);
            }
          break;
        #endregion
        #region 0x9B Open Doors / Chests
        case 0x9B: //Open Doors
            {
            ////////////////////////////
            /////////////////////
            // FIXX all id uint now
            Character c = cli.GameAccount.CurrentCharacter;

            // We open doors
            Console.WriteLine("Open door packet 155: {0}", BitConverter.ToString(pak));
            reader.ReadBytes(8); // pck length and id
                                 // the door id ?
            uint itemid = BitConverter.ToUInt32(reader.ReadBytes(4), 0);
            // ushort itemid = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            // reader.ReadUInt16();
            reader.ReadInt32();
            int passwordProtectedItem = reader.ReadByte(); // is this byte FF ?
            string passWord = string.Empty;
            if (passwordProtectedItem == 255)
              {
              // We have a password
              // So we must have more bytes, lets check
              if (reader.HasXBytesLeft(2))
                {
                // see if it ends up being a password length
                ushort passwordLen = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
                if (reader.HasXBytesLeft(passwordLen))
                  {
                  passWord = Encoding.ASCII.GetString(reader.ReadBytes(passwordLen));
                  }
                }
              }

            // Do we have a password ?
            if (passWord != string.Empty)
              {
              byte[] bad = { 0x23, 0x27, 0x00, 0x00 };
              //byte[] bad = { 0x21, 0x27, 0x00, 0x00 };
              // Ya
              Console.WriteLine("We are a password item, password is: {0}", passWord);

              if (passWord != "1234")
                {
                PacketWriter w1A = new PacketWriter(0x1A);
                w1A.WriteUInt32(cli.GameAccount.AccountId);
                w1A.WriteUInt32(0x00);
                w1A.WriteUInt32(0x9B);
                w1A.WriteBytes(bad);
                byte[] p1A = w1A.ToArray();
                cli.Send(ref p1A);

                }
              else
                {
                /// Fake password chk pass is 1234
                // reply
                PacketWriter w1 = new PacketWriter(0x19);
                w1.WriteUInt32(cli.GameAccount.AccountId);
                w1.WriteInt32(0x00);
                w1.WriteInt32(0x9B);
                w1.WriteBytes(new byte[] { 0xF8, 0x8A, 0xFF, 0xBF });
                byte[] reply25 = w1.ToArray();
                cli.Send(ref reply25);

                PacketWriter w = new PacketWriter(42);
                w.WriteUInt32(cli.GameAccount.AccountId);
                w.WriteInt32(2);
                w.WriteUInt32(c.GameID);
                w.WriteUInt32(c.Location.CurrentRoom.RoomID);
                w.WriteByte(0x0A);// room num
                                  //0xB8, 0x3F, 
                w.WriteUInt32(c.GameID);
                w.WriteUInt32(itemid);
                //0xE6, 0x2B, // chest 
                w.WriteBytes(new byte[] { 0x21, 0xFF, 0x00 });
                //w.WriteBytes(new byte[] { 0x02, 0x00, 0x21, 0xFF, 0x00 });
                byte[] reply42 = w.ToArray();
                cli.Send(ref reply42);
                }
              }
            else
              {
              // Its just a item to open
              Console.WriteLine("We are a useable item like a door.");
              // reply

              // get the item, its a door
              foreach (BaseGameItem i in cli.GameAccount.CurrentCharacter.Location.CurrentRoom.Items)
                {
                if (i is Door && i.GameID == itemid)
                  {
                  Door d = i as Door;
                  if (d.IsLocked)
                    {
                    // Door is locked bish !!! go away !! baiting !
                    PacketWriter w25 = new PacketWriter(0x1A);
                    w25.WriteUInt32(cli.GameAccount.AccountId);
                    w25.WriteUInt32(0x00);
                    w25.WriteUInt32(0x9B);
                    // byte[] say = GetByteArrayFromFileInBaseDir("notodoor.txt");
                    // w25.WriteBytes(say);
                    w25.WriteBytes(new byte[] { 0x14, 0x27, 0x00, 0x00 });
                    byte[] pno = w25.ToArray();
                    cli.Send(ref pno);
                    }
                  else
                    {
                    // otherwize set open to the opposite of what it is.
                    if (d.IsOpen == false) d.IsOpen = true;
                    else d.IsOpen = false;

                    byte[] reply25 = Packet.ReplyWith25(cli.GameAccount.AccountId, 155,
                        new byte[] { 0x0A, 0xE3, 0x11, 0x08 });
                    cli.Send(ref reply25);
                    //roomwide
                    byte[] reply42 = Packet.OpenDoor42(cli.GameAccount, itemid);
                    //cli.Send(ref reply42);
                    cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(reply42);
                    }
                  }
                }
              }
            reader.Close();

            }
          break;
        #endregion
        #region 0x9c Close Item
        case 156:
            {
            Console.WriteLine("Close Item packet 156 (Close Items): {0}", BitConverter.ToString(pak));
            Character c = cli.GameAccount.CurrentCharacter;
            reader.ReadBytes(8); // pck length and id
                                 // the door id ?
            uint itemid = BitConverter.ToUInt16(reader.ReadBytes(4), 0);

            reader.Close();
            byte[] reply25 = Packet.ReplyWith25(cli.GameAccount.AccountId, 156,
                new byte[] { 0x02, 0x00, 0x21, 0xFF, 0x00 });
            cli.Send(ref reply25);
            PacketWriter w = new PacketWriter(42);
            w.WriteUInt32(cli.GameAccount.AccountId);
            w.WriteInt32(0);
            w.WriteUInt32(c.GameID);
            w.WriteUInt32(c.Location.CurrentRoom.RoomID);
            w.WriteByte(0x0B);
            w.WriteUInt32(c.GameID);
            w.WriteUInt32(itemid);
            w.WriteBytes(new byte[] { 0x21, 0xFF, 0x00, });
            byte[] reply42 = w.ToRealmPacket();
            foreach (BaseGameItem i in cli.GameAccount.CurrentCharacter.Location.CurrentRoom.Items)
              {
              if (i is Door && i.GameID == itemid)
                {
                Door d = i as Door;
                if (d.IsOpen == false)
                  d.IsOpen = true;
                else d.IsOpen = false;
                }
              }
            cli.Send(ref reply42);
            }
          break;
        #endregion
        #region 0xA0 Start Fight
        case 0xA0: //160 Fight
            {
            reader.ReadBytes(8);
            uint mob = reader.ReadUInt32();
            reader.ReadInt32(); // all FF or -1
            reader.ReadByte(); // 1 more ff
            ushort mobX = reader.ReadUInt16();
            ushort mobY = reader.ReadUInt16();
            ushort mobFace = reader.ReadUInt16();
            reader.Close();
            Console.WriteLine("Fight at X:{0} Y:{1} Face:{2}", mobX, mobY, mobFace);
            Mobile m = new Mobile();
            m.GameID = mob;
            m.Location = new RoomLocation(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID, mobX, mobY, mobFace);
            m.Location.CurrentRoom = cli.GameAccount.CurrentCharacter.Location.CurrentRoom;

            #region Combat Cloud Init
            // create the cloud
            uint id = 0;
            if (cli.GameAccount.CurrentCharacter.Cloud == null)
              {
              cli.GameAccount.CurrentCharacter.Cloud = new CombatCloud();
              cli.GameAccount.CurrentCharacter.Cloud.CloudOwner = cli.GameAccount;
              }
            // add mob to cloud
            cli.GameAccount.CurrentCharacter.Cloud.AddCombatant(m);
            byte[] cl = cli.GameAccount.CurrentCharacter.Cloud.Serialize(out id);
            #endregion
            #region Create Combat Cloud (roompacket)
            PacketWriter cloud = new PacketWriter(0x2A);
            cloud.WriteUInt32(cli.GameAccount.AccountId);
            cloud.WriteUInt32(0x00);
            cloud.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID);
            cloud.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            cloud.WriteBytes(cl);
            byte[] pcloud = cloud.ToArray();
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(pcloud);

            #endregion
            #region Send 25 (Not room)
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0xA0);
            w25.WriteUInt32(0x00);
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);
            #endregion
            #region Put us in cloud (roompacket)
            // Now put us in it
            PacketWriter w42A = new PacketWriter(0x2A);
            w42A.WriteUInt32(cli.GameAccount.AccountId);
            w42A.WriteUInt32(0x00);
            // the player to put in it (he who jumped ?)
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42A.WriteByte(0x14); // says next is screen background (left side combatants ?)
            w42A.WriteShort((short)cli.GameAccount.CurrentCharacter.Location.CurrentRoom.Background);
            // the trees on screen, some random way ushort fits with no errors
            w42A.WriteBytes(new byte[] { 0xFF, 0xFF });
            w42A.WriteByte(0x01);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            // Controlls where on left side the player/mob is
            w42A.WriteByte(0x01); //<---> of left side
            w42A.WriteByte(0x06); // N/S position

            w42A.WriteByte(0x01); // dunno
            w42A.WriteUInt32(mob); // the mob id
                                   // Mob postion ?
            w42A.WriteByte(0x17); //<---> of right side
            w42A.WriteByte(0x06); // N/S position

            w42A.WriteBytes(new byte[] { 0x0B, 0x02, 0x27 }); // cant detect a change
                                                              //w42A.WriteBytes(new byte[] { 0x17, 0x06, 0x0B, 0x02, 0x27 });
            w42A.WriteByte(0x01);
            w42A.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID); // the cloud to put em in
            w42A.WriteByte(0x00);
            w42A.WriteByte(0x15);
            w42A.WriteUInt32(mob);
            w42A.WriteByte(0x21);
            w42A.WriteByte(0xFF);
            byte[] p42A = w42A.ToArray();
            cli.GameAccount.CurrentCharacter.Location.CurrentRoom.SendPacket(p42A);
            #endregion
            #region Init the Cloud (No Room)
            // We are in the cloud now
            PacketWriter w42B = new PacketWriter(0x2A);
            w42B.WriteUInt32(cli.GameAccount.AccountId);
            w42B.WriteUInt32(0x00);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42B.WriteByte(0x15);
            w42B.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42B.WriteUInt32(0xFF);
            w42B.WriteUInt32(0x00);
            byte[] p42B = w42B.ToArray();
            cli.Send(ref p42B);
            #endregion
            #region Begin Combat (Non Room)
            // Start combat
            PacketWriter w42C = new PacketWriter(0x2A);
            w42C.WriteUInt32(cli.GameAccount.AccountId);
            w42C.WriteUInt32(0x00);
            // init the cloud
            w42C.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID);
            w42C.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42C.WriteByte(0x35);
            w42C.WriteUInt32(cli.GameAccount.CurrentCharacter.Cloud.GameID);
            w42C.WriteByte(0xFF);
            byte[] p42C = w42C.ToArray();
            cli.Send(ref p42C);
            #endregion
            }
          break;
        #endregion
        #region 0xA1 Receive item
        case 161:
            {
            // Item Use
            Console.WriteLine("Received a item use packet 161: {0}", BitConverter.ToString(pak));
            reader.ReadBytes(4);
            reader.ReadBytes(4);
            // this is the item they used, or more specifically the slot in inventory
            // thats being accessed because we should already know what item is there.
            ushort itemSlot = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            reader.Close();
            Character c = cli.GameAccount.CurrentCharacter;

            byte[] pck25 = UseItemPacket25(cli.GameAccount.AccountId);
            cli.Send(ref pck25);
            byte[] pck42 = UseItemPacket42(cli.GameAccount, itemSlot);
            cli.Send(ref pck42);
            }
          break;
        #endregion
        #region 0xA4 Give item
        case 0xA4: // 164
            {
            // looks like it sends the same packet 42 twice (Confirmed)
            // then sends  the packet 25
            // then sends a packet 42 looks like a update, with the id of person we gave too
            reader.ReadBytes(8);
            uint givee = reader.ReadUInt32();
            uint item = reader.ReadUInt32();
            reader.Close();
            Console.WriteLine("Give packet {0}", BitConverter.ToString(pak));
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0xA4);
            w25.WriteBytes(new byte[] { 0x65, 0x25, 0x05, 0x08 });
            byte[] p25 = w25.ToArray();
            }
          break;
        #endregion
        #region 0xA5 Use item / book
        case 0xA5: //165
            {
            Console.WriteLine("Use a item or a book ? {0}", BitConverter.ToString(pak));
            reader.ReadBytes(8);
            uint itemid = reader.ReadUInt32();
            reader.Close();
            Console.WriteLine("Wanting to use inventory item {0}", itemid);
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0xA5);
            w25.WriteBytes(new byte[] { 0x88, 0x86, 0x4A, 0x0C });
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);
            // this has to destroy a item
            PacketWriter w42 = new PacketWriter(0x2A);
            w42.WriteUInt32(cli.GameAccount.AccountId);
            w42.WriteUInt32(0x00);
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.Location.CurrentRoom.RoomID);
            w42.WriteByte(0x32);
            w42.WriteUInt32(cli.GameAccount.CurrentCharacter.GameID);
            w42.WriteUInt32(itemid);
            w42.WriteShort(0x1C);
            w42.WriteByte(0xFF);
            w42.WriteByte(0xFF);
            w42.WriteByte(0x21);
            w42.WriteByte(0xFF);
            byte[] p42 = w42.ToArray();
            cli.Send(ref p42);
            }
          break;
        #endregion
        #region 0xA7 UNKNOWN-- TODO:
        case 0xA7: //??
            {
            // we dont know but the packet 25 is
            PacketWriter w25 = new PacketWriter(0x19);
            w25.WriteUInt32(cli.GameAccount.AccountId);
            w25.WriteUInt32(0x00);
            w25.WriteUInt32(0xA7);
            w25.WriteBytes(new byte[] { 0x58, 0x23, 0x05, 0x08 });
            byte[] p25 = w25.ToArray();
            cli.Send(ref p25);
            }
          break;
        case 0xA9: //169
            {

            Console.WriteLine("Dye packet ? {0}", BitConverter.ToString(pak));
            PacketWriter w = new PacketWriter(0x19);
            w.WriteUInt32(0);
            w.WriteUInt32(0xA9);
            w.WriteBytes(new byte[] { 0x58, 0x23, 0x05, 0x08 });
            byte[] reply = w.ToArray();
            cli.Send(ref reply);

            }
          break;
        #endregion
        #region Personal Packets
        // will user large id's here, so not to interfere with the game
        // starts with 230
        case 0xE6:
            {
            // Router wants to know how many players are on
            PacketWriter w = new PacketWriter(0xE6);
            w.WriteString(ServerGlobals.LoggedInAccounts.Count.ToString());
            byte[] reply = w.ToArray();
            //Console.WriteLine("Router from {0} requested player count.", cli.TcpSocket.LocalEndPoint);
            cli.Send(ref reply);
            }
          break;

        #endregion
        default:
            {
            Console.WriteLine("WorldServer::Unknown Packet ID ({0})", pid);
            Console.WriteLine(BitConverter.ToString(pak));
            }
          break;
        }
      }
    public static byte[] GetByteArrayFromFile(string fileLocation)
      {
      byte[] reply = new byte[] { 0x10, 0x00, 0x00, 0x00, 0x12, 0x00, 0x00, 0x00, 0x83, 0x0F, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0x00, 0x00, 0x00, 0x00 };
      string data = string.Empty;
      // If our file is bad return blank charlist
      if (!File.Exists(fileLocation))
        {
        Console.WriteLine("No File at {0}", fileLocation);
        return reply;
        }
      // Try to load the file, if we fail return blank
      try { data = File.ReadAllText(fileLocation); }
      catch (Exception ex) { Console.WriteLine(ex.Message); return reply; }
      //Console.WriteLine(data);
      // Ok is going to be alot of extra comments and crap
      // So we ignore all else, except those with 0x in front, those we convert and add
      List<byte> b = new List<byte>();
      int index = 0;
      while (data.Length != 0)
        {
        if ((index = data.IndexOf("0x")) == 0) { break; }
        // Get the byte folloiwing it
        string singleByte = string.Empty;
        try { singleByte = data.Substring(index, 4); data = data.Remove(0, index + 4); }
        catch { break; } // we are done
        singleByte = singleByte.Remove(0, 2);
        byte convert = Byte.Parse(singleByte, NumberStyles.HexNumber);
        b.Add(convert);
        }
      if (b.Count > 0) { reply = b.ToArray(); }
      return reply;
      }
    public static byte[] EmptyAcct
      {
      get { return new byte[] { 0x10, 0x00, 0x00, 0x00, 0x12, 0x00, 0x00, 0x00, 0x83, 0x0F, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0x00, 0x00, 0x00, 0x00 }; }
      }
    public static byte[] BuildGossipPacket(int chatColor, string message, string from)
      {
      List<byte> test = new List<byte>();
      // No len and no crc add both
      byte[] begin ={ 0x26, 0x00, 0x00, 0x00, 0x91, 0x63, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0x63,
                            0x35, 0x36, 0x7C, 0x4E, 0x65, 0x77, 0x62, 0x69, 0x65, 0x73, 0x3E, 0x7C, 0x63};
      test.AddRange(begin);
      byte[] tcolor = Encoding.ASCII.GetBytes(chatColor.ToString());
      test.AddRange(tcolor);
      //0x31, 0x30, 0x30, 
      string info = string.Format("{0}:> {1}",
          from, message);
      byte[] binfo = Encoding.ASCII.GetBytes(info);
      byte rem = 0x7C;
      test.Add(rem);
      test.AddRange(binfo);
      byte[] end = { 0x0A, 0x00, 0x14, 0x75, 0x03 };
      test.AddRange(end);
      byte[] payload = test.ToArray();
      test.Clear();
      test.AddRange(BitConverter.GetBytes(payload.Length));
      test.AddRange(payload);
      test.AddRange(new byte[] { 0x00, 0x00, 0x00, 0x00 });
      return test.ToArray();
      }
    public static byte[] BuildGossipPacket(int chatColor, byte[] message, string from)
      {
      List<byte> test = new List<byte>();
      // No len and no crc add both
      byte[] begin ={ 0x26, 0x00, 0x00, 0x00, 0x91, 0x63, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00,
                              0x7C, 0x63,
                            0x35, 0x36, 0x7C, 0x4E, 0x65, 0x77, 0x62, 0x69, 0x65, 0x73, 0x3E, 0x7C, 0x63};
      test.AddRange(begin);
      byte[] tcolor = Encoding.ASCII.GetBytes(chatColor.ToString());
      test.AddRange(tcolor);
      //0x31, 0x30, 0x30, 
      string info = string.Format("{0}:> ",
          from);
      byte[] binfo = Encoding.ASCII.GetBytes(info);
      byte rem = 0x7C;
      test.Add(rem);
      test.AddRange(binfo);
      test.AddRange(message);
      byte[] end = { 0x0A, 0x00, 0x14, 0x75, 0x03 };
      test.AddRange(end);
      byte[] payload = test.ToArray();
      test.Clear();
      test.AddRange(BitConverter.GetBytes(payload.Length));
      test.AddRange(payload);
      test.AddRange(new byte[] { 0x00, 0x00, 0x00, 0x00 });
      return test.ToArray();
      }
    public static byte[] ServerMessageType1(string topic, string message, ushort charId = 0)
      {
      List<byte> builder = new List<byte>();
      builder.AddRange(BitConverter.GetBytes(24)); // Packet ID
      builder.AddRange(BitConverter.GetBytes(charId)); // If supplied the charid we sending too
      builder.AddRange(BitConverter.GetBytes(2)); //02 00 00 00
      builder.AddRange(new byte[2]); // 00 00 full packet begin
      byte[] topicBytes = Encoding.ASCII.GetBytes(topic);
      byte[] messageBytes = Encoding.ASCII.GetBytes(message);
      // Add the topic
      builder.AddRange(BitConverter.GetBytes((ushort)topicBytes.Length));
      builder.AddRange(topicBytes);
      // Add the message
      builder.AddRange(BitConverter.GetBytes((ushort)messageBytes.Length));
      builder.AddRange(messageBytes);
      while (builder.ToArray().Length % 4 != 0)
        {
        builder.Add(0x00);
        }
      // Finish
      byte[] payload = builder.ToArray();
      builder.Clear();
      builder.AddRange(BitConverter.GetBytes(payload.Length));
      builder.AddRange(payload);
      builder.AddRange(new byte[4]);
      return builder.ToArray();
      }
    public static byte[] ServerMessageType2(string message, ushort charId = 0)
      {
      List<byte> builder = new List<byte>();
      builder.AddRange(BitConverter.GetBytes(81)); // Packet ID
      builder.AddRange(BitConverter.GetBytes(charId)); // If supplied the charid we sending too
      builder.AddRange(BitConverter.GetBytes(2)); //02 00 00 00
      builder.AddRange(new byte[2]); // 00 00 full packet begin
      builder.AddRange(Encoding.ASCII.GetBytes(message + " "));
      builder.Add(0x0A);
      while (builder.ToArray().Length % 4 != 0)
        {
        builder.Add(0x00);
        }
      // Finish
      byte[] payload = builder.ToArray();
      builder.Clear();
      builder.AddRange(BitConverter.GetBytes(payload.Length));
      builder.AddRange(payload);
      builder.AddRange(new byte[4]);
      return builder.ToArray();
      }
    public static byte[] UnEquipItemPacket42(Account acct, uint itemSlot)
      {
      PacketWriter writer1 = new PacketWriter(42);
      writer1.WriteUInt32(acct.AccountId);
      writer1.WriteInt32(0);
      writer1.WriteUInt32(acct.CurrentCharacter.GameID);
      // need room here
      writer1.WriteUInt32(acct.CurrentCharacter.Location.CurrentRoom.RoomID);
      //writer1.WriteBytes(new byte[] { 0x83, 0xD1, 0xF0, 0x08 });
      writer1.WriteByte(0x08);
      writer1.WriteUInt32(acct.CurrentCharacter.GameID);
      writer1.WriteUInt32(itemSlot);
      writer1.WriteByte(0x2F);
      writer1.WriteUInt32(acct.CurrentCharacter.GameID);
      writer1.WriteUInt32(acct.CurrentCharacter.GameID);
      writer1.WriteShort(14028);
      writer1.WriteShort(0);
      writer1.WriteShort(-223);
      writer1.WriteInt32(0);
      byte[] packet42 = writer1.ToArray();
      return packet42;
      }
    public static byte[] UnEquipItemPacket25(uint accountID)
      {
      // First reply is packet 25
      PacketWriter writer = new PacketWriter(0x19);
      writer.WriteUInt32(accountID);
      writer.WriteInt32(0);
      writer.WriteInt32(154);
      writer.WriteShort(9573);
      writer.WriteShort(2053);
      byte[] packet25 = writer.ToArray();
      return packet25;
      }
    public static byte[] EquipItemPacket42(Account acct, uint itemSlot)
      {
      PacketWriter writer = new PacketWriter(42);
      writer.WriteUInt32(acct.AccountId);
      writer.WriteInt32(0);
      writer.WriteUInt32(acct.CurrentCharacter.GameID);
      writer.WriteUInt32(acct.CurrentCharacter.Location.CurrentRoom.RoomID);
      writer.WriteByte(0x07);
      writer.WriteUInt32(acct.CurrentCharacter.GameID);
      writer.WriteUInt32(itemSlot);
      writer.WriteByte(0x2F);
      writer.WriteUInt32(acct.CurrentCharacter.GameID);
      writer.WriteUInt32(acct.CurrentCharacter.GameID);
      // These are item stats  ? figure them out
      writer.WriteUInt32(0);
      writer.WriteShort(-223);
      writer.WriteInt32(0);
      byte[] packet42 = writer.ToArray();
      return packet42;
      }
    public static byte[] EquipItemPacket25(uint accountId)
      {
      PacketWriter writer = new PacketWriter(0x19);
      writer.WriteUInt32(accountId);
      writer.WriteInt32(0);
      writer.WriteShort(153);
      writer.WriteShort(0);
      writer.WriteShort(9573);
      writer.WriteShort(2053);
      byte[] packet25 = writer.ToArray();
      return packet25;
      }
    // TODO WORKING
    public static byte[] CombatPacket42(Account acct)
      {
      PacketWriter writer = new PacketWriter();
      writer.WriteInt32(42);
      // account id
      writer.WriteUInt32(acct.AccountId);
      return writer.ToArray();
      }
    public static byte[] UseItemPacket42(Account acct, uint itemSlot)
      {
      PacketWriter writer = new PacketWriter(42);
      // account id
      writer.WriteUInt32(acct.AccountId);
      writer.WriteInt32(0);
      // Char id
      writer.WriteUInt32(acct.CurrentCharacter.GameID);
      writer.WriteUInt32(acct.CurrentCharacter.Location.CurrentRoom.RoomID);
      writer.WriteByte(0x26);
      //writer.WriteBytes(new byte[] { 0x02, 0x00, 0x83, 0xD1, 0xF0, 0x08, 0x26 });
      // charid
      writer.WriteUInt32(acct.CurrentCharacter.GameID);
      // the item slot now
      writer.WriteUInt32(itemSlot);
      writer.WriteBytes(new byte[] { 0x21, 0xFF, 0x00 });
      return writer.ToArray();
      }
    public static byte[] UseItemPacket25(uint accountId)
      {
      PacketWriter writer = new PacketWriter(0x19);
      writer.WriteUInt32(accountId);
      writer.WriteInt32(0);
      // this is a reply to packet 161 client side
      writer.WriteInt32(161);
      // so this must be item specfic
      writer.WriteBytes(new byte[] { 0x07, 0xDB, 0x04, 0x08 });
      return writer.ToArray();
      }
    public static byte[] SpellPacket25(ushort accountID, ushort spellID)
      {
      // dont know what to do with spellid atm, but sure it is needed
      PacketWriter writer = new PacketWriter();
      writer.WriteInt32(25);
      writer.WriteUShort(accountID);
      writer.WriteInt32(2);
      writer.WriteShort(0);
      // replying to client 80
      writer.WriteInt32(80);
      // not sure, the spell animation ?
      writer.WriteBytes(new byte[] { 0xD3, 0x3B, 0x09, 0x08 });
      return writer.ToArray();
      }
    public static byte[] OKReplyToPacket(ushort toCharId, int packetNum)
      {
      PacketWriter writer = new PacketWriter();
      writer.WriteInt32(25);
      writer.WriteUShort(toCharId);
      writer.WriteInt32(2);
      writer.WriteShort(0);
      writer.WriteInt32(packetNum); // replying to packetnumber
      writer.WriteInt32(1);// say OK
      return writer.ToArray();
      }
    public static byte[] GiveInventoryItem(Account acct, Item item)
      {
      //item.ID = ServerGlobals.GetNextAvailableID();
      PacketWriter w = new PacketWriter(0x19);
      w.WriteUInt32(acct.AccountId);
      w.WriteUInt32(0x00);
      w.WriteUInt32(0x7F);
      w.WriteUInt32(0x00);
      w.WriteByte(0x02); // item follows
      w.WriteBytes(item.Serialize());
      w.WriteUInt32(0x00); // the price
      w.WriteByte(0xFF); // end
      return w.ToArray();
      /*
      // Currently says you bought the items, hijacked shop packet
      PacketWriter writer = new PacketWriter(0x19);
      writer.WriteUInt32(acct.CurrentCharacter.CharId);
      writer.WriteInt32(0x00);
      writer.WriteUInt32(0x7F);
      writer.WriteUInt32(0);
      writer.WriteByte(0x02);
      uint id = 0;
      writer.WriteBytes(item.Serialize(out id));
      item.UpdateID(id);
      acct.CurrentCharacter.IDsInUse.Add(id);
      Console.WriteLine("(Give Inventory Item):Set Item {0} slot id to {1}", item.GraphicID , item.ID);
      writer.WriteByte(0);
      writer.WriteByte(0); // 32 in live packet (is cash it takes from player here)
      writer.WriteShort(0);
      writer.WriteByte(0);
      writer.WriteByte(0xFF);
      // try to give this item via sql
      bool give = Managers.MySqlManager.SaveItem(acct.CurrentCharacter.SqlCharId, item);
      Console.WriteLine("SqlGive Item {0} to {1} : {2}",item.ID, acct.CurrentCharacter.SqlCharId, give);
       return writer.ToArray();
       */
      }
    public static byte[] InvalidLogonMessage(string message)
      {
      PacketWriter writer = new PacketWriter();
      writer.WriteInt32(14);
      writer.WriteBytes(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0x01, 0x00, 0x00, 0x00, 0x00 });
      byte[] bmessage = Encoding.ASCII.GetBytes(message);
      byte[] bmsglen = BitConverter.GetBytes((ushort)bmessage.Length);
      writer.WriteBytes(bmsglen);
      writer.WriteBytes(bmessage);
      writer.WriteBytes(new byte[] { 0x00, 0x00, 0x12 });
      return writer.ToArray();
      }
    public static byte[] ShopPacketBuy(uint accountID, out uint usedInvID, ushort color = 0)
      {
      PacketWriter writer = new PacketWriter(0x19);
      writer.WriteUInt32(accountID);
      writer.WriteInt32(0);
      // reply to 117
      writer.WriteInt32(127);
      // not sure
      writer.WriteInt32(0);
      // rest of our test file here
      writer.WriteByte(0x02);
      writer.WriteByte(0x01);
      byte[] item = GetByteArrayFromFileInBaseDir("shop.txt");
      log.LogMessage(BitConverter.ToString(item), MessageType.Warning);
      // we want the next availbile item slot of char ID
      usedInvID = ServerGlobals.GetNextAvailableID();
      // so item bytes in our file are first 2 bytes
      // are the graphic ID, next 2 the next inventory slot
      byte[] nextInv = BitConverter.GetBytes(usedInvID);
      item[2] = nextInv[0];
      item[3] = nextInv[1];
      // if we have a custom color add it
      if (color > 0)
        {
        byte[] newColor = BitConverter.GetBytes(color);
        item[6] = newColor[0];
        item[7] = newColor[1];
        }
      log.LogMessage(BitConverter.ToString(item), MessageType.Information);
      writer.WriteBytes(item);
      return writer.ToArray();
      }
    public static byte[] RoomPacket(ushort accountId, string roomName, string filename)
      {
      PacketWriter writer = new PacketWriter();
      writer.WriteInt32(33);
      writer.WriteUShort(accountId);
      writer.WriteInt32(2); // this sometimes changes 
      writer.WriteShort(0);
      writer.WriteByte(1);
      // now starts name
      byte[] name = Encoding.ASCII.GetBytes(roomName);
      byte[] nameLen = BitConverter.GetBytes((ushort)name.Length);
      writer.WriteBytes(nameLen);
      writer.WriteBytes(name);
      writer.WriteBytes(GetByteArrayFromFileInBaseDir(filename));
      return writer.ToArray(); ;
      }
    public static byte[] MoveNextScreen25(ushort accountId)
      {
      PacketWriter writer = new PacketWriter();
      writer.WriteInt32(25);
      writer.WriteUShort(accountId);
      writer.WriteInt32(2);
      writer.WriteShort(0);
      writer.WriteInt32(52);
      writer.WriteInt32(0);
      writer.WriteBytes(new byte[] { 0x73, 0x02, 0x24, 0x01, 0x00, 0x01, 0x03, 0xFF });
      return writer.ToArray();
      }
    public static byte[] GetByteArrayFromFileInBaseDir(string fileName)
      {
      string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
      Console.WriteLine("From File {0}", fileLocation);
      return GetByteArrayFromFile(fileLocation);
      }
    public static byte[] tRoom(ushort acctID)
      {
      byte[] reply = new byte[] { 0xFC, 0x08, 0x00, 0x00,
                0x21, 0x00, 0x00, 0x00,
                0x32, 0x32,
                0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x00, 0x56, 0x61, 0x6C, 0x68, 0x61, 0x6C, 0x6C, 0x61, 0x20, 0x53, 0x68, 0x6F, 0x70, 0x73, 0x00, 0x17, 0x00, 0x1B, 0x00, 0x00, 0xAC, 0x0D, 0x00, 0x04, 0x00, 0x00, 0xAC, 0x24, 0x0A, 0x28, 0x02, 0xA7, 0x00, 0x1E, 0x00, 0x38, 0x08, 0xB5, 0x01, 0xD4, 0x00, 0x00, 0x00, 0x67, 0x08, 0x11, 0x00, 0x01, 0x01, 0x00, 0x00, 0x23, 0x0A, 0x84, 0x00, 0x94, 0x00, 0x1E, 0x00, 0x23, 0x0A, 0x28, 0x00, 0xA3, 0x00, 0x1E, 0x00, 0x1B, 0x0A, 0xCF, 0x01, 0xAA, 0x00, 0x1E, 0x00, 0x36, 0x08, 0xE8, 0x01, 0xDD, 0x00, 0x00, 0x00, 0x38, 0x08, 0x58, 0x02, 0xED, 0x00, 0x00, 0x00, 0xC9, 0x09, 0x75, 0x02, 0x1B, 0x00, 0x00, 0x00, 0xC5, 0x09, 0xC4, 0x01, 0x07, 0x00, 0xF6, 0xFF, 0x1A, 0x0A, 0x41, 0x00, 0xB5, 0x00, 0x1E, 0x00, 0xD1, 0x09, 0xA4, 0x00, 0x08, 0x00, 0xF6, 0xFF, 0xD5, 0x09, 0x23, 0x00, 0x0A, 0x00, 0xF6, 0xFF, 0xD6, 0x09, 0x81, 0x00, 0x1C, 0x00, 0xF6, 0xFF, 0xDD, 0x09, 0xF4, 0x00, 0x01, 0x00, 0xF6, 0xFF, 0xDD, 0x09, 0x62, 0x01, 0x02, 0x00, 0xF6, 0xFF, 0xDE, 0x09, 0x3B, 0x01, 0x06, 0x00, 0xF6, 0xFF, 0xC7, 0x0A, 0x6F, 0x01, 0x1F, 0x00, 0x00, 0x00, 0xC7, 0x8A, 0x00, 0x01, 0x8B, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0xFE, 0x00, 0x81, 0x00, 0x00, 0x00, 0xC8, 0x8A, 0x01, 0x01, 0x56, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x48, 0x01, 0x29, 0x00, 0x00, 0x00, 0xC9, 0x8A, 0x17, 0x01, 0x65, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0x32, 0x01, 0x29, 0x00, 0x00, 0x00, 0xCA, 0x8A, 0x17, 0x01, 0x2A, 0x00, 0x00, 0x00, 0xCA, 0x8A, 0x30, 0x01, 0x19, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0x54, 0x01, 0x69, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x6B, 0x01, 0xAD, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x5A, 0x01, 0xAD, 0x00, 0x00, 0x00, 0xCA, 0x8A, 0x16, 0x01, 0xAB, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0xD2, 0x00, 0xAA, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x56, 0x01, 0x7D, 0x00, 0xFA, 0xFF, 0xC9, 0x0A, 0xD2, 0x00, 0x77, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0xD4, 0x00, 0x3E, 0x00, 0x00, 0x00, 0xC9, 0x8A, 0x98, 0x01, 0x78, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0xEB, 0x00, 0xA9, 0x00, 0x00, 0x00, 0xC8, 0x8A, 0x86, 0x01, 0x7B, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0xEA, 0x00, 0x33, 0x00, 0x00, 0x00, 0xCA, 0x8A, 0x96, 0x01, 0xAB, 0x00, 0x00, 0x00, 0xCA, 0x8A, 0x97, 0x01, 0x32, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x5B, 0x01, 0x22, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x94, 0x00, 0xB5, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0xBE, 0x00, 0x45, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0xA9, 0x00, 0xB0, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0xB3, 0x00, 0xA8, 0x00, 0x00, 0x00, 0xBF, 0x0A, 0xA8, 0x01, 0xB3, 0x00, 0x00, 0x00, 0xC0, 0x0A, 0x95, 0x01, 0x48, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0x96, 0x01, 0x7B, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0x96, 0x01, 0x37, 0x00, 0x00, 0x00, 0xCB, 0x0A, 0x40, 0x01, 0x5E, 0x00, 0x00, 0x00, 0xCB, 0x8A, 0x2A, 0x01, 0x5F, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0xBE, 0x00, 0x79, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0x95, 0x01, 0xAD, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x42, 0x00, 0xC3, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x58, 0x00, 0xC2, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x1A, 0x00, 0x98, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x6B, 0x00, 0xBB, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x57, 0x00, 0xB7, 0x00, 0x1E, 0x00, 0xC3, 0x0A, 0x6B, 0x00, 0x99, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x1B, 0x00, 0xCB, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x2D, 0x00, 0xC7, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x08, 0x00, 0xA7, 0x00, 0x00, 0x00, 0x24, 0x0A, 0xC5, 0x01, 0x97, 0x00, 0x1E, 0x00, 0xC6, 0x0A, 0x68, 0x00, 0x64, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x80, 0x00, 0xB7, 0x00, 0x00, 0x00, 0x1A, 0x0A, 0x9D, 0x00, 0xA6, 0x00, 0x1E, 0x00, 0xC6, 0x0A, 0x7E, 0x00, 0x85, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x95, 0x00, 0x92, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0xF6, 0xFF, 0xCD, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0xFC, 0xFF, 0x32, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0xF3, 0xFF, 0x9B, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0xAE, 0x00, 0x7D, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0xAA, 0x00, 0x4B, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x07, 0x00, 0xCC, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x43, 0x00, 0x8D, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x95, 0x00, 0x5D, 0x00, 0x00, 0x00, 0x1B, 0x0A, 0x33, 0x02, 0xBB, 0x00, 0x1E, 0x00, 0xC6, 0x0A, 0x2E, 0x00, 0x6F, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x7F, 0x00, 0x50, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0xF9, 0xFF, 0x65, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x07, 0x00, 0x75, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0xA8, 0x00, 0x28, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x92, 0x00, 0x2C, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x56, 0x00, 0x66, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x1A, 0x00, 0x65, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x40, 0x00, 0x5A, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x7E, 0x00, 0x38, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x69, 0x00, 0x30, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x56, 0x00, 0x34, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x2B, 0x00, 0x38, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x40, 0x00, 0x26, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x17, 0x00, 0x2F, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x04, 0x00, 0x42, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x6C, 0x01, 0x51, 0x00, 0x00, 0x00, 0xCA, 0x09, 0x09, 0x02, 0x28, 0x00, 0x00, 0x00, 0xBF, 0x0A, 0xAA, 0x01, 0x60, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0xC3, 0x01, 0x82, 0x00, 0x00, 0x00, 0xC0, 0x0A, 0xAD, 0x01, 0x3A, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0xAD, 0x01, 0x81, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0xC2, 0x01, 0xB8, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0xD8, 0x01, 0xB9, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0xED, 0x01, 0xC0, 0x00, 0x00, 0x00, 0xBF, 0x0A, 0x02, 0x02, 0xC3, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0x1D, 0x02, 0xC9, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0x4B, 0x02, 0xCF, 0x00, 0x00, 0x00, 0xBF, 0x0A, 0x60, 0x02, 0xD2, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0xC4, 0x01, 0x51, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0x34, 0x02, 0xC9, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0xDA, 0x01, 0x56, 0x00, 0x00, 0x00, 0xBF, 0x0A, 0xD7, 0x01, 0x8B, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0xF1, 0x01, 0x91, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0x08, 0x02, 0x8D, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0x1F, 0x02, 0x95, 0x00, 0x00, 0x00, 0xBF, 0x0A, 0x35, 0x02, 0x99, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0xF0, 0x01, 0x5C, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0x50, 0x02, 0x9B, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0x65, 0x02, 0x9F, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0x22, 0x02, 0x60, 0x00, 0x00, 0x00, 0xBF, 0x0A, 0x06, 0x02, 0x5B, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0x67, 0x02, 0x6A, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0x39, 0x02, 0x64, 0x00, 0x00, 0x00, 0xBF, 0x0A, 0x4D, 0x02, 0x68, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0xD8, 0x01, 0x29, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0xF0, 0x01, 0x3D, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0x0B, 0x02, 0x29, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0x3B, 0x02, 0x2E, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0x51, 0x02, 0x34, 0x00, 0x00, 0x00, 0xC1, 0x0A, 0x22, 0x02, 0x2D, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0x68, 0x02, 0x4E, 0x00, 0x00, 0x00, 0xC2, 0x0A, 0x6A, 0x02, 0x1B, 0x00, 0x00, 0x00, 0x39, 0x08, 0x18, 0x00, 0xED, 0x00, 0x00, 0x00, 0x59, 0x0A, 0x3A, 0x02, 0xFF, 0x00, 0x00, 0x00, 0x03, 0x00, 0x73, 0x01, 0x9E, 0x00, 0x00, 0x00, 0x03, 0x00, 0x01, 0x01, 0x99, 0x00, 0x00, 0x00, 0x63, 0x08, 0x4D, 0x00, 0xF3, 0x00, 0x3C, 0x00, 0x6D, 0x78, 0xA2, 0x00, 0xD2, 0x00, 0x3C, 0x00, 0x35, 0x08, 0x8A, 0x00, 0xDF, 0x00, 0x00, 0x00, 0x5E, 0x88, 0x31, 0x00, 0xF3, 0x00, 0x3C, 0x00, 0x48, 0x88, 0x36, 0x02, 0xF5, 0x00, 0x3C, 0x00, 0x39, 0x08, 0xBC, 0x00, 0xD2, 0x00, 0x00, 0x00, 0x62, 0x88, 0xC6, 0x00, 0xD5, 0x00, 0x3C, 0x00, 0x4A, 0x0A, 0x5A, 0x01, 0x4F, 0x00, 0x28, 0x00, 0x44, 0x0A, 0x94, 0x02, 0x7E, 0x00, 0x32, 0x00, 0x03, 0x00, 0x00, 0x01, 0xCB, 0x00, 0x00, 0x00, 0x3F, 0x0A, 0x2E, 0x00, 0x6F, 0x00, 0x32, 0x00, 0x44, 0x0A, 0x47, 0x02, 0x73, 0x00, 0x32, 0x00, 0x52, 0x0A, 0xC8, 0x00, 0x97, 0x00, 0x00, 0x00, 0x03, 0x00, 0x6A, 0x01, 0xB2, 0x00, 0x00, 0x00, 0x47, 0x0A, 0x1C, 0x01, 0x4E, 0x00, 0x28, 0x00, 0x03, 0x00, 0x00, 0x01, 0xB5, 0x00, 0x00, 0x00, 0x58, 0x0A, 0xB3, 0x00, 0xE2, 0x00, 0x00, 0x00, 0x45, 0x0A, 0x22, 0x02, 0x61, 0x00, 0x28, 0x00, 0x40, 0x0A, 0x4B, 0x00, 0x5F, 0x00, 0x28, 0x00, 0x66, 0x0A, 0x98, 0x01, 0xAE, 0x00, 0x00, 0x00, 0x52, 0x0A, 0xC8, 0x00, 0xAD, 0x00, 0x00, 0x00, 0x65, 0x0A, 0x98, 0x01, 0x6E, 0x00, 0x00, 0x00, 0x3F, 0x0A, 0xF1, 0xFF, 0x78, 0x00, 0x32, 0x00, 0x59, 0x0A, 0x27, 0x00, 0xF9, 0x00, 0x00, 0x00, 0x59, 0x0A, 0x72, 0x00, 0xEC, 0x00, 0x00, 0x00, 0x6C, 0x0A, 0x75, 0x01, 0xE6, 0x00, 0x00, 0x00, 0x6D, 0x0A, 0xAB, 0x01, 0xF6, 0x00, 0x00, 0x00, 0x6E, 0x0A, 0xFC, 0x01, 0xFE, 0x00, 0x00, 0x00, 0x6E, 0x0A, 0xE9, 0xFF, 0xFA, 0x00, 0x00, 0x00, 0x0E, 0x00, 0x85, 0x02, 0x17, 0x01, 0x00, 0x00, 0x0E, 0x00, 0xFE, 0x01, 0x01, 0x01, 0x00, 0x00, 0x0E, 0x80, 0xF4, 0xFF, 0x12, 0x01, 0x00, 0x00, 0x0E, 0x80, 0x65, 0x00, 0x00, 0x01, 0x00, 0x00, 0x03, 0x00, 0x6A, 0x01, 0xC8, 0x00, 0x00, 0x00, 0xE2, 0x00, 0x38, 0x01, 0xA1, 0x00, 0x00, 0x00, 0x4A, 0x0A, 0x93, 0x01, 0xB0, 0x00, 0xFB, 0xFF, 0x47, 0x0A, 0x16, 0x01, 0xAF, 0x00, 0xFB, 0xFF, 0xE2, 0x00, 0x7D, 0x02, 0x16, 0x01, 0x00, 0x00, 0x0A, 0x00, 0x01, 0xDC, 0x02, 0xAA, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x00, 0x1B, 0x35, 0x01, 0xB1, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB2, 0x07, 0xBD, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x00, 0x1B, 0x78, 0x01, 0xB4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB2, 0x07, 0xBE, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x00, 0x1B, 0xF3, 0x00, 0xB4, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x83, 0x04, 0xA6, 0xBB, 0x01, 0x00, 0x63, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x00, 0x1B, 0x3A, 0x01, 0x23, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xA7, 0x04, 0xA7, 0xBB, 0x01, 0x00, 0x63, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x00, 0x1B, 0x3A, 0x01, 0x23, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xBC, 0x04, 0xA8, 0xBB, 0x01, 0x00, 0x63, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x00, 0x1B, 0x3A, 0x01, 0x23, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0D, 0x05, 0xA9, 0xBB, 0x01, 0x00, 0x63, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x00, 0x1B, 0x3A, 0x01, 0x23, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x02, 0x05, 0xAA, 0xBB, 0x01, 0x00, 0x63, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x00, 0x1B, 0x3A, 0x01, 0x23, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x36, 0x02, 0xC6, 0xED, 0x01, 0x00, 0x4A, 0x00, 0x00, 0x20, 0xFF, 0x00, 0x01, 0x00, 0x1B, 0xDE, 0x00, 0xF1, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x16, 0x02, 0xD9, 0xED, 0x01, 0x00, 0x58, 0x00, 0x00, 0x20, 0xFF, 0x00, 0x01, 0x00, 0x1B, 0xAF, 0x00, 0xF1, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x01, 0x1D, 0x0B, 0xAB, 0x48, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x00, 0x0B, 0x00, 0x41, 0x72, 0x69, 0x6C, 0x64, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x60, 0x09, 0x00, 0x00, 0x60, 0x09, 0x00, 0x00, 0x01, 0x00, 0x1B, 0x09, 0x02, 0xDB, 0x00, 0x02, 0x00, 0x08, 0x00, 0x01, 0x04, 0x00, 0xAC, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x04, 0x02, 0x01, 0x09, 0x03, 0x06, 0x0B, 0x03, 0x09, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x6B, 0x04, 0xAD, 0x48, 0x01, 0x00, 0x63, 0x00, 0x01, 0x05, 0x00, 0x54, 0x75, 0x6E, 0x69, 0x63, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8A, 0x04, 0xAE, 0x48, 0x01, 0x00, 0x63, 0x00, 0x01, 0x04, 0x00, 0x48, 0x6F, 0x73, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xF7, 0x04, 0xAF, 0x48, 0x01, 0x00, 0x62, 0x00, 0x01, 0x04, 0x00, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0F, 0x05, 0xB0, 0x48, 0x01, 0x00, 0x28, 0x00, 0x01, 0x1D, 0x00, 0x4B, 0x6E, 0x69, 0x67, 0x68, 0x74, 0x20, 0x6F, 0x66, 0x20, 0x74, 0x68, 0x65, 0x20, 0x53, 0x63, 0x65, 0x70, 0x74, 0x65, 0x72, 0x20, 0x42, 0x61, 0x6C, 0x64, 0x72, 0x69, 0x63, 0x4A, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAF, 0x04, 0xB1, 0x48, 0x01, 0x00, 0x62, 0x00, 0x01, 0x13, 0x00, 0x54, 0x72, 0x6F, 0x6C, 0x6C, 0x20, 0x4C, 0x65, 0x61, 0x74, 0x68, 0x65, 0x72, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0xB2, 0x48, 0x01, 0x00, 0x62, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x01, 0x1E, 0x0B, 0xB4, 0x48, 0x01, 0x00, 0x00, 0xFF, 0x00, 0x0C, 0x08, 0x64, 0x64, 0x01, 0x00, 0x00, 0x0F, 0x00, 0x41, 0x76, 0x61, 0x6C, 0x64, 0x61, 0x6D, 0x6F, 0x6E, 0x20, 0x28, 0x4E, 0x50, 0x43, 0x29, 0x00, 0x18, 0x09, 0x00, 0x00, 0x18, 0x09, 0x00, 0x00, 0x01, 0x00, 0x1B, 0x6A, 0x00, 0xDD, 0x00, 0x02, 0x00, 0x08, 0x00, 0x01, 0x04, 0x00, 0xB5, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x0E, 0x02, 0x00, 0x07, 0x00, 0x00, 0x06, 0x01, 0x06, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x6B, 0x04, 0xB6, 0x48, 0x01, 0x00, 0x63, 0x00, 0x01, 0x05, 0x00, 0x54, 0x75, 0x6E, 0x69, 0x63, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x8A, 0x04, 0xB7, 0x48, 0x01, 0x00, 0x63, 0x00, 0x01, 0x04, 0x00, 0x48, 0x6F, 0x73, 0x65, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xF7, 0x04, 0xB8, 0x48, 0x01, 0x00, 0x62, 0x00, 0x01, 0x04, 0x00, 0x43, 0x6F, 0x77, 0x6C, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0F, 0x05, 0xB9, 0x48, 0x01, 0x00, 0x28, 0x00, 0x01, 0x1D, 0x00, 0x4B, 0x6E, 0x69, 0x67, 0x68, 0x74, 0x20, 0x6F, 0x66, 0x20, 0x74, 0x68, 0x65, 0x20, 0x53, 0x63, 0x65, 0x70, 0x74, 0x65, 0x72, 0x20, 0x42, 0x61, 0x6C, 0x64, 0x72, 0x69, 0x63, 0x4A, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xAF, 0x04, 0xBA, 0x48, 0x01, 0x00, 0x62, 0x00, 0x01, 0x13, 0x00, 0x54, 0x72, 0x6F, 0x6C, 0x6C, 0x20, 0x4C, 0x65, 0x61, 0x74, 0x68, 0x65, 0x72, 0x20, 0x42, 0x6F, 0x6F, 0x74, 0x73, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x0E, 0x05, 0xBB, 0x48, 0x01, 0x00, 0x62, 0x00, 0x01, 0x04, 0x00, 0x42, 0x65, 0x6C, 0x74, 0x4A, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x6A, 0x5C, 0xB0, 0x29 };
      byte[] acctid = BitConverter.GetBytes(acctID);
      reply[8] = acctid[0];
      reply[9] = acctid[1];
      return reply;
      }
    public static void ColorCodePacket(byte[] buffer)
      {
      int pckId = -1;
      uint roomNum = 0;
      byte[] payload = Tools.ReadPacket41UntilFF(buffer, out pckId, out roomNum);
      string pack = BitConverter.ToString(payload);
      string reply = string.Empty;
      if (payload[0] == 0x04)
        {

        if (payload.Length == 8)
          {
          if (payload[3] != 0) // This should always be 0, or how we think packet is, aint..
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Packet 41 error, We assume byte 3 is a 0 spacer, but its value is now {0}!!", (int)payload[3]);
            Console.ResetColor();
            }
          short faceing = BitConverter.ToInt16(payload, 1);
          short x = BitConverter.ToInt16(payload, 4);
          short y = BitConverter.ToInt16(payload, 6);
          }
        else reply = string.Format("{0} Length:{1} Facing Packet. {2}", pack, payload.Length, (short)payload[1]);

        }
      else
        {
        reply = string.Format("{0} Length:{1}", pack, payload.Length);
        }
      if (payload.Length == 5)
        {

        short x = BitConverter.ToInt16(payload, 1);
        short y = BitConverter.ToInt16(payload, 3);


        reply += string.Format(" (X:{0} Y:{1})", x, y);
        }
      if (payload.Length == 10)
        {

        // Its a double x,y
        short x1 = BitConverter.ToInt16(payload, 1);
        short y1 = BitConverter.ToInt16(payload, 3);

        short x2 = BitConverter.ToInt16(payload, 6);
        short y2 = BitConverter.ToInt16(payload, 8);
        reply += string.Format(" Double x,y - >(X1:{0} Y1:{1}) (X2:{2} Y2:{3})", x1, y1, x2, y2);

        }
      reply += string.Format(" (RoomNumber: {0})", roomNum);
      Console.WriteLine(reply);
      log.WriteRawLog(reply);
      }
    public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
      {
      // Unix timestamp is seconds past epoch
      System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
      dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
      return dtDateTime;
      }
    public static double DateTimeToUnixTimestamp(DateTime dateTime)
      {
      return (dateTime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
      }
    public static byte[] ParseChatMessage(byte[] payload, out string name)
      {
      // it starts with a /something then a space then the name then a space then the message
      PacketReader r = new PacketReader(payload);
      List<byte> buffer = new List<byte>();
      for (int i = 0; i < payload.Length; i++)
        {
        byte a = r.ReadByte();
        if (a == 0x20) break;
        else buffer.Add(a);
        }
      byte[] cmd = buffer.ToArray();
      Console.WriteLine("Got First {0}", Encoding.ASCII.GetString(cmd));
      buffer.Clear();
      // /t
      // Now again we want the name
      for (int i = 0; i < payload.Length; i++)
        {
        byte a = r.ReadByte();
        if (a == 0x20) break;
        else buffer.Add(a);
        }
      byte[] bname = buffer.ToArray();
      name = Encoding.ASCII.GetString(bname);
      Console.WriteLine("Got second {0}", name);
      //pos += bname.Length + 1;
      buffer.Clear();

      for (int i = 0; i < payload.Length; i++)
        {
        byte a = r.ReadByte();
        if (a == 0x00) break;
        else buffer.Add(a);
        }
      byte[] msg = buffer.ToArray();
      Console.WriteLine("Got msg {0}", Encoding.ASCII.GetString(msg));
      buffer.Clear();
      r.Close();
      return msg;
      }
    public static byte[] FaceEntity(Entity e, string face)
      {
      ushort f = 0;
      switch (face.ToLower())
        {
        case "n":
          f = 347;
          break;
        case "s":
          f = 169;
          break;
        case "w":
          f = 269;
          break;
        case "e":
          f = 90;
          break;
        }
      PacketWriter w = new PacketWriter(0x2A);
      w.WriteUInt32(0x00); // blank acct rdy for room send
      w.WriteUInt32(0x00);
      w.WriteUInt32(e.GameID);
      w.WriteUInt32(e.Location.CurrentRoom.RoomID);
      e.Location.Facing = f;
      w.WriteByte(0x04);
      w.WriteUShort(f);
      w.WriteByte(0xFF);
      return w.ToArray();
      }
    public static byte[] FaceEntity(Account toAccount, Entity e, Room inRoom, ushort currentX, ushort currentY, string face)
      {
      Entity n = inRoom.GetNpcInRoom(e.GameID);
      switch (face.ToLower())
        {
        case "n":
          currentY -= 5;
          break;
        case "s":
          currentY += 5;
          break;
        case "w":
          currentX -= 5;
          break;
        case "e":
          currentX += 5;
          break;
        }
      if (n == null) Console.WriteLine("ERROR Entity to face is null !!");
      else
        {
        if (n is NPC)
          {
          NPC npc = n as NPC;
          npc.Location = new RoomLocation(inRoom.RoomID, currentX, currentY, 0xFF);
          npc.Location.CurrentRoom = inRoom;
          }
        if (n is Mob)
          {
          Mob mob = n as Mob;
          mob.Location = new RoomLocation(inRoom.RoomID, currentX, currentY, 0xFF);
          mob.Location.CurrentRoom = inRoom;
          }
        }
      PacketWriter w = new PacketWriter(0x2A);
      w.WriteUInt32(toAccount.AccountId);
      w.WriteUInt32(0x00);
      w.WriteUInt32(e.GameID);
      w.WriteUInt32(inRoom.RoomID);
      w.WriteByte(0x00);
      // Begin x, y data
      w.WriteUShort(currentX);
      w.WriteUShort(currentY);
      w.WriteByte(0xFF);
      return w.ToArray();
      }
    public static byte[] MoveEntityTo(Account toAccount, Entity e, Room inRoom, short x, short y)
      {
      // x must be between 0-635 any further you must destroy the entity will look as if they simply walked off the screen
      // y must be between 30 - 400 same as above.
      if (x < 0) x = 0;
      if (x > 635) x = 635;
      if (y < 30) y = 30;
      if (y > 400) y = 400;
      Entity n = inRoom.GetNpcInRoom(e.GameID);
      if (n == null) Console.WriteLine("ERROR Entity to move is null !!");
      else
        {
        if (n is NPC)
          {
          NPC npc = n as NPC;
          npc.Location = new RoomLocation(inRoom.RoomID, x, y, 0x00);
          npc.Location.CurrentRoom = inRoom;
          }
        if (n is Mob)
          {
          Mob mob = n as Mob;
          mob.Location = new RoomLocation(inRoom.RoomID, x, y, 0x00);
          mob.Location.CurrentRoom = inRoom;
          }
        }
      PacketWriter w = new PacketWriter(0x2A);
      w.WriteUInt32(toAccount.AccountId);
      w.WriteUInt32(0x00);
      w.WriteUInt32(e.GameID);
      w.WriteUInt32(inRoom.RoomID);
      w.WriteByte(0x00);
      // Begin x, y data
      w.WriteShort(x);
      w.WriteShort(y);
      w.WriteByte(0xFF);
      return w.ToArray();
      }
    public static byte[] MoveEntityTo(Account toAccount, uint npcID, Room inRoom, short x, short y)
      {
      // x must be between 0-635 any further you must destroy the entity will look as if they simply walked off the screen
      // y must be between 30 - 400 same as above.
      if (x < 0) x = 0;
      if (x > 635) x = 635;
      if (y < 30) y = 30;
      if (y > 400) y = 400;
      PacketWriter w = new PacketWriter(0x2A);
      w.WriteUInt32(toAccount.AccountId);
      w.WriteUInt32(0x00);
      w.WriteUInt32(npcID);
      w.WriteUInt32(inRoom.RoomID);
      w.WriteByte(0x00);
      // Begin x, y data
      w.WriteShort(x);
      w.WriteShort(y);
      w.WriteByte(0xFF);
      return w.ToArray();
      }
    }
  }

