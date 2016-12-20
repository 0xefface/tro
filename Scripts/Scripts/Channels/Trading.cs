using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core;

namespace Scripts.Channels
{
    public class Trading : Channel
    {
        public Trading()
        {
            this.SetChannelInfo("5", "Trading", "Trade your wares here !!", null);
        }
    }
}
