using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp;
using System.Threading.Tasks;
using RealmOffline.Base;
using RealmOffline.Queues;
using System.Diagnostics;
using RealmOffline.Accounts;
using System.Reflection;
using System.IO;
using RealmOffline.Tcp.Base;
using RealmOffline.Core;

namespace RealmOffline
{
    public static class ServerGlobals
    {
        public static bool AutoAccountCreation = true;
        public static bool ServerRunning = false;
        public static LoggedInPlayers LoggedInAccounts { get; private set; }
        public static List<uint> CharacterIDsInUse { get; set; }
        public static HashSet<uint> AvailableIDs { get; set; }
        public static bool LoadFromSql = true;
        private static Stopwatch RunningTime { get; set; }
        public static bool UseVBScripts = false;

        public static void Init()
        {
            LoggedInAccounts = new LoggedInPlayers();
            CharacterIDsInUse = new List<uint>();
            CharacterIDsInUse.Add(0); // never use 0
            ServerGlobals.ServerRunning = true;

            RunningTime = new Stopwatch();
            RunningTime.Start();
        }
        public static string GetCurrentUpTime
        {
            get
            {
                return string.Format("Server up for {0} Day(s), {1} Hour(s), {2} Minute(s).", RunningTime.Elapsed.Days, RunningTime.Elapsed.Hours, 
                    RunningTime.Elapsed.Minutes);
            }
        }
        public static bool IsAccountInUse(uint sqlAccountId)
        {
            bool inuse = false;
            foreach (Account a in LoggedInAccounts)
            {
                if (a.SqlId == sqlAccountId)
                    inuse = true;
            }
            return inuse;
        }
        public static string GetCurrentNumberOfPlayers
        {
            get
            {
                string reply = string.Empty;
                if(LoggedInAccounts.Count == 1)
                reply =  string.Format("You are all alone in this big world.");
                else reply = string.Format("There are currently {0} players online.", LoggedInAccounts.Count);
                return reply;
            }
        }
        public static uint GetNextAvailableID()
        {
            for (uint i = uint.MinValue +2000; i < uint.MaxValue -100; i++)
            {
                if (!CharacterIDsInUse.Contains(i))
                {
                    CharacterIDsInUse.Add(i);
                    return i;
                }
            }
            return 0;
        }
        public static void SendToAccounts(Account[] accts, byte[] packet)
        {
            Task task = Task.Factory.StartNew(() =>
                {
                    int totalSent = 0;
                    for (int i = 0; i < accts.Length; i++)
                    {
                        try { accts[i].Socket.Send(ref packet); totalSent++; }
                        catch (Exception ex)
                        {
                            // We cant send
                            Console.WriteLine("We cant send to {0} ERROR: {1}",
                                accts[i].Socket.TcpSocket.RemoteEndPoint, ex.Message);
                        }
                    }
                    Console.WriteLine("Packet sent to {0} clients.", totalSent);
                });
        }
        public static void SendToAllClients(byte[] packet)
        {
            Task task = Task.Factory.StartNew(() =>
                {
                    int totalSent = 0;
                        for (int i = 0; i < LoggedInAccounts.Count; i++)
                        {
                            try { LoggedInAccounts[i].Socket.Send(ref packet); totalSent++; }
                            catch (Exception ex)
                            {
                                // We cant send
                                Console.WriteLine("We cant send to {0} ERROR: {1}", 
                                    LoggedInAccounts[i].Socket.TcpSocket.RemoteEndPoint, ex.Message);
                            }
                        }
                        Console.WriteLine("Packet sent to {0} clients.", totalSent);
                });
        }
        
        public static void RemoveAccountByClient(Account account)
        {
            Task task = Task.Factory.StartNew(() =>
                {
                    try
                    {
                        int found = -1;
                        // First remove this account
                        for (int i = 0; i < LoggedInAccounts.Count; i++)
                        {
                            if (LoggedInAccounts[i] == account)
                                found = i;
                        }
                        if (found != -1)
                        {
                            RemoveID(account.AccountId);
                            LoggedInAccounts.RemoveAt(found);
                        }
                    }
                    catch (Exception ex) { Console.WriteLine("Remove acct "+ex.Message); }
                });
        }
         
