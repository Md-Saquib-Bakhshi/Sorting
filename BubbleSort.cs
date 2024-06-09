using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class BubbleSort
    {
        private int[] arr;

        public BubbleSort(int[] arr) 
        {
            this.arr = arr;
        }

        public void Sort()
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for(int j = 0; j<arr.Length-1-i; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
