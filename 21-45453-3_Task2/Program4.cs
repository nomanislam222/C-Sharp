using System;
using System.Linq;

public class Program4
{
    public static void Main(string[] args)
    {
        int[][] ja_arr1 = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8 }
        };

        int[][] ja_arr2 = new int[][]
        {
            new int[] { 9, 10 },
            new int[] { 11, 12, 13 },
            new int[] { 14 }
        };
        
        int[][] merge_arr = ja_arr1.Concat(ja_arr2).ToArray();

        Console.WriteLine("Merged Jagged Array:");
        foreach (int[] i in merge_arr)
        {
            foreach (int j in i)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}