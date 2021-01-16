using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };

            //BubbleSort(intArray);

            //SelectionSort(intArray);

            //InsertionSort(intArray);
            //ShellSort(intArray);

            //Console.WriteLine(String.Join(',', intArray));

            Console.WriteLine(IterativeFactorial(6));
            Console.WriteLine(RecursiveFactorial(6));

            Console.ReadLine();
        }

        
        public static int RecursiveFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return RecursiveFactorial(number - 1) * number;
        }

        public static int IterativeFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            int sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
        }

        public static void ShellSort(int[] array)// Unstable Algorithm
        {
            // Iyad
            // We can calculate the gap (interval) using (3^k - 1) / 2  ---> k = array.Length
            // But in this method gap = array.Length / 2
            int gap = array.Length / 2;
            while (gap >= 1)
            {
                for (int firstUnsortedIndex = gap; firstUnsortedIndex < array.Length; firstUnsortedIndex++)
                {
                    int newElement = array[firstUnsortedIndex];
                    int i = firstUnsortedIndex - gap;
                    while (i >= 0 && newElement < array[i])
                    {
                        array[i + gap] = array[i];
                        i -= gap;
                    }
                    array[i + gap] = newElement;
                }
                gap /= 2;
            }

            //// Teacher
            //for (int gapValue =array.Length / 2; gapValue > 0; gapValue /= 2)
            //{
            //    for (int i = gapValue; i < array.Length; i++)
            //    {
            //        int newElement = array[i];
            //        int j = i;
            //        while (j >= gapValue && array[j-gapValue] > newElement)
            //        {
            //            array[j] = array[j - gapValue];
            //            j -= gapValue;
            //        }
            //        array[j] = newElement;
            //    }
            //}
        }
        public static void InsertionSort(int[] array) // Stable Algorithm
        {
            // Iyad
            for (int firstUnsortedIndex = 1; firstUnsortedIndex < array.Length; firstUnsortedIndex++)
            {
                int newElement = array[firstUnsortedIndex];
                int i = firstUnsortedIndex - 1;
                while (i >= 0 && newElement < array[i])
                {
                    array[i + 1] = array[i];
                    i--;
                }
                array[i + 1] = newElement;
            }

            //// Teacher
            //for (int firstUnsortedIndex = 1; firstUnsortedIndex < array.Length; firstUnsortedIndex++)
            //{
            //    int newElement = array[firstUnsortedIndex];
            //    int i;
            //    for (i = firstUnsortedIndex; i > 0 && array[i -1] > newElement; i--)
            //    {
            //        array[i] = array[i - 1];
            //    }
            //    array[i] = newElement;
            //}
        }
        public static void SelectionSort(int[] array)// Unstable Algorithm
        {
            for (int lastUnsortedIndex = array.Length-1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            {
                int IndexOflargestNumber = 0;
                for (int i = 1; i <= lastUnsortedIndex; i++)
                {
                    if (array[i] > array[IndexOflargestNumber])
                    {
                        IndexOflargestNumber = i;
                    }
                }
                Swap(array, IndexOflargestNumber, lastUnsortedIndex);
            }
        }

        public static void BubbleSort(int[] array) // Stable Algorithm
        {
            for (int lastUnsortedIndex = array.Length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            {
                for (int i = 0; i < lastUnsortedIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }
        public static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
