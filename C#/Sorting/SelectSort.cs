using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    //选择排序
    class SelectSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;


            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                Swap(arr, 0, min);
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
