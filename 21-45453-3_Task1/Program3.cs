using System;

namespace NomanConsoleApp1
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];

            Console.WriteLine("First 3x3 matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Row {i + 1},Column {j + 1}: ");
                    matrix1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nSecond 3x3 matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Row {i + 1},Column {j + 1}: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] sumMatrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("\nSum of the two matrices:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sumMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
