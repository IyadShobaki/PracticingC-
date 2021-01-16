using System;

namespace Algorithms1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };

            MergeSort(intArray, 0, intArray.Length);

            Console.WriteLine(String.Join(',', intArray));

            Console.ReadLine();
        }
        public static void MergeSort(int[] input, int start, int end)
        {
            if (end - start < 2) 
            {
                return;
            }
            int mid = (start + end) / 2;
            MergeSort(input, start, mid);
            MergeSort(input, mid, end);
            Merge(input, start, mid, end);
        }
        public static void Merge(int[] input, int start, int mid, int end)
        {
            if (input[mid - 1] <= input[mid]) 
            {
                return;
            }
            int i = start;
            int j = mid;
            int tempIndex = 0;

            int[] temp = new int[end - start];
            while (i < mid && j < end)
            {
                temp[tempIndex++] = input[i] <= input[j] ? input[i++] : input[j++];
            }

            Array.Copy(input, i, input, start + tempIndex, mid - i);
            Array.Copy(temp, 0, input, start, tempIndex);

        }
    }
}
