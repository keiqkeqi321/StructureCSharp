using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// 普通动态数组实现的简单队列
    /// </summary>
    /// <typeparam name="E"></typeparam>
    class Array1Queue<E> : IQueue<E>
    {
        private Array1<E> array;

       public   int Count => array.Count;

        public bool isEmpty =>array.IsEmpty;

        public Array1Queue(int capacity)
        {
            array = new Array1<E>(capacity);
        }
        public Array1Queue()
        {
            array = new Array1<E>();
        }
  

        public void Enqueue(E e)
        {
            array.AddLast(e);
        }

        public E Dequeue()
        {
           return   array.RemoveFirst();
        }

        public E Peek()
        {
            return array.GetFirst();
        }

        public override string ToString()
        {
          
            return "Queue:font" + array.ToString()+"trail";
        }

    }
}
