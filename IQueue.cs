using System;
using System.Collections.Generic;
using System.Text;

namespace 数据结构
{
    interface IQueue
    {
        int Count { get; }
        bool isEmpty { get; }
        void Enqueue();
    }
}
