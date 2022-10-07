using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// 键值对节点的链表
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    class Linkedlist3<Key,Value>
    {
        private class Node
        {
            public Key key;
            public Value value;
            public Node next;
            public Node(Key key,Value value,Node next)
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }
            public override string ToString()
            {
                return key.ToString() + ":" + value.ToString();
            }
        }
        private Node head;
        private int N;
        public Linkedlist3()
        {
            head = null;
            N = 0;
        }
        public int Count => N;
        public bool IsEmpty => N == 0;
        private Node GetNode(Key key)
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.key.Equals(key)) 
                {
                    return cur;
                }
                cur = cur.next;
            }
            return null;
        }
        public void Add(Key key,Value value)
        {
            Node  node = GetNode(key);
            if (node == null)
            {
                head = new Node(key, value, head);
                N++;
            }
            else
            {
                node.value = value;
            }

        }
        public bool Contains(Key key)
        {
            return  GetNode(key)!=null;
        }
        public Value Get(Key key)
        {
            Node node = GetNode(key);
            if (node == null)
            {
                throw new ArgumentException("键" + key + "不存在");
            }


            return node.value;
        }
        public Value TryGet(Key key)
        {
            Node node = GetNode(key);
            if (node == null)
            {
                return default(Value);
            }


            return node.value;
        }
        public void Set(Key key, Value value)
        {
            Node node = GetNode(key);
            if (node == null)
            {
                throw new ArgumentException("键" + key + "不存在");
            }

            node.value = value;
        }
        public void Remove(Key key)
        {
            if (head == null)
            {
                return;
            }
            if (head.key.Equals(key))
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
                    if (cur.key.Equals(key))
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
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Count:{0}\n", N));
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur + ",");
                cur = cur.next;
            }
            res.Append("null");
            return res.ToString();
        }

    }
}
