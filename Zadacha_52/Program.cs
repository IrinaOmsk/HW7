// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Число строк массива: ");
int nSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов массива: ");
int mSize = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[nSize, mSize];
double [] columnsAvg = new double[mSize];

FillArray(array);
PrintArray(array);
FindAverageInArrayColumns(array, columnsAvg);

void FindAverageInArrayColumns(int[,] matrixArray, double[] cols)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0, k = 0; i < matrixArray.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrixArray.GetLength(0); j++)
        {
            sum += matrixArray[j, i];
        }
        cols[k] = sum / matrixArray.GetLength(0);
        Console.Write($"{Math.Round(cols[k], 1)} ");
        k++;
    }
    Console.WriteLine();
}

void FillArray(int[,] matrixArray)
{
    Random rand = new Random();

    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            matrixArray[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrixArray)
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            Console.Write($"{matrixArray[i, j]} ");
        }
        Console.WriteLine();
    }
}