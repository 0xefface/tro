using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Logs;
using System.IO;
using RealmOffline.Commands;
using RealmOffline.Core.Items;
using RealmOffline.Core.Mobiles;
using RealmOffline.Core.Rooms;
using System.Reflection;
using RealmOffline.Channels;

namespace RealmOffline.Core
{
    public static class ScriptResolver
    {
        //Our logger
        private static readonly RLog logger = new RLog(Path.Combine(ServerGlobals.BaseDirectory, @"ScriptErrors\Error\Error.log"));

        private static List<Item> gameItems;
        public static List<Item> GameItems
        {
            get { return gameItems; }
            set { gameItems = value; }
        }
        private static List<Mobile> gameMobiles;
        public static List<Mobile> GameMobiles
        {
            get { return gameMobiles; }
            set { gameMobiles = value; }
        }
        private static List<Command> gameCommands;
        public static List<Command> GameCommands
        {
            get { return gameCommands; }
            set { gameCommands = value; }
        }
        private static List<Channel> channels;
        public static List<Channel> Channels
        {
            get { return channels; }
            set { channels = value; }
        }
        // Begin our classes collections
        private static ImportedCommands importedCommands;
        public static ImportedCommands ImportedCommands
        {
            get { return importedCommands; }
            private set { importedCommands = value; }
        }
        private static ImportedItems importedItems;
        public static ImportedItems ImportedItems
        {
            get { return importedItems; }
            private set { importedItems = value; }
        }
        private static ImportedMobiles importedMobiles;
        public static ImportedMobiles ImportedMobiles
        {
            get { return importedMobiles; }
            private set { importedMobiles = value; }
        }
        private static ImportedRooms importedRooms;
        public static ImportedRooms ImportedRooms
        {
            get { return importedRooms; }
            set { importedRooms = value; }
        }
        private static ImportedChannels importedChannels;
        public static ImportedChannels ImportedChannels
        {
            get { return importedChannels; }
            set { importedChannels = value; }
        }
        private static readonly Type[] mSerialTypeArray = new Type[1] { typeof(Entity) };

        public static void LoadScriptObjects(Assembly asm)
        {
            gameItems = new List<Item>();
            gameMobiles = new List<Mobile>();
            gameCommands = new List<Command>();
            channels = new List<Channel>();
            importedCommands = new ImportedCommands();
            importedItems = new ImportedItems();
            importedMobiles = new ImportedMobiles();
            importedRooms = new ImportedRooms();
            importedChannels = new ImportedChannels();
            // Loading our scripts here by type
            try
            {
                foreach (Type t in asm.GetTypes())
                {
                    if (t.IsSubclassOf(typeof(Item)))
                    {
                        bool hasItemAttrib = RequireCommandAttribute(typeof(GameItemAttribute), t);
                        if (!hasItemAttrib)
                        {
                            logger.LogMessage(string.Format("Script {0} does not have the required GameAttribute, and will no be loaded!", t.Name), MessageType.Warning);
                        }
                        else
                        {
                            importedItems.Add(Activator.CreateInstance(t) as Item);
                        }
                    }
                    if (t.IsSubclassOf(typeof(Mobile)))
                    {
                        importedMobiles.Add(Activator.CreateInstance(t) as Mobile);
                    }
                    if (t.IsSubclassOf(typeof(Command)))
                    {
                        // All commands must have a priv level assigned, or they will not be loaded !
                        bool isValidCommand = RequireCommandAttribute(typeof(RequiredPrivledgeAttribute), t);
                        if (!isValidCommand)
                            logger.LogMessage(string.Format("Command {0} has no privs assigned and will not be loaded!!", t.Name), MessageType.Error);
                        else
                        {
                            importedCommands.Add(Activator.CreateInstance(t) as Command);
                        }
                    }
                    if (t.IsSubclassOf(typeof(Channel)))
                    {
                        ImportedChannels.AddChannel(Activator.CreateInstance(t) as Channel);
                    }
                    if (t.IsSubclassOf(typeof(Room)))
                        importedRooms.Add(Activator.CreateInstance(t) as Room);
                }
                Tools.SetColor(ConsoleColor.Yellow);
                Console.WriteLine("Loaded {0} Items, {1} Mobiles, {2} Commands, {3} Rooms, {4} Channels.",
                    importedItems.Count, gameMobiles.Count, importedCommands.Count, importedRooms.Count, importedChannels.Count);
                Tools.ResetColor();
            }
            catch (Exception ex) { logger.WriteException(ex); }

        }
        private static bool RequireCommandAttribute(Type attribute, Type type, bool inherit = false)
        {
            object[] attributes = type.GetCustomAttributes(inherit);
            if (attributes.Length == 0) { return false; }
            foreach (Attribute attrib in attributes)
                if (attrib.ToString() == attribute.ToString()) { return true; }
            return false;
        }
        public static void PrintItems()
        {
            string reply = string.Empty;
            if (importedItems.Count == 0) { reply = "No valid items."; }
            else
            {
                foreach (Item i in importedItems)
                {
                    reply += string.Format("Item Name {0}, Item Color {1}, Item Graphic ID {2}\n",
                        i.Name, i.Color, i.GraphicID);
                }
            }
            Tools.SetColor(ConsoleColor.Green);
            Console.WriteLine(reply);
            Tools.ResetColor();
        }
        public static Room GetRoom(uint roomnumber)
        {
            Room reply = ImportedRooms[0];
            for (int i = 0; i < ImportedRooms.Count; i++)
            {
                if (ImportedRooms[i].RoomID == roomnumber) reply = ImportedRooms[i];
            }
            return reply;
        }
    }
}
