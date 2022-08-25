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

void PrintModifiedMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            if (row % 2 == 1 && column % 2 == 1)
            {
                Console.Write($"*{arr[row, column] * arr[row, column]}\t");
            }
            else Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(7, 7, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
PrintModifiedMatrix(matrix);