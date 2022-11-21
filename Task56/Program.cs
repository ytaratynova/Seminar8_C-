// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] array = GetArray(rows, columns, 0, 10);

Console.WriteLine();
Console.WriteLine("Задаем случайный массив:");
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Строка с максимальной суммой элементов №: {Max(SumRow(array)) + 1}");



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

int[] SumRow(int[,] arr)
{
    int[] sumArray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
       { 
        sumArray[i] += arr[i, j];
        }
    }
    return sumArray;
}

int Max(int[] arr)
{
    int max = arr[0];
    int maxPos = 0;
    for( int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
            maxPos = i;
        }
    }
    return maxPos;
}