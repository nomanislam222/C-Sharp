using System;

namespace NomanConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of array elements: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = arr[0];
            int smallest = arr[0];

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    largest = num;
                }

                if (num < smallest)
                {
                    smallest = num;
                }
            }

            Console.WriteLine($"Largest number: {largest}");
            Console.WriteLine($"Smallest number: {smallest}");
            Console.ReadKey();
        }
    }
}

