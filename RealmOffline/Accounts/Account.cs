using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp;
using RealmOffline.Accounts;
using RealmOffline.Managers;
using System.Diagnostics;
using RealmOffline.Core;

namespace RealmOffline.Base
{
    public class Account
    {
        /// <summary>
        /// The mysql database id in Users for this account.
        /// </summary>
        public uint SqlId { get; private set; }

        public string Username { get; set; }

        public uint AccountId = 0;
        /// <summary>
        /// Characters by slot
        /// </summary>
        public List<Character> Characters { get; set; }

        /// <summary>
        /// Return this value to null when it is not being used
        /// </summary>
        public Character CurrentCharacter = null;
        /// <summary>
        /// Switch to let us know when we are making a new character
        /// </summary>
        public bool InCharacterCreationProcess = false;

        public WorldClient Socket { get; private set; }
        public Channel CurrentChannel { get; set; }
        public List<uint> IDsInUse { get; set; }
        /// <summary>
        /// If we have enough new char data, then we can generate a new char
        /// </summary>
        public bool CanGenerateNewChar
        {
            get
            {
                if (this.CurrentCharacter == null) { return false; }
                return this.CurrentCharacter.CharDataAdded;
            }
        }
        public Stopwatch IntervalTimer { get; set; }

        /// <summary>
        /// Creates a base account, needs a valid sql id
        /// in order for data to be sent to and from the mysql database
        /// </summary>
        /// <param name="client">The connected worldclient</param>
        /// <param name="dataBaseId">The mysql User ID</param>
        public Account(WorldClient client,  uint acctId, uint dataBaseId)
        {
            this.AccountId = acctId;
            this.SqlId = dataBaseId;
            this.Socket = client;
            this.Characters = new List<Character>(4);
            this.IDsInUse = new List<uint>();
            this.IDsInUse.Add(acctId);
            this.IntervalTimer = new Stopwatch();
            this.IntervalTimer.Start();
        }

        /// <summary>
        /// Adds a character to a valid slot (only 4 are valid)
        /// </summary>
        /// <param name="character">The Character to add</param>
        /// <param name="slot">the char slot</param>
        /// <returns>true if slot has been updated</returns>
        public bool AddCharacter(Character character)
        {
            if (NumberOfValidCharacters >= 4) { return false; } // cant add more
            try
            { 
                if(!this.Characters.Contains(character)) this.Characters.Add(character); 
                return true; 
            }
            catch (Exception ex) { Console.WriteLine("{0} : {1}", ex.Message, ex.StackTrace); return false; }
        }
        public byte[] GenerateCreateCharPacket()
        {
            if (this.CurrentCharacter == null) { return null; }

            return this.CurrentCharacter.CreateNewChar48(this.AccountId);
        }
        public int NumberOfValidCharacters
        {
            get
            {
                // Alphabatize this list, moving nulls to the bottom
                try { this.Characters = this.Characters.OrderBy(c => c.Name).ToList<Character>(); }
                catch { } // we dont care
                int number = 0;
                foreach (Character cha in this.Characters)
                {
                    if (cha != null) { number++; }
                }
                return number;
            }
        }
        public bool RemoveCharByGameID(uint gameID)
        {
            Character c = GetCharFromGameID(gameID);
            if (c == null)
            {
                Console.WriteLine("Unable to find {0}", gameID);
                return false;
            }
            bool rem = MySqlManager.DeleteCharacter(c);
            return this.Characters.Remove(c) && rem;
        }
        public Character GetCharFromGameID(uint gameID)
        {
            Character reply = null;
            
           // foreach (Account a in ServerGlobals.LoggedInAccounts)
           // {
                foreach (Character c in this.Characters)
                {
                    if (c != null)
                    {
                        Console.WriteLine("Looking for {0} found {1}", gameID, c.GameID);
                        if (c.GameID == gameID)
                        {
                            reply = c; 
                            break;
                        }
                    }
                }
           // }
            return reply;
        }
     
    }
}
