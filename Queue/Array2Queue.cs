using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Array2Queue<E> : IQueue<E>
    {
        private Array2<E> array;

        public int Count => array.Count;

        public   bool isEmpty => array.IsEmpty;

        public Array2Queue(int capacity)
        {
            array = new Array2<E>(capacity);
        }
        public Array2Queue()
        {
            array = new Array2<E>();
        }


        public void Enqueue(E e)
        {
            array.AddLast(e);
        }

        public E Dequeue()
        {
            return array.RemoveFirst();
        }

        public E Peek()
        {
            return array.GetFirst();
        }

        public override string ToString()
        {

            return "Queue:font" + array.ToString()+"Trail";
        }

    }
}
