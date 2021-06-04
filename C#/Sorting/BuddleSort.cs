using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //冒泡排序
    class BuddleSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                //减去i  不需要对已经拍好序的元素再次进行比较
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                        Swap(arr, j, j + 1);
                }
            }
        }

        private static void Swap(int[] arr,int i,int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }
    }
}
