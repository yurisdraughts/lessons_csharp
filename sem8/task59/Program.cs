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

int[] FindMinCoordinates(int[,] matrix)
{
    int[] minCoordinates = {0, 0};
    int min = matrix[minCoordinates[0], minCoordinates[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minCoordinates[0] = i;
                minCoordinates[1] = j;
            }
        }
    }
    return minCoordinates;
}

int[,] RemoveRowAndColumn(int[,] matrix, int[] coordinates)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        column = 0;
        if (i != coordinates[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != coordinates[1])
                {
                    newMatrix[row, column] = matrix[i, j];
                    column++;
                }
            }
            row++;
        }
    }
    return newMatrix;
}

void Main(int rowCount, int columnCount, int min, int max)
{
    int[,] matrix = CreateMatrix(rowCount, columnCount, min, max);
    PrintMatrix(matrix);
    Console.WriteLine();

    int[] minCoordinates = FindMinCoordinates(matrix);
    int[,] newMatrix = RemoveRowAndColumn(matrix, minCoordinates);
    PrintMatrix(newMatrix);
}

Main(4, 4, 0, 9);

//Если в матрице есть несколько равных минимальных элементов, то удаляются только столбцы и строки с первым из них.