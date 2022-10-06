using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class LinkList2Queue<E> : IQueue<E>
    {
        LinkedList2<E> link;

        public int Count => link.Count;

        public bool isEmpty => link.IsEmpty;
   
        public LinkList2Queue()
        {
            link = new LinkedList2<E>();
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
