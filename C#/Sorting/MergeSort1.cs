using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //归并排序
    class MergeSort1
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];
            Sort(arr, temp, 0, n);
        }

        private static void Sort(int[] arr, int[] temp, int l,int r)
        {
            if (l >= r) return;
            //int mid = (r + l) / 2;
            int mid = l + (r - l) / 2;
            Sort(arr, temp, l,mid);
            Sort(arr, temp, mid + 1, r);
            Merge(arr, temp, l, mid, r);
        }

        private static void Merge(int[] arr,int[] temp,int l,int mid,int r)
        {
            int i = l;
            int j = mid + 1;
            int k = l;

            //左右半边都有元素
            while (i <= mid && j <= r)
            {
                if(arr[i] < arr[j])
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }

            //左半边还有元素,右半边用尽（取左半边的元素）
            while (i<= mid)
                temp[k++] = arr[i++];

            //右半边还有元素,左半边用尽（取右半边的元素）
            while (j<=r)
                temp[k++] = arr[j++];
            //将temp数组拷贝回给arr数组，完成arr排序
            for (int z = l; z < r; z++)
                arr[z] = temp[z];
        }
    }
}
