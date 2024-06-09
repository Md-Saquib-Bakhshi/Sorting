using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Input
    {
        private int size;
        private int choice;
        private int[] array;

        private int Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Size must be positive and greater than 0.");
                    return;
                }
                size = value;
            }
        }

        private void InputArray()
        {
            Console.Write("Enter size: ");
            Size = int.Parse(Console.ReadLine());
            array = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Console.Write($"Enter element[{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Given Array:");
            OutputArray();
        }

        private void OutputArray()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void Choice()
        {
            while (true)
            {
                Console.Write("\nEnter\n 1 for BubbleSort\n 2 for SelectionSort\n 3 for InsertionSort\n 4 for QuickSort\n 5 for MergeSort\n 6 for Exit: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InputArray();
                        BubbleSort bubblesort = new BubbleSort(array);
                        bubblesort.Sort();
                        Console.Write("Sorted Array:");
                        OutputArray();
                        break;
                    case 2:
                        InputArray();
                        SelectionSort selectionsort = new SelectionSort(array);
                        selectionsort.Sort();
                        Console.Write("Sorted Array:");
                        OutputArray();
                        break;
                    case 3:
                        InputArray();
                        InsertionSort insertionsort = new InsertionSort(array);
                        insertionsort.Sort();
                        Console.Write("Sorted Array:");
                        OutputArray();
                        break;
                    case 4:
                        InputArray();
                        QuickSort quicksort = new QuickSort();
                        quicksort.Sort(array, 0, array.Length-1);
                        Console.Write("Sorted Array:");
                        OutputArray();
                        break;
                    case 5:
                        InputArray();
                        MergeSort mergesort = new MergeSort();
                        mergesort.Sort(array, 0, array.Length - 1);
                        Console.Write("Sorted Array:");
                        OutputArray();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("!!!Invalid Choice!!!");
                        break;

                }
            }
        }
    }
}
