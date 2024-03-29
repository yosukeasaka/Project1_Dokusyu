﻿using System;

class ArrayDemo
{
    static void Main()
    {
        int[][] riders = new int[7][];

        riders[0] = new int[10];
        riders[1] = new int[10];
        riders[2] = new int[10];
        riders[3] = new int[10];
        riders[4] = new int[10];

        riders[5] = new int[2];
        riders[6] = new int[2];

        int i, j;

        for (i = 0; i < 5; i++)
            for (j = 0; j < 10; j++)
                riders[i][j] = i + j + 10;
        for (i = 5; i < 7; i++)
            for (j = 0; j < 2; j++)
                riders[i][j] = i + j + 10;

        Console.WriteLine("Riders per trip during the week:");
        for(i=0; i < 5; i++)
        {
            for (j = 0; j < 10; j++)
                Console.WriteLine(riders[i][j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Riders per trip during the weekend:");
        for (i = 5; i < 7; i++)
        {
            for (j = 0; j < 2; j++)
                Console.WriteLine(riders[i][j] + " ");
            Console.WriteLine();
        }

        Console.WriteLine(riders.Length);
    }
}