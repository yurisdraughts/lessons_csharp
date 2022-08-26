//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//Задаём метод для создания двумерного массива из случайных вещественных чисел
double[,] CreateMatrix(int rowCount, int columnCount, double min, double max)
{
    double[,] array = new double[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            double random = new Random().NextDouble();
            array[row, column] = random * (max - min) + min;
        }
    }
    return array;
}

//Задаём метод для вывода двумерного массива на консоль
void PrintMatrix(double[,] arr)
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

//Задаём основной метод, в котором вызываем методы для создания массива и вывода на консоль
void Main(int m, int n, double min, double max)
{
    double[,] matrix = CreateMatrix(m, n, min, max);
    PrintMatrix(matrix);
}

//Вызываем основной метод
Main(3, 4, -9, 9);