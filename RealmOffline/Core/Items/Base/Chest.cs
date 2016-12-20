using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Items.Base
{
    public class Chest : BaseGameItem
    {
        public bool IsOpen
        {
            get { return this.IsInventoryItem; }
            set { this.IsInventoryItem = value; }
        }
        public bool IsLocked { get; set; }
        public bool IsPickable { get; set; }
        public ushort KeyGraphicID { get; set; }
        public BaseGameItem SpecificKey { get; set; }

    }
}
