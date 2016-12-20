using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp.Base;
using RealmOffline.Packets;
using RealmOffline.Managers;
using System.Threading.Tasks;
using RealmOffline.Accounts;
using RealmOffline.Base;
using System.Diagnostics;

namespace RealmOffline.Tcp
{
    public class WorldClient : ClientBase
    {
        public ServerBase rServer;
        // So now we begin our char section, that is specific to this game
        // Values can be stored and updated here for faster retrieval
        // The ID assigned to this account via sql, it is used
        // to look up values pertaining to this account and chars.
        
        public Account GameAccount { get; private set; }

        public WorldClient(ServerBase srv)
            : base(srv)
        {
            this.rServer = srv;
        }
        public bool SetGameAccount(Account account)
        {
            this.GameAccount = account;
            return this.GameAccount == account;
        }
        protected override void OnReceive(int numBytes)
        {
            byte[] packet = new byte[numBytes];
            Array.Copy(m_readBuffer.Array, m_readBuffer.Offset, packet, 0, numBytes);
            int pktId = BitConverter.ToInt32(packet, 4);
            // Thread it
            Task task = Task.Factory.StartNew(() =>
                {
                    RealmPacketIO.ParseWorldPackets(this, packet, pktId);
                    if(this.GameAccount != null)
                    this.GameAccount.IntervalTimer.Restart();
                });

        }
    }
}
