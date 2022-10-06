using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public interface IDictionary<Key,Value>
    {
        void Add(Key key, Value value);
        void Remove(Key key);
        bool ContainsKey(Key key);
        Value Get(Key key);
        Value TryGet(Key key,out Value outValue);
        void Set(Key key, Value newValue);
        int Count { get; }
        bool IsEmpty { get; }
    }
}
