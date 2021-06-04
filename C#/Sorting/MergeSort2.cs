using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //归并排序
    class MergeSort2
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];
            Sort(arr, temp, 0, n);
        }

        private static void Sort(int[] arr, int[] temp, int l, int r)
        {
            if(r-l+1<=15)
            {
                InsertSort.Sort1(arr, l, r);
                return;
            }

            int mid = l + (r - l) / 2;
            Sort(arr, temp, l, mid);        //将左半边排序
            Sort(arr, temp, mid + 1, r);    //将右半边排序

            if(arr[mid]> arr[mid+1])
                Merge(arr, temp, l, mid, r);    //归并结果
        }

        private static void Merge(int[] arr, int[] temp, int l, int mid, int r)
        {
            int i = l;
            int j = mid + 1;
            int k = l;

            //左右半边都有元素
            while (i <= mid && j <= r)
            {
                if (arr[i] < arr[j])
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }

            //左半边还有元素,右半边用尽（取左半边的元素）
            while (i <= mid)
                temp[k++] = arr[i++];

            //右半边还有元素,左半边用尽（取右半边的元素）
            while (j <= r)
                temp[k++] = arr[j++];
            //将temp数组拷贝回给arr数组，完成arr排序
            for (int z = l; z < r; z++)
                arr[z] = temp[z];
        }
    }
}
