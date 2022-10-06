using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class LinkedList1<E>
    {
        class Node
        {
            public E e;
            public Node next;
            public Node(E e,Node next)
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
        int N;
        public LinkedList1()
        {
            N = 0;head = null;
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
        public void Add(int index,E e)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("非法索引");
            }
            if (index == 0)
            {
                //Node node = new Node(e);
                //node.next = head;
                //head = node;
                head = new Node(e, head);
            }
            else
            {
                Node pre = head;
                for(int i = 0; i < index - 1; i++)
                {
                    pre = pre.next;
                }
                pre.next = new Node(e, pre.next);
            }
            N++;

        }
        public void AddFirst(E e)
        {
            Add(0, e);
        }
        public void AddLast(E e)
        {
            Add(N, e);
        }

        public E Get(int index)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("非法索引");
            }
            Node cur=head;
            for(int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            return cur.e;
        }
        public E GetFirst()
        {
            return Get(0);
        }
        public E GetLast()
        {
           return Get(N - 1);
        }


        public void Set(int index,E newE)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("非法索引");
            }
            Node cur = head;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            cur.e = newE;
        }

        public bool  Contains(E e)
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.e.Equals(e)) { return true; }
                cur = cur.next;

            }
            return false;
        }

        public E RemoveAt(int index)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("非法索引");
            }
            Node pre = head;
            if (index == 0)
            {
                Node removeNode=head;
                head = head.next;
                N--;
                return removeNode.e;
            }
            else
            {
                
                for(int i = 0; i < index - 1; i++)
                {
                    pre = pre.next;
                }
                Node removeNode = pre.next;
                pre.next = removeNode.next;
                N--;
                return removeNode.e;

            }
        }
        public E RemoveFirst()
        {
            return RemoveAt(0);
        }
        public E Removelast()
        {
            return RemoveAt(N - 1);
        }
        public void Remove(E e)
        {
            if (head == null)
            {
                return;
            }
            if (head.e.Equals(e))
            {
                head = head.next;
                N--;
            }
            else
            {
                Node cur = head;
                Node pre = null;
                while (cur != null)
                {
                    if (cur.e.Equals(e))
                    {
                        break;
                    }
                    pre = cur;
                    cur = cur.next;

                }
                if (cur != null)
                {
                    pre.next = pre.next.next;
                    N--;
                }
            }

        }

        public override string ToString()
        {
            StringBuilder res=new StringBuilder();
            res.Append(string.Format("Count:{0}\n", N));
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur.e+"->");
                cur = cur.next;
            }
            res.Append("null");
            return res.ToString();
        }

    }
}
