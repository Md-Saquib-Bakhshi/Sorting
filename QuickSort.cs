using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class QuickSort
    {
        public void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int idx = Partitioner(arr, low, high);
                Sort(arr, low, idx-1);
                Sort(arr, idx+1, high);
            }
        }

        public int Partitioner(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int k = high;
            for(int i = high; i > low; i--)
            {
                if(arr[i] > pivot)
                {
                    swap(arr, i, k--);
                }
            }
            swap(arr, low, k);
            return k;
        }

        public void swap(int[] arr, int low, int high)
        {
            int temp = arr[low];
            arr[low] = arr[high];
            arr[high] = temp;
        }
    }
}
