using System;

namespace Array_Operations
{
    internal class Program
    {
        class ArrayMethods
        {
            public void sort(Array arr)
            {
                Array.Sort(arr); // to sort the list in ascending order
                Console.WriteLine("Sorted Array :");
                foreach (string i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            public void reverseArray(Array arr)
            {
                Array.Reverse(arr);
                Console.WriteLine("Reverse Array :");
                foreach(string i in arr)
                {
                    Console.WriteLine(i);
                }  
            }
           public void lengthOfArray(Array arr)
            {
                Console.WriteLine("length of first array: " + arr.Length);
            }

        }
        static void Main(string[] args)
        {
            string[] arr = new string[4];
            Console.WriteLine("Enter the string :");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Print the Array element:");
            foreach(string item in arr)
            {
                Console.WriteLine(item);
            }

            ArrayMethods arrayMethod = new ArrayMethods();
            arrayMethod.sort(arr);
            arrayMethod.reverseArray(arr);
            arrayMethod.lengthOfArray(arr);
        }
    }
}