        public static void AddAccount(Account account)
        {
            if (!LoggedInAccounts.Contains(account))
             {
                LoggedInAccounts.QueueItem(account);
             }
            // Now make sure we are all connected still

        }
        public static void RemoveID(uint id)
        {
            int index = -1;
            for (int i = 0; i < ServerGlobals.CharacterIDsInUse.Count; i++)
            {
                if (ServerGlobals.CharacterIDsInUse[i] == id)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                ServerGlobals.CharacterIDsInUse.RemoveAt(index);
            }
        }
        public static void ClearAccount(Account account, bool disconnect = false)
        {
            // this clears a account of all in use id's
            int removed = 0;
            RemoveID(account.AccountId);
            removed++;
            if (account.CurrentChannel != null)
            {
                try 
                {
                    Channel ch = account.CurrentChannel;
                    // Leave channel
                    //ch.SendLeavePacket(account);

                    if (ch.Moderator == account.CurrentCharacter.Name &&
                        ch.CurrentUsers == 0) // just you
                    {
                        // Remove the channel
                        ScriptResolver.ImportedChannels.Remove(ch);
                    }
                }
                catch { }
            }
            foreach (Character c in account.Characters)
            {
                if (c != null)
                {
                    if (c.Location != null)
                    {
                        if (c.Location.CurrentRoom != null)
                        {
                            try
                            {
                                // Save the last location 
                                c.Location.CurrentRoom.RemoveEntity(c, account);
                            }
                            catch { }
                        }
                    }
                    RemoveID(c.GameID);
                    removed++;
                    foreach (uint invid in c.IDsInUse)
                    {

                        RemoveID(invid);
                        removed++;
                    }
                    // Clear game id's
                }
            }
            if (disconnect)
            {
                // then we got more to do
                // force a disconnect of the socket
                //account.Socket.rServer.DisconnectClient(account.Socket, true);
                // remove us
                RemoveAccountByClient(account);
                string accountName = "Invalid";
                if (account.Username != string.Empty)
                    accountName = account.Username;

                Console.WriteLine("Account {0} forceably removed!", accountName);
            }
        }
        public static bool TrySend(Account account, byte[] testMessage)
        {
            try { account.Socket.Send(ref testMessage); return true; }
            catch { return false; }
        }
        public static string BaseDirectory
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }
        }
        public static string ExePath
        {
            get
            {
                return Assembly.GetExecutingAssembly().Location;
            }
        }
        public static bool TryGetAccountByClient(ClientBase client, out Account acct)
        {
            acct = null;
            for(int i = 0; i < LoggedInAccounts.Count;i++)
                if (LoggedInAccounts[i].Socket == client) { acct = LoggedInAccounts[i]; }
            return acct != null;
        }
        public static List<Account> GetAccountsInRoom(uint room)
        {
            List<Account> reply = new List<Account>();

            for (int i = 0; i < LoggedInAccounts.Count; i++)
            {
                if(LoggedInAccounts[i].CurrentCharacter != null)
                {
                    if (LoggedInAccounts[i].CurrentCharacter.Location != null)
                    {
                        if (LoggedInAccounts[i].CurrentCharacter.Location.CurrentRoom != null)
                        {
                            if (LoggedInAccounts[i].CurrentCharacter.Location.CurrentRoom.RoomID == room)
                                reply.Add(LoggedInAccounts[i]);
                        }
                    }
                }
            }
            return reply;
        }
        public static Account GetAccountFromCharacter(Character c)
        {
            for (int i = 0; i < LoggedInAccounts.Count; i++)
            {
                if (LoggedInAccounts[i].CurrentCharacter == c) return LoggedInAccounts[i];
            }
            return null;
        }
    }
}
