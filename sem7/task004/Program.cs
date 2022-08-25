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

void PrintDiagonalSum(int[,] arr)
{
    int min = Math.Min(arr.GetLength(0), arr.GetLength(1));

    int sumNum = 0;
    string sumStr = string.Empty;
    for (int i = 0; i < min; i++)
    {
        sumNum += arr[i,i];

        if(i != min - 1) sumStr += $"{arr[i,i]}+";
        else sumStr += $"{arr[i,i]}";
    }

    Console.WriteLine($"Сумма элементов главной диагонали: {sumStr} = {sumNum}");
}

int[,] matrix1 = CreateMatrix(7, 3, 0, 10);
PrintMatrix(matrix1);
PrintDiagonalSum(matrix1);

Console.WriteLine();
int[,] matrix2 = CreateMatrix(3, 7, 0, 10);
PrintMatrix(matrix2);
PrintDiagonalSum(matrix2);