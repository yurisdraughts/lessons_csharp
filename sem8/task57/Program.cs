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

int[] FlattenMatrix(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = matrix[i / matrix.GetLength(1), i % matrix.GetLength(1)];
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}\t");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

void PrintFrequencies(int[] arr)
{
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
        {
            if (arr[i] == arr[i - 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine($"{arr[i - 1]} встречается {count} раз");
                count = 1;
            }
        }
        else
        {
            if (arr[i] == arr[i - 1])
            {
                count++;
                Console.WriteLine($"{arr[i]} встречается {count} раз");
            }
            else
            {
                Console.WriteLine($"{arr[i - 1]} встречается {count} раз");
                Console.WriteLine($"{arr[i]} встречается 1 раз");
            }
        }
    }
}

int[,] matrix = CreateMatrix(3, 4, 0, 12);
PrintMatrix(matrix);
Console.WriteLine();

int[] array = FlattenMatrix(matrix);
PrintArray(array);
Console.WriteLine();

int[] sorted = SortArray(array);
PrintArray(array);
Console.WriteLine();

PrintFrequencies(sorted);