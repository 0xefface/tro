using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public interface  IEntity
    {
        byte[] Serialize(out uint id);
        void Deserialize(byte[] data);
    }
}
