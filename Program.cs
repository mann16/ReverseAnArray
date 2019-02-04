using System;

namespace InterviewQuestions
{
    /// <summary>
    /// Given an array A of size N, print the reverse of it
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize, numOfArrays;
            Console.WriteLine("No of test cases for array: ");
            numOfArrays = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfArrays; i++)
            {
                Console.WriteLine(string.Format("Specify the length for the array {0}: ", i + 1));
                arraySize = int.Parse(Console.ReadLine());
                int[] arr = new int[arraySize];
                Console.WriteLine("Enter values space seperated: ");
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < arraySize; j++)
                {
                    arr[j] = int.Parse(s[j]);
                }
                Console.Write("Actual array is \n");
                printArray(arr, arraySize);
                rvereseArray(arr, 0, arraySize - 1);
                Console.Write("Reversed array is \n");
                printArray(arr, arraySize);
            }


        }

        private static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }

        private static void rvereseArray(int[] arr, int start, int end)
        {
            int temp = 0;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }


    }


}
