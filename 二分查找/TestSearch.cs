using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// 二分查找算法
    /// </summary>
    class TestSearch
    {
        public static int BinarySearch(int[] arr,int target)
        {
            int l = 0;
            int r = arr.Length - 1;
            int a = 0;
            while (l <= r)
            {
                a++;
                int mid = (l + (r - l)/2);
                if (target < arr[mid])
                {
                    r = mid - 1;
                }
                else if (target > arr[mid])
                {
                    l = mid + 1;
                }
                else
                {
                    Console.WriteLine("检索次数：" + a);
                    return mid;

                }
            }
            
            return -1;
        }
    }
}
