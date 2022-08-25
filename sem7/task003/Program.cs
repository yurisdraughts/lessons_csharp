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

int[,] ModifyMatrix(int[,] arr)
{
    for (int row = 1; row < arr.GetLength(0); row += 2)
    {
        for (int column = 1; column < arr.GetLength(1); column +=2)
        {
            arr[row, column] = arr[row, column] * arr[row, column];
        }
    }
    return arr;
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

int[,] matrix1 = CreateMatrix(6, 6, 0, 9);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = ModifyMatrix(matrix1);
PrintMatrix(matrix2);