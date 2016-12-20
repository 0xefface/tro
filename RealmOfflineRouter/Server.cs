using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp.Base;
using RealmOffline.Tcp;

namespace RealmOfflineRouter
{
    public class Server : ServerBase
    {
        public bool IsRunning { get; set; }

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
            Console.WriteLine("RouterServer::CreateClient");
            return new Client(this);
        }
        protected override bool OnClientConnected(ClientBase client)
        {
            Console.WriteLine("RouterServer::OnClientConnected");
            // Say Hi!!

            return base.OnClientConnected(client);
        }
        protected override void OnClientDisconnected(ClientBase client, bool forced)
        {
            Console.WriteLine("RouterServer::OnClientDisconnected");
            // Say Bye !!

            base.OnClientDisconnected(client, forced);
        }
        public override void Start()
        {
            Console.WriteLine("RouterServer::Start");
            Console.WriteLine("RouterServer Listening on {0} Port {1}. ", this.TcpIP, this.TcpPort);
            //Console.WriteLine("Socket is bound {0}", this.m_tcpListen.IsBound);
            IsRunning = true;
            base.Start();
        }
        public override void Stop()
        {
            if (!IsRunning)
            {
                Console.WriteLine("RouterServer::Stop -> Server is not running.");
                return;
            }
            Console.WriteLine("RouterServer::Stop");
            IsRunning = false;
            base.Stop();
        }
        #endregion
    }
}
