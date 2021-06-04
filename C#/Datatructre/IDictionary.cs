﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    interface IDictionary<Key,Value>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Add(Key key, Value value);
        void Remove(Key key);
        bool ContainsKey(Key key);
        Value Get(Key key);
        void Set(Key key, Value newvalue);

    }
}
