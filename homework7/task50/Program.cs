//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Задаём метод для создания двумерного массива (целых чисел)
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

//Задаём метод для вывода двумерного массива на консоль
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

//Задаём метод, возвращаюший элемент массива по его координатам, или Null, если такого элемента нет
int? FindElement(int row, int column, int[,] arr)
{
    if (row < arr.GetLength(0) && column < arr.GetLength(1)) return arr[row, column];
    else return null;
}

//Задаём метод, выводящий на консоль элемент по его координатам, либо указывающий, что такого элемента нет
void PrintElement(int row, int column, int[,] arr)
{
    int? element = FindElement(row, column, arr);
    if (element != null)
    {
        Console.WriteLine($"[{row}, {column}] -> {element}");
    }
    else
    {
        Console.WriteLine($"[{row}, {column}] -> такого числа в массиве нет");
    }
}

//Задаём основной метод, в котором вызываем методы вывода на консоль массива
//и искомого элемента (или сообщения о его отсутствии в массиве)
void Main(int row, int column, int[,] arr)
{
    PrintMatrix(arr);
    PrintElement(row, column, arr);
    Console.WriteLine();
}

//Вызываем метод создания нового массивы и основной метод (дважды)
int[,] matrix = CreateMatrix(4, 3, 0, 9);
Main(1, 7, matrix);
Main(2, 2, matrix);