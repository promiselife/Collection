using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    class Array2Queue<E> : IQueue<E>
    {

        private Array2<E> arr;

        public int Count { get { return arr.count; } }

        public bool IsEmpty { get { return arr.IsEmpty; } }

        public Array2Queue(int capacity)
        {
            arr = new Array2<E>(capacity);
        }

        public Array2Queue()
        {
            arr = new Array2<E>();
        }

        public void Enqueue(E e)
        {
            arr.AddLast(e);
        }

        public E Dequeue()
        {
            return arr.RemoveFirst();
        }

        public E Peek()
        {
            return arr.GetFirst();
        }

        public override string ToString()
        {
            return "Queue : Front " + arr.ToString() + " tail";
        }
    }
}
