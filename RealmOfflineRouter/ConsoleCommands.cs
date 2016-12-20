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
using System.Threading;
using System.Net;
using RealmOffline.Tcp;
using System.Net.Sockets;
using RealmOffline;

namespace RealmOfflineRouter
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
            ServerGlobals.Init();
            while (!IsConsoleShuttingDown)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n(Router Server) ");
                Console.ResetColor();
                input = Console.ReadLine();
                string[] args = input.Split(' ');



                switch (args[0].ToLower())
                {
                    case "start":
                        {
                            this.Start();
                        }
                        break;
                        case "ip":
                            {
                                IPAddress add = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
                                Console.WriteLine(add);
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
            IPAddress address = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
            //if (address != null)
            //{
            IPAddress any = IPAddress.Parse("0.0.0.0");
            srv.TcpIP = any;//IPAddress.Any;
            srv.TcpPort = 7002;
            srv.EnableTCP = true;

            ThreadMgr.Start();
            srv.Start();
            //Console.WriteLine("IpAddress = null {0}", address == null);
            //}
            //Console.WriteLine("Unable to parse Ip");
        }
        public void Stop()
        {
            IsConsoleShuttingDown = true;
        }
    }
}
