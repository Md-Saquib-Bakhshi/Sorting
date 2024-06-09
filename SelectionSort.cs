using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class SelectionSort
    {
        private int[] arr;

        public SelectionSort(int[] arr)
        {
            this.arr = arr;
        }

        public void Sort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minPos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minPos])
                    {
                        minPos = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minPos];
                arr[minPos] = temp;
            }
        }
    }
}
