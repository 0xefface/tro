using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core;

namespace Scripts.Channels
{
    public class GameHelp : Channel
    {
        public GameHelp()
        {
            this.SetChannelInfo("4", "Game Help", "Ask for help here !", null);
        }
    }
}
