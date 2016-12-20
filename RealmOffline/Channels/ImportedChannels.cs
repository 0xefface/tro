using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core;

namespace RealmOffline.Channels
{
    public class ImportedChannels : ComponentCollection<Channel>
    {

        public void AddChannel(Channel channel)
        {
            lock (this.List)
            {
                this.List.Add(channel);
            }

            this.OrderChannels();
        }
        public void RemoveChannel(Channel channel)
        {
            lock (this.List)
            {
                this.List.Remove(channel);
            }

            this.OrderChannels();
        }
        public Channel GetChannelByNumber(int chanNum)
        {
            Channel found = null;
            for (int i = 0; i < this.List.Count; i++)
            {
                if (((Channel)this.List[i]).ChannelNumber == chanNum.ToString()) { found = this.List[i] as Channel; }
            }
            return found;
        }
        public void OrderChannels()
        {
            Channel[] channels = new Channel[this.List.Count];
            this.List.CopyTo(channels, 0);
            var items = (from r in channels
                         select r).OrderBy(q => Convert.ToUInt16(q.ChannelNumber));
            lock (this.List)
            {
                this.List.Clear();
                foreach (Channel chan in items)
                    this.List.Add(chan);
            }
        }
    }
}
