using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// 有序数组   升序数组
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SortedArray1<T> where T:IComparable<T>
    {
        private T[] nodes;
        private int N;
        private int capacity;
        public SortedArray1(int Capacity)
        {
            nodes = new T[Capacity];
            capacity = Capacity;
        }
        public SortedArray1() : this(10) { }
        public int Count => N;
        public int Capacity => capacity;
        public bool IsEmpty => N == 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public  int Rank( T node)
        {
            //再[l....r]范围内查找node
            int l = 0;
            int r = N-1;
            int a = 0;
            while (l <= r)
            {
                a++;
                int mid = (l + (r - l) / 2);
                if (node.CompareTo( nodes[mid])<0)
                {
                    r = mid - 1; //再[l....mid-1]范围内查找node
                }
                else if (node .CompareTo( nodes[mid])>0)
                {
                    l = mid + 1; //再[mid+1....r]范围内查找node
                }
                else
                {
                    //Console.WriteLine("检索次数：" + a);
                    return mid;//找到node 返回索引
                }
            }

            return l ;
        }
        public T Get(int index) {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("数组越界");
            }
            return nodes[index];
        }
        public T GetFirst()
        {
            return Get(0);
        }
       public T GetLast()
        {
            return Get(N - 1);
        }
        public void Add(T node)
        {
            if (IsEmpty)
            {
                nodes[0] = node;
            }
            else
            {
                Insert(Rank(node),node);
                Console.WriteLine("insert  index:" + Rank(node)+"Count:"+N);
            }
            N++; 
        }
        void Insert(int Index, T node)
        {
            if (Index < 0 || Index > N)
            {
                throw new ArgumentException("数组越界");
            }
            if (N == nodes.Length)
            {
                ResetCapacity(2 * capacity);
            }
            for (int i = N - 1; i >= Index; i--)
            {
                nodes[i + 1] = nodes[i];
            }
            nodes[Index] = node;
        
        }
        public T RemoveAt(int index)
        {
            if (index < 0 || index >= N )
            {
                throw new ArgumentException("未查到需要删除的数据");
            }
            T del = nodes[index];
            for (int i = index + 1; i <= N - 1; i++)
            {
                nodes[i - 1] = nodes[i];
            }
            N--;
            nodes[N] = default(T);


            if (N == nodes.Length / 4)
            {
                ResetCapacity(nodes.Length / 2);
            }
            return del;
        }
        public T Remove(T node)
        {
            int index = Rank(node);
          
            if (!nodes[index].Equals(node))
            {
                throw new ArgumentException("未查到需要删除的数据");
            }
            return  RemoveAt(index);
            

        }
        public T RemoveLast()
        {
            return RemoveAt(N-1);
        }
        /// <summary>
        /// 不推荐  0（N）复杂度
        /// </summary>
        /// <returns></returns>
        public T RemoveFirst()
        {
            return RemoveAt(0);
        }
         void ResetCapacity(int newCapcity)
        {
            T[] newData = new T[newCapcity];
            for(int i=0;i<N; i++)
            {
                newData[i] = nodes[i];
            }
            nodes= newData;
            capacity = newCapcity;
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(nodes[i ].ToString());
                if (i!=N-1)
                {
                    res.Append(",");
                }
            }
            res.Append("]");
            return res.ToString();
        }

    }
}
