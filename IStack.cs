using System;
using System.Collections.Generic;
using System.Text;

namespace 数据结构
{
    interface IStack<E>
    {
            int Counr { get; }
        bool isEmpty { get; }
        void Push(E e);
        E Pop();
        E Pick();
    }
}
