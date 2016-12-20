#region License
/*
 * Microsoft Public License (Ms-PL)
 * 
 * This license governs use of the accompanying software. If you use the software, you accept this license. 
 * If you do not accept the license, do not use the software.
 *
 * 1. Definitions
 *
 * The terms "reproduce," "reproduction," "derivative works," and "distribution" have the same meaning here as under U.S. copyright law.
 *
 * A "contribution" is the original software, or any additions or changes to the software.
 *
 * A "contributor" is any person that distributes its contribution under this license.
 *
 * "Licensed patents" are a contributor's patent claims that read directly on its contribution.
 *
 * 2. Grant of Rights
 *
 * (A) Copyright Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, 
 * each contributor grants you a non-exclusive, worldwide, royalty-free copyright license to reproduce its contribution, 
 * prepare derivative works of its contribution, and distribute its contribution or any derivative works that you create.
 *
 * (B) Patent Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, 
 * each contributor grants you a non-exclusive, worldwide, royalty-free license under its licensed patents to make, have made, 
 * use, sell, offer for sale, import, and/or otherwise dispose of its contribution in the software or derivative works of the 
 * contribution in the software.
 *
 * 3. Conditions and Limitations
 *
 * (A) No Trademark License- This license does not grant you rights to use any contributors' name, logo, or trademarks.
 *
 * (B) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, 
 * your patent license from such contributor to the software ends automatically.
 *
 * (C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, 
 * and attribution notices that are present in the software.
 *
 * (D) If you distribute any portion of the software in source code form, you may do so only under this license by including 
 * a complete copy of this license with your distribution. If you distribute any portion of the software in compiled or object code form, 
 * you may only do so under a license that complies with this license.
 *
 * (E) The software is licensed "as-is." You bear the risk of using it. The contributors give no express warranties, guarantees or conditions. 
 * You may have additional consumer rights under your local laws which this license cannot change. To the extent permitted under your local laws, 
 * the contributors exclude the implied warranties of merchantability, fitness for a particular purpose and non-infringement. 
 */
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using RealmOffline.Tcp;
using RealmOffline.Packets;
using System.IO;
using RealmOffline.Managers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;
using System.Globalization;
using RealmOffline;
using RealmOffline.Accounts;
using RealmOfflineWorldServer.Core.Scripting;
using RealmOffline.Core;
using Scripts.Scripts;
using RealmOfflineWorldServer.Core;
using RealmOffline.Logs;
using System.Threading.Tasks;
using RealmOffline.Core.Items;
using RealmOffline.Core.Rooms;
using RealmOffline.Commands;
using RealmOffline.Base;
using RealmOffline.Core.Mobiles;

namespace RealmOfflineWorldServer
{

    public class ConsoleCommands
    {
        private List<Thread> currentThreads = new List<Thread>();
        public List<Thread> ThreadList
        {
            get { return currentThreads; }
            set { currentThreads = value; }
        }

        public bool IsConsoleShuttingDown { get; set; }
        private Server srv = new Server();


