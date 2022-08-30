//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Задаем метод, возвращающий одномерный массив из n неповторяющихся двузначных чисел, или null, если двузначных чисел не хватает.
int[]? DoubleDigitNumbers(int n)
{
    if (n <= 90)
    {
        int[] values = { };
        int count = 0;
        while (count < n)
        {
            int newValue = new Random().Next(10, 100);

            bool isValueNew = true;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == newValue)
                {
                    isValueNew = false;
                    break;
                }
            }

            if (isValueNew == true)
            {
                Array.Resize(ref values, values.Length + 1);
                values[values.Length - 1] = newValue;
                count++;
            }
        }
        return values;
    }
    else
    {
        return null;
    }

}

//Задаем метод, возвращающий трехмерный массив заданной размерности, заполненный неповторяющимися двузначными числами, или null, если двузнычных чисел не хватает для заполнения массива.
int[,,]? Create3DArray(int rows, int columns, int blocks)
{
    int length = rows * columns * blocks;
    if (length <= 90)
    {
        int[,,] array = new int[rows, columns, blocks];
        int[] values = DoubleDigitNumbers(length)!;

        int index = 0;
        for (int block = 0; block < blocks; block++)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    array[row, column, block] = values[index];
                    index++;
                }
            }
        }
        return array;
    }
    else
    {
        return null;
    }

}

//Задаем метод, выводящий переданный ему трехмерный массив на консоль.
void PrintArray(int[,,] array)
{
    for (int block = 0; block < array.GetLength(2); block++)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                Console.Write($"{array[row, column, block]} ({row}, {column}, {block})\t");
            }
            Console.WriteLine();
        }
    }
}

//Задаем "главный" метод, создающий массив и выводящий его на консоль, или выводящий на консоль предупреждение, что массив не может быть создан.
void Main(int rows, int columns, int blocks)
{
    if (Create3DArray(rows, columns, blocks) != null)
    {
        int[,,] array = Create3DArray(rows, columns, blocks)!;
        PrintArray(array);
    }
    else
    {
        Console.WriteLine($"Массив с размерностью {rows} * {columns} * {blocks} не может быть заполнен неповторяющимися двузначными числами!");
    }
}

//Вызываем основной метод.
Main(3, 5, 6);
Console.WriteLine();
Main(4, 5, 6);