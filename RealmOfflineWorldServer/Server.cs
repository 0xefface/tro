using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp.Base;
using RealmOffline.Tcp;
using RealmOffline.Packets;
using RealmOffline;
using RealmOffline.Base;

namespace RealmOfflineWorldServer
{
    public class Server : ServerBase
    {
        #region override
        public Server()
            : base()
        {
        }

        protected override void OnSendTo(System.Net.IPEndPoint clientIP, int num_bytes)
        {
        }
        protected override void OnReceiveUDP(int num_bytes, byte[] buf, System.Net.IPEndPoint ip)
        {
        }
        protected override ClientBase CreateClient()
        {
            Console.WriteLine("WorldServer::CreateClient");
            return new WorldClient(this);
        }
        protected override bool OnClientConnected(ClientBase client)
        {
            /*
             * Encryption is handled here, in this hello a 4 byte XOR section is needed
             * also a 2 byte code/decode is needed.
             */
            Console.WriteLine("WorldServer::OnClientConnected");
            PacketWriter w = new PacketWriter(25);
            w.WriteInt32(0);
            w.WriteInt32(0);
            w.WriteInt32(1);
            w.WriteInt32(0);
            w.WriteBytes(new byte[] { 0x00, 0xE4, 0x82, 0x80 }); // Isnt reused, so guess it dont matter.
            byte[] hello = w.ToArray();
            client.Send(ref hello);
            return base.OnClientConnected(client);
        }
        protected override void OnClientDisconnected(ClientBase client, bool forced)
        {
            Console.WriteLine("WorldServer::OnClientDisconnected");
            Account acct = null;
            if (ServerGlobals.TryGetAccountByClient(client, out acct))
            {
                Console.WriteLine("Trying to clear acct");
                ServerGlobals.ClearAccount(acct, true);
            }
            
            base.OnClientDisconnected(client, forced);
        }
        public override void Start()
        {
            Console.WriteLine("WorldServer::Start");
           base.Start();
        }
        public override void Stop()
        {
            Console.WriteLine("WorldServer::Stop");
            base.Stop();
        }
        #endregion
    }
}
