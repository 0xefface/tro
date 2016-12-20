using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RealmOfflineRouter
{
    class Program
    {
        public static Thread cmds;
        static ConsoleCommands consoleCmds = new ConsoleCommands();

        static void Main(string[] args)
        {
            Console.Title = "Realm OFFLine Router port 7002";
            StringBuilder info = new StringBuilder();
            info.AppendLine("*******************************************************************************");
            info.AppendLine("**************** Realm OFFLine  http://nerdcoding.com/Realm3x *******");
            info.AppendLine("*******************    Emulates The Realm Online Servers   ********************");
            info.AppendLine("*******************       Router is always port 7002       ********************");
            info.AppendLine("*******************************************************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(info.ToString() + "\n");
            Console.ResetColor();

            Console.WriteLine("Commands: \n" +
                "start (starts the router and listens for connections.)\n" +
                "stop (stops the router and no longer listens for connections.)\n");
            cmds = new Thread(consoleCmds.WaitForCommands);
            //cmds.IsBackground = true;
            cmds.Name = "Command Thread.";
            consoleCmds.ThreadList.Add(cmds);
            // Start it
            cmds.Start();
        }
    }
}
