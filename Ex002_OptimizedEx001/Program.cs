﻿// See https://aka.ms/new-console-template for more information
int n = 10;
int max = 100;

int[] array = new int[n];


for (int i = 0; i < n - 1; i++)
{

    array[i] = Random.Shared.Next(max);
}

Console.WriteLine($"[{String.Join(',', array)}]");

for (int k = 0; k < n - 1; k++)
{
    for (int i = 0; i < n - 1 - k; i++)
    {
        if (array[i] > array[i + 1])
        {
            int temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
        }
    }

    Console.WriteLine($"[{String.Join(',', array)}]");
}

