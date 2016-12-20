using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core;
using RealmOffline.Tcp;
using System.Threading.Tasks;
using RealmOffline.Base;

namespace RealmOffline.Commands
{
    public class ImportedCommands : ComponentCollection<Command>
    {
       
        /// <summary>
        /// Finds a command by command name
        /// </summary>
        /// <param name="commandName">the command name</param>
        /// <returns>the command or null if none found.</returns>
        public Command CommandByCommandName(char prefix, string commandName)
        {
            commandName = CleanCommandText(commandName);
            Command found = null;
            foreach (Command cmd in this.List)
            {
                if(prefix == cmd.CommandPrefix && cmd.CommandName.Trim().ToLower() == commandName.ToLower())
                    found = cmd;
            }
            return found;
        }
        public Command[] CommandsByPrefix(char prefix)
        {
            List<Command> commands = new List<Command>();
            foreach (Command cmd in this.List)
            {
                if (cmd.CommandPrefix == prefix)
                    commands.Add(cmd);
            }
            return commands.ToArray();
        }
        /// <summary>
        /// Finds the command for this packet
        /// </summary>
        /// <param name="client">the client requesting the command</param>
        /// <param name="commandPacket">the client packet</param>
        /// <returns>true if a command was found and passed the packet</returns>
        public bool ReactToPacket(Account account, byte[] commandPacket)
        {
            // the packet comes to us with a few bites of information
            // we dont need, so strip those now
            // First 8 bytes payload length and packid removed, and last 4 bytes crc removed
            byte[] trimmedPacket = new byte[commandPacket.Length - 12];

            try { Array.Copy(commandPacket, 8, trimmedPacket, 0, trimmedPacket.Length); }
            catch (Exception ex)
            {
                // Reply with bad command and why
                Tools.SetColor(ConsoleColor.Red);
                Console.WriteLine("Unable to trim message: {0}", ex.Message);
                Tools.ResetColor();
                return false;
            }
            try
            {
                // Get the command sent
                List<string> args = Encoding.ASCII.GetString(trimmedPacket).Split(' ').ToList();
                // first list item is the command with prefix
                string commandName = args[0];
                // remove it from the list, we dont need it
                args.RemoveAt(0);
                // split the prefix and command
                char prefix = char.Parse(commandName.Substring(0, 1));
                commandName = commandName.Remove(0, 1);
                // get the command
                Command theCommand = this.CommandByCommandName(prefix, commandName);
                if (theCommand != null)
                {
                    theCommand.SetCommandInfo(account, trimmedPacket);
                    Console.WriteLine("Command info set");
                    Task task = Task.Factory.StartNew(() => { theCommand.ReactToPacket(); });
                }
            }
            catch (Exception ex)
            {
                // Reply with bad command and why
                Tools.SetColor(ConsoleColor.Red);
                Console.WriteLine("Unable to execute command: {0}", ex.Message);
                Tools.ResetColor();
                return false;
            }

            return true;
        }
        public string CleanCommandText(string text)
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
    }
}
