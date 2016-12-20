using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public interface ISerializable<out T>
    {
        byte[] Serialize();
        T DeSerialize(byte[] ob);
    }
}
