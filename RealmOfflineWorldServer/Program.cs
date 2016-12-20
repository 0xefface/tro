using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RealmOfflineWorldServer
{
    class Program
    {
        public static Thread cmds;
        static ConsoleCommands consoleCmds = new ConsoleCommands();

        static void Main(string[] args)
        {
            Console.Title = "Realm OFFLine World Server";
            StringBuilder info = new StringBuilder();
            info.AppendLine("*******************************************************************************");
            info.AppendLine("**************** Realm OFFLine  http://www.nerdcoding.com/Realm3x*******");
            info.AppendLine("*******************    Emulates The Realm Online Servers   ********************");
            info.AppendLine("*******************                World Server            ********************");
            info.AppendLine("*******************************************************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(info.ToString() + "\n");
            Console.ResetColor();

            Console.WriteLine("Commands: \n" +
                "start (starts the world server and listens for connections.)\n" +
                "stop (stops the world server and no longer listens for connections.)\n");
            cmds = new Thread(consoleCmds.WaitForCommands);
            //cmds.IsBackground = true;
            cmds.Name = "Command Thread.";
            consoleCmds.ThreadList.Add(cmds);
            // Start it
            cmds.Start();
        }
    }
}
