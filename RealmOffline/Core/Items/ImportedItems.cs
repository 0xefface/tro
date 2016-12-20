using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core.Items
{
    public class ImportedItems : ComponentCollection<Item>
    {
    }
}
/*
    public class ImportedItems : System.Collections.CollectionBase, IDisposable
    {
        public void Add(Item item)
        {
            if (!this.List.Contains(item))
                this.List.Add(item);
        }
        public void Remove(Item item)
        {
            if (this.List.Contains(item))
                this.List.Remove(item);
        }
        public void ClearItems()
        {
            this.List.Clear();
        }
        public int IndexOf(Item item)
        {
            return this.List.IndexOf(item);
        }
        public void Insert(int index, Item item)
        {
            this.List.Insert(index, item);
        }
        public Item this[int index]
        {
            get
            {
                return this.List[index] as Item;
            }
        }
        public void Dispose()
        {
            this.Clear();
        }
    }
*/