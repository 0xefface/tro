using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public class ComponentCollection<T> : System.Collections.CollectionBase, IDisposable
    {
        public void Add(T value)
        {
            if (!this.List.Contains(value))
                this.List.Add(value);
        }
        public void Remove(T value)
        {
            if (this.List.Contains(value))
                this.List.Remove(value);
        }
        public int IndexOf(T value)
        {
            return this.List.IndexOf(value);
        }
        public void Insert(int index, T value)
        {
            this.List.Insert(index, value);
        }
        public T this[int index]
        {
            get
            {
                return (T)this.List[index];
            }
        }
        public void Dispose()
        {
            this.Clear();
        }
    }
}
