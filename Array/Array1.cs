using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Array1<E>
    {

        E[] data;
        int N;
        public Array1(int capacity)
        {
            data = new E[capacity];
            N = 0;
        }
        public Array1() : this(10) { }
        public int Capacity
        {
            get
            {
                return data.Length;
            }
        }
        public int Count
        {
            get
            {
                return N;
            }
        }
        public bool IsEmpty
        {
            get { return N == 0; }
        }
        public void Add(int Index,E e)
        {
            if (Index < 0 || Index > N)
            {
                throw new ArgumentException("数组越界");
            }
            if (N == data.Length)
            {
                ResetCapacity(2 * Capacity);
            }
            for(int i = N - 1; i >= Index; i--)
            {
                data[i + 1] = data[i];
            }
            data[Index]=e;
            N += 1;
        }
        public void  AddLast(E e)
        {
            Add(N, e);
        }
        public void AddFirst(E e)
        {
            Add(0, e);
        }

        public E Get(int index)
        {
            if (index >= N || index < 0)
            {
                throw new ArgumentException("数组索引越界");
            }
             return data[index];
         }
        public E GetFirst()
        {
            return Get(0);
        }
        public E GetLast()
        {
            return Get(N - 1);
        }



        public void Set(int  index, E e)
        {
            if (index >= N || index < 0)
            {
                throw new ArgumentException("数组索引越界");
            }
            data[index] = e;
        }
        public void SetFirst(E e)
        {
            Set(0,e);
        }
        public void SetLast(E e)
        {
            Set(N - 1,e);
        }



        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
           // res.Append(string.Format("Array1 :Count={0},Capacity={1}\n", N, data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N - 1)
                {
                    res.Append(",");
                }
                
            }
            res.Append("]");
            return res.ToString();

        }



        public bool Contains(E e)
        {
              for(int i = 0; i < N; i++)
            {
                if (data[i].Equals(e)) { return true; }
            }
            return false;
        }
        public int IndexOf(E e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e)) { return i; }
            }
            return -1;
        }
        public E RemoveAt(int index)
        {
            if (index >= N || index < 0)
            {
                throw new ArgumentException("数组索引越界");
            }
            E del = data[index];
            for (int i = index + 1; i < N - 1; i++)
            {
                data[i - 1] = data[i];
            }
            N--;
            data[N] = default(E);

            if (N == data.Length /4)
            {
                ResetCapacity(data.Length / 2);
            }


            return del;
        }
        public E RemoveFirst()
        {
            return RemoveAt(0);
        }
        public E RemoveLast()
        {
            return RemoveAt(N-1);
        }
        public void Remove(E e)
        {
            int index=IndexOf(e);
            if (index!=-1)
            {
                RemoveAt(index);
            }
             
        }
        void ResetCapacity(int newCapcity)
        {
            E[] newData = new E[newCapcity];
            for(int i=0;i<N; i++)
            {
                newData[i] = data[i];
            }

            data = newData;
        }

    }
}
