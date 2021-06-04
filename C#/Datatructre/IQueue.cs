using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    interface IQueue<E>
    {
        //队列中的元素
        int Count { get; }

        //队列是否为空
        bool IsEmpty { get; }

        //队列添加元素
        void Enqueue(E e);

        //删除队列的元素并返回
        E Dequeue();

        //查询队列的元素
        E Peek();
    }
}
