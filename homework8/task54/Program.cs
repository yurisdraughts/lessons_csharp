//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Задаем метод, создающий двумерный массив.
int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] matrix = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            matrix[row, column] = new Random().Next(min, max+1);
        }
    }
    return matrix;
}

//Задаем метод, ваыводящий переданный ему двумерный массив на консоль.
void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row, column]}\t");
        }
        Console.WriteLine();
    }
}

//Задаем метод, изменяющий переданный ему массив таким образом, чтобы в каждой строке элементы были упорядочены по убыванию.
void SortRows(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[row, j] > matrix[row, i])
                {
                    int temp = matrix[row, i];
                    matrix[row, i] = matrix[row, j];
                    matrix[row, j] = temp;
                }
            }
        }
    }
}

//Задаем "главный" метод, в котором вызываем методы по созданию, выводу на консоль, упорядочиванию и повторному выводу на консоль двумерного массива.
void Main(int rowCount, int columnCount, int min, int max)
{
    int[,] matrix = CreateMatrix(rowCount, columnCount, min, max);
    PrintMatrix(matrix);
    Console.WriteLine();

    SortRows(matrix);
    PrintMatrix(matrix);
}

//Вызываем "главный" метод.
Main(3, 4, 0, 9);