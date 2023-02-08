// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного матрицы

/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);*/
//-----------Методы-------------------------------------------------
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
/*void SortArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            for (int t = j + 1; t < array.GetLength(1); t++)
            {
                if (array[i,t] > array[i,j])
                {
                    int temp = array[i,j]; 
                    array[i,j] = array[i,t];
                    array[i,t] = temp; 
                }
            }
        }
        
    }
}*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
Console.Write($"Строка с наименьшей суммой - {GetRowNumber(array)}");

int GetRowNumber (int[,] array)
{
    int row = 0;
    int minsum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        minsum = minsum + array[0,i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк 1 матрицы: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 матрицы: ");
int columsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 матрицы: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 матрицы: ");
int columsB = int.Parse(Console.ReadLine()!);
if(columsA != rowsB)
{
    Console.WriteLine($"Умножение таких матриц невозможно!");
    return;
}

int[,] arrayA = GetArray(rowsA, columsA, 0, 10);
int[,] arrayB = GetArray(rowsB, columsB, 0, 10);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(arrayA,arrayB));

int [,] GetMultiplicationMatrix (int [,] arrayA, int[,] arrayB)
{
    int [,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i,j] +=arrayA[i, k] * arrayB[k,j];
            }
        }
    }
    return arrayC;
}
