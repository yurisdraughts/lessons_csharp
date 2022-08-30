//Напишите программу, которая заполнит спирально массив 4 на 4.

//Чисто технически, это тоже решение задачи:
int[,] CreateMatrix()
{
    int[,] matrix = {
        {1, 2, 3, 4},
        {12, 13, 14, 5},
        {11, 16, 15, 6},
        {10, 9, 8, 7}
    };
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

int[,] matrix = CreateMatrix();
// PrintMatrix(matrix);

//Тем не менее...
//Зададим метод, который будет спирально заполнять двумерный массив произвольной длинны, начиная с позиции с индексами {0; 0} по часовой стрелке.
void Main(int rows, int columns)
{
    //Зададим начальную позицию и первое число.
    int[] position = {0, 0};
    int count = 1;

    //Зададим пустую матрицу и крайние строки/столбцы.
    int[,] matrix = new int[rows, columns];
    int top = 0;
    int left = 0;
    int bottom = matrix.GetLength(0) - 1;
    int right = matrix.GetLength(1) - 1;

    //Вычислим следующую позицию, основываясь на текущей позиции и крайних строках/столбцах.
    int[] NextPosition(int[] position)
    {
        if (position[0] == top && position[1] == right) position[0]++;
        else if (position[0] == top) position[1]++;
        else if (position[0] == bottom && position[1] == right) position[1]--;
        else if (position[1] == right) position[0]++;
        else if (position[0] == bottom && position[1] == left) position[0]--;
        else if (position[0] == bottom) position[1]--;
        //Когда программа вернется к левому верхнему углу, изменим значения крайних строк/столбцов.
        else if (position[0] == top + 1 && position[1] == left)
        {
            position[1]++;
            top++;
            left++;
            bottom--;
            right--;
        }
        else if (position[1] == left) position[0]--;

        return position;
    }

    //Заполним матрицу, сдвигая позицию, увеличивая значение вносимого в матрицу числа, и рекурсивно вызывая метод.
    void FillMatrix(int[,] matrix, int[] position, int count)
    {
        matrix[position[0], position[1]] = count;

        position = NextPosition(position);

        if (count < matrix.Length)
        {
            count++;
            FillMatrix(matrix, position, count);
        }
    }

    //Вызовем заданный выше метод для заполнения матрицы и распечатаем ее.
    FillMatrix(matrix, position, count);
    PrintMatrix(matrix);
}

//Вызовем заданный выше метод.
Main(4, 4);
//Main(5, 5);
//Main(5, 4);