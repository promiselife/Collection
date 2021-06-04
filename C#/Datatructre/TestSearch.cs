using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructre
{
    class TestSearch
    {
        //二分查找法 时间复杂度 O(Log N)
        public static int BinarySearch(int[] arr,int target)
        {
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {
                //int mid = (r + l) / 2;
                int mid = 1 + (r - l) / 2;

                if (target < arr[mid])
                    r = mid - 1;
                else if (target > arr[mid])
                    l = mid + 1;
                else
                    return mid;
            }

            return -1;
        }
    }
}
