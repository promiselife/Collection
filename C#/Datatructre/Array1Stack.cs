using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    //数组栈
    class Array1Stack<E> : IStack<E>
    {
        private ArrayGeneric<E> arr;

        public int Count { get { return arr.Count; } }

        public bool IsEmpty { get { return arr.IsEmpty; } }

        public Array1Stack(int capacity)
        {
            arr = new ArrayGeneric<E>(capacity);
        }

        public Array1Stack()
        {
            arr = new ArrayGeneric<E>();
        }

        public void Push(E e)
        {
            arr.AddLast(e);
        }

        public E Pop()
        {
            return arr.RemoveLast();
        }

        public E Peek()
        {
            return arr.GetLast();
        }

        public override string ToString()
        {
            return "Stack :" + arr.ToString() + " Top";
        }
    }
}
