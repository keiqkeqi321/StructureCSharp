
namespace DataStructure
{
    class Linked1ListSet<E> : ISet<E>
    {
        LinkedList1<E> link;
        public Linked1ListSet()
        {
            link = new LinkedList1<E>();
        }
        public bool IsEmpty => link.IsEmpty;

        public int Count => link.Count;

        public void Add(E e)
        {
            if (!link.Contains(e)){
                link.AddFirst(e);
            }
        }

        public bool Contains(E e)
        {
            return link.Contains(e);
        }

        public void Remove(E e)
        {
              link.Remove(e);
        }
        public override string ToString()
        {
            return "linked1Set;" + link;
        }

    }
}
