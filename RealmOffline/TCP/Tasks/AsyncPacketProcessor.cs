using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Tcp.Base;

namespace RealmOffline.Tcp.Tasks
{
    public class AsyncPacketProcessor : AsyncTask
    {
        public AsyncPacketProcessor(ClientBase client)
            : base(client)
        {
        }
        public override byte[] ProcessClientPacket(ClientBase client, byte[] packet)
        {
            return base.ProcessClientPacket(client, packet);
        }
        public override byte[] ProcessServerPacket(ClientBase client, byte[] packet)
        {
            return base.ProcessServerPacket(client, packet);
        }
    }
}
