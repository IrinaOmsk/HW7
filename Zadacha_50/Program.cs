// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 7 -> такого числа в массиве нет

Console.Write("Число строк массива: ");
int nSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов массива: ");
int mSize = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[nSize, mSize];

FillArray(array);
PrintArray(array);

Console.Write("Индекс строки элемента в массиве: ");
int nIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Индекс столбца элемента в массиве: ");
int mIndex = Convert.ToInt32(Console.ReadLine());

FindElemInArray(array, nIndex, mIndex);

void FindElemInArray(double[,] matrixArray, int i, int j)
{
    if (i < 0 || i >= matrixArray.GetLength(0) ||
        j < 0 || j >= matrixArray.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
        Console.WriteLine(matrixArray[i, j]);
}


void FillArray(double[,] matrixArray)
{
    Random rand = new Random();

    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            matrixArray[i, j] = rand.Next(-10, 10);
        }
    }
}

void PrintArray(double[,] matrixArray)
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