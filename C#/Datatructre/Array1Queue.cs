using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    //数组队列
    class Array1Queue<E>:IQueue<E>
    {
        private ArrayGeneric<E> arr;

        public int Count { get { return arr.Count; } }

        public bool IsEmpty { get { return arr.IsEmpty; } }

        public Array1Queue(int capacity)
        {
            arr = new ArrayGeneric<E>(capacity);
        }
   
        public Array1Queue()
        {
            arr = new ArrayGeneric<E>();
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
