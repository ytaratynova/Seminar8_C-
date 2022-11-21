﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] array = GetArray(rows, columns, -100, 100);

Console.WriteLine();
Console.WriteLine("Задаем случайный массив:");
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Сортируем элементы в строках по убыванию:");
PrintArray(SortArray(array));


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 6}", inArray[i, j]));
        }
        Console.WriteLine();
    }

}

int[,] SortArray(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++ )
        {
            for(int n = j + 1; n < arr.GetLength(1); n++)
            {
                if (arr[i, n] > arr[i, j])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, n];
                    arr[i, n] = temp;
                }
            }
        }
    }
    return arr;
}