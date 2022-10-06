using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    interface IQueue<E>
    {
       public  int Count { get; }
      public   bool isEmpty { get; }
        void Enqueue(E e);
        E Dequeue();
        E Peek();
       
  
    }
}
