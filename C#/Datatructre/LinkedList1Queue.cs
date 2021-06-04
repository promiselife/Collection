using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    class LinkedList1Queue<E>:IQueue<E>
    {
        private LinkedList1<E> list;

        public LinkedList1Queue()
        {
            list = new LinkedList1<E>();
        }

        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }

        public E Dequeue()
        {
            return list.RemoveFirst();
        }

        public void Enqueue(E e)
        {
            list.AddLast(e);
        }

        public E Peek()
        {
            return list.GetFirst();
        }

        public override string ToString()
        {
            return "Queue front " + list.ToString() + "tail";
        }
    }
}
