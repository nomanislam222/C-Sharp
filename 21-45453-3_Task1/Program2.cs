using System;
using System.Collections.Generic;

namespace NomanConsoleApp1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of array1 element: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of array2 element: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[x1];
            int[] arr2 = new int[x2];

            Console.WriteLine("Enter elements for array1:");
            for (int i = 0; i < x1; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter elements for array2:");
            for (int i = 0; i < x2; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            List<int> primeNumbers = new List<int>();
            foreach (int num in arr1)
            {
                bool isPrime = true;

                if (num <= 1)
                {
                    isPrime = false;
                }
                else if (num <= 3)
                {
                    isPrime = true;
                }
                else if (num % 2 == 0 || num % 3 == 0)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 5; i * i <= num; i += 6)
                    {
                        if (num % i == 0 || num % (i + 2) == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(num);
                }
            }

            foreach (int num in arr2)
            {
                bool isPrime = true;

                if (num <= 1)
                {
                    isPrime = false;
                }
                else if (num <= 3)
                {
                    isPrime = true;
                }
                else if (num % 2 == 0 || num % 3 == 0)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 5; i * i <= num; i += 6)
                    {
                        if (num % i == 0 || num % (i + 2) == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(num);
                }
            }

            int[] primeArray = primeNumbers.ToArray();
            Console.WriteLine("Prime numbers are:");
            foreach (int prime in primeArray)
            {
                Console.WriteLine(prime);
            }
            Console.ReadKey();

        }
    }
}

