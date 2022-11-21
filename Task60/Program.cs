// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество листов массива: ");
int lists = int.Parse(Console.ReadLine() ?? "0");


int[,,] array = GetArray(rows, columns, lists);
Console.WriteLine();

if (rows * columns * lists > 90) Console.WriteLine("Данный массив заполнить неповторяющимися двузначными числами невозможно!");
else 
{
Console.WriteLine("Наш массив:");
PrintArray(array);
}

int[,,] GetArray(int m, int n, int l)
{
    int[,,] result = new int[m, n, l];
    int k = 0;
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int t = 0; t < n; t++ )
            {
                result[j, t, i] = 10 + k;
                k++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(2); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            for (int t = 0; t < inArray.GetLength(1); t++)
        {
            Console.Write($"{String.Format("{0, 12}", inArray[j, t, i])} ({j}, {t}, {i}) ");
        }
        Console.WriteLine();         
        }
        Console.WriteLine();
    }
}