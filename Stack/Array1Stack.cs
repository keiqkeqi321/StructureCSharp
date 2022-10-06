
namespace DataStructure
{
    class Array1Stack<E> : IStack<E>
    {
        Array1<E> arr;
        public int Counr => arr.Count;

        public bool isEmpty => arr.IsEmpty;
        public  Array1Stack(int capacity)
        {
            arr = new Array1<E>(capacity);
        }
        public Array1Stack()
        {
            arr = new Array1<E>();
        }

        public E Pick()
        {
            return arr.GetLast();
        }

        public E Pop()
        {
           return arr.RemoveLast();
        }

        public void Push(E e)
        {
            arr.AddLast(e);
        }
        public override string ToString()
        {
            return "stack:" + arr.ToString() + "Top";
        }
    }
}
