using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core;

namespace Scripts.Channels
{
    public class General: Channel
    {
        public General()
        {
            this.SetChannelInfo("1", "General", "Talk about general stuff.", null);
        }
    }
}
