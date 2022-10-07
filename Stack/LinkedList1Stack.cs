using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructure
{
    /// <summary>
    /// 头指针链表实现的栈
    /// </summary>
    /// <typeparam name="E"></typeparam>
    class LinkedList1Stack<E>:IStack<E>
    {
        LinkedList1<E> list;

        public int Counr =>list.Count;

        public bool isEmpty => list.IsEmpty;
       public   LinkedList1Stack()
        {
            list = new LinkedList1<E>();
        }

        public E Pick()
        {
            return list.GetFirst();
        }

        public E Pop()
        {
           return list.RemoveFirst();
        }

        public void Push(E e)
        {
            list.AddFirst(e);
        }
        public override string ToString()
        {
            return "Stack:Top" + list.ToString();
        }
    }
}
