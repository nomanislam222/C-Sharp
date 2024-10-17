using System;

public class Program3
{
    public static void Main(string[] args)
    {
        int[][] ja_arr = new int[][]
        {
            new int[] { 1, 2, 3, 90, 12 },
            new int[] { 4, 5, 6, 44 },
            new int[] { 7, 8, 9 }
        };

        Console.Write("Search: ");
        int user_input = Convert.ToInt32(Console.ReadLine());

        bool found = false;
        int row = -1;
        int col = -1;

        for (int i = 0; i < ja_arr.Length; i++)
        {
            for (int j = 0; j < ja_arr[i].Length; j++)
            {
                if (ja_arr[i][j] == user_input)
                {
                    found = true;
                    row = i;
                    col = j;
                    break;
                }
            }
            if (found)
                break;
        }

        if (found)
        {
            Console.WriteLine($"{user_input} is found at position (Row: {row}, Column: {col})");
        }
        else
        {
            Console.WriteLine($"{user_input} is not in the array.");
        }
    }
}