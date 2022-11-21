// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк массива для спирального вывода: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов массива для спирального вывода: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число, начало отсчета: ");
int firstElement = int.Parse(Console.ReadLine() ?? "0");

int[,] array = GetArray(rows, columns, firstElement);

Console.WriteLine();
Console.WriteLine("Спиральный вывод массива: ");
PrintArray(array);

int[,] GetArray(int m, int n, int element)
{
    int[,] result = new int[m, n];
    int i = 0;
    int j = 0;
    int count = 0;
    while (count < m /2 + 1)
    {
        for (j = 0 + count; j < n - count; j++)
        {
            result[i + count, j] = element;
            element++;
        }
         for (i = 1 + count; i < m - count; i++)
        {
          result[i, n - 1 - count] = element;
          element++;
        }
        for (j = n - 2 - count; j > -1 + count; j--)
        {
            result[m - 1 - count, j] = element;
            element++;
        }
        for (i = m - 2 - count; i > 0 + count; i--)
        {
             result[i, count] = element;
            element++;
        }
        count ++;
        i = 0;
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
