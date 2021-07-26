using System;
using System.Collections.Generic;

namespace SampleTest2.ACA
{
    class Program
    {
        /// <summary>
        //1D-array
        ///Given N elements of integer array and we have to find its median.A median
        ///is the value present at the centre of a sorted array list.
        /// </summary>

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 7, 9, 15, 25, 34, 68, 75 };

            Console.WriteLine(FindMedian2(arr));

            LinkedList<int> list = new LinkedList<int>();

            for (int i = 1; i <= 9; i++)
            {
                list.AddLast(i);
            }

            Console.WriteLine(FindLinkedListMedian(list));
        }


        public static int FindLinkedListMedian(LinkedList<int> list)
        {
            var first = list.First;
            var last = list.Last;

            while (first != last)
            {
                first = first.Next;
                last = last.Previous;
            }

            if (first == last)
            {
                return first.Value;
            }

            return 0;
        }

        public static int FindMedian1(int[] arr)
        {
            int count = arr.Length;

            int median = arr[count / 2];

            return median;
        }

        public static int FindMedian2(int[] arr)
        {
            int count = arr.Length;

            int median = 0;

            for (int i = 0; i <= count / 2; i++)
            {
                median = arr[i];
            }

            return median;
        }
    }
}