        public ConsoleCommands()
        {
        }
        public void WaitForCommands()
        {
            string input = null;
            this.Start();
            LoadScripts();
            InitGameData();
            while (!IsConsoleShuttingDown)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n[{Realm World Server}] ");
                Console.ResetColor();
                input = Console.ReadLine();
                string[] args = input.Split(' ');



                switch (args[0].ToLower())
                {
                    case "pass":
                        {
                            // we gonna hash passwords here man !!
                            string password = string.Empty;

                            if (args.Length >= 2)
                            {
                                // get the pass
                                password = args[1];
                                string hash =RealmOffline.Accounts.PasswordHash.CreateHash(password);
                                bool back = RealmOffline.Accounts.PasswordHash.ValidatePassword(password, hash);
                                Console.WriteLine("We got password ({0}) and hash ({1}), they {2} match.", password, hash, 
                                    back ? "do":" do not");

                                
                            }
                        }
                        break;
                    case "/mob":
                        {
                            if (args.Length >= 2)
                            {
                                short id = 0;
                                if (short.TryParse(args[1], out id))
                                {
                                    MobileType type = MobileType.None;
                                    string name = BaseMobile.MobNameFromID(id, out type);
                                    Console.WriteLine("We found {0} for MobID {1}, its type is {2}",
                                        name, id, type);

                                }
                            }
                        }
                        break;
                    case "/sm":
                        {
                            if (args.Length >= 3)
                            {
                                //1 = topic 2 on = message
                                string topic = input.Split('|').First();
                                string msg = input.Split('|').Last();
                                Console.WriteLine("Topic ({0}) Message ({1})",topic, msg);
                            }
                        }
                        break;
                    case "terd":
                        {
                            BaseMobile.Init();
                            string[] m = BaseMobile.NonHumanoid.Select(x => x.Value).ToArray();
                            foreach (string c in m) Console.WriteLine(c);
                        }
                        break;
                    case "fight":
                        {
                            // We want stats 2 stats 2 skills for attack
                            //1 = str 2 = dex 3 = CS 4 = wepskill
                            if (args.Length >= 5)
                            {
                                int str = 0;
                                int dex = 0;
                                int cs = 0;
                                int wep = 0;
                                if (int.TryParse(args[1], out str)
                                    && int.TryParse(args[2], out dex)
                                    && int.TryParse(args[3], out cs)
                                    && int.TryParse(args[4], out wep))
                                {
                                    Console.WriteLine("We got STR:({0}) DEX:({1}) CS:({2}) Wep:({3})",
                                        str, dex, cs, wep);

                                    // Lets formulate a chance
                                    int[] attacker = { str, dex, cs, wep};
                                    int[] oppn = { 12, 12, 5, 5};

                                   // int hitpoints = 3000; // both have 3k hp
                                    int aper = attacker.Sum();
                                    int oper = oppn.Sum();

                                    Console.WriteLine("We start with {0}% for Attacker and {1}% for opponent.", aper, oper);



                                }
                            }
                        }
                        break;
                    case "id":
                        {
                            if (args.Length == 2)
                            {
                                short id = 0;
                                if (short.TryParse(args[1], out id))
                                {
                                    
                                    bool vali = Mob.IsValidID(id);
                                    Console.WriteLine("{0} {1} a valid id.", id, vali ? "is" : "is not");
                                }
                            }
                        }
                        break;
                    case "ts":
                        {
                            byte[] t = new byte[] {0x21, 0xFF, 0x00, 0x9C};
                            Array.Reverse(t);
                            double d = (double)BitConverter.ToInt32(t, 0);
                            DateTime dt = MagicMail.UnixTimeStampToDateTime(d);
                            Console.WriteLine(dt);
                        }
                        break;
                    #region Account Creation and Deletion
                    case "account":
                        {
                            string useage = "[Create an Account]\naccount create username password emailaddress secretword 3 \n"+
                                "Last value is User Priv's\n"+
                                "5 = Player, 4 = EventHost 3 = Guide 2 = Moderator 1 = Admin 0 = Owner \n"+
                                "\n"+
                                "[Delete an Account]\n"+
                                "account delete username";
                            string createUseage = "[Create an Account]\naccount create username password emailaddress secretword 3 \n" +
                                "Last value is User Priv's\n" +
                                "5 = Player, 4 = EventHost 3 = Guide 2 = Moderator 1 = Admin 0 = Owner \n";
                            string deleteUsage = "[Delete an Account]\n" +
                                    "account delete username";

                            // create or delete
                            if (args.Length > 2)
                            {
                                if (args[1].ToLower() == "create")
                                {
                                    if (args[2].ToLower() == "help" || args[2] == string.Empty)
                                    {
                                        Console.WriteLine(createUseage);
                                    }
                                    else
                                    {
                                        string error = string.Empty;
                                        if (!MySqlManager.ValidateAccount(args, out error))
                                        {
                                            if (error.Trim() != string.Empty)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine(error);
                                                Console.ResetColor();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Account {0} Created.", args[2]);
                                        }
                                    }
                                }
                                else if (args[1].ToLower() == "delete")
                                {
                                    if (args.Length != 3)
                                        Console.WriteLine(deleteUsage);
                                    else
                                    {
                                        bool delete = MySqlManager.DeleteUserAccount(args[2].ToLower());
                                        if (delete)
                                            Console.WriteLine("Removed Account {0}.", args[2].ToLower());
                                        else Console.WriteLine("Account {0} not found.", args[2].ToLower());
                                    }
                                }
                                else
                                    Console.WriteLine("create or delete are the only valid options.");
                            }
                            else
                                Console.WriteLine(useage);
                            // Ok this will be the command to create a new account
                            /*
                             * We need
                             * 2: Username
                             * 3: Password
                             * 4: email address
                             * 5: secret word
                             * 6: Priv Level
                             * string string string string int
                             */

                        }
                        #endregion
                        break;
                    case "spell":
                        {
                            List<Account> accts = ServerGlobals.GetAccountsInRoom(1310);
                            Console.WriteLine("Total in room 1310 {0}", accts.Count);
                        }
                        break;
                    case "online":
                        {
                            int online = 0;
                            if (ServerGlobals.LoggedInAccounts != null)
                                online = ServerGlobals.LoggedInAccounts.Count;
                            Console.WriteLine("Currently {0} accounts online.", online);
                        }
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "mem":
                        {
                            // Returns the current memory usage
                            Console.WriteLine(MemoryUseDisplay);
                        }
                        break;
                    case "q":
                        {
                            TestObject t = new TestObject();
                            string fileloc = Path.Combine(ServerGlobals.BaseDirectory, "TestSerialize.xml");

                            SerializedObject.Serialize(t, fileloc);

                            TestObject t1 = SerializedObject.Deserialize<TestObject>(fileloc);
                            Console.WriteLine(t1.ID);
                        }
                        break;
                    case "touint16":
                        {
                            if (args.Length == 2)
                            {
                                // should be 4 letters / numbers
                                string toParse = args[1].Trim();
                                // split string in half
                                if (toParse.Length == 4)
                                {
                                    string b1 = toParse.Substring(0, 2);
                                    string b2 = toParse.Substring(2);
                                    List<byte> blist = new List<byte>();

                                    try
                                    {
                                        byte a;
                                        byte b;
                                        a = Byte.Parse(b1, NumberStyles.HexNumber);
                                        b = Byte.Parse(b2, NumberStyles.HexNumber);
                                        blist.Add(a);
                                        blist.Add(b);
                                        byte[] f1 = blist.ToArray();
                                        ushort result = BitConverter.ToUInt16(f1, 0);
                                        Console.WriteLine("UInt16 result of bytes [{0}] [{1}] = {2}",
                                            BitConverter.ToString(new byte[] { a }), BitConverter.ToString(new byte[] { b }), result);
                                    }
                                    catch { Console.WriteLine("Bad Parse"); }
                                }
                            }
                        }
                        break;
                    case "toint32":
                        {
                            if (args.Length == 2)
                            {
                                // should be 8 letters / numbers
                                string toParse = args[1].Trim();
                                // split string in half
                                if (toParse.Length == 8)
                                {
                                    string b1 = toParse.Substring(0, 2);
                                    string b2 = toParse.Substring(2, 2);
                                    string b3 = toParse.Substring(4, 2);
                                    string b4 = toParse.Substring(6);
                                    List<byte> blist = new List<byte>();

                                    try
                                    {
                                        byte a;
                                        byte b;
                                        byte c;
                                        byte d;
                                        a = Byte.Parse(b1, NumberStyles.HexNumber);
                                        b = Byte.Parse(b2, NumberStyles.HexNumber);
                                        c = Byte.Parse(b3, NumberStyles.HexNumber);
                                        d = Byte.Parse(b4, NumberStyles.HexNumber);
                                        blist.Add(a);
                                        blist.Add(b);
                                        blist.Add(c);
                                        blist.Add(d);
                                        byte[] f1 = blist.ToArray();
                                        f1.Reverse();
                                        Int32 result = BitConverter.ToInt32(f1, 0);
                                        Console.WriteLine("Int32 result of bytes [{0}] [{1}] [{2}] [{3}]= {4}",
                                            BitConverter.ToString(new byte[] { a }), BitConverter.ToString(new byte[] { b }),
                                            BitConverter.ToString(new byte[] { c }), BitConverter.ToString(new byte[] { d }),
                                            result);
                                    }
                                    catch { Console.WriteLine("Bad Parse"); }
                                }
                            }
                        }
                        break;
                    case "touint32":
                        {
                            if (args.Length == 2)
                            {
                                // should be 8 letters / numbers
                                string toParse = args[1].Trim();
                                // split string in half
                                if (toParse.Length == 8)
                                {
                                    string b1 = toParse.Substring(0, 2);
                                    string b2 = toParse.Substring(2, 2);
                                    string b3 = toParse.Substring(4, 2);
                                    string b4 = toParse.Substring(6);
                                    List<byte> blist = new List<byte>();

                                    try
                                    {
                                        byte a;
                                        byte b;
                                        byte c;
                                        byte d;
                                        a = Byte.Parse(b1, NumberStyles.HexNumber);
                                        b = Byte.Parse(b2, NumberStyles.HexNumber);
                                        c = Byte.Parse(b3, NumberStyles.HexNumber);
                                        d = Byte.Parse(b4, NumberStyles.HexNumber);
                                        blist.Add(a);
                                        blist.Add(b);
                                        blist.Add(c);
                                        blist.Add(d);
                                        byte[] f1 = blist.ToArray();
                                        f1.Reverse();
                                        UInt32 result = BitConverter.ToUInt32(f1, 0);
                                        Console.WriteLine("Int32 result of bytes [{0}] [{1}] [{2}] [{3}]= {4}",
                                            BitConverter.ToString(new byte[] { a }), BitConverter.ToString(new byte[] { b }),
                                            BitConverter.ToString(new byte[] { c }), BitConverter.ToString(new byte[] { d }),
                                            result);
                                    }
                                    catch { Console.WriteLine("Bad Parse"); }
                                }
                            }
                        }
                        break;
                    case "tobytes32":
                        {
                            // the next value is a number
                            if (args.Length == 2)
                            {
                                int value = 0;
                                if(int.TryParse(args[1], out value))
                                {
                                    byte[] conv = BitConverter.GetBytes(value);
                                    Console.WriteLine(BitConverter.ToString(conv));
                                }
                            }
                        }
                        break;
                    case "m2ushort":
                        {
                            // we have 2 bytes space 2 bytes 0 1 2 args or 3 total

                            if (args.Length == 3)
                            {
                                try
                                {
                                string firstushort = args[1].Trim();
                                string secondushort = args[2].Trim();

                                string b1 = firstushort.Substring(0, 2);
                                string b2 = firstushort.Substring(2, 2);
                                string b3 = secondushort.Substring(0, 2);
                                string b4 = secondushort.Substring(2, 2);
                                List<byte> blist = new List<byte>();

                                
                                    byte a;
                                    byte b;
                                    byte c;
                                    byte d;
                                    a = Byte.Parse(b1, NumberStyles.HexNumber);
                                    b = Byte.Parse(b2, NumberStyles.HexNumber);
                                    c = Byte.Parse(b3, NumberStyles.HexNumber);
                                    d = Byte.Parse(b4, NumberStyles.HexNumber);
                                    byte[] fArg = { a, b };
                                    byte[] sArg = { c, d };
                                    ushort vone = BitConverter.ToUInt16(fArg, 0);
                                    ushort vtwo = BitConverter.ToUInt16(sArg, 0);
                                    Console.WriteLine("We got {0} and {1} for a difference of {2} or {3}", 
                                        vone, vtwo, vone - vtwo, vtwo - vone);
                                }
                                catch { Console.WriteLine("Bad Parse"); }
                            }
                        }
                        break;
                    case "bc":
                        {
                            if (args.Length > 2)
                            {
                                // get the rest of this string
                                StringBuilder build = new StringBuilder();
                                foreach (string s in args)
                                    build.Append(s + " ");
                                string first = build.ToString().Remove(0, 3);
                                string[] parse2 = first.Split(' ');
                                // whats the color ?
                                int color = -1;
                                if (int.TryParse(parse2[0], out color))
                                {
                                    // Fix the last string again then
                                    build.Clear();
                                    foreach (string s in parse2)
                                        build.Append(s + " ");
                                    string message = build.ToString().Remove(0, parse2[0].Length + 1);
                                    byte[] messagePacket = RealmPacketIO.BuildGossipPacket(color, message, "SERVER");
                                    ServerGlobals.SendToAllClients(messagePacket);
                                    byte[] messagePacket2 = Packet.ChatPacket(color, 1, message, "SERVER");
                                    ServerGlobals.SendToAllClients(messagePacket2);
                                    //Console.WriteLine(message);
                                }
                                else Console.WriteLine("Bad color argument of {0}", parse2[0]);
                            }
                            else Console.WriteLine("Usage: bc 10 I want to say hi !!");
                            

                        }
                        break;
                    case "sta":
                        {
                            //string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ServerPacket24Message.txt");
                            byte[] fake0 = RealmPacketIO.ServerMessageType1(
                                "A Topic Test", "A Very Nice Message, we couldnt have much nicer, so dont be a dick!");//RealmPacketIO.GetByteArrayFromFile(fileLocation);

                            if (args.Length == 2)
                            {
                                if (args[1].ToLower() == "len")
                                {
                                    Console.WriteLine("Message Packet Length {0}", 
                                        BitConverter.ToString(BitConverter.GetBytes(fake0.Length - 8)));
                                }
                            }
                            else
                            {
                                //ServerPacket24Message.txt

                                ServerGlobals.SendToAllClients(fake0);
                            }
                        }
                        break;
                    case "sta2":
                        {
                            // ServerMessagePacket81.txt
                            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ServerMessagePacket81.txt");
                            byte[] fake0 = RealmPacketIO.ServerMessageType2(
                                "Fuck you and da horse you roded in on foo!");//RealmPacketIO.GetByteArrayFromFile(fileLocation);
                            if (args.Length == 2)
                            {
                                if (args[1].ToLower() == "len")
                                {
                                    Console.WriteLine("Message Packet Length {0}",
                                        BitConverter.ToString(BitConverter.GetBytes(fake0.Length - 8)));
                                }
                            }
                            else
                            {
                                // ServerMessagePacket81.txt

                                ServerGlobals.SendToAllClients(fake0);
                            }
                        }
                        break;
                    case "switch":
                        {
                            if (ServerGlobals.LoadFromSql) { ServerGlobals.LoadFromSql = false; Console.WriteLine("Loading from CharData.txt File."); }
                            else { ServerGlobals.LoadFromSql = true; Console.WriteLine("Loading from MySql."); }
                        }
                        break;
                    case "croom":
                        {
                            // Sends a packet derived from a filename in our debug dir
                            // args[1] is the filename
                            string fileLocation = string.Empty;
                            if (args.Length != 2)
                            {
                                Console.WriteLine("Please supply a filename with extention.");
                            }
                            else
                            {
                                if (args[1].Trim() == "off")
                                {
                                    RealmPacketIO.CustomRoomLoad = false;
                                    RealmPacketIO.CustomRoomFile = string.Empty;
                                }
                                else
                                {
                                    fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), args[1].Trim());
                                    if (!File.Exists(fileLocation))
                                    {
                                        Console.WriteLine("Unable to find file {0}", fileLocation);
                                    }
                                    else
                                    {
                                        RealmPacketIO.CustomRoomLoad = true;
                                        RealmPacketIO.CustomRoomFile = args[1].Trim();
                                        Console.WriteLine("CustomFile Atrrib = {0} for file {1}",
                                            RealmPacketIO.CustomRoomLoad, RealmPacketIO.CustomRoomFile);
                                    }
                                }
                            }
                        }
                        break;
                    case "to":
                        {
                        }
                        break;
                    case "itempacket":
                        {
                            for (int f = 0; f < 2001; f++)
                            {
                                Item i = new Item();
                                i.GraphicID = 1444;
                                i.Color = 0x69;
                                //uint id = 0;
                               // byte[] r = i.Ser();
                                //byte[] item = i.Serialize(out id);
                                Console.Write("\rItem:{0}.          ", f);
                            }
                        }
                        break;
                    case "send":
                        {
                            // Sends a packet derived from a filename in our debug dir
                            // args[1] is the filename
                            string fileLocation = string.Empty;
                            if (args.Length != 2)
                            {
                                Console.WriteLine("Please supply a filename with extention.");
                            }
                            else
                            {
                                fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), args[1].Trim());
                                if (!File.Exists(fileLocation))
                                {
                                    Console.WriteLine("Unable to find file {0}", fileLocation);
                                }
                                else
                                {
                                    byte[] fileToArray = null;
                                    try { fileToArray = RealmPacketIO.GetByteArrayFromFile(fileLocation); }
                                    catch (Exception ex) { Console.WriteLine(ex.Message); }

                                    if (fileToArray != null)
                                    {
                                        ServerGlobals.SendToAllClients(fileToArray);
                                        Console.WriteLine("Sent {0}", fileLocation);
                                    }
                                }
                            }
                        }
                        break;
                    case "a":
                        {
                            
                        }
                        break;
                    case "x":
                        {
                            //byte[] p = RealmPacketIO.Test;
                           // ServerGlobals.SendToAllClients(p);
                        }
                        break;
                    case "w":
                        {
                            /*
                            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Lookat.txt");
                            byte[] fake0 = RealmPacketIO.GetByteArrayFromFile(fileLocation);
                            byte[] len = BitConverter.GetBytes(fake0.Length);
                            Console.WriteLine(BitConverter.ToString(len));
                             */
                            
                        }
                        break;
                    case "t":
                        {
                            // try to get this room
                            Room found = null;
                            if (ScriptResolver.ImportedRooms.TryGetRoom(213, out found))
                            {
                                Console.WriteLine("Found room {0}", 213);
                                Console.WriteLine(BitConverter.ToString(found.GetRoomPacket(3)));
                            }
                        }
                        break;
                    case "tt":
                        {
                            // messin wit commands
                            if (ScriptResolver.ImportedCommands.Count == 0)
                            {
                                Console.WriteLine("WTF ?");
                            }
                            else
                            {
                                Console.WriteLine("{0} commands found.", ScriptResolver.ImportedCommands.Count);
                                foreach (Command cmd in ScriptResolver.ImportedCommands)
                                {
                                    Console.WriteLine("Command Name {0}", cmd.CommandName);

                                    Command[] cmds = ScriptResolver.ImportedCommands.CommandsByPrefix('/');
                                    Console.WriteLine("Commands by Prefix returned {0}", cmds.Length);
                                }
                            }
                        }
                        break;
                    case "lmob":
                        {
                            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "mobtest.txt");
                            byte[] fake0 = RealmPacketIO.GetByteArrayFromFile(fileLocation);
                            byte[] len = BitConverter.GetBytes(fake0.Length);
                            Console.WriteLine(BitConverter.ToString(len));
                        }
                        break;
                    case "mob":
                        {
                            string fileLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "mobtest.txt");
                            byte[] fake0 = RealmPacketIO.GetByteArrayFromFile(fileLocation);
                            Console.WriteLine("We have a packet {0} in length.", fake0.Length);
                            ServerGlobals.SendToAllClients(fake0);
                        }
                        break;
                    case "s":
                        {
                            
                            string fileLocation = Path.Combine(ServerGlobals.BaseDirectory, "Test.log");
                            RLog log = new RLog(fileLocation);
                            StringBuilder b = new StringBuilder();
                            for (int i = 2000; i != 0; i--)
                            {
                                b.AppendLine(i.ToString());
                            }
                            log.LogMessage(b.ToString(), MessageType.Warning);
                            
                        }
                        break;
                    case "start":
                        {
                            this.Start();
                        }
                        break;
                    case "stop":
                        ThreadMgr.Stop();
                        srv.Stop();
                        break;
                    case "exit":
                        this.Stop();
                        break;
                    default:
                        Console.WriteLine("No Such Command: " + input + "\r\n");
                        break;
                }
            }
        }
        public void Start()
        {
            // if (cmd.Length == 3)
            // {
            srv.TcpIP = IPAddress.Any;
            srv.TcpPort = 8001;
            srv.EnableTCP = true;
            ServerGlobals.Init();
            ThreadMgr.Start();
            srv.Start();
            // Turn on and test our mysql
            try
            {
                bool mysql = MySqlManager.TestConnection;
                Console.WriteLine("MySql Initialize {0}", mysql ? "Successful" : "Unsuccessful");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to continue, error is {0}\nPress any key to close!", ex.Message);
                Console.Read();
                this.IsConsoleShuttingDown = true;
            }
                            
        }
        public void Stop()
        {
            IsConsoleShuttingDown = true;
        }
        public long MemoryUsage
        {
            get { return Process.GetCurrentProcess().WorkingSet64; }
        }
        public string MemoryUseDisplay
        {
            get { return string.Format("Current Server Memory use in Kilobytes {0} kbs.", MemoryUsage / 1024); }
        }
        public void LoadScripts()
        {
            string[] files = CSharpCompiler.GetScripts("*.cs");
            Console.WriteLine("Found {0} Scripts.", files.Length);
            CSharpCompiler.Compile(files);
            // So look for our new assembly
            string dll = Path.Combine(ServerGlobals.BaseDirectory, "Scripts\\Scripts.dll");
            Assembly a = Assembly.LoadFrom(dll);

            if (a != null)
            {
                ScriptResolver.LoadScriptObjects(a);
                
            }
        }
        void InitGameData()
        {
            BaseMobile.Init();
            BaseItem.Init();
            // load all room id's into used id' section
            foreach (Room r in ScriptResolver.ImportedRooms)
            {
                r.RoomsIDsInUse.Add(r.RoomID);
            }
            Console.WriteLine("Server startup tasks complete.");
        }
    }
}
