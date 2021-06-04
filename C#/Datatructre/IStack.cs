using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    interface IStack<E>
    {
        //栈中的元素
        int Count { get; }

        //栈是否为空
        bool IsEmpty { get; }

        //栈顶添加元素
        void Push(E e);

        //删除栈顶的元素并返回
        E Pop();

        //查询栈顶的元素
        E Peek();
    }
}
