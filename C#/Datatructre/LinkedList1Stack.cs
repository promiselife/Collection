using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    //链表栈
    class LinkedList1Stack<E>:IStack<E>
    {
        private LinkedList1<E> list;

        public LinkedList1Stack()
        {
            list = new LinkedList1<E>();
        }

        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }

        public E Peek()
        {
            return list.GetFirst();
        }

        public E Pop()
        {
            return list.RemoveFirst();
        }

        public void Push(E e)
        {
            list.AddFirst(e);
        }

        public override string ToString()
        {
            return "Stack: Top " + list.ToString();
        }
    }
}
