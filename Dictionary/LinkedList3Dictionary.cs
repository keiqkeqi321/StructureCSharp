using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// 键值对链表为底层的无序字典
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    class LinkedList3Dictionary<Key, Value> : IDictionary<Key, Value>
    {
        Linkedlist3<Key, Value> link;
        public LinkedList3Dictionary()
        {
            link = new Linkedlist3<Key, Value>();
        }
        public int Count => link.Count;

        public bool IsEmpty => link.IsEmpty;

        public void Add(Key key, Value value)
        {
            link.Add(key, value);
        }

        public bool ContainsKey(Key key)
        {
            return link.Contains(key);
        }

        public Value Get(Key key)
        {
           return  link.Get(key);
        }
        public Value TryGet(Key key, out Value outValue)
        {
            Value value = link.TryGet(key);

            outValue = default(Value);
            return value;

        }
        public void Remove(Key key)
        {
            link.Remove(key);
        }
        public void Set(Key key, Value newValue)
        {
                link.Set(key, newValue);
        }
        public override string ToString()
        {
            return "dic:" + link;
                 
        }


    }
}
