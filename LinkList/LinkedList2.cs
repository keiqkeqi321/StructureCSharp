using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// 带尾指针得链表
    /// </summary>
    /// <typeparam name="E"></typeparam>
    class LinkedList2<E>
    {
        class Node
        {
            public E e;
            public Node next;
            public Node(E e, Node next)
            {
                this.e = e;
                this.next = next;
            }
            public Node(E e)
            {
                this.e = e;
                this.next = null;
            }
            public override string ToString()
            {
                return e.ToString();
            }

        }
        Node head;
        Node tail;
        int N;
        public LinkedList2()
        {
            head = null;
            tail = null;
            N = 0;
        }
        public int Count => N;
        public bool IsEmpty => N == 0;
        public void AddLast(E e)
        {
            Node node = new Node(e);
            if (IsEmpty)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            N++;
        }
        public E RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("链表为空");
            }


            E e = head.e;
            head = head.next;
            N--;


            if (head == null)
            {
                tail = null;
            }
            return e;
        }
        public E GetFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("链表为空");
            }
            return head.e;

        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Count:{0}\n", N));
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur.e + "->");
                cur = cur.next;
            }
            res.Append("null");
            return res.ToString();
        }
    }
}
