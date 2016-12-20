using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core;

namespace Scripts.Channels
{
    public class Emulator : Channel
    {
        public Emulator()
        {
            this.SetChannelInfo("6", "Emulator", "The Emulator Channel!!", null);
        }
    }
}
