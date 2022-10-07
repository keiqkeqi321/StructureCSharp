using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructure
{
    class Program
    {
        static long testQueue(IQueue<int> queue,int N)
        {
            Stopwatch t= new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                queue.Enqueue(i);
            for (int i = 0; i < N; i++)
                queue.Dequeue();
            t.Stop();
            return t.ElapsedMilliseconds;
        }
        static long testSet(ISet<int > set,int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();

            for (int i = 0; i < N; i++)
            {
                set.Add(i);
            }
            for (int i = 0; i < N; i++)
            {
                set.Add(i);
            }
            for (int i = 0; i < N; i++)
            {
                set.Add(i);
            }
            t.Stop();
            return t.ElapsedMilliseconds;
        }
        static long testDic(IDictionary<int,int> dic, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            

            for (int i = 0; i < N; i++)
            {
                if (!dic.ContainsKey(i))
                {
                    dic.Add(i, 1);

                }
                else
                {
                    dic.Set(i, dic.Get(i) + 1);
                }
                
            }
            for (int i = 0; i < N; i++)
            {
                if (!dic.ContainsKey(i))
                {
                    dic.Add(i, 1);

                }
                else
                {
                    dic.Set(i, dic.Get(i) + 1);
                }

            }
            for (int i = 0; i < N; i++)
            {
                if (!dic.ContainsKey(i))
                {
                    dic.Add(i, 1);

                }
                else
                {
                    dic.Set(i, dic.Get(i) + 1);
                }

            }
            t.Stop();
            return t.ElapsedMilliseconds;
        }
        static void Main(string[] args)
        {
            SortedArray1<int> sortedArray1 = new SortedArray1<int>();
            Random r = new Random();
            for(int i = 0; i < 20; i++)
            {
                int a = r.Next(0, 16);
                sortedArray1.Add(a);
            }



            Console.WriteLine("有序数组：" + sortedArray1+"Count:"+sortedArray1.Count+"capacity:"+sortedArray1.Capacity);
            for(int i = 0; i < 18; i++)
            {
                sortedArray1.RemoveFirst();
            }
            Console.WriteLine("有序数组：" + sortedArray1 + "Count:" + sortedArray1.Count + "capacity:" + sortedArray1.Capacity);
        }



    }
}
