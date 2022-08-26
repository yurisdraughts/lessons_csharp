//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int? FindElement(int row, int column, int[,] arr)
{
    if (row < arr.GetLength(0) && column < arr.GetLength(1)) return arr[row, column];
    else return null;
}

void PrintElement(int row, int column, int[,] arr)
{
    if (FindElement(row, column, arr) != null)
    {
        Console.WriteLine($"[{row}, {column}] -> {FindElement(row, column, arr)}");
    }
    else
    {
        Console.WriteLine($"[{row}, {column}] -> такого числа в массиве нет");
    }
}

void Main(int row, int column, int[,] arr)
{
    PrintMatrix(arr);
    PrintElement(row, column, arr);
    Console.WriteLine();
}

int[,] matrix = CreateMatrix(4, 3, 0, 9);
Main(1, 7, matrix);
Main(2, 2, matrix);