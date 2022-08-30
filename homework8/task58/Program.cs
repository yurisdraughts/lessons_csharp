//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Задаем метод, выводящий переданный ему двумерный массив на консоль.
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

//Зададим метод, возвращающий произведение матриц или null, если две матрицы не могут быть перемножены
int[,]? MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[] matrix1Rows = new int[matrix1.GetLength(0)];
        for (int row = 0; row < matrix1.GetLength(0); row++)
        {
            int multiple = 1;
            for (int column = 0; column < matrix1.GetLength(1); column++)
            {
                multiple *= matrix1[row, column];
            }
            matrix1Rows[row] = multiple;
        }

        int[] matrix2Columns = new int[matrix2.GetLength(1)];
        for (int column = 0; column < matrix2.GetLength(1); column++)
        {
            int multiple = 1;
            for (int row = 0; row < matrix2.GetLength(0); row++)
            {
                multiple *= matrix2[row, column];
            }
            matrix2Columns[column] = multiple;
        }

        int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int row = 0; row < product.GetLength(0); row++)
        {
            for (int column = 0; column < product.GetLength(1); column++)
            {
                product[row, column] = matrix1Rows[row] + matrix2Columns[column];
            }
        }

        return product;
    }
    else
    {
        return null;
    }
}

//Зададим "главный" метод программы, выводящий на консоль переданные ему матрицы и их произведение или сообщение, что произведение матриц невозможно.
void Main(int[,] matrix1, int[,] matrix2)
{
    Console.WriteLine("Матрица 1:");
    PrintMatrix(matrix1);
    Console.WriteLine();

    Console.WriteLine("Матрица 2:");
    PrintMatrix(matrix2);
    Console.WriteLine();

    int[,]? product = MatrixMultiplication(matrix1, matrix2);
    if (product != null)
    {
        PrintMatrix(product);
    }
    else
    {
        Console.WriteLine("Матрицы 1 и 2 не могут быть перемножены, т.к. число столбцов матрицы 1 не равно числу строк матрицы 2!");
    }
}

//Вызовем "главный" метод для двух матриц, которые могут быть перемножены...
int[,] matrix1 = {
    {2, 4},
    {3, 2}
};
int[,] matrix2 = {
    {3, 4},
    {3, 3}
};

Main(matrix1, matrix2);

//...и которые не могут быть перемножены.
Console.WriteLine();
int[,] matrixA = {
    {2, 4, 1},
    {3, 2, 1}
};
int[,] matrixB = {
    {3, 4, 1},
    {3, 3, 1}
};

Main(matrixA, matrixB);