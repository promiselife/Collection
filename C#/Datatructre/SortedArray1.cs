using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    // 有序数组
    class SortedArray1<Key> where Key : IComparable<Key>
    {
        private Key[] keys;
        private int N;

        public SortedArray1(int capacity)
        {
            keys = new Key[capacity];
        }
        public SortedArray1() : this(10) { }
        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }
        public int Rank(Key key)
        {
            int l = 0;
            int r = N - 1;

            while (l <= r)
            {
                //int mid = (r + l) / 2;
                int mid = 1 + (r - l) / 2;

                if (key.CompareTo(keys[mid]) < 0)
                    r = mid - 1;
                else if (key.CompareTo(keys[mid]) > 0)
                    l = mid + 1;
                else
                    return mid;
            }

            return l;
        }

        public void Add(Key key)
        {
            int i = Rank(key);

            if (N == keys.Length)
                ResetCapacity(2 * keys.Length);

            if (i < N && keys[i].CompareTo(key) == 0)
                return;

            for (int j = N - 1; j < i; j--)
            {
                keys[j + 1] = keys[j];
            }
            keys[i] = key;
            N++;
        }

        public void Remove(Key key)
        {
            if (IsEmpty)
                return;

            int i = Rank(key);

            if (i == N || keys[i].CompareTo(key) != 0)
                return;

            for (int j = i + 1; j < N - 1; j++)
            {
                keys[j - 1] = keys[j];
            }
            N--;
            keys[N] = default(Key);

            if (N == keys.Length / 4)
                ResetCapacity(keys.Length / 2);
        }

        public Key Min()
        {
            if (IsEmpty)
                throw new ArgumentException("数组为空");
            return keys[0];
        }

        public Key Max()
        {
            if (IsEmpty)
                throw new ArgumentException("数组为空");
            return keys[N - 1];
        }

        public Key Select(int k)
        {
            if (k < 0 || k >= N)
                throw new ArgumentException("数组为空");

            return keys[k];
        }

        public bool Contains(Key key)
        {
            int i = Rank(key);

            if (i < N && keys[i].CompareTo(key) == 0)
                return true;

            return false;
        }

        //向下取整
        public Key Floor(Key key)
        {
            int i = Rank(key);

            if (i < N && keys[i].CompareTo(key) == 0)
                return keys[i];

            if (i == 0)
                throw new ArgumentException("没有找到小于或等于" + key + "的最大键");
            else
                return keys[i - 1];
        }

        //向上取整
        public Key Ceiling(Key key)
        {
            int i = Rank(key);

            if (i == N)
                throw new ArgumentException("没有找到大于和等于" + key + "的最小键");
            else
                return keys[i];
        }

        //容量扩充
        private void ResetCapacity(int newCapacity)
        {
            Key[] newkeys = new Key[newCapacity];
            for (int i = 0; i < N; i++)
                newkeys[i] = keys[i];

            keys = newkeys;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //res.Append(string.Format("Array1: count = {0}  capacity = {1}\n", N, data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(keys[i]);
                if (i != N - 1)
                    res.Append(",");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
