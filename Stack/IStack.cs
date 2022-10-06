using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
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
