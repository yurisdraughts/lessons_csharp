//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

//Задаем метод, возвращающий массив с суммами элементов, расположенных в одной и той же строке.
int[] RowSums(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sums[i] = sum;
    }
    return sums;
}

//Задаем метод, возвращающий массив с номерами строк (== индекс + 1) переданного ей двумерного массива с наименьшей суммой элементов.
int[] FindSmallestSumRowNumbers(int[,] matrix)
{
    int[] sums = RowSums(matrix);

    int[] minSumIndex = {0};
    for (int i = 0; i < sums.Length; i++)
    {
        if (sums[i] < sums[minSumIndex[0]]) minSumIndex[0] = i;
    }

    for (int i = 0; i < sums.Length; i++)
    {
        if (i != minSumIndex[0] && sums[i] == sums[minSumIndex[0]])
        {
            Array.Resize(ref minSumIndex, minSumIndex.Length + 1);
            minSumIndex[minSumIndex.Length - 1] = i;
        }
    }

    int[] minSumNumber = new int[minSumIndex.Length];
    for (int i = 0; i < minSumNumber.Length; i++)
    {
        minSumNumber[i] = minSumIndex[i] + 1;
    }
    return minSumNumber;
}

//Задаем метод, возвращающий строку с элементами массива, разделенными " и ".
string StringifyArray(int[] array)
{
    string stringArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) stringArray += $"{array[i]}";
        else stringArray += $" и {array[i]}";
    }
    return stringArray;
}

//Задаем "главный" метод, в котором вызываем методы, выводящие двумерный массив на консоль и находящие строки с минимальной суммой элементов.
void Main(int[,] matrix)
{
    PrintMatrix(matrix);
    Console.WriteLine();
    string smallesSumRowNumbers = StringifyArray(FindSmallestSumRowNumbers(matrix));
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {smallesSumRowNumbers} строка.");
}

//Вызываем "главный" метод со случайным двумерным массивом.
int[,] matrix = CreateMatrix(4, 4, 0, 9);
Main(matrix);

//Вызываем "главный" метод с двумерным массивом, в котором суммы элементов в 1 и 2 строке совпадают.
Console.WriteLine("\n***\n");
int[,] matrix2 = {
    {2, 2, 3},
    {3, 2, 2},
    {4, 5, 6}
};
Main(matrix2);