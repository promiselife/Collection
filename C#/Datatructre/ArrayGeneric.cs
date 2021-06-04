using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    class ArrayGeneric<E>
    {
        //元素的存储
        private E[] data;
        //记录实际存的元素
        private int N;
        //初始化有参
        public ArrayGeneric(int capacity)
        {
            data = new E[capacity];
            N = 0;
        }
        //初始化无参
        public ArrayGeneric() : this(10) { }
        //返回数组长度
        public int Capacity
        {
            get { return data.Length; }
        }
        //返回数组实际元素
        public int Count
        {
            get { return N; }
        }
        //返回数组是否为空
        public bool IsEmpty
        {
            get { return N == 0; }
        }
        //添加元素
        public void Add(int index, E e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            if (N == data.Length)
                //throw new ArgumentException("数组已满");
                ResetCapacity(2 * data.Length);

            //从后往前移动
            for (int i = N - 1; i >= index; i--)
                data[i + 1] = data[i];

            data[index] = e;
            N++;
        }
        //添加元素到最后一个
        public void AddLast(E e)
        {
            Add(N, e);
        }
        //添加元素到底一个
        public void AddFirst(E e)
        {
            Add(0, e);
        }
        //获取index位元素
        public E Get(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");
            return data[index];
        }
        //获取第一个元素
        public E GetFirst()
        {
            return Get(0);
        }
        //获取最后一个元素
        public E GetLast()
        {
            return Get(N - 1);
        }
        //设置第index个元素
        public void Set(int index, E newE)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");
            data[index] = newE;
        }
        //查询元素是否存在
        public bool Contains(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))
                    return true;
            }
            return false;
        }
        //查询元素位置
        public int IndexOf(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))
                    return i;
            }
            return -1;
        }
        //删除index位元素
        public E RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("数组索引越界");

            E del = data[index];

            for (int i = index + 1; i <= N - 1; i++)
                data[i - 1] = data[i];

            N--;
            data[N] = default(E);

            if (N == data.Length / 4)
                ResetCapacity(data.Length / 2);

            return del;
        }
        //删除首位元素
        public E RemoveFirst()
        {
            return RemoveAt(0);
        }
        //删除末位元素
        public E RemoveLast()
        {
            return RemoveAt(N - 1);
        }
        //删除确定元素
        public void Remove(int e)
        {
            int index = IndexOf(e);
            if (index != -1)
                RemoveAt(index);
        }

        //容量扩充
        private void ResetCapacity(int newCapacity)
        {
            E[] newData = new E[newCapacity];
            for (int i = 0; i < N; i++)
                newData[i] = data[i];

            data = newData;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //res.Append(string.Format("Array1: count = {0}  capacity = {1}\n", N, data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N - 1)
                    res.Append(",");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
