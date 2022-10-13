﻿// Задайте двумерный массив размером m?n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Число строк массива: ");
int nSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов массива: ");
int mSize = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[nSize, mSize];
FillArray(array);
PrintArray(array);


void FillArray(double[,] matrixArray)
{
    int rows = matrixArray.GetLength(0);
    int columns = matrixArray.GetLength(1);
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrixArray[i, j] = Math.Round(Convert.ToDouble(rand.Next(-10, 10)) + rand.NextDouble(), 1);
        }
    }
}

void PrintArray(double[,] matrixArray)
{
    int rows = matrixArray.GetLength(0);
    int columns = matrixArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrixArray[i, j]} ");
        }
        Console.WriteLine();
    }
}