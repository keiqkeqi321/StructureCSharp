namespace DataStructure
{
    public  interface ISet<E>
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Add(E e);
       void Remove(E e);
        bool Contains(E e);

    }
}
