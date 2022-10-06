using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class LinkList1Queue<E> : IQueue<E>
    {
        LinkedList1<E> link;

        public int Count => link.Count;

        public bool isEmpty => link.IsEmpty;
   
        public LinkList1Queue()
        {
            link = new LinkedList1<E>();
        }

        public E Dequeue( )
        {
            return  link.RemoveFirst();
        }

        public void Enqueue(E e)
        {
            link.AddLast(e);
        }

        public E Peek()
        {
            return link.GetFirst();
        }
        public override string ToString()
        {
            return "Queue: Front" + link + "tail";
        }
    }
}
