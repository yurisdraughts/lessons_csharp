//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Задаём метод, создающий двумерный массив
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

//Задаём метод, выводящий двумерный массив на консоль
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

//Задаём метод, возвращающий массив со средними значениями для каждого столбца
double[] FindMeanValues(int[,] arr)
{
    double[] meanValues = new double[arr.GetLength(1)];
    for (int column = 0; column < arr.GetLength(1); column++)
    {
        double sum = 0;
        double mean = 0;

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            sum += arr[row, column];
        }
        mean = sum / arr.GetLength(0);
        meanValues[column] = mean;
    }
    return meanValues;
}

//Задаём метод, выводящий массив в виде строки
string StringifyArray(double[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) result += array[i] + "; ";
        else result += array[i];
    }
    return result;
}

//Задаём метод, вызывающий методы 1) вывода двумерного массива на консоль,
//2) нахождения среднего арифметического для каждого столбца и сохранения найденных значений в массив
//3) и преобразования массива в строку с последующим выводом на консоль
void Main(int[,] array)
{
    PrintMatrix(array);
    double[] meanValues = FindMeanValues(array);
    Console.WriteLine($"Среднее арифметическое каждого столбца: {StringifyArray(meanValues)}");
}

//Вызываем метод создания нового массивы и основной метод
int[,] matrix = CreateMatrix(4, 5, 0, 9);
Main(matrix);