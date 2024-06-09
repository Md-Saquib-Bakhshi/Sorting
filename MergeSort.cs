using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class MergeSort
    {
        public void Sort(int[] arr, int low, int high)
        {
            if(low >= high)
            {
                return;
            }
            int mid = (low + high) / 2;
            Sort(arr, low, mid);
            Sort(arr, mid+1, high);
            Merge(arr, low, mid, high);
        }

        public void Merge(int[] arr, int low, int mid, int high)
        {
            int[] temp = new int[high-low+1];
            int i = low;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= high)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i++];
                }
                else
                {
                    temp[k] = arr[j++];
                }
                k++;
            }

            while( i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= high)
            {
                temp[k++] = arr[j++];
            }

            //Copy to the real array
            for(i = low, k = 0; k < temp.Length; i++, k++)
            {
                arr[i] = temp[k];
            }
        }
    }
}
