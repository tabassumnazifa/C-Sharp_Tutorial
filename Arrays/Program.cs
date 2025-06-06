using System;
class Program
{
    static void Main()
    {
        // 1D Array Input
        Console.Write("Enter size of 1D array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] oneD = new int[n];

        Console.WriteLine("Enter elements of 1D array:");
        for (int i = 0; i < n; i++)
        {
            oneD[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\n1D Array:");
        foreach (int val in oneD)
            Console.Write(val + " ");
        Console.WriteLine();

        //2D Array Input
        Console.Write("\nEnter number of rows for 2D array: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of columns for 2D array: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] twoD = new int[rows, cols];
        Console.WriteLine("Enter elements for 2D array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                
                twoD[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\n2D Array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(twoD[i, j] + " ");
            Console.WriteLine();
        }

        //Jagged Array Input
        Console.Write("\nEnter number of rows for jagged array: ");
        int jaggedRows = Convert.ToInt32(Console.ReadLine());
        int[][] jagged = new int[jaggedRows][];

        for (int i = 0; i < jaggedRows; i++)
        {
            Console.Write($"Enter number of elements in row {i}: ");
            int len = Convert.ToInt32(Console.ReadLine());
            jagged[i] = new int[len];

            for (int j = 0; j < len; j++)
            {
               
                jagged[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nJagged Array:");
        for (int i = 0; i < jagged.Length; i++)
        {
            foreach (int val in jagged[i])
                Console.Write(val + " ");
            Console.WriteLine();
        }
    }
}
