using System;

public class Data4
{
    public static void Main()
    {

        int[,] tabel = {
            {1, 1},
            {2, 4},
            {3, 9},
            {4, 16},
            {5, 25},
            {6, 36},
            {7, 49},
            {8, 64},
            {9, 81},
            {10, 100}
        };

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(tabel[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


}