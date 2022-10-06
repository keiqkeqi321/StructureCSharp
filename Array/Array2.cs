using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Array2<E>
    {
        private E[]data;
        int first, last;
        int N;
        public Array2(int capacity)
        {
            data = new E[capacity];
            first = 0;last = 0;
            N = 0;
        }
        public Array2() : this(10) { }
        public int Count => N;
        public bool IsEmpty =>N == 0;
        public void AddLast(E e)
        {
            if (N == data.Length)
            {
                ResetCapacity(data.Length * 2);
            }
            data[last] = e;
            last = (last + 1) % data.Length;
            N++;
        }
        public E RemoveFirst()
        {
            if (IsEmpty) { throw new InvalidOperationException("Array Empty"); }
            E res = data[first];
            data[first] = default(E);
            first = (first + 1) % data.Length;
            N--;
            if (N == data.Length / 4)
            {
                ResetCapacity(data.Length/2);
            }
            return res;
        }
        public E GetFirst()
        {
            if (IsEmpty) { throw new InvalidOperationException("Array Empty"); }
            return data[first];

        }
        private void ResetCapacity(int newCapacity)
        {
            E[] newData = new E[newCapacity];
            for(int i = 0; i < N; i++)
            {
                newData[i] = data[(i + first) % data.Length];

            }
            data = newData;
            first = 0;
            last = N;

        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            for(int i = 0; i < N; i++)
            {
                res.Append(data[(i + first) % data.Length].ToString());
                if((first + i + 1) % data.Length != last)
                {
                    res.Append(",");
                }
            }
            res.Append("]");
            return res.ToString();
        }

    }
}
