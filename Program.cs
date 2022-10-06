using System;
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
        static void Main(string[] args)
        {
            int n = 10000;
            Linked1ListSet<int> set = new Linked1ListSet<int>();
            long time= testSet(set, n);
            Console.WriteLine("linked1Set:" + set.Count + "个数字" + set);
            Console.WriteLine("共花费：" + time);
            



        }


        
    }
}
