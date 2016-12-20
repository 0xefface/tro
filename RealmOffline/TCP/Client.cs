using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp.Base;
using RealmOffline.Packets;
using System.Threading.Tasks;

namespace RealmOffline.Tcp
{
    public class Client : ClientBase
    {
        public ServerBase rServer;
        public Client(ServerBase srv)
            : base(srv)
        {
            this.rServer = srv;
        }

        protected override void OnReceive(int numBytes)
        {
            byte[] packet = new byte[numBytes];
            Array.Copy(m_readBuffer.Array, m_readBuffer.Offset, packet, 0, numBytes);
            int pktId = BitConverter.ToInt32(packet, 4);

            Console.WriteLine("Router:> Client::OnReceive({0}) Packet Id: ({1})", numBytes, pktId);
            Task task = Task.Factory.StartNew(() =>
                {
                    try { RealmPacketIO.ParseUpdatesRequest(this, packet, pktId); }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error parsing packet from {0}:\n{1}",
                            this.TcpSocket.RemoteEndPoint, ex.Message);
                        Console.ResetColor();
                    }
                });

        }
    }
}
