bool CheckTriangleSides(int a, int b, int c)
{
    return a+b>c && a+c>b && b+c>a;
}

void IsTriangle()
{
    int[] triangle = new int[3];
    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Введите длину {i+1}-й стороны: ");
        triangle[i] = Convert.ToInt32(Console.ReadLine());
    }

    if (CheckTriangleSides(triangle[0],triangle[1],triangle[2]))
    {
        Console.WriteLine($"Треугольник с длинами сторон {triangle[0]}, {triangle[1]} и {triangle[2]} существует.");
    }
    else Console.WriteLine($"Треугольник с длинами сторон {triangle[0]}, {triangle[1]} и {triangle[2]} НЕ существует!");
}

IsTriangle();