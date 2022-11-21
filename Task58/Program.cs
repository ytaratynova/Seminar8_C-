// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк матрицы A: ");
int rowsA = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов матрицы A = количество строк матрицы B: ");
int columnsArowsB = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов матрицы B: ");
int columnsB = int.Parse(Console.ReadLine() ?? "0");

int[,] arrayA = GetArray(rowsA, columnsArowsB, 1, 5);
int[,] arrayB = GetArray(columnsArowsB, columnsB, 0, 10);

Console.WriteLine();
Console.WriteLine("Задана матрица A:");
PrintArray(arrayA);

Console.WriteLine();
Console.WriteLine("Задана матрица B:");
PrintArray(arrayB);

Console.WriteLine();
Console.WriteLine("Произведение матриц A*B: ");
PrintArray(MatrixComposition(arrayA, arrayB));


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

int[,] MatrixComposition(int [,] arrayX, int [,] arrayY)
{
    int[,] composition = new int[arrayX.GetLength(0), arrayY.GetLength(1)];
    
    for (int i = 0; i < arrayX.GetLength(0); i++)
    {
       for (int m = 0; m < arrayY.GetLength(1); m++) 
       {
        for (int j = 0; j < arrayX.GetLength(1); j++)
        {
            
            composition[i,m] = composition[i,m] + arrayX[i, j] * arrayY[j, m];
        }
        
       }
    }
    return composition;
}