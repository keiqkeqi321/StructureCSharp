using System;
using System.Collections;
using System.Collections.Generic;
namespace 数据结构
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList1Stack<int> stack = new LinkedList1Stack<int>();
            for(int i=0; i < 10; i++)
            {
                stack.Push(i);
                Console.WriteLine(stack);
            }
            for (int i = 0; i < 3; i++)
            {
                stack.Pop();
                Console.WriteLine(stack);
            }
        }


        
    }
}
