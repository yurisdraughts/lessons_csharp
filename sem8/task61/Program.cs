void PrintPascalsTriangle(int rows)
{
    int val = 1;
    for (int i = 0; i < rows; i++)
    {
        for (int blank = 0; blank < rows - i; blank++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || i == 0) val = 1;
            else val = val * (i - j + 1) / j; //???
            Console.Write(val + " ");
        }
        Console.WriteLine();
    }
}

PrintPascalsTriangle(20);

//Треугольник получается немного кривым из-за разницы в длине разных чисел.